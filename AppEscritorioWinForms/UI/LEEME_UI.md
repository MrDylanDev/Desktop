# Kit visual RestoOS (WinForms .NET 8)

Réplica en WinForms del tema de la versión WPF (`App.xaml`). Todo se edita desde el **diseñador de Visual Studio**.

## Cómo se usa

1. **Compila una vez** (Ctrl+Shift+B). Los controles aparecen en el Cuadro de herramientas, en la sección *app escritorio Components*.
2. Arrástralos a cualquier formulario o UserControl.
3. En Propiedades, busca la categoría **RestoOS** y elige el estilo. No hace falta escribir colores ni fuentes a mano.

| Control | Equivale en WPF | Propiedad clave |
|---|---|---|
| `RButton` | `PrimaryButton`, `SecondaryButton`, `DangerButton`, `NavButton`, `NumpadButton`, `IconButton` | `Variant`, `Selected` |
| `RPanel` | `Border` / `Style="Card"` | `Surface`, `CornerRadius`, `BottomBorder` |
| `RFlowPanel` | `WrapPanel` / lista con scroll | `Surface` |
| `RLabel` | `TextBlock` | `TextStyle` (Title, Muted, Price, Total, Accent...) |
| `RTextBox` | `TextBox` con placeholder | `PlaceholderText`, `Multiline`, `LargeText` |
| `RComboBox` | `ComboBox` oscuro | `Items` |
| `RBadge` | chip (rol, "Operando local") | `Kind` |
| `RSwitch` | `CheckBox` "Módulo activado" | `Checked`, evento `CheckedChanged` |
| `RDataGridView` | `ListView`/`GridView` oscuro | columnas con `Tag = "chip"` (insignia) o botón con `Tag = "danger"`/`"primary"` |
| `RCalendar` | `Calendar` oscuro | `SelectedDate`, evento `DateChanged` |
| `RBarChart` | barras de "Ventas últimos 7 días" | `SetData(valores, etiquetas)` desde código |
| `RCardControl` | base para tarjetas propias | `Surface`, `HoverSurface` |
| `RDialogForm` | ventana de diálogo oscura | *Agregar → Formulario heredado* |

Los colores y las fuentes salen de `Utils/Theme.cs`: si cambias un color ahí, cambia en toda la app.

## Estructura

**Cada sección de la app es un Form en `Forms/`.** Ábrelo con doble clic y verás la ventana completa (menú lateral, barra superior y la sección), igual que al ejecutar. Todo lo de la sección se selecciona y se mueve desde el diseñador.

| Form | Sección | Piezas propias (en `Views/`, se arrastran desde el Cuadro de herramientas) |
|---|---|---|
| `PosForm` | POS | `ProductTile`, `TicketLineItem`, `CheckoutDialog`, `NoteDialog`, `ReceiptDialog` |
| `MesasForm` | Mesas y Salón | `TableCard`, `TableDialog` |
| `KdsForm` | Cocina KDS | `KdsOrderCard` (propiedad `Stage`: Nuevo / Preparación / Listo) |
| `InventarioForm` | Inventario | `InsumoDialogForm` |
| `ReservasForm` | Reservas | `ReservaDialogForm` |
| `DeliveryForm` | Delivery | `DeliveryDialogForm` |
| `ReportesForm` | Reportes + Trazabilidad | — |
| `SettingsForm` | Configuración | — |
| `ModulesForm` | Módulos | `ModuleCard` (propiedades `Title`, `Description`, `Glyph`, `IsCore`...) |
| `Form1` | Menú y productos | `CategoryBar`, `MenuCard`, `StatusBar` |

- En cada Form, `sidebar` y `topBar` son los controles reales de `Shell/ShellSidebar` y `Shell/ShellTopBar`. Para cambiar el menú o la barra, edítalos ahí: el cambio aparece en todas las secciones. En cada Form solo se ajusta `sidebar.ActiveRoute` (botón resaltado) y `topBar.RouteText` (título).
- Al ejecutar hay una sola ventana: `Shell/ShellForm` crea el Form de la sección, le quita su sidebar y su barra (son copias para el diseñador) y lo muestra en `contentHost`.
- `Data/ModuleStore.cs` guarda qué módulos están activos (`modules.dat`) y avisa al menú con `ModuleStateChanged`.
- Los datos de KDS, Inventario, Reservas, Delivery y Reportes son DEMO en memoria (`Models/ModuloModels.cs`).

## Agregar una sección nueva

1. *Agregar → Formulario (Windows Forms)* en `Forms/<Seccion>Form.cs`.
2. Arrastra `ShellSidebar` (Dock = Left) y `ShellTopBar` (Dock = Top); pon `ActiveRoute` y `RouteText`.
3. Arrastra un `RPanel` con Dock = Fill y diseña la sección dentro (mira `InventarioForm`: título, filtros, tabla y nota).
4. Agrega la ruta en `ShellForm.GetOrCreateView` y un botón con ese `Tag` en `ShellSidebar`.

## Reglas para no romper el diseñador

- En los `*.Designer.cs` va solo lo que genera Visual Studio. Nada de lambdas `(s, e) =>` ni código propio.
- Los eventos se conectan en Propiedades → ⚡ (rayo). El manejador queda en el `.cs`.
- El código que solo debe correr en la app (leer archivos, cargar datos) va en el `.cs` después de `InitializeComponent()`, protegido con `if (UiHelpers.IsDesignTime) return;`.
