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
| `RCardControl` | base para tarjetas propias | `Surface`, `HoverSurface` |
| `RDialogForm` | ventana de diálogo oscura | *Agregar → Formulario heredado* |

Los colores y las fuentes salen de `Utils/Theme.cs`: si cambias un color ahí, cambia en toda la app.

## Estructura

- `Shell/ShellForm`: la ventana principal, con el sidebar y la barra superior. Cada módulo es un **UserControl** que se carga en `contentHost`.
- `Shell/ShellSidebar` y `Shell/ShellTopBar`: se diseñan por separado. Cada botón del sidebar tiene en `Tag` la ruta a la que navega.
- `Views/Pos/*` y `Views/Mesas/*`: POS y Mesas ya migrados; sirven de ejemplo para los demás módulos.
- Los módulos que aún no se migraron (KDS, Inventario, Reservas, Delivery, Menú, Módulos, Reportes y Configuración) se muestran dentro de la ventana principal con `HostLegacyForm`, que les oculta su sidebar viejo.

## Migrar otro módulo (ej. KDS)

1. *Agregar → Control de usuario* en `Views/Kds/KdsView.cs`.
2. Diseña la pantalla con los controles `R*` (mira `PosView` como guía).
3. Pasa la lógica de `Forms/KdsForm.cs` a `KdsView.cs`.
4. En `ShellForm.GetOrCreateView`, cambia `HostLegacyForm(new KdsForm ...)` por `new KdsView()`.

## Reglas para no romper el diseñador

- En los `*.Designer.cs` va solo lo que genera Visual Studio. Nada de lambdas `(s, e) =>` ni código propio.
- Los eventos se conectan en Propiedades → ⚡ (rayo). El manejador queda en el `.cs`.
- El código que solo debe correr en la app (leer archivos, cargar datos) va en el `.cs` después de `InitializeComponent()`, protegido con `if (UiHelpers.IsDesignTime) return;`.
