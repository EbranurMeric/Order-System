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
    public partial class FormSiparis : Form
    {
        public FormSiparis()
        {
            InitializeComponent();
        }

        public Musteri Musteri { get; set; }
        public Urun Urun { get; set; }
        public Siparis Siparis { get; set; }
        private void comboBoxTür_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void buttonTamam_Click(object sender, EventArgs e)
        {
            Siparis.SiparisTarihi = dateTimePicker1.Value;
            Siparis.Durum = comboBoxSiparisDurumu.SelectedItem.ToString();
            Siparis.TeslimatAdresi = textTeslimatAdresi.Text;

            DialogResult = DialogResult.OK;
        }
        private void FormSiparis_Load(object sender, EventArgs e)
        {
            
            textMusteriID.Text= Musteri.ToString();
            textUrunID.Text=Urun.ToString();
        }
    }
}
