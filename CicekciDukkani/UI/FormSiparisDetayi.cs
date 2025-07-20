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
    public partial class FormSiparisDetayi : Form
    {
        public FormSiparisDetayi()
        {
            InitializeComponent();
        }

        private void buttonİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void buttonTamam_Click(object sender, EventArgs e)
        {
            if (nmBirimFiyat.Value == 0)
            {
                errorProvider1.SetError(nmBirimFiyat, "Lütfen fiyat giriniz!");
                nmBirimFiyat.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(nmBirimFiyat, "");

            }
            if (nmToplamFiyat.Value == 0)
            {
                errorProvider1.SetError(nmToplamFiyat, "Lütfen fiyat giriniz!");
                nmToplamFiyat.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(nmToplamFiyat, "");

            }
            DialogResult = DialogResult.OK;
        }
    }
}
