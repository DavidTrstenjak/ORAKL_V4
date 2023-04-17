using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ORAKL_NIOP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void buttonOtvSmj_Click(object sender, EventArgs e)
        {
            this.Close();
            OtvaranjeSmjene otvsmj = new OtvaranjeSmjene();
            otvsmj.ShowDialog();
        }

        private void buttonRacun_Click(object sender, EventArgs e)
        {

            if (File.Exists("OtvorenaSmjena.xml"))
            {
                this.Close();
                Racun racun = new Racun();
                racun.ShowDialog();
            }
            else
            {
                MessageBox.Show("Smjena nije otvorena.");
            }
        }

        private void buttonZtvSmj_Click(object sender, EventArgs e)
        {
            if (File.Exists("OtvorenaSmjena.xml"))
            {
                this.Close();
                ZatvaranjeSmjene ztvsmj = new ZatvaranjeSmjene();
                ztvsmj.ShowDialog();
            }
            else
            {
                MessageBox.Show("Smjena nije otvorena.");
            }
        }

        private void buttonIspis_Click(object sender, EventArgs e)
        {
            if (File.Exists("OtvorenaSmjena.xml"))
            {
            Ispis ispis = new Ispis();
            ispis.ShowDialog();
            }
            else
            {
                MessageBox.Show("Smjena nije otvorena.");
            }
        }
    }
}