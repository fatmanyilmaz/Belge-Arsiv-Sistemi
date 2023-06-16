namespace BelgeArşivYönetimSistemi_2._1_
{
    partial class EvrakArsivi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvrakArsivi));
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "MUHASEBE", "ÖĞRENCİ İŞLERİ", "BÖLÜM SEKRETERLİĞİ", "FAKÜLTE SEKRETERLİĞİ", "AKADEMİK PERSONEL" });
            comboBox1.Location = new Point(12, 212);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(248, 25);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "LÜTFEN DEPARTMAN SEÇİNİZ";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(202, 41);
            label1.Name = "label1";
            label1.Size = new Size(332, 30);
            label1.TabIndex = 1;
            label1.Text = "BURSA ULUDAĞ ÜNİVERSİTESİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(293, 85);
            label2.Name = "label2";
            label2.Size = new Size(161, 30);
            label2.TabIndex = 2;
            label2.Text = "EVRAK ARŞİVİ";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(277, 155);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(257, 204);
            listBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // EvrakArsivi
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 390);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "EvrakArsivi";
            Text = "EvrakArsivi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private PictureBox pictureBox1;
    }
}