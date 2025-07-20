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
    public partial class FormOdemeler : Form
    {
        public FormOdemeler()
        {
            InitializeComponent();
        }

        private void buttonİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public Odemeler odemeler {  get; set; }
        private void buttonTamam_Click(object sender, EventArgs e)
        {
            if (nmOdemeTutarı.Value == 0)
            {
                errorProvider1.SetError(nmOdemeTutarı, "Lütfen fiyat giriniz!");
                nmOdemeTutarı.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(nmOdemeTutarı, "");

            }
            if (comboBoxOdemeTuru is TextBox || comboBoxOdemeTuru is ComboBox)
            {
                if (comboBoxOdemeTuru.Text == "")
                {
                    errorProvider1.SetError(comboBoxOdemeTuru, "Ödeme türü seçiniz.");
                    comboBoxOdemeTuru.Focus();
                    return;
                }
                else
                {
                    errorProvider1.SetError(comboBoxOdemeTuru, "");
                }
            }
            odemeler.Odemeturu = comboBoxOdemeTuru.SelectedItem.ToString();
            odemeler.OdemeTutari = nmOdemeTutarı.Value;
            odemeler.OdemeTarihi = dateTimePicker1.Value;
            odemeler.Durum = comboBoxOdemeDurumu.SelectedItem.ToString();

            DialogResult = DialogResult.OK;
        }
    }
}
