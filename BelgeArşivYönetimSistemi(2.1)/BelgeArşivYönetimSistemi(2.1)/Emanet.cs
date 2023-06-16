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
    public partial class Emanet : Form
    {
        public Emanet()
        {
            InitializeComponent();
        }

        private void Emanet_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Close();
        }
    }
}
