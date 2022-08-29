using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;

namespace QRcode0._2
{
    public partial class scanner : Form
    {
        public scanner()
        {
            InitializeComponent();
        }
        FilterInfoCollection filter;
        VideoCaptureDevice captureDevice;
        private void scanner_Load(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filter)
                comboBox_camera.Items.Add(filterInfo.Name);
            comboBox_camera.SelectedIndex = 0;
        }

        private void button_scan_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filter[comboBox_camera.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void scanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning==true)
                captureDevice.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox.Image !=null)
            {
                BarcodeReader barcode = new BarcodeReader();
                Result result = barcode.Decode((Bitmap)pictureBox.Image);
                if(result != null)
                {
                    textBox_display.Text = result.ToString();
                    timer1.Stop();
                }
            }
        }
    }
}
