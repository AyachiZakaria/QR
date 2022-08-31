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


        private void button1_Click(object sender, EventArgs e)
        {
            var qrText = comboBox1.SelectedItem+ "\n" + "ID: " +textBox1.Text + "\n" + "Acheté le: " + dateTimePicker1.Value + "\n" + "donné à: " + textBox2.Text + "\n" + "le: " + dateTimePicker2.Value + "\n" + "par: " + textBox3.Text + "\n";
            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var MyData = QG.CreateQrCode(qrText, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            pictureBox1.Image = code.GetGraphic(50);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string initialDIR = @"C:\Users\Name\Documents\QR_codes_file";
            var dialog = new SaveFileDialog();
            dialog.InitialDirectory = initialDIR;
            dialog.FileName = textBox1.Text;
            dialog.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif";
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image.Save(dialog.FileName);
            }
        }

        private void generate_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Casque");
            comboBox1.Items.Add("Clavier");
            comboBox1.Items.Add("Souris");
            comboBox1.Items.Add("Cable");
        }
    }
}
