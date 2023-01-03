using System;
using System.Data;
using System.Data.SqlClient;

namespace MarketManagment.Classes

{
    public class ProduitADO
    {
        public void Inserer(Produit P)
        {
            SqlCommand cmdaj = new SqlCommand("insert into Produit(Code_Pd,Nom_Pd,Prix_Pd,Quantite_Pd,Type_Pd,Four_Pd) values (@Code,@Nom,@Prix,@Qte,@Type,@Four)", Connexion.cn);
            cmdaj.Parameters.AddWithValue("@Code", P.Code_Pd);
            cmdaj.Parameters.AddWithValue("@Nom", P.Nom_Pd);
            cmdaj.Parameters.AddWithValue("@Type", P.Type_Pd);
            cmdaj.Parameters.AddWithValue("@Four", P.Four_Pd);
            cmdaj.Parameters.AddWithValue("@Qte", P.Quantite_Pd);
            cmdaj.Parameters.AddWithValue("@Prix", P.Prix_Pd);

            cmdaj.ExecuteNonQuery();
        }
        public static bool Existe_Produit(Int64 Code)
        {
            SqlCommand cverif = new SqlCommand("select * from Produit where Code_Pd = @Code", Connexion.cn);
            cverif.Parameters.AddWithValue("@Code", Code);
            SqlDataReader drverif = cverif.ExecuteReader();
            if (drverif.HasRows == true)
            {
                drverif.Close();
                return true;
            }
            else
            {
                drverif.Close();
                return false;
            }
        }

        public void Supprimer(Int64 Code)
        {
            string req = "delete from Produit where Code_Pd = @Code";
            SqlCommand cmdsupp = new SqlCommand(req, Connexion.cn);
            cmdsupp.Parameters.AddWithValue("@Code", Code);
            cmdsupp.ExecuteNonQuery();
        }
        public void Modifier(Produit P)
        {
            string req = "update Produit set Nom_Pd=@Nom,Prix_Pd=@Prix,Type_Pd=@Type, Four_Pd=@Four, Quantite_Pd=@Qte where Code_Pd =@Code";
            SqlCommand cmdmaj = new SqlCommand(req, Connexion.cn);
            cmdmaj.Parameters.AddWithValue("@Code", P.Code_Pd);
            cmdmaj.Parameters.AddWithValue("@Nom", P.Nom_Pd);
            cmdmaj.Parameters.AddWithValue("@Type", P.Type_Pd);
            cmdmaj.Parameters.AddWithValue("@Four", P.Four_Pd);
            cmdmaj.Parameters.AddWithValue("@Qte", P.Quantite_Pd);
            cmdmaj.Parameters.AddWithValue("@Prix", P.Prix_Pd);
            cmdmaj.ExecuteNonQuery();
        }


        public static DataTable Liste_Produit()
        {
            DataTable dtcl = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Produit", Connexion.cn);
            da.Fill(dtcl);
            return dtcl;
        }

        public static DataTable Liste_Produits(Int64 Code, String Nom, String Type, String Four, Int64 Qte, Int64 Prix )
        {
            DataTable dtcl = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Produit where Code_Pd>=@Code and Nom_Pd = @Nom and Prix_Pd>=@Prix  and Type_Pd = @Type  and Four_Pd=@Four and Quantite_Pd>=@Qte", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@Code", Code);
            da.SelectCommand.Parameters.AddWithValue("@Nom", Nom);
            da.SelectCommand.Parameters.AddWithValue("@Type", Type);
            da.SelectCommand.Parameters.AddWithValue("@Four", Four);
            da.SelectCommand.Parameters.AddWithValue("@Qte", Qte);
            da.SelectCommand.Parameters.AddWithValue("@Prix", Prix);


            da.Fill(dtcl);
            return dtcl;
        }
        public static DataTable Liste_Procuit_Cde(Int64 NCde)
        {
            DataTable dtcl = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select pd.* from Produit pd, Commande c where pd.Code_Pd=c.Code_Pd and c.Num_Cde=@Num", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@Num", NCde);
            da.Fill(dtcl);
            return dtcl;
        }

    }
}
