using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YemekOtomasyonu.Models;

namespace YemekOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string kullaniciKartNo = "123321";

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtGiris.Text != kullaniciKartNo)
            {
                MessageBox.Show("Lütfen geçerli bir isim girin.");
                txtGiris.Text = "";
            }
            else
            {
                Form2 form2 = new Form2();
                form2.Show();
                btnGiris.Enabled = false;
            }
        }

    }
}
