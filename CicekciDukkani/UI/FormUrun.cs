using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CicekciDukkani.UI
{
    public partial class FormUrun : Form
    {
        public FormUrun()
        {
            InitializeComponent();
        }

        private void FormUrun_Load(object sender, EventArgs e)
        {

        }
        public Urun urun { get; set; }
        private void buttonTamam_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(textUrunAdi)) return;
            if (!ErrorControl(comboBoxTür)) return;
            if (!ErrorControl(nmFiyat)) return;
            if (!ErrorControl(nmStok)) return;

            urun.UrunAdi = textUrunAdi.Text;
            urun.Tur = comboBoxTür.Text;
            urun.Fiyat =nmFiyat.Value;
            urun.Stok =(int)nmStok.Value;

            DialogResult = DialogResult.OK;
        }
        private void buttonİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private bool ErrorControl(Control c)
        {
            if (c is TextBox || c is ComboBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi girdiniz.");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }
            return true;
            if (c is NumericUpDown)
            {
                if (((NumericUpDown)c).Value == 0)
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi girdiniz.");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }
        }

        
    }
}
