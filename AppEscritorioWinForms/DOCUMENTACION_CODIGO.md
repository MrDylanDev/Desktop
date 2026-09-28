# Documentación del código — RestoOS ("app escritorio")

Aplicación de escritorio **Windows Forms sobre .NET 8** (`net8.0-windows`) para gestionar un restaurante pequeño:
POS, Mesas, Cocina KDS, Inventario, Reservas, Delivery, Menú, Reportes, Configuración y Módulos.
Es **solo frontend**: no hay base de datos. Algunos datos se guardan en archivos planos (ver [§7](#7-persistencia)).

Otros documentos: [README principal](../README.md) (visión general, roles y estado por módulo) ·
[`UI/LEEME_UI.md`](UI/LEEME_UI.md) (kit visual y cómo editar en el diseñador).

---

## 1. Visión general

| Dato | Valor |
|---|---|
| Lenguaje | C# (code-behind, sin MVVM ni inyección de dependencias) |
| Framework | .NET 8 (`net8.0-windows`, WinForms, `WinExe`, proyecto SDK) |
| Namespace raíz | `app_escritorio` |
| Diseño | Todo se edita en el **diseñador de Visual Studio** (`*.Designer.cs` sin código propio) |
| Dependencias externas | Ninguna (sin NuGet) |

## 2. Estructura de carpetas

```
AppEscritorioWinForms/
├── Program.cs            Punto de entrada: Login → ShellForm (bucle para "Cambiar perfil")
├── Shell/                Ventana principal
│   ├── ShellForm         Menú lateral + barra superior + contentHost; navega entre secciones
│   ├── ShellSidebar      Menú lateral (Operación / Administración); cada botón lleva la ruta en Tag
│   └── ShellTopBar       Reloj, ruta actual, rol y botón "Cambiar perfil"
├── Forms/                UNA SECCIÓN = UN FORM + diálogos + login
│   ├── PosForm, MesasForm, MenuForm (Menú digital), KdsForm, InventarioForm, ReservasForm,
│   │   DeliveryForm, ReportesForm, SettingsForm (Configuración), ModulesForm (Selector de módulos)
│   ├── InsumoDialogForm, ReservaDialogForm, DeliveryDialogForm, CategoriasDialogForm, InsumoLinkDialogForm
│   └── LoginForm, AdminCodeForm (PIN de administrador), OrderHistoryForm
├── Views/                Piezas reutilizables de las secciones
│   ├── Pos/              ProductTile, TicketLineItem, CheckoutDialog, NoteDialog, ReceiptDialog
│   ├── Mesas/            TableCard, TableDialog
│   ├── Carta/            DishCard, DishImage, InsumoLinkRow, CartaUi (Menú digital)
│   ├── Kds/              KdsOrderCard
│   └── Modulos/          ModuleCard
├── UI/                   Kit visual (RButton, RPanel, RLabel, RTextBox, RComboBox, RBadge, RChip, RSwitch,
│                         RDataGridView, RCalendar, RBarChart, RCardControl, RDialogForm, UiHelpers)
├── Data/                 Acceso a datos (patrón "Store": métodos estáticos Load/Save que no lanzan excepciones)
├── Models/               Clases de datos
└── Utils/Theme.cs        Paleta y tipografía únicas (copiadas de App.xaml de la versión WPF)
```

## 3. Arquitectura

```
Program ──► LoginForm ──► ShellForm ──────────────────────────────┐
                            │ ShellSidebar.NavigateRequested(ruta) │
                            ▼                                      │
                     ShellForm.Navigate(ruta)                      │
                            │ GetOrCreateView: crea el Form 1 vez  │
                            ▼                                      │
               HostSectionForm(form): TopLevel=false, sin borde,   │
               quita su ShellSidebar/ShellTopBar, Dock=Fill        │
                            ▼                                      │
                     contentHost (se muestra 1 sección)  ◄─────────┘
```

- **Una sección = un Form.** En el diseñador cada Form tiene `sidebar` (ShellSidebar con `ActiveRoute`), `topBar`
  (ShellTopBar con `RouteText`) y el contenido en `root`, así que se ve la app completa.
- **Al ejecutar hay una sola ventana.** `ShellForm` crea cada sección una vez (`_views`), le quita las copias del
  menú y de la barra y la muestra en `contentHost`. Al volver a una sección no se recrea (no parpadea y conserva el estado).
- **Al mostrar una sección** (`OnViewShown`): el POS recarga el impuesto por defecto, Mesas refresca los totales,
  Módulos relee `modules.dat` y Configuración relee sus archivos.
- **Comunicación entre secciones por eventos:** `MesasForm.MesaParaPos` → `PosForm.SetMesa(mesa)`;
  `SettingsForm.RestaurantSaved` → `ShellSidebar.SetBranch(...)`; `ModuleStore.ModuleStateChanged` → habilita o
  deshabilita botones del menú.
- **Roles:** `ShellForm` recibe el rol elegido en `LoginForm`. El Administrador ve Operación + Administración;
  Empleados solo Operación. Reportes y Configuración rechazan a Empleados. Atajos F1 POS · F2 Mesas · F3 KDS.

## 4. Secciones (`Forms/`)

| Form | Qué hace | Piezas / diálogos |
|---|---|---|
| `PosForm` | Productos por categoría y búsqueda, ticket por mesa (`TicketStore`), notas por ítem, impuesto 0/8/19/27 %, tipo de pedido (mesa, para llevar, domicilio), cobro y recibo | `ProductTile`, `TicketLineItem`, `CheckoutDialog`, `NoteDialog`, `ReceiptDialog` |
| `MesasForm` | Plano de mesas por salón, detalle con total real del POS, CRUD de mesas, "Abrir en POS" | `TableCard`, `TableDialog` |
| `KdsForm` | Tres columnas Nuevo → En preparación → Listo, filtro por estación, tiempo transcurrido con color, reloj | `KdsOrderCard` (propiedad `Stage`) |
| `InventarioForm` | Insumos con búsqueda, categoría, "Solo stock bajo", estado OK/Bajo/Crítico, ajustar/eliminar | `InsumoDialogForm` |
| `ReservasForm` | Calendario + agenda del día, filtro por estado y búsqueda, crear/editar/eliminar | `RCalendar`, `ReservaDialogForm` |
| `DeliveryForm` | Cola de pedidos Rappi / Uber Eats / DiDi Food, avanzar estado, sincronizar menú (DEMO) | `DeliveryDialogForm` |
| `ReportesForm` | KPIs por período y origen, gráfico de 7 días, top platos, ventas por mesa, historial de cobros con detalle | `RBarChart`, `RDataGridView` |
| `SettingsForm` | Datos del negocio, impuesto por defecto, respaldos y ubicación de los archivos | — |
| `ModulesForm` | Activa o desactiva módulos | `ModuleCard` (propiedades `Title`, `Description`, `Glyph`, `IsCore`, `ModuleEnabled`) |
| `MenuForm` | Menú digital (ver §6) | `DishCard`, `DishImage`, `InsumoLinkRow`, `CategoriasDialogForm`, `InsumoLinkDialogForm`, `OrderHistoryForm` |

Los datos de KDS, Inventario, Reservas, Delivery y Reportes son **DEMO en memoria** (`Models/ModuloModels.cs`):
se generan al abrir la sección y se pierden al cerrar la app.

## 5. Kit visual (`UI/`) y tema

- Los controles `R*` ocultan `BackColor`/`ForeColor`/`Font` en el diseñador: el color sale de `Surface`,
  `TextStyle`, `Variant` o `Kind`, y los valores vienen de `Utils/Theme.cs`.
- `RDataGridView`: columna con `Tag = "chip"` → el texto se pinta como insignia del color de la celda; columnas de
  botón con `Tag = "danger"` / `"primary"` / vacío.
- `UiHelpers.IsDesignTime`: el código que lee archivos o carga datos va después de `InitializeComponent()` y se
  salta en el diseñador (`if (UiHelpers.IsDesignTime) return;`).
- `UiHelpers.ApplyDarkTitleBar` / `ApplyDarkScrollbars`: barra de título y scrollbars oscuros en Windows 10/11.
- Detalle de cada control y reglas para no romper el diseñador: [`UI/LEEME_UI.md`](UI/LEEME_UI.md).

## 6. Menú digital (`Forms/MenuForm.cs`)

Pantalla de la carta con el estilo de tarjetas: barra de contadores (Disponibles / Agotados hoy / Sugerencias del
Chef, que también son filtros), buscador, chips de categoría, grilla de `DishCard` y el panel **Edición Rápida**.

| Método | Qué hace |
|---|---|
| `RenderDishes` | Crea una `DishCard` por plato según categoría, contador elegido y búsqueda (nombre, descripción, etiquetas, alérgenos e insumos) |
| `FitCards` | Reparte el ancho en columnas (tarjetas de 250 a 360 px) |
| `LoadEditor(item, isNew)` | Llena el panel de edición; si hay cambios sin publicar pregunta antes de cambiar de plato |
| `BtnPublicar_Click` (Ctrl+S) | Valida, aplica los cambios al plato y llama a `MenuStore.Publish()` (guarda y avisa al POS) |
| `Card_PauseClicked` | "Pausar por falta de stock" / "Reactivar": se publica al instante |
| `BtnNuevo_Click` (Ctrl+N), `BtnDuplicar_Click`, `BtnEliminar_Click` | Crear, duplicar y eliminar platos |
| `BtnCalcDelivery_Click` | Precio delivery = salón + comisión (15 %), redondeado a la centena |
| `BtnVincular_Click` / `InsumoLinkRow` | Insumos que se descuentan del almacén por cada plato vendido |
| `FlowDishes_DragDrop` | Reordenar la carta arrastrando una tarjeta desde su foto |
| `BtnCategorias_Click` | `CategoriasDialogForm`: agregar, ordenar y eliminar categorías (no deja borrar una con platos) |

- **Etiquetas:** filtros dietéticos y alérgenos (`DietaryFilters`: Sin TACC, Vegetariano, Picante, Sin Lactosa,
  Gluten, Lácteos), `IsSuggestion` (Sugerencia Chef) y la etiqueta "Plato Más Vendido" (sello dorado en la foto).
- **Estado del plato:** `IsAvailable = false` o `Stock = 0` → "⚠ AGOTADO HOY" (foto oscurecida); `Stock` de 1 a 5 →
  "● QUEDAN n"; `Stock = -1` → ilimitado.
- **Fotos:** `ImageUrl` es la ruta de un archivo del equipo; sin foto se dibuja un fondo con el ícono de la categoría.

## 7. Persistencia

| Clase | Archivo | Qué guarda |
|---|---|---|
| `Data/ModuleStore` | `%LocalAppData%\RestoOS\modules.dat` | Módulos activos (`clave=1/0`) y evento `ModuleStateChanged` |
| `Data/MesaStore` | `%LocalAppData%\RestoOS\mesas.dat` | Mesas del salón |
| `Data/LocalSettings` | `%LocalAppData%\RestoOS\tax.dat`, `settings.xml` | Impuesto por defecto; nombre y dirección del negocio (los escribe `SettingsForm`) |
| `SettingsForm` | `%LocalAppData%\RestoOS\backups\respaldo_yyyyMMdd_HHmmss\` | Respaldos manuales de todos los archivos |
| `Data/MenuStore` | `data\menu.xml` (relativo a la carpeta de ejecución) | Carta compartida (`MenuStore.Current`): categorías y platos. `Publish()` guarda y dispara `MenuChanged`, que recarga los productos del POS |
| `Data/OrderHistoryStore` | `data\orders.xml` | Historial de pedidos del editor de carta |
| `Data/TicketStore` | memoria | Ticket abierto por mesa; evento `TicketChanged` (lo escuchan POS y Mesas) |

## 8. Modelos (`Models/`)

| Archivo | Clases |
|---|---|
| `Category.cs`, `MenuItem.cs` | Carta: `MenuItem` (precios salón/delivery, comisión, stock, disponibilidad, foto, etiquetas, filtros dietéticos, insumos) e `InsumoLink` |
| `OrderRecord.cs` | `OrderRecord`, `OrderRecordLine` (historial) |
| `PosModels.cs` | `Product`, `OrderLine` del POS (namespace `app_escritorio.Forms`) |
| `ModuloModels.cs` | `KdsOrder`/`KdsItem`, `Insumo`, `Reserva`, `PedidoDelivery`, `Venta`/`VentaItem` (datos DEMO) |

## 9. Agregar una sección nueva

1. *Agregar → Formulario (Windows Forms)* en `Forms/<Seccion>Form.cs`.
2. Arrastrar `ShellSidebar` (Dock = Left) y `ShellTopBar` (Dock = Top); poner `ActiveRoute` y `RouteText`.
3. Arrastrar un `RPanel` con Dock = Fill y diseñar la sección dentro con los controles `R*`.
4. Crear la sección en `ShellForm.GetOrCreateView` y agregar un botón con la ruta en `Tag` en `ShellSidebar`.

## 10. Archivos generados (no editar a mano)

- `*.Designer.cs` y `*.resx`: los escribe el diseñador de Visual Studio.
- `bin/`, `obj/`, `.vs/`: salida de compilación y caché del IDE (ignorados por `.gitignore`).
