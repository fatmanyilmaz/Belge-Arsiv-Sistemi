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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EvrakArsivi evrakArsivi = new EvrakArsivi();
            evrakArsivi.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EvrakArsivi evrakArsivi = new EvrakArsivi();
            evrakArsivi.Show();
            this.Hide();
        }

        private void GirisBttn_Click(object sender, EventArgs e)
        {
            EvrakKayit evrakKayit = new EvrakKayit();
            evrakKayit.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
