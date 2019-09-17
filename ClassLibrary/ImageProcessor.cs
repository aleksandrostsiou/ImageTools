using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Collections;

namespace ClassLibrary
{
    public class ImageProcessor
    {
        public ImageProcessor()
        {
        }
        public ImageProcessor(string imagePath)
        {
            this.ImagePath = imagePath;
        }
        //List of tools 
        //**Add Tools HERE**
        public List<ITools> ToolsList = new List<ITools>() { new GrayscaleTool(), new RotateTool() };
        public string ImagePath { get; set; }
        public void GetImagePath()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = "C:\\";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ImagePath = openFileDialog.FileName;
                }
            }
            catch (DirectoryNotFoundException dirE)
            {
                MessageBox.Show("A directory error has occurred"+ dirE.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show("Uknown error has occurred" + e.Message);
            }
        }

    }
}
