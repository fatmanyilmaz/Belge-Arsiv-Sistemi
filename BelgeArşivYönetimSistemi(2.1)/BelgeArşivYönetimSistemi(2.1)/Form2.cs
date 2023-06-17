using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BelgeArşivYönetimSistemi_2._1_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void GirisBttn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = true;
            panel2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem != null && comboBox4.SelectedItem.ToString() == "MUHASEBE")
            {
                comboBox5.Items.Clear();

                comboBox5.Items.Add("Öğrenci Aidatları ve Ödemeleri");
                comboBox5.Items.Add("Personel Bordroları");
                comboBox5.Items.Add("Satın Alım Evrakları");
                comboBox5.Items.Add("Vergi Beyannameleri ve Raporlar");
                comboBox5.Items.Add("Bütçe Planlaması ve Raporları");
                comboBox5.Items.Add("Gelir - Gider Tabloları");
                comboBox5.Items.Add("Fatura ve Fatura İrsaliyeleri");
            }

            if (comboBox4.SelectedItem != null && comboBox4.SelectedItem.ToString() == "ÖĞRENCİ İŞLERİ")
            {
                comboBox5.Items.Clear();

                comboBox5.Items.Add("Öğrenci Disiplin Kayıtları");
                comboBox5.Items.Add("Öğrenci İzin ve Rapor Talepleri");
                comboBox5.Items.Add("Diplomalar ve Mezuniyet Bekgeleri");
                comboBox5.Items.Add("Öğrenci Etkinlikleri ve Kulüpler");
                comboBox5.Items.Add("Staj ve İşyeri İlişkileri");
                comboBox5.Items.Add("Öğrenci Sağlık ve Sigorta Belgeleri");
                comboBox5.Items.Add("Akademik Programlar");
                comboBox5.Items.Add("Öğrenci Başvuruları ve Belgeler");
            }

            if (comboBox4.SelectedItem != null && comboBox4.SelectedItem.ToString() == "BÖLÜM SEKRETERLİĞİ")
            {
                comboBox5.Items.Clear();

                comboBox5.Items.Add("Öğretim Üyeleri ile İlgili Kayıtlar");
                comboBox5.Items.Add("Ders Programları");
                comboBox5.Items.Add("Bölüm Toplantıları");
                comboBox5.Items.Add("Bölüm Bütçesi ve Harcamalar");
                comboBox5.Items.Add("Öğrenci Danışmanlığı");
                comboBox5.Items.Add("Bölüm Etkinlikleri");
            }

            if (comboBox4.SelectedItem != null && comboBox4.SelectedItem.ToString() == "FAKÜLTE SEKRETERLİĞİ")
            {
                comboBox5.Items.Clear();

                comboBox5.Items.Add("Fakülte Programları ve Müfredatlar");
                comboBox5.Items.Add("Burs ve Finansal Yardımlar");
                comboBox5.Items.Add("Fakülte Toplantıları");
                comboBox5.Items.Add("Fakülte Bütçesi ve Harcamalar");
                comboBox5.Items.Add("Akreditasyon ve Kalite Güvencesi");
                comboBox5.Items.Add("Fakülte Etkinlikleri");
            }

            if (comboBox4.SelectedItem != null && comboBox4.SelectedItem.ToString() == "AKADEMİK PERSONEL")
            {
                comboBox5.Items.Clear();

                comboBox5.Items.Add("Öğrenci Kayıtları");
                comboBox5.Items.Add("Ders Materyalleri");
                comboBox5.Items.Add("Akademik Programlar");
                comboBox5.Items.Add("Araştırma Verileri ve Kaynaklar");
                comboBox5.Items.Add("Akademik İşler ve Yönetim Belgeleri");
                comboBox5.Items.Add("Proje ve Araştırma Başvuruları");
                comboBox5.Items.Add("Yayınlar ve Makaleler");
                comboBox5.Items.Add("Danışmanlık Belgeleri");
                comboBox5.Items.Add("Konferans ve Seminer Belgeleri");
                comboBox5.Items.Add("Akademik Değerlendirme Belgeleri");
            }
        }
    }
}
