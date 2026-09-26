# Informe técnico y académico del proyecto

## Aplicación de escritorio para administrar una carta y registrar pedidos

**Proyecto:** `app escritorio`  
**Lenguaje:** C#  
**Tecnología de interfaz:** Windows Forms (WinForms)  
**Framework:** .NET 8 (`net8.0-windows`) — migrado desde .NET Framework 4.7.2  
**Tipo de aplicación:** Aplicación local de escritorio para Windows  
**Propósito:** Administrar platos, bebidas, categorías, precios, disponibilidad, stock y pedidos de un restaurante.

> **Nota (septiembre 2026):** este documento describe el **editor de carta** original ("app escritorio").
> Hoy ese proyecto es la base de **RestoOS en WinForms .NET 8**: el editor vive en el módulo *Menú y productos*
> (`Form1`) dentro de la ventana principal `Shell/ShellForm`, junto con POS, Mesas, KDS, Inventario, Reservas,
> Delivery, Reportes y Configuración. Arranque, arquitectura general, kit visual y estado de cada módulo:
> ver el [README principal](../README.md) y [`UI/LEEME_UI.md`](UI/LEEME_UI.md).

---

## 1. Presentación del proyecto

`app escritorio` es un programa diseñado para funcionar como un editor de carta y un registro local de pedidos de restaurante. La aplicación permite organizar los productos en categorías, crear platos y bebidas, asignarles precios e imágenes, controlar su disponibilidad y stock, realizar búsquedas y registrar pedidos.

El proyecto no depende de una base de datos ni de un servidor. Los datos se guardan localmente en archivos XML, lo que permite ejecutar la aplicación en un equipo Windows sin instalar un servidor de base de datos.

La aplicación utiliza una arquitectura sencilla dividida en módulos:

- **Interfaz:** `Form1` y formularios secundarios.
- **Modelos:** clases que representan platos, categorías, pedidos y configuración.
- **Datos:** clases que cargan y guardan la información en XML.
- **Controles reutilizables:** barra de categorías, tarjetas de productos y barra de estado.
- **Utilidades:** temas visuales y procesamiento de imágenes.

El objetivo actual es demostrar una aplicación funcional de escritorio, no un sistema comercial completo. Algunas funciones, especialmente las relacionadas con códigos QR, sincronización móvil y conexión con servicios externos, todavía son botones demonstrativos.

---

## 2. Objetivos del proyecto

Los objetivos principales son:

1. Crear una interfaz gráfica intuitiva para administrar una carta.
2. Separar platos y bebidas mediante categorías.
3. Permitir crear, editar, buscar y eliminar productos.
4. Guardar información de manera local y persistente.
5. Gestionar precios de salón y delivery.
6. Controlar disponibilidad y stock.
7. Permitir la creación de pedidos.
8. Conservar un historial de pedidos.
9. Crear respaldos de la carta.
10. Aplicar una interfaz visual coherente mediante colores, fuentes y controles personalizados.

---

## 3. Tecnologías utilizadas

### 3.1 C#

C# es el lenguaje principal del proyecto. Se utilizó para crear la interfaz, los eventos, los modelos de datos y las operaciones de lectura y escritura.

Dentro del código se pueden observar conceptos como:

- Programación orientada a objetos.
- Clases y propiedades.
- Eventos de WinForms.
- Colecciones como `List<T>`.
- Consultas LINQ.
- Serialización XML.
- Manejo de excepciones.
- Controles visuales personalizados mediante `UserControl`.

### 3.2 Windows Forms

Windows Forms permite crear aplicaciones de escritorio para Windows utilizando controles visuales como:

- `Form`.
- `Panel`.
- `Button`.
- `TextBox`.
- `Label`.
- `ComboBox`.
- `NumericUpDown`.
- `CheckBox`.
- `PictureBox`.
- `FlowLayoutPanel`.
- `TableLayoutPanel`.
- `ListBox`.
- `UserControl`.

La mayoría de la interfaz se construye mediante código, especialmente en `Form1.cs`. Esto significa que las propiedades de los controles se escriben directamente en C#.

### 3.3 .NET 8 (antes .NET Framework 4.7.2)

El proyecto empezó sobre .NET Framework 4.7.2 y se migró a **.NET 8** (`net8.0-windows`, proyecto estilo SDK). En .NET 8 los atributos de ensamblado se generan desde el `.csproj`, por eso ya no existe `Properties/AssemblyInfo.cs`. Requiere Windows 10 (1607) o superior y Visual Studio 2022 o superior.

El tipo de salida del proyecto es `WinExe`, por lo que se genera un ejecutable de Windows en lugar de una aplicación de consola.

### 3.4 XML

La persistencia se realiza mediante `System.Xml.Serialization`. Los datos de la carta se guardan en:

```text
data/menu.xml
```

Los pedidos se guardan en:

```text
data/orders.xml
```

La configuración del restaurante se guarda en:

```text
data/settings.xml
```

XML significa que los datos pueden ser revisados y editados con un Bloc de notas o un editor de texto.

---

## 4. Estructura de carpetas

La estructura principal del proyecto es la siguiente:

```text
app escritorio/
├── Controls/
│   ├── CategoryBar.cs
│   ├── MenuCard.cs
│   └── StatusBar.cs
├── Data/
│   ├── MenuStore.cs
│   ├── OrderHistoryStore.cs
│   └── SettingsStore.cs
├── Forms/
│   ├── OrderForm.cs
│   ├── OrderHistoryForm.cs
│   └── SettingsForm.cs
├── Models/
│   ├── Category.cs
│   ├── MenuItem.cs
│   ├── OrderRecord.cs
│   └── RestaurantSettings.cs
├── Utils/
│   ├── Theme.cs
│   └── ImageFetcher.cs
├── Form1.cs
├── Form1.Designer.cs
├── Program.cs
├── App.config
└── app escritorio.csproj
```

### Responsabilidad de cada carpeta

- **Controls:** contiene controles reutilizables de la interfaz.
- **Data:** contiene las clases que cargan y guardan la información.
- **Forms:** contiene ventanas separadas para pedidos, historial y configuración.
- **Models:** contiene las clases que representan los datos.
- **Utils:** contiene clases auxiliares, como el tema y el procesamiento de imágenes.
- **Form1.cs:** contiene la ventana principal y coordina las operaciones de la carta.
- **Program.cs:** contiene el punto de entrada de la aplicación.

---

## 5. Arquitectura del programa

La aplicación sigue el siguiente flujo:

```text
Program.cs
    ↓
Form1
    ├── Carga la carta XML
    ├── Construye la interfaz
    ├── Muestra las categorías
    ├── Muestra los productos
    ├── Abre el editor de platos
    ├── Crea y elimina categorías
    └── Abre formularios de pedidos
            ↓
        Data/MenuStore
            ↓
        data/menu.xml
```

Los datos tienen una relación básica de esta forma:

```text
MenuData
├── Categories
│   ├── Entradas
│   ├── Platos Principales
│   └── Bebidas
└── Items
    ├── Plato 1
    ├── Plato 2
    ├── Bebida 1
    └── Bebida 2
```

Un producto se relaciona con una categoría mediante la propiedad `CategoryId`.

---

## 6. Modelo de datos

### 6.1 Categoría: `Category.cs`

La clase `Category` representa una sección de la carta.

Sus propiedades principales son:

- `Id`: identificador único de la categoría.
- `Name`: nombre visible, por ejemplo `Entradas` o `Bebidas`.
- `Position`: posición para ordenar la categoría.
- `ItemIds`: lista de identificadores de productos relacionados.

La categoría `Bebidas` no necesita una clase diferente. El sistema utiliza la misma entidad `MenuItem` para platos y bebidas. La diferencia se establece mediante la categoría asignada.

### 6.2 Producto: `MenuItem.cs`

La clase `MenuItem` representa un plato o una bebida.

Sus propiedades más importantes son:

- `Id`: identificador único.
- `Name`: nombre del producto.
- `Description`: descripción del producto.
- `PriceSalon`: precio para consumo en el restaurante.
- `PriceDelivery`: precio para delivery.
- `CategoryId`: categoría a la que pertenece.
- `ImageUrl`: ruta de la imagen.
- `Stock`: cantidad disponible.
- `IsAvailable`: indica si aparece como disponible.
- `Tags`: etiquetas del producto.
- `Variants`: posibles variantes del producto.
- `DietaryFilters`: filtros dietéticos.

El valor `Stock = -1` representa stock ilimitado. El valor `Stock = 0` representa un producto agotado.

### 6.3 Pedido: `OrderRecord.cs`

La clase `OrderRecord` representa un pedido realizado.

Incluye:

- Identificador.
- Fecha de creación.
- Nombre del cliente.
- Número de mesa.
- Estado del pedido.
- Total.
- Lista de líneas de pedido.

Cada línea de pedido contiene el nombre del producto, la cantidad y el precio unitario.

### 6.4 Configuración: `RestaurantSettings.cs`

Esta clase guarda información del restaurante:

- Nombre.
- Dirección.
- Teléfono.
- Símbolo de moneda.
- Ruta del logo.

---

## 7. Inicio de la aplicación

El punto de entrada está en `Program.cs`. WinForms necesita que el hilo principal se marque con `[STAThread]` antes de crear la aplicación.

El proceso de inicio es:

1. Windows inicia el ejecutable.
2. Se ejecuta `Program.Main`.
3. Se habilitan los estilos visuales.
4. Se crea un objeto `Form1`.
5. Se ejecuta `Application.Run`.
6. `Form1` construye la interfaz.
7. Al cargar la ventana, se lee `data/menu.xml`.
8. Si el archivo no existe o no tiene información, se cargan datos de ejemplo.
9. Se normalizan las categorías principales.
10. Se muestran las tarjetas de productos.

En `Form1.cs` se garantiza que existan las categorías `Entradas` y `Bebidas`. Además, si aparece la categoría anterior `Entradas y Tapas`, se renombra a `Entradas`.

---

## 8. Interfaz principal

La ventana principal está organizada en varias zonas.

### 8.1 Barra de herramientas

La parte superior contiene botones para:

- Crear un nuevo plato o bebida.
- Administrar categorías.
- Crear respaldos.
- Abrir configuración.
- Ver historial.
- Crear pedidos.
- Simular sincronización QR.
- Simular impresión de QR.
- Simular modo móvil.

### 8.2 Barra de búsqueda y guardado

La segunda barra contiene:

- Indicadores de estado.
- Cuadro de búsqueda.
- Botón `Guardar Carta`.

El botón de búsqueda filtra las tarjetas visibles por nombre o descripción.

### 8.3 Barra de categorías

La barra de categorías se construye mediante `CategoryBar`. Incluye el botón `Todas` y un botón por cada categoría.

Cuando se presiona un botón de categoría, se produce el evento `CategorySelected`. `Form1` recibe el evento y filtra los productos mediante `MenuItem.CategoryId`.

Actualmente las categorías principales son:

- `Entradas`.
- `Platos Principales`.
- `Bebidas`.

### 8.4 Tarjetas de productos

Cada producto se muestra mediante `MenuCard`, un control personalizado. La tarjeta muestra información como:

- Nombre.
- Descripción.
- Precio de salón.
- Precio de delivery.
- Disponibilidad.
- Stock.
- Etiquetas.
- Imagen, si existe.

La tarjeta permite:

- Editar el producto.
- Eliminarlo.
- Abrir el editor con doble clic.
- Participar en operaciones de drag and drop para cambiar el orden visual.

### 8.5 Panel de edición

El panel lateral derecho se utiliza para editar un producto existente o uno nuevo.

Permite modificar:

- Categoría.
- Nombre.
- Descripción.
- Etiquetas.
- Precio de salón.
- Precio de delivery.
- Stock.
- Disponibilidad.
- Foto.

Se agregó un botón visible llamado `Guardar cambios del plato`. Al presionarlo, el programa valida el nombre, actualiza el objeto `MenuItem`, guarda la carta en XML y actualiza las tarjetas.

El botón `Eliminar plato` fue organizado con el mismo ancho del botón de guardado para mejorar la distribución visual del panel.

---

## 9. Creación de un plato o bebida

El flujo de creación comienza cuando el usuario presiona `Nuevo Plato/Bebida`.

### Pasos internos

1. Se verifica que la carta esté cargada.
2. Se verifica que exista al menos una categoría.
3. Se crea un nuevo objeto `MenuItem`.
4. Se asigna el nombre inicial `Nuevo plato`.
5. Se asigna la categoría seleccionada o la primera categoría disponible.
6. Se establecen precios iniciales en cero.
7. Se establece el stock en `-1`, que representa stock ilimitado.
8. Se agrega el producto a `menuData.Items`.
9. Se actualiza la lista de tarjetas.
10. Se abre el panel lateral para completar la información.
11. El usuario presiona `Guardar cambios del plato`.
12. Se actualizan los datos y se guardan en `menu.xml`.

La misma función sirve para platos y bebidas. Para crear una bebida, el usuario debe asignarla a la categoría `Bebidas`.

---

## 10. Guardado de datos

La clase `MenuStore` es la responsable de leer y escribir la carta.

### Cargar

`MenuStore.Load` intenta abrir el archivo XML y convertir su contenido en objetos `MenuData` mediante `XmlSerializer`.

Si el archivo no existe, se devuelve un objeto vacío. Si ocurre un error de lectura, la aplicación utiliza datos de ejemplo para evitar que se cierre inesperadamente.

### Guardar

`MenuStore.Save` realiza estos pasos:

1. Obtiene la ruta del archivo.
2. Crea la carpeta si no existe.
3. Crea un `FileStream`.
4. Crea un `XmlSerializer`.
5. Serializa `MenuData` dentro del archivo.
6. Cierra el archivo.

El botón `Guardar Carta` llama a `SaveMenu`, que utiliza esta función y muestra un mensaje al usuario indicando si la operación fue correcta o si ocurrió un error.

### Respaldos

El botón `Respaldo` crea copias de `menu.xml` dentro de:

```text
data/backups/
```

Los nombres incluyen fecha y hora, por ejemplo:

```text
menu_20260925_011328.xml
```

---

## 11. Creación de pedidos

La clase `OrderForm` permite crear pedidos.

El usuario puede:

1. Buscar un producto.
2. Seleccionar un producto.
3. Ingresar la cantidad.
4. Presionar `Agregar`.
5. Revisar las líneas del pedido.
6. Confirmar el pedido.

El formulario calcula el total multiplicando la cantidad por el precio unitario.

Al confirmar, se crea un `OrderRecord` y se guarda en `data/orders.xml`.

Los estados de pedido disponibles son:

- Pendiente.
- En curso.
- Listo.
- Entregado.

Actualmente el formulario utiliza el precio de salón como precio base. El proyecto tiene el campo `PriceDelivery`, pero esta parte de la aplicación todavía no permite elegir entre salón y delivery.

---

## 12. Historial de pedidos

La pantalla `OrderHistoryForm` permite consultar los pedidos guardados.

Muestra información como:

- Fecha.
- Cliente.
- Mesa.
- Estado.
- Total.
- Cantidad de productos.

También presenta un resumen con:

- Total de pedidos.
- Ventas acumuladas.
- Pedidos realizados en el día.

El historial se obtiene de `OrderHistoryStore`, que utiliza XML para leer y guardar los registros.

---

## 13. Procesamiento de imágenes

La utilidad `ImageFetcher` permite trabajar con imágenes remotas y locales.

Cuando una imagen no está disponible localmente, la aplicación puede descargarla mediante `WebClient`. Luego:

1. Crea una carpeta de imágenes.
2. Guarda temporalmente el archivo.
3. Abre la imagen.
4. Redimensiona la imagen a un tamaño máximo de 600 por 600.
5. Mantiene la proporción.
6. Guarda una versión optimizada.

El editor también permite seleccionar imágenes locales desde un `OpenFileDialog`. Al aceptar, la ruta de la imagen se guarda en `MenuItem.ImageUrl`.

---

## 14. Cambios implementados durante el desarrollo

### 14.1 Botón para guardar cambios

Se agregó y ajustó el botón:

```text
Guardar cambios del plato
```

Este botón está conectado al evento de guardado del panel de edición. Su objetivo es permitir que el usuario modifique los campos del producto y confirme la información.

### 14.2 Organización del botón eliminar

El botón `Eliminar plato` se ajustó para tener un tamaño coherente con el botón de guardado y ocupar correctamente el ancho del panel.

### 14.3 Categoría de bebidas

Se agregó la categoría:

```text
Bebidas
```

Las bebidas utilizan la misma estructura que los platos, pero se muestran al seleccionar esa categoría.

### 14.4 Cambio de nombre de entradas

La categoría anterior:

```text
Entradas y Tapas
```

se normaliza a:

```text
Entradas
```

---

## 15. Problemas y limitaciones actuales

Es importante explicar honestamente al instructor que el proyecto es un prototipo funcional y que todavía existen limitaciones.

### Limitaciones funcionales

- Los botones de QR y modo móvil son demostrativos.
- No existe una base de datos.
- No existe una API web.
- No hay conexión con cocina.
- No se imprimen comandas reales.
- No se descuenta stock al crear un pedido.
- No se permite elegir salón o delivery al confirmar un pedido.
- No se calculan impuestos, propinas o descuentos.
- No existe edición completa de categorías existentes.
- No existe una papelera ni deshacer.

### Limitaciones técnicas

- Los datos se guardan en archivos XML locales.
- Las rutas relativas pueden cambiar según el directorio desde el que se ejecute el programa.
- Las imágenes locales pueden quedar con rutas que no funcionan en otra computadora.
- No hay guardado atómico del archivo XML.
- No hay control de concurrencia para varias instancias de la aplicación.
- No hay pruebas automatizadas.
- La interfaz utiliza tamaños fijos y puede ser limitada en pantallas pequeñas.
- Algunas funciones del modelo, como variantes o filtros dietéticos, todavía no tienen editor visual.

Estas limitaciones pueden convertirse en propuestas de mejora para una segunda etapa.

---

## 16. Mejoras recomendadas

Una siguiente versión podría incorporar:

1. Una base de datos SQLite o SQL Server.
2. Guardado atómico mediante archivo temporal y reemplazo.
3. Copia de imágenes dentro de la carpeta de la aplicación.
4. Validación de categorías duplicadas.
5. Sincronización de `Category.ItemIds`.
6. Selección de salón o delivery durante el pedido.
7. Descuento automático de stock.
8. Estados de pedido editables.
9. Exportación del historial a PDF o Excel.
10. Generación real de códigos QR.
11. Página móvil para consultar la carta.
12. Sincronización entre dispositivos.
13. Roles de usuario y contraseña.
14. Pruebas unitarias para la persistencia y los cálculos de pedidos.
15. Diseño adaptable para distintas resoluciones de pantalla.

---

## 17. Compilación y ejecución

Desde Visual Studio se puede abrir el archivo de solución:

```text
RestauranteGestor.sln   (raíz del repositorio)
```

También se puede compilar desde una terminal de MSBuild:

```powershell
dotnet build "app escritorio.csproj" --configuration Debug
```

El ejecutable de depuración se genera en:

```text
bin\Debug\net8.0-windows\app escritorio.exe
```

Antes de compilar, se debe cerrar la aplicación si está abierta, porque Windows puede bloquear el archivo `.exe` mientras se intenta reemplazarlo.

---

## 18. Explicación oral para presentar el proyecto

Puedes explicar el proyecto con la siguiente secuencia:

> “Este proyecto lo realicé en C# utilizando Windows Forms. Es una aplicación de escritorio para administrar la carta y registrar pedidos de un restaurante. La pantalla principal está construida con paneles, botones, campos de texto y tarjetas personalizadas. La aplicación separa la información en modelos, datos, controles y utilidades. Los modelos representan las categorías, platos, bebidas, pedidos y configuración. La capa de datos carga y guarda la información mediante XML. Cuando se inicia la aplicación, se cargan los datos de `menu.xml` y se muestran las categorías y los productos. El usuario puede crear, editar, buscar y eliminar platos o bebidas. También puede crear pedidos y consultar el historial. Para la organización de la carta se utilizan categorías como Entradas, Platos Principales y Bebidas. Durante el desarrollo se ajustó el botón de guardado de cambios y el tamaño del botón de eliminar. La aplicación utiliza un tema oscuro para mantener una apariencia consistente. Actualmente el proyecto es local y las funciones de QR y modo móvil son demostrativas, por lo que podrían ampliarse en una siguiente etapa.”

---

## 19. Conclusión

El proyecto demuestra conocimientos de programación de escritorio en C#, construcción de interfaces con WinForms, orientación a objetos, eventos, modelos de datos, persistencia XML, búsqueda, formularios secundarios y construcción de una aplicación completa de gestión.

La aplicación `app escritorio` puede describirse como un **prototipo funcional de editor de carta y registro de pedidos para restaurante**, con arquitectura modular sencilla, almacenamiento local y una interfaz orientada a la administración de productos y bebidas.

Su evolución natural sería convertir el prototipo en un sistema más robusto, incorporando una base de datos, control de inventario en tiempo real, generación real de QR, sincronización móvil, impresión de comandas y mayor validación de los datos.


