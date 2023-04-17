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

namespace ORAKL_NIOP
{


    public partial class Racun : Form
    {
        public Racun()
        {
            InitializeComponent();
        }

        private void buttonNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void Racun_Load(object sender, EventArgs e)
        {

        }

        private void buttonUnesi_Click(object sender, EventArgs e)
        {
            

            XmlDocument doc = new XmlDocument();
            doc.Load("proizvodi.xml");

            XmlNodeList proizvodi = doc.GetElementsByTagName("proizvod");

            foreach (XmlNode proizvod in proizvodi)
            {
                if (proizvod.SelectSingleNode("sifra").InnerText == textBox2.Text)
                {
                    string naziv = proizvod.SelectSingleNode("naziv").InnerText;
                    string cijena = proizvod.SelectSingleNode("cijena").InnerText;

                    textBox1.AppendText(textBox2.Text + "            " + naziv + "            " + cijena + Environment.NewLine);
                    textBox2.Clear();

                    break;
                }
            }

            
            decimal ukupnaCijena = 0m;
            foreach (string line in textBox2.Lines)
            {
                XmlNode proizvod = proizvodi.Cast<XmlNode>()
                                           .FirstOrDefault(p => p.SelectSingleNode("sifra").InnerText == line.Trim());
                if (proizvod != null)
                {
                    decimal cijena = decimal.Parse(proizvod.SelectSingleNode("cijena").InnerText);
                    ukupnaCijena += cijena;
                }
            }

            // Display the total price
            textBox3.Text = ukupnaCijena.ToString("F2");
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public List<int> values = new List<int>();
        private void buttonDodajArtikl_Click(object sender, EventArgs e)
        {

            string textBox2Value = string.Empty;
            textBox2.Text = textBox2Value;
            buttonUnesi.PerformClick();

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
             
        }
    }
}
    
    
    

