using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net;

namespace app_escritorio.Utils
{
    public static class ImageFetcher
    {
        private static readonly string ImagesFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "images");
        private static readonly int MaxWidth = 600;  // Thumbnail max width
        private static readonly int MaxHeight = 600; // Thumbnail max height

        public static string DownloadImage(string url)
        {
            try
            {
                if (string.IsNullOrEmpty(url)) return null;
                if (!Directory.Exists(ImagesFolder)) Directory.CreateDirectory(ImagesFolder);

                var ext = Path.GetExtension(url);
                if (string.IsNullOrEmpty(ext) || ext.Length > 5) ext = ".jpg";

                var fileName = Guid.NewGuid().ToString() + ext;
                var tempPath = Path.Combine(ImagesFolder, "temp_" + fileName);
                var finalPath = Path.Combine(ImagesFolder, fileName);

                // Descargar imagen
                using (var wc = new WebClient())
                {
                    wc.DownloadFile(new Uri(url), tempPath);
                }

                // Redimensionar y optimizar
                ResizeAndOptimizeImage(tempPath, finalPath);

                // Eliminar temp
                if (File.Exists(tempPath))
                    File.Delete(tempPath);

                return finalPath;
            }
            catch
            {
                return null;
            }
        }

        private static void ResizeAndOptimizeImage(string sourcePath, string destinationPath)
        {
            Image originalImage = null;
            try
            {
                originalImage = Image.FromFile(sourcePath);

                // Calcular nuevas dimensiones manteniendo aspect ratio
                int newWidth = originalImage.Width;
                int newHeight = originalImage.Height;

                if (newWidth > MaxWidth || newHeight > MaxHeight)
                {
                    double ratioX = (double)MaxWidth / newWidth;
                    double ratioY = (double)MaxHeight / newHeight;
                    double ratio = Math.Min(ratioX, ratioY);

                    newWidth = (int)(newWidth * ratio);
                    newHeight = (int)(newHeight * ratio);
                }

                // Crear thumbnail con alta calidad
                using (Bitmap thumbnail = new Bitmap(newWidth, newHeight))
                {
                    using (Graphics g = Graphics.FromImage(thumbnail))
                    {
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        g.SmoothingMode = SmoothingMode.HighQuality;
                        g.CompositingMode = CompositingMode.SourceCopy;
                        g.CompositingQuality = CompositingQuality.HighQuality;

                        g.DrawImage(originalImage, 0, 0, newWidth, newHeight);
                    }

                    // Guardar con compresión
            var jpgEncoder = GetEncoder(System.Drawing.Imaging.ImageFormat.Jpeg);
            if (jpgEncoder != null)
            {
                var encoder = System.Drawing.Imaging.Encoder.Quality;
                var encoderParams = new System.Drawing.Imaging.EncoderParameters(1);
                encoderParams.Param[0] = new System.Drawing.Imaging.EncoderParameter(encoder, 85L);
                thumbnail.Save(destinationPath, jpgEncoder, encoderParams);
            }
                }
            }
            finally
            {
                originalImage?.Dispose();
            }
        }

        private static System.Drawing.Imaging.ImageCodecInfo GetEncoder(System.Drawing.Imaging.ImageFormat format)
        {
            var codecs = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders();
            foreach (var codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                    return codec;
            }
            return null;
        }
    }
}
