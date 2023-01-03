using MarketManagment.Classes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MarketManagment.forms
{
    public partial class FormClients : Form
    {
        public FormClients()
        {
            InitializeComponent();
            ClientADO.Liste_Client();
        }
        
        private void Clients_Load(object sender, EventArgs e)
        {
            LoadTheme();
            
        }
            ClientADO Client = new ClientADO();
            Client C = new Client();
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.primaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.secondaryColor;
                }
            }
            lblLCL.ForeColor = ThemeColor.primaryColor;
            lblTries.ForeColor = ThemeColor.secondaryColor;
        }

        private void lblCIN_Click(object sender, EventArgs e)
        {
            txt_cin_client.Focus();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            txt_name_client.Focus();
        }

        private void lblPren_Click(object sender, EventArgs e)
        {
            txt_pren_client.Focus();
        }

        private void lblVil_Click(object sender, EventArgs e)
        {
            txt_vil_client.Focus();
        }

        private void lblTele_Click(object sender, EventArgs e)
        {
            txt_tele_client.Focus();
        }

        private void lblCart_Click(object sender, EventArgs e)
        {
            txt_cart_client.Focus();
        }

        private void Get_Clients(object sender, EventArgs e)
        {
            Int64 Cin = 0;
            Int64 Tele = 0;
            Int64 Cart = 0;
            String Nom = "%";
            String Pren = "%";
            String Vil = "%";
            if (!String.IsNullOrEmpty(txt_cin_client.Text))
            {
                double len = 8 - txt_cin_client.TextLength;
                Cin = Convert.ToInt64(txt_cin_client.Text) * Convert.ToInt64(Math.Pow(10, len));
            }
            if (!String.IsNullOrEmpty(txt_tele_client.Text))
            {
                double len = 8 - txt_tele_client.TextLength;
                Tele = Convert.ToInt64(txt_tele_client.Text) * Convert.ToInt64(Math.Pow(10, len)); ;
            }
            if (!String.IsNullOrEmpty(txt_cart_client.Text))
            {
                double len = 13 - txt_cart_client.TextLength;
                Cart = Convert.ToInt64(txt_cart_client.Text) * Convert.ToInt64(Math.Pow(10, len));
            }
            Nom = txt_name_client.Text + Nom;

            Pren = txt_pren_client.Text + Pren;

            Vil = txt_vil_client.Text + Vil;

            dgv_client.DataSource = ClientADO.Liste_Client(Cin, Nom, Pren, Vil, Tele, Cart);
        }



        private void btn_ajou_client_Click(object sender, EventArgs e)
        {
            if (txt_cin_client.TextLength == 8)
            {
                C.Cin_Cl = Convert.ToInt64(txt_cin_client.Text);
                C.Pren_Cl = txt_pren_client.Text;
                C.Carte = Convert.ToInt64(txt_cart_client);
                C.Nom_Cl = txt_name_client.Text;
                C.Ville_Cl = txt_vil_client.Text;
                C.Tel_Cl = Convert.ToInt64(txt_tele_client.Text);
                if (!ClientADO.Existe_Client(Convert.ToInt64(txt_cin_client.Text)))                
                    Client.Inserer(C);
                else
                        MessageBox.Show("le code client a ete existe !!");
                }
                else
                    MessageBox.Show("complet le CIN de client  !!");
            }

        private void btn_sup_client_Click(object sender, EventArgs e)
        {
            long cin = Convert.ToInt64(txt_cin_client.Text);
            if (ClientADO.Existe_Client(cin))
                Client.Supprimer(cin);
            else
                MessageBox.Show(" le client n'est pas existe !!");
        }

        private void btn_mod_client_Click(object sender, EventArgs e)
        {
            C.Cin_Cl = Convert.ToInt64(txt_cin_client.Text);
            C.Pren_Cl = txt_pren_client.Text;
            C.Carte = Convert.ToInt64(txt_cart_client);
            C.Nom_Cl = txt_name_client.Text;
            C.Ville_Cl = txt_vil_client.Text;
            C.Tel_Cl = Convert.ToInt64(txt_tele_client.Text);
            if (ClientADO.Existe_Client(C.Cin_Cl))
                Client.Modifier(C);

        }

        private void btn_rad_cin_client_CheckedChanged(object sender, EventArgs e)
        {
            Get_Clients(sender, null);
            dgv_client.Sort(dgv_client.Columns[0], ListSortDirection.Ascending);
        }

        private void btn_rad_name_client_CheckedChanged(object sender, EventArgs e)
        {
            Get_Clients(sender, null);
            dgv_client.Sort(dgv_client.Columns[1], ListSortDirection.Ascending);
        }

        private void btn_rad_pren_client_CheckedChanged(object sender, EventArgs e)
        {
            Get_Clients(sender, null);
            dgv_client.Sort(dgv_client.Columns[2], ListSortDirection.Ascending);
        }

        private void btn_rad_vil_client_CheckedChanged(object sender, EventArgs e)
        {
            Get_Clients(sender, null);
            dgv_client.Sort(dgv_client.Columns[3], ListSortDirection.Ascending);
        }

        private void btn_rad_tele_client_CheckedChanged(object sender, EventArgs e)
        {
            Get_Clients(sender, null);
            dgv_client.Sort(dgv_client.Columns[4], ListSortDirection.Ascending);
        }



        private void dgv_client_DoubleClick(object sender, EventArgs e)
        {
            int i = dgv_client.CurrentRow.Index;
            txt_cin_client.Text = dgv_client.Rows[i].Cells[0].Value.ToString();
            txt_name_client.Text = dgv_client.Rows[i].Cells[1].Value.ToString();
            txt_pren_client.Text = dgv_client.Rows[i].Cells[2].Value.ToString();
            txt_vil_client.Text = dgv_client.Rows[i].Cells[3].Value.ToString();
            txt_tele_client.Text = dgv_client.Rows[i].Cells[4].Value.ToString();
            txt_cart_client.Text = dgv_client.Rows[i].Cells[5].Value.ToString();

        }
    }
}
