# Requisitos — Software de gestión de restaurantes (escritorio, Windows)

## 1. Resumen del proyecto
Aplicación de escritorio nativa para Windows (compatible desde Windows 8 hasta Windows 11), para la gestión de restaurantes de cualquier tamaño. Arquitectura modular: el negocio arranca con un punto de venta básico y activa nuevas funciones a medida que crece, sin reinstalar ni perder datos. Funciona sin depender de la nube para su operación central; solo requiere internet para facturación electrónica DIAN e integración con apps de delivery. Modelo de licenciamiento de pago único o perpetuo, no suscripción.

## 2. Público objetivo
Restaurantes pequeños e independientes, con prioridad en ciudades intermedias y pueblos de Colombia — negocios con internet poco confiable, computadores no siempre nuevos, y resistencia a pagar mensualidades. Usuarios finales: dueños (sin conocimientos técnicos), meseros, cajeros, personal de cocina.

## 3. Requisitos funcionales por módulo

**Sistema de módulos activables (núcleo del producto)**
- Panel donde el dueño activa/desactiva funciones sin tocar configuración técnica.
- Activar un módulo nuevo no debe requerir reinstalar la app ni perder datos existentes.
- Cada módulo debe poder funcionar de forma independiente o combinada con los demás.

**Punto de venta (POS básico)** — módulo inicial obligatorio
- Registro rápido de venta, cálculo de total, cobro (efectivo/tarjeta), impresión de recibo.
- Interfaz táctil-friendly, botones grandes.
- Cantidad y notas por ítem (ej. "x2", "sin cebolla", "término medio").
- Cálculo de cambio (vueltos) al pagar en efectivo, con campo de "monto recibido".
- Pago dividido entre varias personas o mixto (parte efectivo, parte tarjeta).
- Vista previa de recibo antes/después de imprimir.
- El pago con tarjeta se registra como método (no procesa la tarjeta directamente) — se asume que el negocio usa un datáfono físico externo, como es habitual en restaurantes pequeños en Colombia.

**Gestión de mesas**
- Plano visual del salón, estados por color (libre, ocupada, reservada, por limpiar).
- Asignación de pedidos a mesa específica.

**Inventario**
- Registro de insumos, descuento automático por venta, alertas de stock bajo.

**Reservas**
- Vista tipo calendario/agenda, asignación de mesa a una reserva.

**Pedidos / pantalla de cocina (KDS)**
- Lista de comandas en curso, separadas por estación si aplica.
- Debe poder recibir pedidos de salón y, cuando el módulo de delivery esté activo, también de plataformas externas en la misma pantalla.

**Menú digital**
- Editor de categorías y platos: nombre, foto, precio, disponibilidad.
- Cambios en precio/disponibilidad deben poder reflejarse también en plataformas de delivery conectadas.

**Administración / reportes**
- Reportes de ventas por período, unificando salón + delivery.
- Gestión de usuarios/roles (dueño, cajero, mesero, cocina) con permisos distintos.

**Facturación electrónica DIAN** (requiere internet)
- Integración vía API con un proveedor tecnológico ya habilitado (no desarrollo directo contra DIAN en la v1).
- Generación de factura desde la venta del POS, sin salir de la app.

**Integración con apps de delivery** (requiere internet)
- Conexión vía agregador/middleware (no integraciones directas por plataforma en la v1).
- Recepción de pedidos de Rappi, Uber Eats y DiDi Food en el mismo flujo que los pedidos de salón.
- Sincronización de menú y disponibilidad hacia las plataformas conectadas.

## 4. Requisitos no funcionales
- **Compatibilidad de sistema operativo:** Windows 8, 8.1, 10 y 11.
- **Funcionamiento offline:** todo excepto DIAN y delivery debe operar sin conexión a internet.
- **Rendimiento:** debe correr fluido en hardware modesto/antiguo (procesadores y RAM típicos de un PC de 6-8 años).
- **Licenciamiento:** validación de licencia que no dependa de conexión constante a un servidor (coherente con el modelo de pago único, sin suscripción).
- **Seguridad de datos:** la base de datos local debe protegerse ante pérdida (backups locales) y ante acceso no autorizado (los datos son financieros y de clientes).
- **Usabilidad:** curva de aprendizaje mínima, pensada para personal sin experiencia previa en software.

## 5. Arquitectura técnica recomendada

**Corrección importante sobre el framework de UI:** en una conversación anterior mencioné WinUI 3 como opción — hay que descartarlo. Confirmé que WinUI 3 / Windows App SDK requiere como mínimo Windows 10 versión 1809 en adelante; **no corre en Windows 8 ni 8.1 bajo ninguna circunstancia**. Como el requisito de compatibilidad con Windows 8 es un punto central de tu propuesta de valor (negocios con PCs viejos), la recomendación real es:

- **Framework de UI:** WPF sobre .NET (Windows Presentation Foundation). Sigue siendo compatible con Windows 8/8.1 en adelante, tiene herramientas de diseño maduras y es la opción estándar para este tipo de software de escritorio en C#.
- **Base de datos local:** SQLite — liviana, sin necesidad de instalar un motor de base de datos aparte, ideal para operación 100% local.
- **Arquitectura modular:** patrón de plugins (por ejemplo, con MEF — Managed Extensibility Framework — o un sistema propio de carga de módulos por DLL) para que activar una función nueva no implique recompilar ni reinstalar toda la app.
- **Sistema de licencias:** validación local con archivo de licencia firmado, con verificación periódica opcional en línea (no obligatoria) para mantener coherencia con el pago único.
- **Integraciones externas:** vía llamadas HTTP/API REST al proveedor tecnológico DIAN y al agregador de delivery — son los únicos componentes que requieren red.
- **Multi-terminal / varias cajas:** para negocios medianos o grandes con más de una caja o estación (mostrador + segunda caja + pantalla de cocina), una sola máquina opera como "servidor" con la base de datos central, y las demás se conectan como clientes por la red local (WiFi/cable del propio restaurante) — sin depender de internet. No se debe compartir el archivo de la base de datos directamente por red (riesgo de corrupción con escrituras simultáneas); la máquina servidor debe exponer un pequeño servicio/API local al que los clientes se conectan. Alternativa: usar un motor de base de datos con soporte nativo para ambos modos (embebido y cliente-servidor), como Firebird, en vez de construir la capa de sincronización desde cero. Si una caja pierde conexión con el servidor, debe mostrar un aviso claro y bloquear el cobro hasta reconectar (para la v1; cola de reintento automático queda para una fase posterior).

## 6. Entidades principales de datos
Productos/platos, categorías de menú, mesas, pedidos, ítems de pedido, clientes, reservas, inventario/insumos, usuarios/roles, ventas/facturas, configuración de módulos activos.

## 7. Fases sugeridas
- **Fase 1 (MVP):** sistema de módulos + POS básico + gestión de mesas + menú digital.
- **Fase 2:** inventario + pedidos/KDS + reservas + administración/reportes.
- **Fase 3:** integración DIAN + integración de delivery (dependen de terceros externos, conviene dejarlas para cuando el core ya esté validado con usuarios reales).

## 8. Consideraciones operativas y de continuidad

**Operación diaria**
- Apertura y cierre de caja (arqueo): fondo inicial al abrir turno, conteo real al cerrar, diferencia calculada automáticamente, reporte por cajero/turno.
- Anulación de pedidos/ventas: requiere PIN de supervisor distinto al del cajero, motivo obligatorio, registro de quién autorizó.
- Propina: porcentaje configurable (activable/desactivable), como línea aparte de la venta; reporte de reparto por período.
- Descuentos y promociones: por porcentaje o valor fijo, por ítem o por cuenta, con autorización de supervisor sobre cierto monto; combos como ítem agrupado.
- Impuesto configurable por negocio (INC 8%, IVA general, exento), definido una vez y aplicado automático — se diseña junto con el módulo de facturación DIAN.

**Continuidad y resiliencia**
- Backups automáticos programados (USB, otra máquina de la red local, o nube cifrada opcional de pago) con restauración de un clic.
- Escrituras transaccionales seguras ante cortes de luz (WAL/journaling); recomendar UPS para la máquina servidor.
- Impresión térmica basada en el estándar ESC/POS (cubre la mayoría de impresoras del mercado) en vez de drivers por marca.

**Sostenimiento del software**
- Actualizaciones: revisión en segundo plano cuando hay internet, sin bloquear la operación si no la hay; instalador manual como respaldo para negocios sin internet.
- Soporte remoto: reporte de diagnóstico exportable para enviar por WhatsApp, dado el canal de soporte más realista para el público objetivo.
- Importación de menú existente desde Excel/CSV (nombre, categoría, precio) para reducir la fricción de onboarding de cada cliente nuevo.

## 9. Fuera de alcance para la v1
- Multi-sucursal / cadenas grandes con sincronización entre locales.
- Integraciones directas con cada plataforma de delivery (se usa agregador).
- Desarrollo propio de la conexión a DIAN (se usa proveedor tecnológico).

## 10. Backlog futuro (no exigido por este documento)
Items vistos en el prototipo POS (`stitch/.../code.html`) sin respaldo en los requisitos; no bloquean el MVP:
- Pago con QR como método de cobro (el POS v1 solo exige efectivo/tarjeta como registro, §3).
- Lector de códigos de barras / modo barcode.
- Reimpresión del último recibo bajo demanda.
- Apertura manual de cajón (botón F12).
- Pago mixto exacto por montos parciales (el §3 exige pago dividido/mixto; el MVP cubre cuenta completa + división simple, el mixto exacto queda para Fase 1.1).
- Fotos de platos desde URLs externas (el §3 exige foto, pero el MVP usa imagen local/offline).
- Impresión de pre-cuenta desde el detalle de mesa (requiere infra de impresión ESC/POS, §8).
- Envío de comanda a caja desde mesas (requiere módulo de caja/arqueo, §8).
- Cambio / unión de mesas (traslado y fusión de cuentas entre mesas).

## 11. Mejoras no previstas en el documento inicial (aportes durante el desarrollo)
- Editor de salón en Mesas: añadir, renombrar, eliminar y mover mesas entre salones sin tocar código.
- Filtro por salón y conteos por estado calculados desde las mesas reales (antes estáticos).
- Vínculo mesa → POS (`?mesa=`): abrir mesa lleva a cobrar con la mesa asignada y guardada en la venta.
- Tarjeta como registro con modal propio (monto exacto, sin vuelto ni cajón, nota de datáfono).
- Impuesto configurable en POS (INC 8% / IVA 19% / Exento) en vez de tasa fija.

## 12. Fase 4 (futuro): app de meseros
- Carcasa híbrida delgada (.NET MAUI con WebView o Capacitor) sobre la misma base web (`mesas.html`/`pos.html`); nativa pura descartada por costo.
- 100% local: la app habla solo con el PC-servidor por el WiFi del restaurante (`192.168.1.100`); sin nube y sin internet para operar.
- Distribución sin Play Store: APK descargable del propio servidor (`http://192.168.1.100/app.apk`), instalación por "orígenes desconocidos".
- Actualizaciones: el contenido vive en el servidor y se actualiza solo; el APK solo cambia si se toca la carcasa.
