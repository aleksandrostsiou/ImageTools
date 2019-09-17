using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClassLibrary;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Creating ComboBoxItems 
            CreateComboBoxItems();
        }
        //Instantiating the image processor
        ImageProcessor processor = new ImageProcessor();
        public void CreateComboBoxItems()
        {
            //for each tool in ToolsList Create an item on comboBox Control with its Title for name
            foreach (var tool in processor.ToolsList)
            {
                comboBox.Items.Add(tool.Title);
            }
        }
        private void BtnUpload_Click(object sender, RoutedEventArgs e)
        {
            UploadFile(processor.ImagePath);
        }
        private void UploadFile(string path)
        {
            processor.GetImagePath();
            image1.Source = new BitmapImage(new Uri(processor.ImagePath));
        }

        private void ToolsBtn_Click(object sender, RoutedEventArgs e)
        {
            InitTool();
        }
        //Converting Windows.Control.Image to System.Drawing.Bitmap(Image)
        public Bitmap CovertBitmapImageToBitmap()
        {
            Bitmap outBit;
            using (MemoryStream ms = new MemoryStream())
            {
                PngBitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create((BitmapSource)image1.Source));
                encoder.Save(ms);
                using (Bitmap bit = new Bitmap(ms))
                {
                    using (outBit = new Bitmap(bit))
                    {
                        MessageBox.Show(outBit.ToString());
                        return outBit;
                    }
                }
            }
            
        }
        //Initiating the tool
        public void InitTool()
        {
            var selectedTool = comboBox.SelectedItem;
            foreach (var tool in processor.ToolsList)
            {
                //if the selected tool match the tool in the list 
                if (selectedTool.ToString() == tool.Title)
                {
                    MessageBox.Show("tet");
                    //perfom tool action having converted the 
                    var convertedBitmap = CovertBitmapImageToBitmap();
                     var test = tool.PerfomToolAction(convertedBitmap);
                    MessageBox.Show(test.ToString());
                    //image1.Source(BitmapImage())
                }
            }
        }
    }
}
