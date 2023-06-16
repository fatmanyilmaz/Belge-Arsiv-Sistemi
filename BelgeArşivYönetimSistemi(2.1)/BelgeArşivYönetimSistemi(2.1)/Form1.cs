using MySql.Data.MySqlClient;
namespace BelgeArşivYönetimSistemi_2._1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string mysqlCon = "server=172.21.54.3; user=Grup2-2023; database=Grup2-2023; password=NyP:974.cc";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mySqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
        //Formlar arası veri tanımlama
        public static string id, adi, soyadi, yetki;
        //Yerel değişken tanımlama
        int hak = 3; bool durum = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = " Kullanıcı Girişi ";
            this.AcceptButton = GirisBttn; this.CancelButton = CikisBttn;
            YoneticiRdioBttn.Checked = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;

        }

        private void GirisBttn_Click(object sender, EventArgs e)
        {
            if (KullaniciRadioBttn.Checked)
            {
                Form3 frm3 = new Form3();
                frm3.Show();
                this.Hide();
            }

            else if (YoneticiRdioBttn.Checked)
            {
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
            }

            if (hak != 0)
            {
                string mysqlCon = "server=172.21.54.3; user=Grup2-2023; database=Grup2-2023; password=NyP:974.cc";
                MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
                mySqlConnection.Open();

                MySqlCommand selectsorgu = new MySqlCommand("select * from Kullanici", mySqlConnection);
                MySqlDataReader kayitOkuma = selectsorgu.ExecuteReader();

                while (kayitOkuma.Read())
                {
                    if (YoneticiRdioBttn.Checked == true)
                    {
                        if (kayitOkuma["kullaniciAd"].ToString() == KullaniciAdiTxtbx.Text && kayitOkuma["sifre"].ToString() == SifreTxtbx.Text && kayitOkuma["yetki"].ToString() == "Yönetici")
                        {

                            durum = true;
                            id = kayitOkuma.GetValue(0).ToString();
                            adi = kayitOkuma.GetValue(1).ToString();
                            soyadi = kayitOkuma.GetValue(2).ToString();
                            yetki = kayitOkuma.GetValue(3).ToString();

                            break;



                        }

                    }
                    if (KullaniciRadioBttn.Checked == true)
                    {
                        if (kayitOkuma["kullaniciAd"].ToString() == KullaniciAdiTxtbx.Text && kayitOkuma["sifre"].ToString() == SifreTxtbx.Text && kayitOkuma["yetki"].ToString() == "Kullanıcı")
                        {

                            durum = true;
                            id = kayitOkuma.GetValue(0).ToString();
                            adi = kayitOkuma.GetValue(1).ToString();
                            soyadi = kayitOkuma.GetValue(2).ToString();
                            yetki = kayitOkuma.GetValue(3).ToString();

                            break;



                        }

                    }


                }
                if (durum == false)

                    hak--;
                mySqlConnection.Close();

            }
            if (hak == 0)
            {
                GirisBttn.Enabled = false;
                MessageBox.Show("Giriş Hakkınız Dolmuştur.", "Belge Arşiv Yönetim Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void GirisBttn_Click_1(object sender, EventArgs e)
        {
            if (KullaniciRadioBttn.Checked)
            {
                Form3 frm3 = new Form3();
                frm3.Show();
                this.Hide();
            }

            else if (YoneticiRdioBttn.Checked)
            {
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
            }
        }
    }
}