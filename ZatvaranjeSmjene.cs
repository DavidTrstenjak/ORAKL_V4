using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace ORAKL_NIOP
{
    public partial class ZatvaranjeSmjene : Form
    {
        public ZatvaranjeSmjene()
        {
            InitializeComponent();
                int sat = DateTime.Now.Hour;
                string promet = textBoxPromet.Text;

                if (sat >= 8 && sat < 14)
                {
                    textBoxSmjena.Text = "1";
                }
                else if (sat >= 14 && sat < 20)
                {
                    textBoxSmjena.Text = "2";
                }
                else
                {
                    textBoxSmjena.Text = "3";
                }

                textBoxDatum.Text = DateTime.Now.ToString("dd/MM/yyyy");
                textBoxVrijeme.Text = DateTime.Now.ToString("HH:mm:ss"); 
        }


        private void buttonIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }


        private void buttonSlanje_Click(object sender, EventArgs e)
        {
            using (XmlWriter writer = XmlWriter.Create("ZatvorenaSmjena.xml"))
            {

                writer.WriteStartDocument();


                writer.WriteStartElement("Podaci");


                DodajElement(writer, "BrojSmjene", textBoxSmjena.Text);
                DodajElement(writer, "Datum", textBoxDatum.Text);
                DodajElement(writer, "Vrijeme", textBoxVrijeme.Text);
                DodajElement(writer, "Promet", textBoxPromet.Text);


                writer.WriteEndElement();


                writer.WriteEndDocument();
            }

            MessageBox.Show("Podaci su spremljeni u datoteku.");

            this.Close();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        private void DodajElement(XmlWriter writer, string nazivElementa, string vrijednostElementa)
        {
            writer.WriteStartElement(nazivElementa);
            writer.WriteString(vrijednostElementa);
            writer.WriteEndElement();
        }
    }

}
