using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Reflection;

namespace FillTest
{
    public static class Image
    {
        public static void SaveImage(string name, int[] array, int width, int height)
        {
            using (Bitmap b = new Bitmap(width, height))
            {
                using (Graphics g = Graphics.FromImage(b))
                {
                    g.Clear(Color.Beige);
                }
                for (int i = 0; i < array.Length; i++)
                {
                    var cy = array[i] / height;
                    var cx = array[i] - cy * height;
                    b.SetPixel(cx, cy, Color.Cyan);
                }
                string myExeDir = new FileInfo(Assembly.GetEntryAssembly().Location).Directory.ToString();
                var path = Path.Combine(myExeDir, name + ".png");
                b.Save(path, ImageFormat.Png);
            }
        }
    }
}
