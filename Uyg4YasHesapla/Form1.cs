using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uyg4YasHesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime gununTarihi = DateTime.Now;
            int yil=gununTarihi.Year;

            DateTime secilenTarih = dateTimePicker1.Value;
            int dYili=secilenTarih.Year;

            int yas = yil - dYili;
            label2.Text = "Yasiniz: " + yas.ToString();
        }

        
    }
}
