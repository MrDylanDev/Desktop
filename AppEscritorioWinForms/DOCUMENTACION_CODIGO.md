# Documentación del código — "app escritorio"

Aplicación de escritorio Windows Forms (.NET 8, `net8.0-windows`) para **gestionar la carta de un restaurante y registrar pedidos**.

> **Nota (septiembre 2026):** este documento describe el **editor de carta** original ("app escritorio").
> Hoy ese proyecto es la base de **RestoOS en WinForms .NET 8**: el editor vive en el módulo *Menú y productos*
> (`Form1`) dentro de la ventana principal `Shell/ShellForm`, junto con POS, Mesas, KDS, Inventario, Reservas,
> Delivery, Reportes y Configuración. Arranque, arquitectura general, kit visual y estado de cada módulo:
> ver el [README principal](../README.md) y [`UI/LEEME_UI.md`](UI/LEEME_UI.md).


---

## 1. Visión general

| Dato | Valor |
|---|---|
| Lenguaje | C# |
| Framework | .NET 8 (`net8.0-windows`, WinForms, `WinExe`, proyecto SDK) — antes .NET Framework 4.7.2 |
|.Namespace | `app_escritorio` |
| Persistencia | Archivos XML locales (`data/menu.xml`, `data/orders.xml`, `data/settings.xml`) |
| Sin dependencias externas | Solo assemblies de .NET (`System.Drawing`, `System.Windows.Forms`, `System.Xml`) |

### Estructura de carpetas

```
app escritorio/
├── Program.cs              Punto de entrada
├── Form1.cs                Ventana principal (todo el código de la UI principal)
├── Form1.Designer.cs       Generado automáticamente por Visual Studio (no editar)
├── Models/                 Clases de datos (platos, categorías, pedidos, settings)
├── Controls/               UserControls reutilizables (tarjeta, barra de categorías, barra de estado)
├── Data/                   Clases que leen/escriben los XML (patrón "Store")
├── Forms/                  Ventanas secundarias (pedido, historial, configuración)
├── Utils/                  Utilidades (tema de colores, descarga de imágenes)
└── data/                   Datos que se crean en tiempo de ejecución
    ├── menu.xml            La carta
    ├── orders.xml          Historial de pedidos
    ├── settings.xml        Datos del restaurante
    ├── images/             Fotos descargadas
    └── backups/            Copias de seguridad de menu.xml
```

### Arquitectura (3 capas simplificadas)

```
        Forms/ + Form1.cs  +  Controls/     ← CAPA DE PRESENTACIÓN (dibuja y captura clics)
                    ↕  (objetos MenuItem / OrderRecord)
        Models/  +  Data/                  ← CAPA DE DATOS (estructuras + lectura/escritura XML)
                    ↕
        Utils/                             ← CAPA DE APOYO (colores, imágenes)
```

**Regla general:** la UI nunca habla con el disco directamente; siempre pasa por `MenuStore`, `OrderHistoryStore` o `SettingsStore`.

---

## 2. `Program.cs` — Punto de entrada

```csharp
[STAThread]
static void Main()
{
    Application.EnableVisualStyles();          // activa los estilos visuales de Windows
    Application.SetCompatibleTextRenderingDefault(false);
    Application.Run(new Form1());              // abre la ventana principal y entra al "bucle de mensajes"
}
```

- **`[STAThread]`**: obligatorio en WinForms. Significa *Single-Thread Apartment*; el motor de WinForms necesita que el hilo principal sea STA para que funcionen el portapapeles y los diálogos.
- **`Application.Run(...)`**: bloquea el programa en un bucle que atiende clics, teclado, repintado, etc., hasta que la ventana se cierre.

---

## 3. `Models/` — Los datos

### 3.1 `Category.cs`
```csharp
public class Category
{
    public Guid Id { get; set; } = Guid.NewGuid();   // identificador único autogenerado
    public string Name { get; set; }                // "Entradas", "Bebidas"...
    public int Position { get; set; } = 0;          // orden en la barra de categorías
    public List<Guid> ItemIds { get; set; }         // ids de los platos de esta categoría
}
```

### 3.2 `MenuItem.cs`
El plato/bebida. Contiene datos de negocio que la UI actual todavía no expone (comisión de delivery, variantes, filtros dietéticos), pero que ya están en el modelo y se guardan en el XML.

| Propiedad | Significado |
|---|---|
| `Id` | Guid único |
| `Name`, `Description` | Nombre y descripción |
| `PriceSalon` | Precio para consumo en el local |
| `PriceDelivery` | Precio para delivery |
| `CommissionPercentage` | % de comisión para delivery (por defecto 15) |
| `NoCommission` | Marca el plato como "sin comisión" |
| `IsAvailable` | Si aparece en la carta |
| `IsSuggestion` | Sugerencia del chef (★) |
| `CategoryId` | A qué categoría pertenece |
| `Position` | Orden dentro de la categoría (reordenar con drag & drop) |
| `ImageUrl` | Ruta **local** del archivo de imagen |
| `Stock` | `-1` = ilimitado, `0` = agotado, `n` = unidades |
| `IsFavorite` | Favorito |
| `Variants` | Lista de `MenuVariant` (variantes con sobreprecio y stock propio) |
| `Tags` | Etiquetas libres: "DISPONIBLE", "Carnes Grill", "Plato Más Vendido" |
| `DietaryFilters` | "Sin TACC", "Vegetariano", "Picante" |
| `InventoryDiscount` | Descuento de inventario por unidades vendidas |

`MenuVariant` (mismo archivo):
```csharp
public class MenuVariant { public string Name; public decimal PriceDelta; public int Stock = -1; }
```

### 3.3 `OrderRecord.cs`
Tres clases:
- **`OrderRecord`**: un pedido guardado (`Id`, `CreatedAt`, `CustomerName`, `TableNumber`, `Status`, `Total`, `Lines`).
- **`OrderRecordLine`**: una línea del pedido (`Name`, `Quantity`, `UnitPrice`).
- **`RestaurantSettings`**: datos del restaurante. El atributo `[XmlRoot("restaurantSettings")]` define el nombre del nodo raíz en el XML.

---

## 4. `Data/` — Persistencia en XML

Los XML se generan con `System.Xml.Serialization.XmlSerializer`: convierte objetos ↔ XML automáticamente. Por eso las clases de `Models` son *planas* (sin constructores con parámetros, sin eventos).

### 4.1 `MenuStore.cs`
```csharp
public class MenuData                      // el "contenedor" que se serializa entero
{
    public List<Category> Categories { get; set; } = new List<Category>();
    public List<MenuItem>   Items      { get; set; } = new List<MenuItem>();
}
```
- `MenuStore.Load(ruta)`: si el archivo no existe devuelve `MenuData` vacío; si falla la deserialización también devuelve vacío (nunca lanza excepción).
- `MenuStore.Save(ruta, datos)`: crea la carpeta si falta y escribe el XML.
- `MenuStore.SampleData()`: carta de ejemplo con 2 categorías y 2 platos, usada la primera vez que se abre la app.

### 4.2 `OrderHistoryStore.cs`
Dos clases estáticas con el mismo patrón:
- `OrderHistoryStore.Load/Save` → `List<OrderRecord>` en `data/orders.xml`.
- `SettingsStore.Load/Save` → `RestaurantSettings` en `data/settings.xml`.

---

## 5. `Utils/`

### 5.1 `Theme.cs` — Paleta y tipografías
Clase estática con `Color` y `Font` compartidos por toda la app (tema oscuro). Ejemplos:
`BackgroundDark #1e1e1e`, `BackgroundMedium #323232`, `AccentPrimary` (naranja), `AccentSecondary` (verde), `StatusUnavailable` (rojo), `FontTitle`, `FontSmall`...
> Nota: las fuentes son propiedades `=>` (no `readonly`), así que **cada acceso crea un objeto `Font` nuevo**.

### 5.2 `ImageFetcher.cs` — Descarga y optimiza imágenes
- `DownloadImage(url)`: descarga a `data/images/temp_<guid>.jpg`, redimensiona, guarda el resultado con GUID definitivo y **borra el temporal**.
- `ResizeAndOptimizeImage`: mantiene la proporción usando `Math.Min(ratioX, ratioY)` y limita a 600×600 px; reescala con `HighQualityBicubic` y guarda como JPEG con calidad 85.
- `GetEncoder`: busca el codificador de imagen (JPEG) instalado en el sistema.

---

## 6. `Controls/` — Componentes reutilizables

### 6.1 `CategoryBar.cs` — Barra de filtros por categoría
- `UserControl` con un `FlowLayoutPanel` que llena una fila de botones horizontales.
- `SetCategories(List<Category>)`: limpia y recrea los botones, ordenados por `Position`. El primero siempre es **"Todas"** (`catId = null`).
- Cada botón guarda su `Guid?` en `Tag` (así se sabe a qué categoría pertenece sin lambdas de cierre).
- `SelectCategory(Guid?)`: repinta el botón seleccionado, dispara el evento `CategorySelected` con `CategorySelectedEventArgs { SelectedCategoryId }`.
- Efectos hover con `MouseEnter` / `MouseLeave`.

### 6.2 `MenuCard.cs` — Tarjeta visual de un plato
- `UserControl` de 330×310 con: `PictureBox` (foto), nombre, descripción, precios, stock, etiquetas y botones **Editar / Eliminar**.
- `SetData(MenuItem)`: rellena los labels. Lógica de presentación:
  - precio: `"Salón: {0:C}    Delivery: {1:C}"`
  - stock: `"ilimitado"` si `Stock < 0`; en rojo si `Stock == 0`
  - etiquetas: agrega `"NO DISPONIBLE"` si no está disponible, `"★ SUGERENCIA"` si es sugerencia, y los `Tags` del modelo.
- Eventos `EditRequested` y `DeleteRequested` (el control **avisa**, no decide; quien decide es `Form1`).
- **Drag & drop**: `MouseDown` guarda la posición, `MouseMove` compara con `SystemInformation.DragSize` y si se superó el umbral llama a `DoDragDrop` con un `DataObject` que transporta la propia tarjeta.
- `LoadImage` libera el archivo con `using` + `new Bitmap(source)` para no bloquear la imagen en disco.

### 6.3 `StatusBar.cs` — Indicadores
`UserControl` con 3 labels: `✓ Disponibles`, `✗ Agotado hoy`, `★ Sugerencias`. `SetItems(lista)` recalcula con `Count(...)` usando LINQ.

---

## 7. `Form1.cs` — Ventana principal (la más importante)

### 7.1 Campos y construcción
```csharp
private string dataFile = "data/menu.xml";
private app_escritorio.Data.MenuData menuData;      // el estado en memoria de toda la carta
private Guid? currentSelectedCategoryId = null;     // filtro activo
```
Constructor:
```csharp
public Form1() { InitializeComponent(); BuildUi(); this.Load += Form1_Load; }
```
`InitializeComponent()` viene del `.Designer.cs` y aquí solo deja el formulario vacío. **Toda la interfaz se crea a mano en `BuildUi()`**.

### 7.2 `BuildUi()` — La interfaz en código
Se arma por docked panels (el orden de `Controls.Add` es **inverso** al orden visual: el último agregado queda arriba):

1. **Toolbar (60 px, arriba)** — 9 botones: Auto-Sync QR, Imprimir QR, Modo Móvil, Nuevo Plato, Categorías, Respaldo, Configuración, Historial, Crear Pedido. Se crean con `CreateToolbarButton(texto, ancho, color)` y se conectan con lambdas `Click += (s,e) => ...`.
2. **TopBar (50 px)** — buscador (`txtSearch`), `btnSaveAll` y el `StatusBar`.
3. **Layout principal** — `TableLayoutPanel` de 2 columnas: izquierda 100 % (con `CategoryBar` arriba y `flowPanel` de tarjetas abajo) y derecha 400 px (`rightPanel`, el editor).
4. `flowPanel` es un `FlowLayoutPanel` con `WrapContents = true` y `AutoScroll = true`: es la cuadrícula de tarjetas. Se le activa `AllowDrop` y se suscriben `DragEnter` y `DragDrop`.

### 7.3 `Form1_Load()` — Arranque
1. `MenuStore.Load(dataFile)`; si no hay categorías ni platos → `SampleData()`.
2. Garantiza listas no nulas.
3. Renombra la categoría legacy `"Entradas y Tapas"` a `"Entradas"` y se asegura que existan `Entradas` y `Bebidas` (migración de datos).
4. `categoryBar.SetCategories(...)` y `PopulateCards(null)` (muestra todo).

### 7.4 `PopulateCards(Guid? categoryId)` — El corazón de la pantalla
```csharp
flowPanel.Controls.Clear();
var itemsToShow = (categoryId == null ? menuData.Items
                  : menuData.Items.Where(i => i.CategoryId == categoryId).ToList())
                  .OrderBy(i => i.CategoryId).ThenBy(i => i.Position).ToList();
foreach (var item in itemsToShow) { var card = new MenuCard(); card.SetData(item); ... flowPanel.Controls.Add(card); }
statusBar.SetItems(itemsToShow);
```
Crea una tarjeta por plato, engancha sus eventos y actualiza la barra de estado.

### 7.5 `ShowEditorFor(MenuItem)` — Panel de edición
Limpia `rightPanel` y reconstruye el formulario de edición (todo en código):
`PictureBox` + botón "Elegir foto" (`OpenFileDialog`), `ComboBox` de categorías, `TextBox` de nombre/descripción/etiquetas, tres `NumericUpDown` (precio salón, delivery, stock) y un `CheckBox` de disponibilidad.

Detalles importantes:
- Los controles se agregan **de abajo hacia arriba** porque todos usan `Dock = Top` (el último en agregarse queda arriba visualmente).
- El botón Guardar valida que el nombre no esté vacío, escribe los valores sobre el **mismo objeto `MenuItem`** (no crea uno nuevo), parsea las etiquetas con `Split(',')` y llama a `SaveMenu()` + `PopulateCards()`.
- `LoadEditorImage` carga la foto local con `using` para no bloquear el archivo.

### 7.6 Guardado, búsqueda y reordenar
- **`SaveMenu()`**: `MenuStore.Save` dentro de `try/catch` y muestra un `MessageBox` de éxito o error.
- **`ApplySearch()`**: en vez de recrear tarjetas, recorre las existentes con `flowPanel.Controls.OfType<MenuCard>()` y cambia `Visible` según si el nombre o la descripción contienen el texto.
- **`FlowPanel_DragDrop`**: convierte la coordenada global a local con `PointToClient`, busca la posición de inserción, usa `SetChildIndex`, y luego llama a `UpdateMenuOrderFromUI()`.
- **`UpdateMenuOrderFromUI()`**: recorre las tarjetas en el nuevo orden visible y reescribe `Position = 0,1,2…`; los platos no visibles de la categoría se agregan al final.
- **`ManageCategories()`**: crea un `Form` anónimo en runtime con `ListBox` + `TextBox` + botones Agregar/Eliminar/Listo. Solo guarda si el `DialogResult` es `OK`.

### 7.7 Botones "de relleno"
`BtnAutoSync_Click`, `BtnPrintQR_Click` y `BtnModoMovil_Click` **solo muestran un `MessageBox`** que dice "funcionalidad en desarrollo". Son placeholders.

### 7.8 Ventanas modales
- `OpenSettings()` → `Forms.SettingsForm("data/settings.xml")`
- `OpenOrderHistory()` → `Forms.OrderHistoryForm("data/orders.xml")`
- `BtnNewOrder_Click()` → `Forms.OrderForm(menuData)`
Todas con `using (...)` + `ShowDialog(this)` (modal: bloquean la ventana principal) y `TopMost = true` para que queden encima.

---

## 8. `Forms/` — Ventanas secundarias

### 8.1 `OrderForm.cs` — Crear pedido
Constructor de 127 líneas que arma: header (búsqueda, cliente, mesa, estado), panel izquierdo con las tarjetas de productos, panel derecho con un `ListView` del pedido y los botones de acción.

| Método | Qué hace |
|---|---|
| `RefreshProducts(query)` | Filtra `menuData.Items` por nombre y recrea las mini-tarjetas (`CreateProductCard`) |
| `SelectProduct(item)` | Guarda el plato elegido y lo resalta comparando `control.Tag` con `item` |
| `AddSelectedItem()` | Agrega la cantidad a la lista; si ya existe la línea, **suma** la cantidad |
| `RemoveSelectedLine()` / `OrderLines_DoubleClick` | Quitan la línea seleccionada |
| `UpdateOrderDisplay()` | Rellena el `ListView` con Producto/Cant./Precio/Total y calcula el total (`Sum`) |
| `ConfirmOrder()` | Valida que haya productos, crea un `OrderRecord`, lo agrega al historial con `OrderHistoryStore.Load` + `Add` + `Save`, y cierra con `DialogResult.OK` |

`OrderLine` es una **clase privada anidada** (línea temporal del pedido, no se persiste; al guardar se convierte en `OrderRecordLine`).

### 8.2 `OrderHistoryForm.cs` — Historial
`ListView` de 6 columnas (Fecha, Cliente, Mesa, Estado, Total, Productos). `LoadRecords()` ordena por `CreatedAt` descendente, muestra un resumen (`Pedidos / Ventas / Hoy`) y permite recargar con el botón "Actualizar". Los botones se reposicionan en `footer.Resize`.

### 8.3 `SettingsForm.cs` — Configuración
Formulario con posiciones fijas (`Left`/`Top`) para: nombre, dirección, teléfono, símbolo de moneda y ruta del logo, con botón "Elegir logo" (`OpenFileDialog`) y "Guardar configuración" que llama a `SettingsStore.Save` y cierra con `DialogResult.OK`.

---

## 9. Archivos generados automáticamente (no tocar)

- `Form1.Designer.cs`, `Form1.resx`, `Properties/Resources.*`, `Properties/Settings.*`, `Properties/AssemblyInfo.cs`
- `bin/` y `obj/` (salida de compilación)

---

## 10. Cómo explicar el proyecto en 1 minuto (guion)

1. **WinForms puro, sin diseñador**: toda la UI se crea en código; `Form1.Designer.cs` está prácticamente vacío.
2. **Modelo en memoria + XML**: `MenuData` guarda todo en memoria y `MenuStore` lo serializa a `data/menu.xml`. No hay base de datos.
3. **Patrón Store**: clases estáticas `Load`/`Save` que nunca lanzan excepciones (si algo falla, devuelven un objeto vacío).
4. **Comunicación por eventos**: los `UserControl` (`MenuCard`, `CategoryBar`) avisan con eventos (`EditRequested`, `CategorySelected`) y `Form1` decide qué hacer. El control no toca datos.
5. **Tema centralizado**: `Theme` tiene todos los colores y fuentes.
6. **Features pendientes**: Auto-Sync QR, impresión de QR y Modo Móvil son `MessageBox` de relleno.

---

## 11. Detalles técnicos y cosas a tener en cuenta al explicar

| Tema | Detalle |
|---|---|
| `Dock` | Un control `Dock=Top` se apila; el **último agregado** aparece arriba. De ahí el orden invertido de `Controls.Add`. |
| `FlowLayoutPanel` | Organiza los hijos en fila/columna; con `WrapContents=true` salta de línea → es la "cuadrícula" de tarjetas. |
| `Tag` | Propiedad genérica de WinForms usada aquí para asociar un botón a un `Guid?` y un panel a un `MenuItem`. |
| Lambdas `(s, e) =>` | Se usan para conectar eventos de forma compacta. Ojo: dentro de un bucle capturan la variable de esa iteración. |
| `foreach (Button btn in ...OfType<Button>())` | `OfType<T>()` filtra los controles del mismo tipo. |
| Lambdas estáticas `private static Label CreateEditorLabel(...)` | Se declaran `static` porque no usan estado del formulario. |
| `using` + `new Bitmap(source)` | Patrón para abrir imágenes sin dejar el archivo bloqueado. |
| `catch { }` / `catch { return null; }` | El código "se traga" los errores a propósito para que la app no se caiga; si se necesita depurar, hay que poner un `MessageBox` o `Debug.WriteLine` temporal. |
| `string.Format` / interpolación `$"..."` | Se usa `{0:C}` para moneda y `$"⬤ {name}"` para texto. |
| `Guid` | Identificadores únicos; se generan al crear el objeto (`= Guid.NewGuid()`), por eso todas las listas arrancan vacías pero con ids válidos al deserializar. |

---

## 12. Índice de referencias rápidas

| Archivo | Responsibility |
|---|---|
| `Program.cs` | Arranque de la app |
| `Form1.cs` | Ventana principal, editor, búsqueda, drag&drop, categorías |
| `Models/Category.cs` | Categoría |
| `Models/MenuItem.cs` | Plato + variantes |
| `Models/OrderRecord.cs` | Pedido, línea de pedido, configuración del restaurante |
| `Data/MenuStore.cs` | Leer/escribir `menu.xml` + datos de ejemplo |
| `Data/OrderHistoryStore.cs` | Leer/escribir `orders.xml` y `settings.xml` |
| `Utils/Theme.cs` | Colores y fuentes del tema oscuro |
| `Utils/ImageFetcher.cs` | Descargar y redimensionar fotos |
| `Controls/CategoryBar.cs` | Filtro por categorías |
| `Controls/MenuCard.cs` | Tarjeta de plato con drag&drop |
| `Controls/StatusBar.cs` | Contadores de disponibles/agotados/sugerencias |
| `Forms/OrderForm.cs` | Ventana de creación de pedidos |
| `Forms/OrderHistoryForm.cs` | Ventana de historial de pedidos |
| `Forms/SettingsForm.cs` | Ventana de configuración del restaurante |
