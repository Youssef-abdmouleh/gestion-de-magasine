using MarketManagment.Classes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace MarketManagment.forms
{
    public partial class FormProduits : Form
    {
        public FormProduits()
        {
            InitializeComponent();
        }
        private void Produits_Load(object sender, EventArgs e)
        {
            LoadTheme();
           
            dgv_prod.DataSource = ProduitADO.Liste_Produit();
        }
            Produit P = new Produit();
            ProduitADO PADO = new ProduitADO();
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
            lblLPd.ForeColor = ThemeColor.primaryColor;
            lblTries.ForeColor = ThemeColor.secondaryColor;
        }

        private void Get_Produits(object sender, EventArgs e)
        {
            Int64 Code = 0;
            String Nom = "%";
            Int64 Prix = 0;
            Int64 Qte = 0;
            String Type = "%";
            String Four = "%";
            if (!String.IsNullOrEmpty(txt_code_prod.Text))
            {
                double len = 13 - txt_code_prod.TextLength;
                Code = Convert.ToInt64(txt_code_prod.Text) * Convert.ToInt64(Math.Pow(10, len));
            }
            if (!String.IsNullOrEmpty(txt_prix_prod.Text))
            {
                double len = txt_prix_prod.TextLength;
                Prix = Convert.ToInt64(txt_prix_prod.Text) * Convert.ToInt64(Math.Pow(10, len)); ;
            }
            if (!String.IsNullOrEmpty(txt_qte_prod.Text))
            {
                double len = txt_qte_prod.TextLength;
                Qte = Convert.ToInt64(txt_qte_prod.Text) * Convert.ToInt64(Math.Pow(10, len));
            }
            Nom = txt_name_prod.Text + Nom;

            Type = txt_type_prod.Text + Type;

            Four = txt_four_prod.Text + Four;

            dgv_prod.DataSource = ClientADO.Liste_Client(Code, Nom, Type, Four, Prix, Qte);
        }
        private void btn_rad_code_prod_CheckedChanged(object sender, EventArgs e)
        {
            Get_Produits(null,null);
            dgv_prod.Sort(dgv_prod.Columns[0], ListSortDirection.Ascending);

        }       
        private void btn_rad_name_prod_CheckedChanged(object sender, EventArgs e)
        {
            Get_Produits(null, null);
            dgv_prod.Sort(dgv_prod.Columns[1], ListSortDirection.Ascending);
        }  
        private void btn_rad_prix_prod_CheckedChanged(object sender, EventArgs e)
        {
            Get_Produits(null, null);
            dgv_prod.Sort(dgv_prod.Columns[2], ListSortDirection.Ascending);
        }

        private void btn_rad_qte_prod_CheckedChanged(object sender, EventArgs e)
        {
            Get_Produits(null, null);
            dgv_prod.Sort(dgv_prod.Columns[3], ListSortDirection.Ascending);
        } 
        private void btn_rad_type_prod_CheckedChanged(object sender, EventArgs e)
        {
            Get_Produits(null, null);
            dgv_prod.Sort(dgv_prod.Columns[4], ListSortDirection.Ascending);
        }
        private void btn_rad_four_prod_CheckedChanged(object sender, EventArgs e)
        {
            Get_Produits(null, null);
            dgv_prod.Sort(dgv_prod.Columns[5], ListSortDirection.Ascending);
        }
        private void btn_ajou_prod_Click(object sender, EventArgs e)
        {
            if (txt_code_prod.Text.Length == 13)
            {
                P.Code_Pd = Convert.ToInt64(txt_code_prod.Text);
                P.Nom_Pd = txt_name_prod.Text;
                P.Prix_Pd = Convert.ToInt64(txt_prix_prod.Text);
                P.Quantite_Pd = Convert.ToInt64(txt_qte_prod.Text);
                P.Type_Pd = txt_type_prod.Text;
                P.Four_Pd = txt_four_prod.Text;
                if (!ProduitADO.Existe_Produit(Convert.ToInt64(txt_code_prod.Text)))
                    PADO.Inserer(P);
                else
                    MessageBox.Show("le code produit a ete existe !!");
            }
            else
                MessageBox.Show("complet le code produit !!");
        }

        private void btn_sup_prod_Click(object sender, EventArgs e)
        {
            long Code = Convert.ToInt64(txt_code_prod.Text);
            if (ProduitADO.Existe_Produit(Code))
                PADO.Supprimer(Code);
            else
                MessageBox.Show(" le produit n'est pas existe !!");
        }

        private void btn_mod_prod_Click(object sender, EventArgs e)
        {
                P.Code_Pd = Convert.ToInt64(txt_code_prod.Text);
                P.Nom_Pd = txt_name_prod.Text;
                P.Prix_Pd = Convert.ToInt64(txt_prix_prod.Text);
                P.Quantite_Pd = Convert.ToInt64(txt_qte_prod.Text);
                P.Type_Pd = txt_type_prod.Text;
                P.Four_Pd = txt_four_prod.Text;
            if (ProduitADO.Existe_Produit(P.Code_Pd))
                PADO.Modifier(P);
        }
        private void dgv_prod_DoubleClick(object sender, EventArgs e)
        {
            int i = dgv_prod.CurrentRow.Index;
            txt_code_prod.Text = dgv_prod.Rows[i].Cells[0].Value.ToString();
            txt_name_prod.Text = dgv_prod.Rows[i].Cells[1].Value.ToString();
            txt_prix_prod.Text = dgv_prod.Rows[i].Cells[2].Value.ToString();
            txt_qte_prod.Text = dgv_prod.Rows[i].Cells[3].Value.ToString();
            txt_type_prod.Text = dgv_prod.Rows[i].Cells[4].Value.ToString();
            txt_four_prod.Text = dgv_prod.Rows[i].Cells[5].Value.ToString();
        }















        private void lblCode_Click(object sender, EventArgs e)
        {
            txt_code_prod.Focus();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            txt_name_prod.Focus();
        }

        private void lbltype_Click(object sender, EventArgs e)
        {
            txt_type_prod.Focus();
        }

        private void lblQte_Click(object sender, EventArgs e)
        {
            txt_qte_prod.Focus();
        }

        private void lblPrix_Click(object sender, EventArgs e)
        {
            txt_prix_prod.Focus();
        }

        private void lblFour_Click(object sender, EventArgs e)
        {
            txt_four_prod.Focus();
        }

        
    }
}
