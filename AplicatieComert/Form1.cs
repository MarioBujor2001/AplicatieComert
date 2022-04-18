using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieComert
{
    public partial class Form1 : Form
    {
        string[] tipuri = new string[]
        {
            "alimentar",
            "vestimentar",
            "electronic"
        };
        Produs p;
        List<Produs> listProd;
        List<string> listNames;
        public Form1()
        {
            InitializeComponent();
            tipProdCb.DataSource = tipuri;
            atributParticularLbl.Text = "Ceva";atributParticularLbl.Visible = false;
            atributParticularTb.Visible = false;
            listProd = new List<Produs>();
            listNames = new List<string>();
        }

        private void tipProdCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tipProdCb.Text == "alimentar")
            {
                atributParticularLbl.Text = "Data Expirare";
                atributParticularLbl.Visible = true;
                atributParticularTb.Visible = true;

                atributParticularTb.Visible = true;
            }
            else
            if (tipProdCb.Text == "vestimentar")
            {
                atributParticularLbl.Text = "Marime:";
                atributParticularLbl.Visible = true;
                atributParticularTb.Visible = true;

                atributParticularTb.Visible = true;
            }else
            if (tipProdCb.Text == "electronic")
            {
                atributParticularLbl.Text = "Consum:";
                atributParticularLbl.Visible = true;
                atributParticularTb.Visible = true;

                atributParticularTb.Visible = true;
            }
            else
            {
                atributParticularLbl.Text = "";
                atributParticularLbl.Visible = false;
                atributParticularTb.Visible = false;
            }
        }

        private void updateStocBtn_Click(object sender, EventArgs e)
        {
            string denumire, cantitate, tip, pret;
            denumire = denProdTb.Text;
            cantitate = cantitateTb.Text;
            tip = tipProdCb.Text;
            pret = pretTb.Text;

            int verificare = 1;
            foreach(Produs prod in listProd)
            {
                if(prod.Denumire == denumire)
                {
                    verificare = 0;
                    prod.Denumire = denumire;
                    prod.Cantitate = Convert.ToDouble(cantitate);
                    prod.Pret = Convert.ToDouble(pret);
                    prod.Tip = tip;
                    
                    break;
                }
            }
            if(verificare != 0)//daca nu exista produsul il adaug
            {
                p = new Produs(denumire, Convert.ToDouble(cantitate),
                tip, Convert.ToDouble(pret));
                listProd.Add(p);
                listNames.Add(p.Denumire);
                MessageBox.Show(p.ToString());
            }

            FileStream fisOut = new FileStream("Stoc.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fisOut, listProd);
            fisOut.Close();
            MessageBox.Show("S-a actualizat stocul!");
            //behavior ciudat intrebare!
            forUpdateCb.DataSource = listNames;
            forUpdateCb.Refresh();
            Invalidate();
        }

        private void denProdTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cantitateTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void pretTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }


        private void loadAvailableProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mesaj = "Stoc incarcat:\n";
            FileStream fisIn = new FileStream("Stoc.dat", FileMode.Open);
            BinaryFormatter b = new BinaryFormatter();
            if(fisIn.CanRead)
            {
                listProd = (List<Produs>)b.Deserialize(fisIn);
                foreach(Produs produs in listProd)
                {
                    mesaj += produs;
                    mesaj += "\n";
                }
            }
            fisIn.Close();
            MessageBox.Show(mesaj);

            denProdTb.Enabled = true;
            cantitateTb.Enabled = true;
            tipProdCb.Enabled = true;
            pretTb.Enabled = true;
            updateStocBtn.Enabled = true;
            foreach(Produs produs in listProd)
            {
                listNames.Add(produs.Denumire);
                ListViewItem listViewItem = new ListViewItem(produs.Denumire);
                listViewItem.SubItems.Add(produs.Cantitate.ToString());
                listViewItem.SubItems.Add(produs.Tip);
                listViewItem.SubItems.Add(produs.Pret.ToString());
                //ramane tipul de adaugat!
                lvProduse.Items.Add(listViewItem);

            }
            forUpdateCb.DataSource = listNames;
        }

        private void seeStockBtn_Click(object sender, EventArgs e)
        {
            string mesaj = "\tStoc curent:\n\n";
            foreach(Produs produs in listProd)
            {
                mesaj += produs;
                mesaj += "\n";
            }
            MessageBox.Show(mesaj);
        }

        private void forUpdateCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int verif = 1;
            foreach(Produs produs in listProd)
            {
                if(produs.Denumire == forUpdateCb.Text)
                {
                    verif = 0;

                    denProdTb.Text = produs.Denumire;
                    cantitateTb.Text = produs.Cantitate.ToString();
                    tipProdCb.SelectedItem = produs.Tip;
                    pretTb.Text = produs.Pret.ToString();

                    break;
                }
            }
        }

        private void saveToTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                foreach(Produs p in listProd)
                {
                    sw.WriteLine(p);
                }
                sw.Close();
            }
        }

        private void openFromTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|*.txt";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string text = sr.ReadToEnd();
                Form2 form2 = new Form2(text);
                form2.ShowDialog();
                sr.Close();
            }
        }
    }
}
