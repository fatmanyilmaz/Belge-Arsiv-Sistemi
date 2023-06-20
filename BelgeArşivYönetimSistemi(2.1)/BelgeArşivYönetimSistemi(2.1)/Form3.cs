using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
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

                listBox1.Items.Add("Öğrenci Aidatları ve Ödemeleri, Raf 31");
                listBox1.Items.Add("Personel Bordroları, Raf 32");
                listBox1.Items.Add("Satın Alım Evrakları, Raf 33");
                listBox1.Items.Add("Vergi Beyannameleri ve Raporlar, Raf 34");
                listBox1.Items.Add("Bütçe Planlaması ve Raporları, Raf 35");
                listBox1.Items.Add("Gelir - Gider Tabloları, Raf 36");
                listBox1.Items.Add("Fatura ve Fatura İrsaliyeleri, Raf 37");
            }

            if (comboBox1.SelectedItem.ToString() == "ÖĞRENCİ İŞLERİ")
            {
                listBox1.Items.Clear();

                listBox1.Items.Add("Öğrenci Disiplin Kayıtları, Raf 23");
                listBox1.Items.Add("Öğrenci İzin ve Rapor Talepleri, Raf 24");
                listBox1.Items.Add("Diplomalar ve Mezuniyet Bekgeleri, Raf 25");
                listBox1.Items.Add("Öğrenci Etkinlikleri ve Kulüpler, Raf 26");
                listBox1.Items.Add("Staj ve İşyeri İlişkileri, Raf 27");
                listBox1.Items.Add("Öğrenci Sağlık ve Sigorta Belgeleri, Raf 28");
                listBox1.Items.Add("Akademik Programlar, Raf 29");
                listBox1.Items.Add("Öğrenci Başvuruları ve Belgeler, Raf 30");
            }

            if (comboBox1.SelectedItem.ToString() == "BÖLÜM SEKRETERLİĞİ")
            {
                listBox1.Items.Clear();

                listBox1.Items.Add("Öğretim Üyeleri ile İlgili Kayıtlar, Raf 17");
                listBox1.Items.Add("Ders Programları, Raf 18");
                listBox1.Items.Add("Bölüm Toplantıları, Raf 19");
                listBox1.Items.Add("Bölüm Bütçesi ve Harcamalar, Raf 20");
                listBox1.Items.Add("Öğrenci Danışmanlığı, Raf 21");
                listBox1.Items.Add("Bölüm Etkinlikleri, Raf 22");
            }

            if (comboBox1.SelectedItem.ToString() == "FAKÜLTE SEKRETERLİĞİ")
            {
                listBox1.Items.Clear();

                listBox1.Items.Add("Fakülte Programları ve Müfredatlar, Raf 11");
                listBox1.Items.Add("Burs ve Finansal Yardımlar, Raf 12");
                listBox1.Items.Add("Fakülte Toplantıları, Raf 13");
                listBox1.Items.Add("Fakülte Bütçesi ve Harcamalar, Raf 14");
                listBox1.Items.Add("Akreditasyon ve Kalite Güvencesi, Raf 15");
                listBox1.Items.Add("Fakülte Etkinlikleri, Raf 16");
            }

            if (comboBox1.SelectedItem.ToString() == "AKADEMİK PERSONEL")
            {
                listBox1.Items.Clear();

                listBox1.Items.Add("Öğrenci Kayıtları, Raf 1");
                listBox1.Items.Add("Ders Materyalleri, Raf 2");
                listBox1.Items.Add("Akademik Programlar, Raf 3");
                listBox1.Items.Add("Araştırma Verileri ve Kaynaklar, Raf 4");
                listBox1.Items.Add("Akademik İşler ve Yönetim Belgeleri, Raf 5");
                listBox1.Items.Add("Proje ve Araştırma Başvuruları, Raf 6");
                listBox1.Items.Add("Yayınlar ve Makaleler, Raf 7");
                listBox1.Items.Add("Danışmanlık Belgeleri, Raf 8");
                listBox1.Items.Add("Konferans ve Seminer Belgeleri, Raf 9");
                listBox1.Items.Add("Akademik Değerlendirme Belgeleri, Raf 10");
            }
        }


        public void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() == "MUHASEBE")
            {
                comboBox3.Items.Clear();

                comboBox3.Items.Add("Öğrenci Aidatları ve Ödemeleri, Raf 31");
                comboBox3.Items.Add("Personel Bordroları, Raf 32");
                comboBox3.Items.Add("Satın Alım Evrakları, Raf 33");
                comboBox3.Items.Add("Vergi Beyannameleri ve Raporlar, Raf 34");
                comboBox3.Items.Add("Bütçe Planlaması ve Raporları, Raf 35");
                comboBox3.Items.Add("Gelir - Gider Tabloları, Raf 36");
                comboBox3.Items.Add("Fatura ve Fatura İrsaliyeleri, Raf 37");

            }

            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() == "ÖĞRENCİ İŞLERİ")
            {
                comboBox3.Items.Clear();

                comboBox3.Items.Add("Öğrenci Disiplin Kayıtları, Raf 23");
                comboBox3.Items.Add("Öğrenci İzin ve Rapor Talepleri, Raf 24");
                comboBox3.Items.Add("Diplomalar ve Mezuniyet Bekgeleri, Raf 25");
                comboBox3.Items.Add("Öğrenci Etkinlikleri ve Kulüpler, Raf 26");
                comboBox3.Items.Add("Staj ve İşyeri İlişkileri, Raf 27");
                comboBox3.Items.Add("Öğrenci Sağlık ve Sigorta Belgeleri, Raf 28");
                comboBox3.Items.Add("Akademik Programlar, Raf 29");
                comboBox3.Items.Add("Öğrenci Başvuruları ve Belgeler, Raf 30");
            }

            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() == "BÖLÜM SEKRETERLİĞİ")
            {
                comboBox3.Items.Clear();

                comboBox3.Items.Add("Öğretim Üyeleri ile İlgili Kayıtlar, Raf 17");
                comboBox3.Items.Add("Ders Programları, Raf 18");
                comboBox3.Items.Add("Bölüm Toplantıları, Raf 19");
                comboBox3.Items.Add("Bölüm Bütçesi ve Harcamalar, Raf 20");
                comboBox3.Items.Add("Öğrenci Danışmanlığı, Raf 21");
                comboBox3.Items.Add("Bölüm Etkinlikleri, Raf 22");
            }

            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() == "FAKÜLTE SEKRETERLİĞİ")
            {
                comboBox3.Items.Clear();

                comboBox3.Items.Add("Fakülte Programları ve Müfredatlar, Raf 11");
                comboBox3.Items.Add("Burs ve Finansal Yardımlar, Raf 12");
                comboBox3.Items.Add("Fakülte Toplantıları, Raf 13");
                comboBox3.Items.Add("Fakülte Bütçesi ve Harcamalar, Raf 14");
                comboBox3.Items.Add("Akreditasyon ve Kalite Güvencesi, Raf 15");
                comboBox3.Items.Add("Fakülte Etkinlikleri, Raf 16");
            }

            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() == "AKADEMİK PERSONEL")
            {
                comboBox3.Items.Clear();

                comboBox3.Items.Add("Öğrenci Kayıtları, Raf 1");
                comboBox3.Items.Add("Ders Materyalleri, Raf 2");
                comboBox3.Items.Add("Akademik Programlar, Raf 3");
                comboBox3.Items.Add("Araştırma Verileri ve Kaynaklar, Raf 4");
                comboBox3.Items.Add("Akademik İşler ve Yönetim Belgeleri, Raf 5");
                comboBox3.Items.Add("Proje ve Araştırma Başvuruları, Raf 6");
                comboBox3.Items.Add("Yayınlar ve Makaleler, Raf 7");
                comboBox3.Items.Add("Danışmanlık Belgeleri, Raf 8");
                comboBox3.Items.Add("Konferans ve Seminer Belgeleri, Raf 9");
                comboBox3.Items.Add("Akademik Değerlendirme Belgeleri, Raf 10");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=172.21.54.3; user=Grup2-2023; database=Grup2-2023; password=NyP:974.cc";
            using (MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon))
            {
                mySqlConnection.Open();
                string query = "INSERT INTO Evrak (EvrakKayitId, EvrakKaydedenAdi, EvrakKaydedenSoyadi, EvrakKaydedenDepartman, EvrakTuru, KayitTarihi, EvrakRaf) VALUES (@EvrakKayitId, @EvrakKaydedenAdi, @EvrakKaydedenSoyadi, @EvrakKaydedenDepartman, @EvrakTuru, @KayitTarihi, @EvrakRaf)";
                using (MySqlCommand cmd = new MySqlCommand(query, mySqlConnection))
                {
                    cmd.Parameters.AddWithValue("@EvrakKayitId", textBox1.Text);
                    cmd.Parameters.AddWithValue("@EvrakKaydedenAdi", textBox3.Text);
                    cmd.Parameters.AddWithValue("@EvrakKaydedenSoyadi", textBox2.Text);
                    cmd.Parameters.AddWithValue("@EvrakKaydedenDepartman", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@EvrakTuru", comboBox3.Text);
                    cmd.Parameters.AddWithValue("@KayitTarihi", dateTimePicker1.Text);
                    cmd.Parameters.AddWithValue("@EvrakRaf", textBox4.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            if (!string.IsNullOrEmpty(textBox1.Text) &&
            !string.IsNullOrEmpty(textBox2.Text) &&
            !string.IsNullOrEmpty(textBox3.Text) &&
            comboBox3.SelectedIndex != -1 &&
            comboBox2.SelectedIndex != -1)
            {
                MessageBox.Show("Başarıyla Kaydedildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            dateTimePicker1.ShowUpDown = true;
        }
    }
}
