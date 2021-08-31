using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kebapFormComboBox
{
    public partial class Form1 : Form
    {
        string selectedYemek1 = string.Empty;
        string selectedYemek2 = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> Yemekler = new List<string>
            {
                "Kebap",
                "Pilav",
                "Ciğer",
                "Lahmacun"
            };

            foreach (var item in Yemekler)
            {
                cmbYemek1.Items.Add(item);
                cmbYemek2.Items.Add(item);
            }

            //cmbYemek1.SelectedItem = Yemekler.FirstOrDefault();
            //cmbYemek2.SelectedItem = Yemekler.FirstOrDefault();

        }
        decimal totalPrice = 0;
        private void btnHesapGetir_Click(object sender, EventArgs e)
        {
            lblFiyat.Text = totalPrice.ToString();
            btnOdeme.Visible = true;


        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
        }

    }
}


