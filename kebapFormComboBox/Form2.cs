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
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Son kararınız mı ??", "Bak emin misin ? ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                MessageBox.Show("Ödeme Tamamlandı.");
            else
                MessageBox.Show("Sen bilirsin :(");
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
        }


    }
}
