using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestauranteGestor.Theme;

namespace RestoOSTests
{
    [TestClass]
    public sealed class ThemeTests
    {
        [TestMethod]
        public void AppColors_NoSonTransparentes()
        {
            Assert.AreNotEqual(Color.Empty, AppColors.Surface);
            Assert.AreNotEqual(Color.Transparent, AppColors.Primary);
            Assert.AreNotEqual(Color.Transparent, AppColors.Secondary);
        }

        [TestMethod]
        public void AppColors_TerciaryEsVerdeEsmeralda()
        {
            // #4edea3
            Assert.AreEqual(0x4e, AppColors.Tertiary.R);
            Assert.AreEqual(0xde, AppColors.Tertiary.G);
            Assert.AreEqual(0xa3, AppColors.Tertiary.B);
        }

        [TestMethod]
        public void AppColors_SurfaceEsOscuro()
        {
            // Luminancia baja para modo dark
            var c = AppColors.Surface;
            double lum = 0.2126 * c.R + 0.7152 * c.G + 0.0722 * c.B;
            Assert.IsTrue(lum < 40, $"Surface debe ser oscuro, luminancia {lum}");
        }
    }
}
