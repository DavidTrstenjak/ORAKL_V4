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

namespace ORAKL_NIOP
{
    public partial class OtvaranjeSmjene : Form
    {
        public OtvaranjeSmjene()
        {
            InitializeComponent();
        }

        private void OtvaranjeSmjene_Load(object sender, EventArgs e)
        {
            int sat = DateTime.Now.Hour;
            string polog = textBox4.Text;

            if (sat >= 8 && sat < 14)
            {
                textBox1.Text = "1";
            }
            else if (sat >= 14 && sat < 20)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = "3";
            }

            textBox2.Text = DateTime.Now.ToString("dd/MM/yyyy");
            textBox3.Text = DateTime.Now.ToString("HH:mm:ss");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (XmlWriter writer = XmlWriter.Create("OtvorenaSmjena.xml"))
            {

                writer.WriteStartDocument();


                writer.WriteStartElement("Podaci");


                DodajElement(writer, "BrojSmjene", textBox1.Text);
                DodajElement(writer, "Datum", textBox2.Text);
                DodajElement(writer, "Vrijeme", textBox3.Text);
                DodajElement(writer, "Polog", textBox4.Text);


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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
