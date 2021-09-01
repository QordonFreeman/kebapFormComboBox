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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        private void Form2_Load(object sender, EventArgs e)
        {

            //textBox2.KeyPress += textBox_KeyPress;
            // bu yöntemle de ilgili textbox için event belirtebilirsin.
            // ancak bu sefer o kısımda gözükmez. sebebi şu bu set etme işlemi runtime da kodun 24.satıra gelmesinden sonra olacak. diğer türlü en başından belirtiyoruz.
            // bunu ne zaman kullanabilirsin:   misal kaç buton olduğunu bilemediğin dinamik oluşan restoran otomasyonu gibi yerlerde. bana her textboxa lazım bu 4 tane var
            // sen sağ klikle öte taraftan yapsan iyi olur az buton var ve butonlar statik.

        }
        private void btnOde_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Son kararınız mı ??", "Bak emin misin ? ", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                MessageBox.Show("Ödeme Tamamlandı ^-^","Olley be!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                this.Hide();
                frm1.Show(); // newlemeden form1.cs yi nasıl acıcak?
            }
           else if (dialog == DialogResult.No)
            {
                MessageBox.Show("Sen bilirsin.. :(");
                return;
            }
            
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 4)
                textBox2.Focus();
            else if (textBox1.Text == string.Empty)
                return;

            int card = int.Parse(textBox1.Text);
            if (card <= 5000)
                label1.Text = "Visa";
            else if (card > 5000)
                label1.Text = "MasterCard";
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox2.Text.Length >= 4)
                textBox3.Focus();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length >= 4)
                textBox4.Focus();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length >= 4)
                textBox5.Focus();
        }
    }
}