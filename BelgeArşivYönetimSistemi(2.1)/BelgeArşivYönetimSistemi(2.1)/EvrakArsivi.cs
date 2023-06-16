using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelgeArşivYönetimSistemi_2._1_
{
    public partial class EvrakArsivi : Form
    {
        public EvrakArsivi()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Close();
        }
    }
}
