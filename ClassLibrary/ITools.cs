using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Media.Imaging;

namespace ClassLibrary
{
    public interface ITools : IDisposable
    {
        string Title { get; set; }
        string Description { get; set; }

        Bitmap PerfomToolAction(Bitmap bit);
    }
}
