using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieComert
{
    class ProdusAlimentar : Produs
    {
        private string dataExpirare;
        public ProdusAlimentar(string denumire, float cantitate, string tip, float pret,string dataExpirare) : base(denumire, cantitate, tip, pret)
        {
            this.dataExpirare = dataExpirare;
        }
    }
}
