using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QRcode0._2
{
    public partial class generate : Form
    {
        public generate()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var MyData = QG.CreateQrCode(textBox1.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            pictureBox1.Image = code.GetGraphic(50);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var MyData = QG.CreateQrCode(textBox1.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            pictureBox1.Image = code.GetGraphic(50);
        }
    }
}
