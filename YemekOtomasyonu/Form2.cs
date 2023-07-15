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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Icecekler> icecekler = new List<Icecekler>
            {
                new Icecekler { Ad = "Kola", Fiyat = 10 },
                new Icecekler { Ad = "Fanta", Fiyat = 5 }

            };

            List<Yiyecekler> yiyecekler = new List<Yiyecekler>
            {
                new Yiyecekler { Ad = "Tost", Fiyat = 20 },
                new Yiyecekler { Ad = "Hamburger", Fiyat = 30 }
            };

            foreach (Yiyecekler yiyecek in yiyecekler)
            {
                cmbYiyecekler.Items.Add(yiyecek.Ad);
            }

            foreach (Icecekler icecek in icecekler)
            {
                cmbIcecekler.Items.Add(icecek.Ad);
            }

            cmbIcecekler.SelectedIndex = -1;
            cmbYiyecekler.SelectedIndex = -1;
            cmbYiyecekler.DataSource = yiyecekler;
            cmbIcecekler.DataSource = icecekler;
            
        }

        int ciro;

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            if (cmbYiyecekler.SelectedItem == null && cmbIcecekler.SelectedItem == null)
            {
                MessageBox.Show("Seçim yapın lütfen.");
            }
            else
            {
                int icecekTutar = (cmbIcecekler.SelectedItem as Icecekler).Fiyat;
                int yiyecekTutar = (cmbYiyecekler.SelectedItem as Yiyecekler).Fiyat;

                int toplamTutar = yiyecekTutar + icecekTutar;
                ciro = ciro + toplamTutar;

                lblTutar.Text = toplamTutar.ToString();
                lblTutar.Text = toplamTutar.ToString();
            }
        }

        private void btnCiro_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{ciro.ToString()} kâr elde ettiniz.");
        }
    }
}
