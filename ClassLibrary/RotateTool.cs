using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ClassLibrary
{
    public class RotateTool : ITools
    {
        public string Title { get; set; } = "Rotate";
        public string Description { get; set; } = "Taking an image and rotating it 90 degrees";

        //BITMAPIMAGE IS NOT DISPOSED******************
        public Bitmap PerfomToolAction(Bitmap bit)
        {
            return null;
        }

        public void Dispose()
        {
            this.Dispose();
        }

    }
}
