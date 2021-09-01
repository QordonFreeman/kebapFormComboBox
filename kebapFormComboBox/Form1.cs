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

        decimal totalPrice;
        int porsiyon;

        Yemek pilav1 = new Yemek();
        Yemek kebap1 = new Yemek();

        List<Yemek> yemekler;
        public void Form1_Load(object sender, EventArgs e)
        {


            pilav1.Name = "Pilav";
            pilav1.Price = 18m;

            kebap1.Name = "Kebap";
            kebap1.Price = 25m;

            yemekler = new List<Yemek>
            {
                pilav1,
                kebap1
            };

            //cmbYemek1.Items.Add(kebap1);
            //cmbYemek1.Items.Add(pilav1);
            //cmbYemek2.Items.Add(kebap1);
            //cmbYemek2.Items.Add(pilav1);



            foreach (var item in yemekler)
            {
                cmbYemek1.Items.Add(item);
                //cmbYemek2.Items.Add(item);
            }
            //cmbYemek1.SelectedItem = Yemekler.FirstOrDefault();
            //cmbYemek2.SelectedItem = Yemekler.FirstOrDefault();

        }

        private void btnHesapGetir_Click(object sender, EventArgs e)
        {
            btnOdeme.Visible = true;
            decimal y1tutar;
            decimal y2tutar;
            Yemek random = new Yemek();
            random = cmbYemek1.SelectedItem as Yemek;

            Yemek random2 = new Yemek();
            random2 = cmbYemek2.SelectedItem as Yemek;

            y1tutar = random.Price * decimal.Parse(textBox1.Text);
            y2tutar = random2.Price * decimal.Parse(textBox2.Text);

            totalPrice = y1tutar + y2tutar;

            lblFiyat.Text = totalPrice.ToString("C2");

            //if (totalPrice == decimal.Zero)
            //{
            //    return;
            //}
            


            


        }
        
        private void btnOdeme_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();            
            form2.Show();
            this.Hide();

            form2.Text = lblFiyat.Text;
            form2.textBox6.Text = lblFiyat.Text;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cmbYemek1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbYemek1.SelectedItem == yemekler.Find(x => x.Name == cmbYemek1.Text))
            {
                cmbYemek2.Items.Add(yemekler.Find(x => x.Name != cmbYemek1.Text));
            }
            if (cmbYemek2.Items.Count >= 1)
            {
                cmbYemek2.Items.Clear();
                cmbYemek2.Items.Add(yemekler.Find(x => x.Name != cmbYemek1.Text));
            }

            //if (cmbYemek1.SelectedText == pilav1.Name)
            //{
            //    cmbYemek2.Items.Remove(pilav1);
            //}
            //else if (cmbYemek1.SelectedText == kebap1.Name)
            //{
            //    cmbYemek2.Items.Remove(kebap1);
            //    cmbYemek2.Items.Add(pilav1);
            //}





        }

       
    }
}


