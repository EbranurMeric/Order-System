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
    public partial class FormMusteri : Form
    {
        public FormMusteri()
        {
            InitializeComponent();
        }
        public Musteri Musteri { get;set; }
        private void buttonTamam_Click(object sender, EventArgs e)
        {
            if(!ErrorControl(textİSİM)) return;
            if(!ErrorControl(textSOYİSİM)) return;
            if (!ErrorControl(textEPOSTA)) return;
            if (!ErrorControl(maskedTextTEL)) return;
            if (!ErrorControl(textADRES)) return;

            Musteri.Isim = textİSİM.Text;
            Musteri.Soyisim = textSOYİSİM.Text;
            Musteri.Eposta=textEPOSTA.Text;
            Musteri.Telefon = maskedTextTEL.Text;
            Musteri.Adres = textADRES.Text;

            DialogResult = DialogResult.OK;
        }
        private void buttonİptal_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }
        private bool ErrorControl(Control c)
        {
            if (c is TextBox)
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
            if (!((MaskedTextBox)c).MaskFull)
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
        }
    }
}
