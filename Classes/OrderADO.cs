using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManagment.Classes
{
    internal class OrderADO
    {
        public void Insert_Cdm(Int64 Code_Pd,Int64 Qte, Int64 Code_Cl )
        {
            SqlCommand cmdaj = new SqlCommand("insert into Commande(Code_Cl,Code_Pd,Qte) values (@client,@produit,@Qte)", Connexion.cn);
            cmdaj.Parameters.AddWithValue("@client", Code_Cl);
            cmdaj.Parameters.AddWithValue("@produit", Code_Pd);
            cmdaj.Parameters.AddWithValue("@Qte", Qte);
            cmdaj.ExecuteNonQuery();
        }
    }
}
