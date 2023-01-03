using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MarketManagment.Classes
{
    public class Produit
    {
        public Int64 Code_Pd { get; set; }
        public string Nom_Pd { get; set; }
        public Int64 Prix_Pd { get; set; }
        public Int64 Quantite_Pd { get; set; }
        public string Type_Pd { get; set; }
        public string Four_Pd { get; set; }
    }

}

