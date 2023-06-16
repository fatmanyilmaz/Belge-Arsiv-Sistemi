namespace BelgeArşivYönetimSistemi_2._1_
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            GirisBttn = new Button();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // GirisBttn
            // 
            GirisBttn.BackColor = SystemColors.ActiveBorder;
            GirisBttn.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            GirisBttn.Location = new Point(32, 21);
            GirisBttn.Name = "GirisBttn";
            GirisBttn.Size = new Size(156, 128);
            GirisBttn.TabIndex = 7;
            GirisBttn.Text = "EVRAK KAYIT EKRANI";
            GirisBttn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(308, 22);
            button1.Name = "button1";
            button1.Size = new Size(156, 128);
            button1.TabIndex = 8;
            button1.Text = "KULLANICI KAYIT";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(32, 263);
            button3.Name = "button3";
            button3.Size = new Size(156, 128);
            button3.TabIndex = 10;
            button3.Text = "EMANET EKRANI";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(308, 263);
            button2.Name = "button2";
            button2.Size = new Size(156, 128);
            button2.TabIndex = 11;
            button2.Text = "ÇIKIŞ YAP";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(188, 156);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 428);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(GirisBttn);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            Text = "Yönetici Sayfası";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button GirisBttn;
        private Button button1;
        private Button button3;
        private Button button2;
        private PictureBox pictureBox1;
    }
}