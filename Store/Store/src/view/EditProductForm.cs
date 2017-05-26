using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TouchlessLib;
using ZXing;
using ZXing.Client;

namespace Store
{
    public partial class EditProductForm : Form
    {

        private TouchlessMgr _touch;
        private const int _previewWidth = 640;
        private const int _previewHeight = 480;

        public EditProductForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void productPriceText_TextChanged(object sender, EventArgs e)
        {

        }

        private void InfoLabel_Click(object sender, EventArgs e)
        {

        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {
            _touch = new TouchlessMgr();
        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            if (webCamBox.Image == null)
            {
                MessageBox.Show("Пожалуйста, сделайте снимок!");
                return;
            }

            ReadBarcode((Bitmap)webCamBox.Image);
        }

        private void StartCamera()
        {
            if (_touch.Cameras.Count == 0)
            {
                MessageBox.Show("Камера не подключена");
                webcamButton.Text = "Начать сканирование";
                return;
            }

            _touch.CurrentCamera = _touch.Cameras[0];
            _touch.CurrentCamera.CaptureWidth = _previewWidth; // Set width
            _touch.CurrentCamera.CaptureWidth = _previewHeight; // Set height
            _touch.CurrentCamera.OnImageCaptured += new EventHandler<CameraEventArgs>(OnImageCaptured); // Set preview callback function
        }

        private void StopCamera()
        {
            webcamButton.Text = "Начать сканирование";
            if (_touch.CurrentCamera != null)
            {
                _touch.CurrentCamera.OnImageCaptured -= new EventHandler<CameraEventArgs>(OnImageCaptured);
            }
        }

        private void OnImageCaptured(object sender, CameraEventArgs args)
        {
            Bitmap bitmap = args.Image;
            this.Invoke((MethodInvoker)delegate
            {
                webCamBox.Image = bitmap;
                ReadBarcode(bitmap);
            });
        }

        private void ReadBarcode(Bitmap bitmap)
        {
            IBarcodeReader reader = new ZXing.BarcodeReader();
            var barcodeBitmap = bitmap;
            var result = reader.Decode(barcodeBitmap);
            if (result != null)
            {
                productIdText.Text = result.Text;
            }
        }

        private void webcamButton_Click(object sender, EventArgs e)
        {
            string buttonText = webcamButton.Text;
            if (buttonText.Equals("Начать сканирование"))
            {
                webcamButton.Text = "Закончить сканирование";
                StartCamera();
            }
            else
            {
                webcamButton.Text = "Начать сканирование";
                StopCamera();
            }
        }
    }
}
