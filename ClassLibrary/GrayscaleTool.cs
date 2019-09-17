using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ClassLibrary
{
    public class GrayscaleTool : ITools
    {
        public string Title { get; set; } = "Grayscale";
        public string Description { get; set; } = "Grayscaling image's pixels..";

        public Bitmap PerfomToolAction(Bitmap bit)
        {
            //securing that bit is Bitmap
            System.Windows.Forms.MessageBox.Show(bit.ToString());

            using (bit)
            {
                //Bitmap dimensions
                int width = bit.Width;
                int height = bit.Height;
                //Color of a pixel
                Color color;

                //Performing the grayscale for a matrix
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        color = bit.GetPixel(i, j);
                        Color newColor = Color.FromArgb(color.R / 3, color.G / 3, color.B / 3);
                        bit.SetPixel(i, j, newColor);
                    }
                }
                return bit;
            };
        }
        public void Dispose()
        {
           this.Dispose();
        }

    }
}
