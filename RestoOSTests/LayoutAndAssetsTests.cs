using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RestoOSTests
{
    [TestClass]
    public sealed class LayoutAndAssetsTests
    {
        private string WebPath => Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Assets", "web", "index.html");

        private string FindWebPath()
        {
            var candidates = new[]
            {
                Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Assets", "web", "index.html"),
                Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Assets", "web", "index.html"),
                @"C:\Users\SENA\source\repos\RestauranteGestor\RestauranteGestor\Assets\web\index.html"
            };
            return candidates.FirstOrDefault(File.Exists) ?? candidates[0];
        }

        [TestMethod]
        public void Assets_Existen()
        {
            var p = FindWebPath();
            Assert.IsTrue(File.Exists(p), $"index.html no existe en {p}");
            var tailwind = Path.Combine(Path.GetDirectoryName(p), "tailwind.js");
            Assert.IsTrue(File.Exists(tailwind), "tailwind.js no existe - offline bundle roto");
            Assert.IsTrue(new FileInfo(tailwind).Length > 100000, "tailwind.js truncado");
        }

        [TestMethod]
        public void Html_NoTieneDobleSidebar_Padding()
        {
            var p = FindWebPath();
            var html = File.ReadAllText(p);
            // Fallo original: pl-72 + left-72 causaba doble gutter (WebView + WinForms sidebar)
            Assert.IsFalse(html.Contains("pl-72"), "HTML aún contiene pl-72 -> doble sidebar, botones desfasados");
            // Permite left-0 pero no left-72
            Assert.IsFalse(html.Contains("left-72"), "HTML aún contiene left-72 -> header desfasado");
            Assert.IsTrue(html.Contains("./tailwind.js"), "Debe referenciar tailwind.js local, no CDN");
            Assert.IsFalse(html.Contains("https://cdn.tailwindcss.com"), "No debe quedar CDN tailwind en producción offline");
        }

        [TestMethod]
        public void Html_TienePersistenciaRestoOS()
        {
            var p = FindWebPath();
            var html = File.ReadAllText(p);
            Assert.IsTrue(html.Contains("window.RestoOS"), "Falta bridge RestoOS");
            Assert.IsTrue(html.Contains("saveToStorage"), "Falta saveToStorage");
            Assert.IsTrue(html.Contains("persist()") || html.Contains("function persist"), "Falta persist hook");
            Assert.IsTrue(html.Contains("localStorage"), "Debe usar localStorage para persistencia offline");
        }

        [TestMethod]
        public void Html_Desactivado_TieneAnimacionVisible()
        {
            var p = FindWebPath();
            var html = File.ReadAllText(p);
            Assert.IsTrue(html.Contains("restoos-deactivating"), "Falta clase restoos-deactivating para animar desactivado");
            Assert.IsTrue(html.Contains("restoos-toast"), "Falta toast para feedback desactivado");
            Assert.IsTrue(html.Contains("showToast"), "Falta showToast para confirmar activado/desactivado");
            Assert.IsTrue(html.Contains("Desactivado"), "Debe mostrar texto 'Desactivado' al desactivar");
            Assert.IsTrue(html.Contains("opacity-60") && html.Contains("grayscale"), "Estado desactivado debe usar opacity-60+grayscale bien visible");
            Assert.IsTrue(html.Contains("restoos-toggle-off") && html.Contains("restoos-toggle-on"), "Faltan keyframes toggle on/off");
            Assert.IsFalse(html.Contains("__restoos_persist"), "No debe quedar codigo duplicado __restoos_persist");
        }

        [TestMethod]
        public void Html_WebViewBridgeInvocado()
        {
            var p = FindWebPath();
            var html = File.ReadAllText(p);
            Assert.IsTrue(html.Contains("chrome.webview.hostObjects.bridge.SaveState"), "Falta llamada a hostObjects.bridge.SaveState");
        }

        [TestMethod]
        public void Sidebar_NavButtons_Configuracion()
        {
            // Validar que Form1.Designer haya sido corregido: debe usar navHost Dock.Fill no botones absolutos
            var designer = File.ReadAllText(@"C:\Users\SENA\source\repos\RestauranteGestor\RestauranteGestor\Form1.Designer.cs");
            Assert.IsTrue(designer.Contains("navHost"), "Form1.Designer debe contener navHost - fix de botones superpuestos");
            Assert.IsTrue(designer.Contains("Dock = System.Windows.Forms.DockStyle.Top") && designer.Contains("DockStyle.Fill"), "Debe usar Dock para evitar overlapping");
            Assert.IsFalse(designer.Contains("BringToFront(); badgePanel.BringToFront()"), "No debe quedar BringToFront bug que invertia orden de Dock.Top");
            // botones deben usar Dock.Top no Top = y + i*42 (old bug)
            // Busca el old pattern absoluto
            Assert.IsFalse(designer.Contains("btn.Top = y + i*42"), "Botones sidebar no deben usar posicion absoluta - causa falla click fuera de area");
        }

        [TestMethod]
        public void Form1_Botones_TodosConHandlerRecursivo()
        {
            var cs = File.ReadAllText(@"C:\Users\SENA\source\repos\RestauranteGestor\RestauranteGestor\Form1.cs");
            Assert.IsTrue(cs.Contains("AttachSidebarHandlers"), "Form1 debe usar AttachSidebarHandlers recursivo - fix para botones dentro de navHost");
            Assert.IsTrue(cs.Contains("ClearSidebarSelection"), "Debe limpiar seleccion recursivo");
            Assert.IsFalse(cs.Contains("foreach (Control c in sidebarPanel.Controls)\n                if (c is Button b) b.Click"), "Old flat loop no detecta botones anidados");
        }

        [TestMethod]
        public void Theme_ColoresExisten()
        {
            var theme = File.ReadAllText(@"C:\Users\SENA\source\repos\RestauranteGestor\RestauranteGestor\Theme\AppColors.cs");
            Assert.IsTrue(theme.Contains("#111415"), "Falta Surface #111415");
            Assert.IsTrue(theme.Contains("#ffb59d"), "Falta Primary");
            Assert.IsTrue(theme.Contains("#4edea3"), "Falta Tertiary");
        }

        [TestMethod]
        public void Configuracion_RuedaExisteYAbreModulos()
        {
            var designer = File.ReadAllText(@"C:\Users\SENA\source\repos\RestauranteGestor\RestauranteGestor\Form1.Designer.cs");
            var cs = File.ReadAllText(@"C:\Users\SENA\source\repos\RestauranteGestor\RestauranteGestor\Form1.cs");
            // rueda en sidebar y topbar
            Assert.IsTrue(designer.Contains("btnConfig") && designer.Contains("config-modulos"), "Debe existir btnConfig con Tag config-modulos en sidebar");
            Assert.IsTrue(designer.Contains("btnConfigTop"), "Debe existir rueda en TopBar (btnConfigTop)");
            Assert.IsTrue(designer.Contains("Configuración") && designer.Contains("Módulos"), "Texto debe indicar que abre apartado de módulos");
            Assert.IsTrue(cs.Contains("NavigateToModulos"), "Form1 debe tener metodo NavigateToModulos");
            Assert.IsTrue(cs.Contains("config-modulos"), "Handler debe manejar tag config-modulos");
            // handler recursivo para topbar
            Assert.IsTrue(cs.Contains("AttachSidebarHandlers(panelTop)"), "Debe enganchar handlers de TopBar");
        }
    }
}
