---
name: Culinary Workspace Kinetic
colors:
  surface: '#111415'
  surface-dim: '#111415'
  surface-bright: '#37393b'
  surface-container-lowest: '#0c0f10'
  surface-container-low: '#191c1e'
  surface-container: '#1d2022'
  surface-container-high: '#282a2c'
  surface-container-highest: '#333537'
  on-surface: '#e1e2e4'
  on-surface-variant: '#e1bfb5'
  inverse-surface: '#e1e2e4'
  inverse-on-surface: '#2e3132'
  outline: '#a88a81'
  outline-variant: '#59413a'
  surface-tint: '#ffb59d'
  primary: '#ffb59d'
  on-primary: '#5d1800'
  primary-container: '#f06536'
  on-primary-container: '#521400'
  inverse-primary: '#ab3504'
  secondary: '#ffb95f'
  on-secondary: '#472a00'
  secondary-container: '#ee9800'
  on-secondary-container: '#5b3800'
  tertiary: '#4edea3'
  on-tertiary: '#003824'
  tertiary-container: '#00a572'
  on-tertiary-container: '#00311f'
  error: '#ffb4ab'
  on-error: '#690005'
  error-container: '#93000a'
  on-error-container: '#ffdad6'
  primary-fixed: '#ffdbd0'
  primary-fixed-dim: '#ffb59d'
  on-primary-fixed: '#390b00'
  on-primary-fixed-variant: '#842500'
  secondary-fixed: '#ffddb8'
  secondary-fixed-dim: '#ffb95f'
  on-secondary-fixed: '#2a1700'
  on-secondary-fixed-variant: '#653e00'
  tertiary-fixed: '#6ffbbe'
  tertiary-fixed-dim: '#4edea3'
  on-tertiary-fixed: '#002113'
  on-tertiary-fixed-variant: '#005236'
  background: '#111415'
  on-background: '#e1e2e4'
  surface-variant: '#333537'
typography:
  display-lg:
    fontFamily: Inter
    fontSize: 40px
    fontWeight: '800'
    lineHeight: 48px
  display-md:
    fontFamily: Inter
    fontSize: 32px
    fontWeight: '700'
    lineHeight: 40px
  headline-lg:
    fontFamily: Inter
    fontSize: 24px
    fontWeight: '700'
    lineHeight: 32px
  headline-md:
    fontFamily: Inter
    fontSize: 20px
    fontWeight: '600'
    lineHeight: 28px
  title-lg:
    fontFamily: Inter
    fontSize: 18px
    fontWeight: '600'
    lineHeight: 24px
  body-lg:
    fontFamily: Inter
    fontSize: 16px
    fontWeight: '500'
    lineHeight: 24px
  body-md:
    fontFamily: Inter
    fontSize: 14px
    fontWeight: '400'
    lineHeight: 20px
  label-tactile:
    fontFamily: Inter
    fontSize: 15px
    fontWeight: '700'
    lineHeight: 20px
  label-sm:
    fontFamily: Inter
    fontSize: 12px
    fontWeight: '600'
    lineHeight: 16px
  numeric-timer:
    fontFamily: Inter
    fontSize: 28px
    fontWeight: '800'
    lineHeight: 32px
rounded:
  sm: 0.25rem
  DEFAULT: 0.5rem
  md: 0.75rem
  lg: 1rem
  xl: 1.5rem
  full: 9999px
spacing:
  touch-min: 3.5rem
  touch-expanded: 4rem
  gutter-kds: 1rem
  gutter-pos: 0.75rem
  panel-padding: 1.25rem
  screen-edge: 1.5rem
---

## Brand & Style

Este sistema de diseño está concebido específicamente para el software de escritorio de gestión gastronómica de alto rendimiento: puntos de venta (POS), pantallas de cocina (KDS), control de salón y comandas, gestión de stock e integración de delivery masivo.

### Personalidad y Tono
- **Eficiencia implacable:** La interfaz responde con inmediatez; reduce la fricción en horas pico y elimina pasos innecesarios.
- **Calidez culinaria contemporánea:** Huye del aspecto frío y utilitario de los sistemas heredados de punto de venta mediante toques refinados de terracota tostada y ámbar gourmet, manteniendo un entorno apetitoso pero rigurosamente técnico.
- **Claridad ergonómica táctil:** Pensada tanto para la interacción con pantalla táctil grasosa o húmeda como para ratón y atajos rápidos de teclado físico.

### Movimiento de Diseño
Una fusión híbrida entre **Corporate / Modern de alta precisión** y **Tactile Ergonomics**:
- Superficies sólidas en capas con contraste deliberado para mitigar el reflejo de luces de cocina o salones oscuros.
- Áreas de toque generosas (hit-targets sobredimensionados).
- Semántica cromática inequívoca que permite escanear el estado de una mesa o comanda a 2 metros de distancia.

## Colors

La paleta se apoya de forma nativa en un modo oscuro profundo basado en carbón pizarra (`#181A20`), formulado específicamente para entornos KDS y terminales POS de mostrador, reduciendo la fatiga visual y minimizando la visibilidad de reflejos.

### Paleta Principal
- **Primary (`#E05A2B` - Terracota Tostado):** Acciones críticas de conversión (cobrar ticket, disparar comanda a cocina, acción principal del POS).
- **Secondary (`#F59E0B` - Ámbar Gourmet):** Estados intermedios, reservas activas, artículos en preparación o avisos de tiempo medio.
- **Tertiary (`#10B981` - Esmeralda Cocina):** Platos listos para pase, mesas libres, pago confirmado y estado de sistema operativo óptimo.
- **Neutral (`#DCDDDF` - Gris Claro Técnico):** Tonalidad de contraste para elementos de soporte y tipografías secundarias sobre fondos oscuros.

### Paleta Semántica y Canales Operativos
- **Canal Delivery Integrado (Rappi / UberEats / PedidosYa):** Violeta Eléctrico (`#8B5CF6`).
- **Canal Salón / Comedor:** Azul Cobalto / Cian Neón (`#0EA5E9`).
- **Urgencia / Retraso Crítico / Anulaciones:** Carmesí Fuerte (`#EF4444`).
- **Barra / Cafetería:** Cobre Bronce (`#D97706`).

## Typography

La selección tipográfica única es **Inter**, elegida por sus números tabulares nativos (`tnum`), su alta legibilidad bajo ángulos oblicuos y su neutralidad geométrica.

### Directrices de Jerarquía
- **Precios y Totales de Cuenta:** Deben configurarse invariablemente con fuentes de ancho tabular (`font-feature-settings: 'tnum' 1`) para garantizar una alineación decimal estricta en comandas y pre-cuentas.
- **Cronómetros KDS (`numeric-timer`):** Utilizan el peso `800` para informar instantáneamente los minutos transcurridos en preparación desde el inicio del ticket.
- **Labels Táctiles (`label-tactile`):** Tienen un peso `700` y tamaño de 15px con espaciado óptico compensado para su lectura a un brazo de distancia.
- **Abreviaciones de Cocina:** Las descripciones secundarias y exclusiones de alérgenos ("SIN GLUTEN", "TÉRMINO MEDIO") se formatean en alta compacta con peso `700` y contraste positivo.

## Layout & Spacing

El software de gestión opera fundamentalmente en resoluciones de pantalla táctil industrial estándar (desde terminales táctiles de 15.6" Full HD hasta pantallas KDS de 21" y 32").

### Filosofía de Distribución
- **Arquitectura de Tres Zonas para POS:**
  1. **Navegador de Familias / Categorías:** Barra o riel lateral izquierdo/superior fijo de acceso inmediato.
  2. **Grid de Artículos Central:** Sistema de grilla fluida donde cada ítem mantiene un alto mínimo de `touch-min` (56px) para evitar toques falsos.
  3. **Comanda / Resumen Activo (Lateral Derecho):** Panel vertical fijo con ancho mínimo de 360px a 420px, reservando el extremo inferior para el botón de cobro masivo.

### Pantallas de Cocina (KDS)
- **Columnas de Flujo Horizontal:** Grilla modular de 4 a 6 columnas independientes con scroll horizontal continuo, organizadas según prioridad de cocción o tiempo de espera.
- Espacio libre de separación de `gutter-kds` (16px) entre comandas para prevenir confusiones entre mesas colindantes.

## Elevation & Depth

La profundidad se comunica a través de **capas tonales combinadas con contornos de bajo contraste** y sombras ambientales suaves. En un entorno táctil de ritmo acelerado, el falso realismo 3D excesivo genera fatiga; la distinción debe provenir de contrastes limpios:

1. **Nivel 0 (Fondo General):** Lienzo global de la aplicación.
2. **Nivel 1 (Contenedores y Paneles):** Aloja grids de productos y mapas de salón.
3. **Nivel 2 (Tarjetas Activas, Mesas y Comandas):** Superficies interactivas con borde de estado según canal (Azul comensal, Violeta delivery, Carmesí alerta).
4. **Nivel 3 (Modales de Cobro, Teclados Numéricos Flotantes y Descuentos):** Acompañados de un drop shadow perimetral difuso.
5. **Pulsación / Feedback Táctil:** Al pulsar una tarjeta o botón, la elevación se invierte instantáneamente con un escalado sutil de `scale(0.98)` y un flash de borde blanco semitransparente.

## Shapes

El lenguaje de formas adopta esquinas redondeadas de nivel 2 (base `0.5rem`, componentes ergonómicos con `rounded-xl` a `1.5rem`).

### Justificación de Formas
- **Amigabilidad Táctil:** Los bordes muy afilados generan tensión visual; el redondeado en tarjetas de producto guía la mirada naturalmente hacia el centro del botón y el precio.
- **Etiquetas de Estado y Píldoras de Canal:** Utilizan una forma envolvente semirredondeada para distinguirse claramente de los botones rectangulares de acción.
- **Teclado Numérico (Numpad):** Botones con `rounded-xl` y separación uniforme para máxima precisión al digitar cantidades con una sola mano.

## Components

### Botones
- **Botón de Cobro / Despacho Maestro:** Alto mínimo de 56px (`min-h-14`), fondo terracota (`#E05A2B`) o esmeralda (`#10B981`), texto en peso 700 e icono de validación masivo. Siempre anclado al pie de la comanda.
- **Botones de Modificador (+ Queso, Sin Sal):** Altura de 48px, fondo neutro carbón, borde suave que se ilumina con acento primario al estar seleccionado.

### Tarjetas de Mesa y Comandas KDS
- **Tarjeta de Mesa en Mapa de Salón:**
  - Superficie con esquinas `rounded-xl`.
  - Borde perimetral de 2px de color codificado (Verde = Libre, Ámbar = Reservada, Azul = Ocupada con cuenta abierta, Rojo = Esperando factura / Bloqueada).
  - Indicador numérico de mesa en tamaño `headline-lg` visible a distancia.
- **Ticket KDS:**
  - Cabecera con cronómetro de alta visibilidad que conmuta de verde a amarillo a los 10 minutos y a carmesí intermitente superados los 20 minutos.
  - Artículos tachables mediante toque directo de renglón con confirmación auditiva háptica/sonora.

### Conmutadores ("Power-On" Toggles)
- Interruptores sobredimensionados (ancho de 64px, alto de 36px) para abrir/cerrar salón, pausar pedidos de delivery y cambiar turnos de caja. Estado encendido en verde esmeralda o terracota con manija prominente.

### Entradas Numéricas e Inputs
- **Numpad de Cobro:** Diseñado con campos de entrada de moneda sobredimensionados (`display-md`), botones de denominación rápida de billetes para agilizar devoluciones de cambio sin escribir.
- **Campos de Texto:** Modo de búsqueda rápida con botón de limpieza con un solo toque (icono de 'X' grande) para restablecer filtros al instante.