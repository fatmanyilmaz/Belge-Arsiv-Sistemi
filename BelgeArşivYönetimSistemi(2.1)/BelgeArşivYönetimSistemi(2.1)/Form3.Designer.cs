namespace BelgeArşivYönetimSistemi_2._1_
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            GirisBttn = new Button();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            listBox1 = new ListBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // GirisBttn
            // 
            GirisBttn.BackColor = SystemColors.ActiveBorder;
            GirisBttn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            GirisBttn.Location = new Point(413, 12);
            GirisBttn.Name = "GirisBttn";
            GirisBttn.Size = new Size(156, 45);
            GirisBttn.TabIndex = 6;
            GirisBttn.Text = "EVRAK KAYIT EKRANI";
            GirisBttn.UseVisualStyleBackColor = false;
            GirisBttn.Click += GirisBttn_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(237, 12);
            button1.Name = "button1";
            button1.Size = new Size(156, 45);
            button1.TabIndex = 7;
            button1.Text = "EVRAK ARŞİVİ EKRANI";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(50, 409);
            button2.Name = "button2";
            button2.Size = new Size(75, 35);
            button2.TabIndex = 8;
            button2.Text = "ÇIKIŞ YAP";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(listBox1);
            panel1.Location = new Point(210, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 391);
            panel1.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "MUHASEBE", "ÖĞRENCİ İŞLERİ", "BÖLÜM SEKRETERLİĞİ", "FAKÜLTE SEKRETERLİĞİ", "AKADEMİK PERSONEL" });
            comboBox1.Location = new Point(70, 127);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(248, 25);
            comboBox1.TabIndex = 7;
            comboBox1.Text = "LÜTFEN DEPARTMAN SEÇİNİZ";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(118, 66);
            label2.Name = "label2";
            label2.Size = new Size(161, 30);
            label2.TabIndex = 6;
            label2.Text = "EVRAK ARŞİVİ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 22);
            label1.Name = "label1";
            label1.Size = new Size(332, 30);
            label1.TabIndex = 5;
            label1.Text = "BURSA ULUDAĞ ÜNİVERSİTESİ";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(70, 170);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(248, 204);
            listBox1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Location = new Point(210, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(389, 391);
            panel2.TabIndex = 8;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 458);
            Controls.Add(panel2);
            Controls.Add(GirisBttn);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form3";
            Text = "Kullanıcı Ekranı";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button GirisBttn;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private ListBox listBox1;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Panel panel2;
    }
}