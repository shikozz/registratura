using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Registy
{
    public class ImageConverter : IValueConverter
    {
        private ImageConverter() { }

        /// <summary>
        /// Convert from Base64 string to BitmapImage
        /// </summary>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return null;
            string base64 = value as string;

            byte[] data = System.Convert.FromBase64String(base64);

            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.StreamSource = new MemoryStream(data);
            bi.EndInit();

            return bi;
        }

        /// <summary>
        /// Convert from BitmapImage to Base64 string
        /// </summary>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return null;
            string path = value as string;

            if (!File.Exists(path)) return null;
            byte[] imageArray = File.ReadAllBytes(path);
            string base64 = System.Convert.ToBase64String(imageArray);

            return base64;
        }

        public BitmapImage ConvertToImage(string base64) => Instance.Convert(base64, null, null, null) as BitmapImage;

        public string ConvertToBase64(string path) => Instance.ConvertBack(path, null, null, null) as string;

        public static ImageConverter Instance
        {
            get { return _instance; }
        }

        private static ImageConverter _instance = new ImageConverter();
    }
}