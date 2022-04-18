using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieComert
{
    [Serializable]
    class Produs
    {
        private string denumire;
        private double cantitate;
        private string tip;
        private double pret;

        public Produs(string denumire, double cantitate, string tip,double pret)
        {
            this.denumire = denumire;
            this.cantitate = cantitate;
            this.tip = tip;
            this.pret = pret;
        }

        public string Denumire
        {
            get { return denumire;}
            set{ this.denumire = value;}
        }

        public double Cantitate
        {
            get { return cantitate; }
            set { this.cantitate = value; }
        }

        public string Tip
        {
            get { return tip; }
            set { tip = value; }
        }
    
        public double Pret
        {
            get { return pret; }
            set { pret = value; }
        }

        public override string ToString()
        {
            string mesaj =  "Denum:" + denumire + ", cant:" + cantitate + ", tip:" + tip +
                ", pret:" + pret;

            return mesaj;
        }
    }
}
