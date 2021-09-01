
namespace kebapFormComboBox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbYemek1 = new System.Windows.Forms.ComboBox();
            this.cmbYemek2 = new System.Windows.Forms.ComboBox();
            this.lblBirinciYemek = new System.Windows.Forms.Label();
            this.lblİkinciYemek = new System.Windows.Forms.Label();
            this.btnHesapGetir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblOdenmesiGereken = new System.Windows.Forms.Label();
            this.lblPorsiyonBilgisi = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.btnOdeme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbYemek1
            // 
            this.cmbYemek1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYemek1.FormattingEnabled = true;
            this.cmbYemek1.Location = new System.Drawing.Point(12, 29);
            this.cmbYemek1.Name = "cmbYemek1";
            this.cmbYemek1.Size = new System.Drawing.Size(186, 21);
            this.cmbYemek1.TabIndex = 0;
            this.cmbYemek1.SelectedIndexChanged += new System.EventHandler(this.cmbYemek1_SelectedIndexChanged_1);
            // 
            // cmbYemek2
            // 
            this.cmbYemek2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYemek2.FormattingEnabled = true;
            this.cmbYemek2.Location = new System.Drawing.Point(12, 142);
            this.cmbYemek2.Name = "cmbYemek2";
            this.cmbYemek2.Size = new System.Drawing.Size(186, 21);
            this.cmbYemek2.TabIndex = 1;
            // 
            // lblBirinciYemek
            // 
            this.lblBirinciYemek.AutoSize = true;
            this.lblBirinciYemek.Location = new System.Drawing.Point(9, 13);
            this.lblBirinciYemek.Name = "lblBirinciYemek";
            this.lblBirinciYemek.Size = new System.Drawing.Size(149, 13);
            this.lblBirinciYemek.TabIndex = 2;
            this.lblBirinciYemek.Text = "Lütfen Birinci Yemeği Seçiniz :";
            // 
            // lblİkinciYemek
            // 
            this.lblİkinciYemek.AutoSize = true;
            this.lblİkinciYemek.Location = new System.Drawing.Point(12, 126);
            this.lblİkinciYemek.Name = "lblİkinciYemek";
            this.lblİkinciYemek.Size = new System.Drawing.Size(146, 13);
            this.lblİkinciYemek.TabIndex = 3;
            this.lblİkinciYemek.Text = "Lütfen İkinci Yemeği Seçiniz :";
            // 
            // btnHesapGetir
            // 
            this.btnHesapGetir.Location = new System.Drawing.Point(15, 193);
            this.btnHesapGetir.Name = "btnHesapGetir";
            this.btnHesapGetir.Size = new System.Drawing.Size(269, 23);
            this.btnHesapGetir.TabIndex = 4;
            this.btnHesapGetir.Text = "HESABI GETİR";
            this.btnHesapGetir.UseVisualStyleBackColor = true;
            this.btnHesapGetir.Click += new System.EventHandler(this.btnHesapGetir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(312, 30);
            this.textBox1.MaxLength = 2;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(312, 143);
            this.textBox2.MaxLength = 2;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(51, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // lblOdenmesiGereken
            // 
            this.lblOdenmesiGereken.AutoSize = true;
            this.lblOdenmesiGereken.Location = new System.Drawing.Point(12, 239);
            this.lblOdenmesiGereken.Name = "lblOdenmesiGereken";
            this.lblOdenmesiGereken.Size = new System.Drawing.Size(170, 13);
            this.lblOdenmesiGereken.TabIndex = 7;
            this.lblOdenmesiGereken.Text = "Ödemeniz Gereken Toplam Tutar :";
            // 
            // lblPorsiyonBilgisi
            // 
            this.lblPorsiyonBilgisi.AutoSize = true;
            this.lblPorsiyonBilgisi.Location = new System.Drawing.Point(287, 14);
            this.lblPorsiyonBilgisi.Name = "lblPorsiyonBilgisi";
            this.lblPorsiyonBilgisi.Size = new System.Drawing.Size(76, 13);
            this.lblPorsiyonBilgisi.TabIndex = 8;
            this.lblPorsiyonBilgisi.Text = "Porsiyon Bilgisi";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(214, 239);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(0, 13);
            this.lblFiyat.TabIndex = 9;
            // 
            // btnOdeme
            // 
            this.btnOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdeme.Location = new System.Drawing.Point(134, 289);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(150, 68);
            this.btnOdeme.TabIndex = 10;
            this.btnOdeme.Text = "Ödeme Yap";
            this.btnOdeme.UseVisualStyleBackColor = true;
            this.btnOdeme.Visible = false;
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 386);
            this.Controls.Add(this.btnOdeme);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblPorsiyonBilgisi);
            this.Controls.Add(this.lblOdenmesiGereken);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnHesapGetir);
            this.Controls.Add(this.lblİkinciYemek);
            this.Controls.Add(this.lblBirinciYemek);
            this.Controls.Add(this.cmbYemek2);
            this.Controls.Add(this.cmbYemek1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbYemek1;
        private System.Windows.Forms.ComboBox cmbYemek2;
        private System.Windows.Forms.Label lblBirinciYemek;
        private System.Windows.Forms.Label lblİkinciYemek;
        private System.Windows.Forms.Button btnHesapGetir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblOdenmesiGereken;
        private System.Windows.Forms.Label lblPorsiyonBilgisi;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Button btnOdeme;
    }
}

