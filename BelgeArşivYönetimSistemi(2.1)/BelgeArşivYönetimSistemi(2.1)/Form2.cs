using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
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
            panel4.Visible = false;
            panel3.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
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

        private void button5_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=172.21.54.3; user=Grup2-2023; database=Grup2-2023; password=NyP:974.cc";
            using (MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon))
            {
                mySqlConnection.Open();
                string query = "INSERT INTO Emanet (EmanetAlanId, EmanetAlanAd, EmanetAlanSoyad, TelNo, EmanetAlanMail, EmanetAlanDepartman) VALUES (@EmanetAlanId, @EmanetAlanAd, @EmanetAlanSoyad, @TelNo, @EmanetAlanMail, @EmanetAlanDepartman)";
                using (MySqlCommand komut = new MySqlCommand(query, mySqlConnection))
                {
                    komut.Parameters.AddWithValue("@EmanetAlanId", textBox1.Text);
                    komut.Parameters.AddWithValue("@EmanetAlanAd", textBox2.Text);
                    komut.Parameters.AddWithValue("@EmanetAlanSoyad", textBox4.Text);
                    komut.Parameters.AddWithValue("@TelNo", textBox3.Text);
                    komut.Parameters.AddWithValue("@EmanetAlanMail", textBox5.Text);
                    komut.Parameters.AddWithValue("@EmanetAlanDepartman", comboBox1.Text);
                    komut.ExecuteNonQuery();
                }
            }
            if (!string.IsNullOrEmpty(textBox1.Text) &&
            !string.IsNullOrEmpty(textBox2.Text) &&
            !string.IsNullOrEmpty(textBox3.Text) &&
            !string.IsNullOrEmpty(textBox4.Text) &&
            !string.IsNullOrEmpty(textBox5.Text) &&
            comboBox1.SelectedIndex != -1)
            {
                MessageBox.Show("Başarıyla Kaydedildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=172.21.54.3; user=Grup2-2023; database=Grup2-2023; password=NyP:974.cc";
            using (MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon))
            {
                mySqlConnection.Open();
                string query = "INSERT INTO EmanetV (EmanetVerenId, EmanetVerenAd, EmanetVerenSoyad,EmanetVerenMail) VALUES (@EmanetVerenId, @EmanetVerenAd, @EmanetVerenSoyad, @EmanetVerenMail)";
                using (MySqlCommand komut = new MySqlCommand(query, mySqlConnection))
                {
                    komut.Parameters.AddWithValue("@EmanetVerenId", textBox6.Text);
                    komut.Parameters.AddWithValue("@EmanetVerenAd", textBox7.Text);
                    komut.Parameters.AddWithValue("@EmanetVerenSoyad", textBox9.Text);
                    komut.Parameters.AddWithValue("@EmanetVerenMail", textBox8.Text);
                    komut.ExecuteNonQuery();
                }
            }
            if (!string.IsNullOrEmpty(textBox6.Text) &&
            !string.IsNullOrEmpty(textBox7.Text) &&
            !string.IsNullOrEmpty(textBox8.Text) &&
            !string.IsNullOrEmpty(textBox9.Text))

            {
                MessageBox.Show("Başarıyla Kaydedildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=172.21.54.3; user=Grup2-2023; database=Grup2-2023; password=NyP:974.cc";
            using (MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon))
            {
                mySqlConnection.Open();
                string query = "INSERT INTO Evrak (EvrakKayitId, EvrakKaydedenAdi, EvrakKaydedenSoyadi, EvrakKaydedenDepartman, EvrakTuru, KayitTarihi, EvrakRaf) VALUES (@EvrakKayitId, @EvrakKaydedenAdi, @EvrakKaydedenSoyadi, @EvrakKaydedenDepartman, @EvrakTuru, @KayitTarihi, @EvrakRaf)";
                using (MySqlCommand komut = new MySqlCommand(query, mySqlConnection))
                {
                    komut.Parameters.AddWithValue("@EvrakKayitId", textBox12.Text);
                    komut.Parameters.AddWithValue("@EvrakKaydedenAdi", textBox10.Text);
                    komut.Parameters.AddWithValue("@EvrakKaydedenSoyadi", textBox11.Text);
                    komut.Parameters.AddWithValue("@EvrakKaydedenDepartman", comboBox4.Text);
                    komut.Parameters.AddWithValue("@EvrakTuru", comboBox5.Text);
                    komut.Parameters.AddWithValue("@KayitTarihi", dateTimePicker1.Text);
                    komut.Parameters.AddWithValue("@EvrakRaf", textBox15.Text);
                    komut.ExecuteNonQuery();
                }
            }
            if (!string.IsNullOrEmpty(textBox10.Text) &&
            (dateTimePicker1.Value == DateTimePicker.MinimumDateTime ||
            !string.IsNullOrEmpty(textBox11.Text) &&
            !string.IsNullOrEmpty(textBox12.Text) &&
            !string.IsNullOrEmpty(textBox15.Text) &&
            comboBox4.SelectedIndex != -1 &&
            comboBox5.SelectedIndex != -1))

            {
                MessageBox.Show("Başarıyla Kaydedildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=172.21.54.3; user=Grup2-2023; database=Grup2-2023; password=NyP:974.cc";
            using (MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon))
            {
                mySqlConnection.Open();
                string query = "INSERT INTO KullaniciKayit (KullaniciAd, KullaniciSoyad, Departman, KullaniciMail, KullaniciId, Yetki) VALUES (@Kullaniciad, @KullaniciSoyad, @Departman, @KullaniciMail, @KullaniciId, @Yetki)";
                using (MySqlCommand komut = new MySqlCommand(query, mySqlConnection))
                {
                    komut.Parameters.AddWithValue("@KullaniciAd", textBox13.Text);
                    komut.Parameters.AddWithValue("@KullaniciSoyad", textBox14.Text);
                    komut.Parameters.AddWithValue("@Departman", comboBox2.Text);
                    komut.Parameters.AddWithValue("@KullaniciId", textBox17.Text);
                    komut.Parameters.AddWithValue("@KullaniciMail", textBox16.Text);
                    string selectedValue = string.Empty;
                    if (radioButton1.Checked)
                    {
                        selectedValue = radioButton1.Text;
                    }
                    else if (radioButton2.Checked)
                    {
                        selectedValue = radioButton2.Text;
                    }
                    komut.Parameters.AddWithValue("@Yetki", selectedValue);
                    komut.ExecuteNonQuery();
                }
            }
            if (!string.IsNullOrEmpty(textBox16.Text) &&
            !string.IsNullOrEmpty(textBox17.Text) &&
            !string.IsNullOrEmpty(textBox13.Text) &&
            !string.IsNullOrEmpty(textBox14.Text) &&
            (radioButton1.Checked || radioButton2.Checked) &&
            comboBox2.SelectedIndex != -1)
            {
                MessageBox.Show("Başarıyla Kaydedildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            dateTimePicker1.ShowUpDown = true;
        }
    }
}
