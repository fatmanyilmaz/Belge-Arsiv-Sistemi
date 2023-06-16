namespace BelgeArşivYönetimSistemi_2._1_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BaslikLbl = new Label();
            pictureBox1 = new PictureBox();
            KullaniciAdiLbl = new Label();
            SifreLbl = new Label();
            YetkiLbl = new Label();
            SifreTxtbx = new TextBox();
            KullaniciAdiTxtbx = new TextBox();
            YoneticiRdioBttn = new RadioButton();
            KullaniciRadioBttn = new RadioButton();
            CikisBttn = new Button();
            GirisBttn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BaslikLbl
            // 
            BaslikLbl.AutoSize = true;
            BaslikLbl.Font = new Font("Constantia", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            BaslikLbl.Location = new Point(227, 77);
            BaslikLbl.Name = "BaslikLbl";
            BaslikLbl.Size = new Size(256, 33);
            BaslikLbl.TabIndex = 0;
            BaslikLbl.Text = "Belge Arşiv Sistemi";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // KullaniciAdiLbl
            // 
            KullaniciAdiLbl.AutoSize = true;
            KullaniciAdiLbl.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            KullaniciAdiLbl.Location = new Point(144, 184);
            KullaniciAdiLbl.Name = "KullaniciAdiLbl";
            KullaniciAdiLbl.Size = new Size(114, 19);
            KullaniciAdiLbl.TabIndex = 2;
            KullaniciAdiLbl.Text = "Kullanıcı Adı : ";
            // 
            // SifreLbl
            // 
            SifreLbl.AutoSize = true;
            SifreLbl.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SifreLbl.Location = new Point(218, 238);
            SifreLbl.Name = "SifreLbl";
            SifreLbl.Size = new Size(53, 19);
            SifreLbl.TabIndex = 2;
            SifreLbl.Text = "Şifre : ";
            // 
            // YetkiLbl
            // 
            YetkiLbl.AutoSize = true;
            YetkiLbl.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            YetkiLbl.Location = new Point(214, 288);
            YetkiLbl.Name = "YetkiLbl";
            YetkiLbl.Size = new Size(58, 19);
            YetkiLbl.TabIndex = 2;
            YetkiLbl.Text = "Yetki : ";
            // 
            // SifreTxtbx
            // 
            SifreTxtbx.BackColor = SystemColors.ActiveBorder;
            SifreTxtbx.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SifreTxtbx.Location = new Point(289, 230);
            SifreTxtbx.Name = "SifreTxtbx";
            SifreTxtbx.Size = new Size(212, 27);
            SifreTxtbx.TabIndex = 3;
            // 
            // KullaniciAdiTxtbx
            // 
            KullaniciAdiTxtbx.BackColor = SystemColors.ActiveBorder;
            KullaniciAdiTxtbx.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            KullaniciAdiTxtbx.Location = new Point(289, 176);
            KullaniciAdiTxtbx.Name = "KullaniciAdiTxtbx";
            KullaniciAdiTxtbx.Size = new Size(212, 27);
            KullaniciAdiTxtbx.TabIndex = 3;
            // 
            // YoneticiRdioBttn
            // 
            YoneticiRdioBttn.AutoSize = true;
            YoneticiRdioBttn.BackColor = Color.Transparent;
            YoneticiRdioBttn.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            YoneticiRdioBttn.Location = new Point(302, 288);
            YoneticiRdioBttn.Name = "YoneticiRdioBttn";
            YoneticiRdioBttn.Size = new Size(75, 21);
            YoneticiRdioBttn.TabIndex = 4;
            YoneticiRdioBttn.TabStop = true;
            YoneticiRdioBttn.Text = "Yönetici";
            YoneticiRdioBttn.UseVisualStyleBackColor = false;
            // 
            // KullaniciRadioBttn
            // 
            KullaniciRadioBttn.AutoSize = true;
            KullaniciRadioBttn.BackColor = Color.Transparent;
            KullaniciRadioBttn.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            KullaniciRadioBttn.Location = new Point(403, 288);
            KullaniciRadioBttn.Name = "KullaniciRadioBttn";
            KullaniciRadioBttn.Size = new Size(80, 21);
            KullaniciRadioBttn.TabIndex = 4;
            KullaniciRadioBttn.TabStop = true;
            KullaniciRadioBttn.Text = "Kullanıcı";
            KullaniciRadioBttn.UseVisualStyleBackColor = false;
            // 
            // CikisBttn
            // 
            CikisBttn.BackColor = SystemColors.ActiveBorder;
            CikisBttn.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            CikisBttn.Location = new Point(398, 346);
            CikisBttn.Name = "CikisBttn";
            CikisBttn.Size = new Size(103, 47);
            CikisBttn.TabIndex = 5;
            CikisBttn.Text = "Çıkış Yap";
            CikisBttn.UseVisualStyleBackColor = false;
            // 
            // GirisBttn
            // 
            GirisBttn.BackColor = SystemColors.ActiveBorder;
            GirisBttn.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            GirisBttn.Location = new Point(247, 346);
            GirisBttn.Name = "GirisBttn";
            GirisBttn.Size = new Size(103, 47);
            GirisBttn.TabIndex = 5;
            GirisBttn.Text = "Giriş Yap";
            GirisBttn.UseVisualStyleBackColor = false;
            GirisBttn.Click += GirisBttn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(553, 428);
            Controls.Add(GirisBttn);
            Controls.Add(CikisBttn);
            Controls.Add(KullaniciRadioBttn);
            Controls.Add(YoneticiRdioBttn);
            Controls.Add(KullaniciAdiTxtbx);
            Controls.Add(SifreTxtbx);
            Controls.Add(YetkiLbl);
            Controls.Add(SifreLbl);
            Controls.Add(KullaniciAdiLbl);
            Controls.Add(pictureBox1);
            Controls.Add(BaslikLbl);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BaslikLbl;
        private PictureBox pictureBox1;
        private Label KullaniciAdiLbl;
        private Label SifreLbl;
        private Label YetkiLbl;
        private TextBox SifreTxtbx;
        private TextBox KullaniciAdiTxtbx;
        private RadioButton YoneticiRdioBttn;
        private RadioButton KullaniciRadioBttn;
        private Button CikisBttn;
        private Button GirisBttn;
    }
}