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
            GirisBttn = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // GirisBttn
            // 
            GirisBttn.BackColor = SystemColors.ActiveBorder;
            GirisBttn.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            GirisBttn.Location = new Point(36, 46);
            GirisBttn.Name = "GirisBttn";
            GirisBttn.Size = new Size(156, 128);
            GirisBttn.TabIndex = 6;
            GirisBttn.Text = "EVRAK KAYIT EKRANI";
            GirisBttn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(240, 46);
            button1.Name = "button1";
            button1.Size = new Size(156, 128);
            button1.TabIndex = 7;
            button1.Text = "EVRAK ARŞİVİ EKRANI";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(240, 221);
            button2.Name = "button2";
            button2.Size = new Size(156, 128);
            button2.TabIndex = 8;
            button2.Text = "ÇIKIŞ YAP";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(36, 221);
            button3.Name = "button3";
            button3.Size = new Size(156, 128);
            button3.TabIndex = 9;
            button3.Text = "EMANET EKRANI";
            button3.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 407);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(GirisBttn);
            Name = "Form3";
            Text = "Kullanıcı Ekranı";
            ResumeLayout(false);
        }

        #endregion

        private Button GirisBttn;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}