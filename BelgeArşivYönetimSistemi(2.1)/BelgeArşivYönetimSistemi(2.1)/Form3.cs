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
    public partial class Form3 : Form



    {
        public Form3()
        {
            InitializeComponent();

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void GirisBttn_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "MUHASEBE")
            {
                listBox1.Items.Clear();

                listBox1.Items.Add("Öğrenci Aidatları ve Ödemeleri");
                listBox1.Items.Add("Personel Bordroları");
                listBox1.Items.Add("Satın Alım Evrakları");
                listBox1.Items.Add("Vergi Beyannameleri ve Raporlar");
                listBox1.Items.Add("Bütçe Planlaması ve Raporları");
                listBox1.Items.Add("Gelir - Gider Tabloları");
                listBox1.Items.Add("Fatura ve Fatura İrsaliyeleri");
            }

            if (comboBox1.SelectedItem.ToString() == "ÖĞRENCİ İŞLERİ")
            {
                listBox1.Items.Clear();

                listBox1.Items.Add("Öğrenci Disiplin Kayıtları");
                listBox1.Items.Add("Öğrenci İzin ve Rapor Talepleri");
                listBox1.Items.Add("Diplomalar ve Mezuniyet Bekgeleri");
                listBox1.Items.Add("Öğrenci Etkinlikleri ve Kulüpler");
                listBox1.Items.Add("Staj ve İşyeri İlişkileri");
                listBox1.Items.Add("Öğrenci Sağlık ve Sigorta Belgeleri");
                listBox1.Items.Add("Akademik Programlar");
                listBox1.Items.Add("Öğrenci Başvuruları ve Belgeler");
            }

            if (comboBox1.SelectedItem.ToString() == "BÖLÜM SEKRETERLİĞİ")
            {
                listBox1.Items.Clear();

                listBox1.Items.Add("Öğretim Üyeleri ile İlgili Kayıtlar");
                listBox1.Items.Add("Ders Programları");
                listBox1.Items.Add("Bölüm Toplantıları");
                listBox1.Items.Add("Bölüm Bütçesi ve Harcamalar");
                listBox1.Items.Add("Öğrenci Danışmanlığı");
                listBox1.Items.Add("Bölüm Etkinlikleri");
            }

            if (comboBox1.SelectedItem.ToString() == "FAKÜLTE SEKRETERLİĞİ")
            {
                listBox1.Items.Clear();

                listBox1.Items.Add("Fakülte Programları ve Müfredatlar");
                listBox1.Items.Add("Burs ve Finansal Yardımlar");
                listBox1.Items.Add("Fakülte Toplantıları");
                listBox1.Items.Add("Fakülte Bütçesi ve Harcamalar");
                listBox1.Items.Add("Akreditasyon ve Kalite Güvencesi");
                listBox1.Items.Add("Fakülte Etkinlikleri");
            }

            if (comboBox1.SelectedItem.ToString() == "AKADEMİK PERSONEL")
            {
                listBox1.Items.Clear();

                listBox1.Items.Add("Öğrenci Kayıtları");
                listBox1.Items.Add("Ders Materyalleri");
                listBox1.Items.Add("Akademik Programlar");
                listBox1.Items.Add("Araştırma Verileri ve Kaynaklar");
                listBox1.Items.Add("Akademik İşler ve Yönetim Belgeleri");
                listBox1.Items.Add("Proje ve Araştırma Başvuruları");
                listBox1.Items.Add("Yayınlar ve Makaleler");
                listBox1.Items.Add("Danışmanlık Belgeleri");
                listBox1.Items.Add("Konferans ve Seminer Belgeleri");
                listBox1.Items.Add("Akademik Değerlendirme Belgeleri");
            }
        }


        public void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() == "MUHASEBE")
            {
                comboBox3.Items.Clear();

                comboBox3.Items.Add("Öğrenci Aidatları ve Ödemeleri");
                comboBox3.Items.Add("Personel Bordroları");
                comboBox3.Items.Add("Satın Alım Evrakları");
                comboBox3.Items.Add("Vergi Beyannameleri ve Raporlar");
                comboBox3.Items.Add("Bütçe Planlaması ve Raporları");
                comboBox3.Items.Add("Gelir - Gider Tabloları");
                comboBox3.Items.Add("Fatura ve Fatura İrsaliyeleri");

            }

            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() == "ÖĞRENCİ İŞLERİ")
            {
                comboBox3.Items.Clear();

                comboBox3.Items.Add("Öğrenci Disiplin Kayıtları");
                comboBox3.Items.Add("Öğrenci İzin ve Rapor Talepleri");
                comboBox3.Items.Add("Diplomalar ve Mezuniyet Bekgeleri");
                comboBox3.Items.Add("Öğrenci Etkinlikleri ve Kulüpler");
                comboBox3.Items.Add("Staj ve İşyeri İlişkileri");
                comboBox3.Items.Add("Öğrenci Sağlık ve Sigorta Belgeleri");
                comboBox3.Items.Add("Akademik Programlar");
                comboBox3.Items.Add("Öğrenci Başvuruları ve Belgeler");
            }

            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() == "BÖLÜM SEKRETERLİĞİ")
            {
                comboBox3.Items.Clear();

                comboBox3.Items.Add("Öğretim Üyeleri ile İlgili Kayıtlar");
                comboBox3.Items.Add("Ders Programları");
                comboBox3.Items.Add("Bölüm Toplantıları");
                comboBox3.Items.Add("Bölüm Bütçesi ve Harcamalar");
                comboBox3.Items.Add("Öğrenci Danışmanlığı");
                comboBox3.Items.Add("Bölüm Etkinlikleri");
            }

            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() == "FAKÜLTE SEKRETERLİĞİ")
            {
                comboBox3.Items.Clear();

                comboBox3.Items.Add("Fakülte Programları ve Müfredatlar");
                comboBox3.Items.Add("Burs ve Finansal Yardımlar");
                comboBox3.Items.Add("Fakülte Toplantıları");
                comboBox3.Items.Add("Fakülte Bütçesi ve Harcamalar");
                comboBox3.Items.Add("Akreditasyon ve Kalite Güvencesi");
                comboBox3.Items.Add("Fakülte Etkinlikleri");
            }

            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() == "AKADEMİK PERSONEL")
            {
                comboBox3.Items.Clear();

                comboBox3.Items.Add("Öğrenci Kayıtları");
                comboBox3.Items.Add("Ders Materyalleri");
                comboBox3.Items.Add("Akademik Programlar");
                comboBox3.Items.Add("Araştırma Verileri ve Kaynaklar");
                comboBox3.Items.Add("Akademik İşler ve Yönetim Belgeleri");
                comboBox3.Items.Add("Proje ve Araştırma Başvuruları");
                comboBox3.Items.Add("Yayınlar ve Makaleler");
                comboBox3.Items.Add("Danışmanlık Belgeleri");
                comboBox3.Items.Add("Konferans ve Seminer Belgeleri");
                comboBox3.Items.Add("Akademik Değerlendirme Belgeleri");
            }
        }
    }
}
