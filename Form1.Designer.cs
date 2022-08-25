
namespace QRcode0._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gen = new System.Windows.Forms.Panel();
            this.scan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.gen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gen
            // 
            this.gen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gen.Controls.Add(this.scan);
            this.gen.Controls.Add(this.pictureBox1);
            this.gen.Controls.Add(this.button1);
            this.gen.Dock = System.Windows.Forms.DockStyle.Left;
            this.gen.Location = new System.Drawing.Point(0, 32);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(234, 418);
            this.gen.TabIndex = 0;
            // 
            // scan
            // 
            this.scan.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.scan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.scan.FlatAppearance.BorderSize = 0;
            this.scan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scan.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scan.Image = global::QRcode0._2.Properties.Resources.qr_code_scan;
            this.scan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scan.Location = new System.Drawing.Point(32, 194);
            this.scan.Name = "scan";
            this.scan.Size = new System.Drawing.Size(133, 34);
            this.scan.TabIndex = 3;
            this.scan.Text = "Scan";
            this.scan.UseVisualStyleBackColor = false;
            this.scan.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QRcode0._2.Properties.Resources._1519911806715;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(54, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 112);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = global::QRcode0._2.Properties.Resources.qr__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(32, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.AccessibleName = "bar";
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.exit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 32);
            this.panel2.TabIndex = 1;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.Location = new System.Drawing.Point(768, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(29, 32);
            this.exit.TabIndex = 4;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(234, 32);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(566, 418);
            this.mainpanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.gen);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button scan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel mainpanel;
    }
}

