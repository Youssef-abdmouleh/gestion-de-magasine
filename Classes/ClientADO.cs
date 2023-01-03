using System;
using System.Data;
using System.Data.SqlClient;

namespace MarketManagment.Classes

{
    public class ClientADO
    {
        public void Inserer(Client C)
        {
            SqlCommand cmdaj = new SqlCommand("insert into Client(Cin_Cl,Nom_Cl,Pren_Cl,Ville_Cl,Tel_Cl,Carte) values (@Cin,@Nom,@Pren,@Ville,@Tel,@Carte)", Connexion.cn);
            cmdaj.Parameters.AddWithValue("@Cin", C.Cin_Cl);
            cmdaj.Parameters.AddWithValue("@Nom", C.Nom_Cl);
            cmdaj.Parameters.AddWithValue("@Pren", C.Pren_Cl);
            cmdaj.Parameters.AddWithValue("@Ville", C.Ville_Cl);
            cmdaj.Parameters.AddWithValue("@Tel", C.Tel_Cl);
            cmdaj.Parameters.AddWithValue("@Carte", C.Carte);
            cmdaj.ExecuteNonQuery();
        }
        public static bool Existe_Client(Int64 Cin)
        {
            SqlCommand cverif = new SqlCommand("select * from Client where Cin_Cl = @Cin", Connexion.cn);
            cverif.Parameters.AddWithValue("@Cin", Cin);
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

        public void Supprimer(Int64 Cin)
        {
            string req = "delete from Client where Cin_Cl = @Cin";
            SqlCommand cmdsupp = new SqlCommand(req, Connexion.cn);
            cmdsupp.Parameters.AddWithValue("@Cin", Cin);
            cmdsupp.ExecuteNonQuery();
        }
        public void Modifier(Client C)
        {
            string req = "update Client set Nom_Cl=@Nom,Pren_Cl=@Pren, Ville_Cl=@Ville, Tel_Cl=@Tel, Carte=@Carte where Cin_Cl =@Cin";
            SqlCommand cmdmaj = new SqlCommand(req, Connexion.cn);
            cmdmaj.Parameters.AddWithValue("@Nom", C.Nom_Cl);
            cmdmaj.Parameters.AddWithValue("@Pren", C.Pren_Cl);
            cmdmaj.Parameters.AddWithValue("@Ville", C.Ville_Cl);
            cmdmaj.Parameters.AddWithValue("@Tel", C.Tel_Cl);
            cmdmaj.Parameters.AddWithValue("@Cin", C.Cin_Cl);
            cmdmaj.Parameters.AddWithValue("@Carte", C.Carte);

            cmdmaj.ExecuteNonQuery();
        }


        public static DataTable Liste_Client()
        {
            DataTable dtcl = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Client", Connexion.cn);
            da.Fill(dtcl);
            return dtcl;
        }



        //"select * from client where Cin_Cl>=@Cin and Nom_Cl = @Nom  and Pren_Cl = @Pren  and Ville_Cl=@Ville and Tel_Cl>=@Tele  and Carte>=@Cart"
        public static DataTable Liste_Client(Int64 Cin, String Nom, String Pren, String Ville, Int64 Tele, Int64 Cart)
        {
            DataTable dtcl = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from client where Cin_Cl>=@Cin and Nom_Cl = @Nom  and Pren_Cl = @Pren  and Ville_Cl=@Ville and Tel_Cl>=@Tele  and Carte>=@Cart", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@Cin", Cin);
            da.SelectCommand.Parameters.AddWithValue("@Nom", Nom);
            da.SelectCommand.Parameters.AddWithValue("@Pren", Pren);
            da.SelectCommand.Parameters.AddWithValue("@Ville", Ville);
            da.SelectCommand.Parameters.AddWithValue("@Tele", Tele);
            da.SelectCommand.Parameters.AddWithValue("@Cart", Cart);

            da.Fill(dtcl);
            return dtcl;
        }
        public static DataTable Liste_Client_Cde(Int64 NCde)
        {
            DataTable dtcl = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select cl.* from Client cl, Commande c where cl.Cin_Cl=c.Cin_Cl and c.Num_Cde=@Num", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@Num", NCde);
            da.Fill(dtcl);
            return dtcl;
        }

    }
}
