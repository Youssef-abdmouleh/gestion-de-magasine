using MarketManagment.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketManagment.forms
{
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
        }
        List<Int64> PList=new List<Int64> { };
        List<Int64> QList=new List<long> { };
        Int64 client=new long();
        Int64 price=new long();
        private void Orders_Load(object sender, EventArgs e)
        {
            LoadTheme();

        }
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
            lblLOrd.ForeColor = ThemeColor.primaryColor;
            
        }

        private void lblCode_Click(object sender, EventArgs e)
        {
            txt_clt_ord.Focus();
        }
        private void lblName_Click(object sender, EventArgs e)
        {
            txt_prod_ord.Focus();
        }
        private void lblQte_Click(object sender, EventArgs e)
        {
            txt_qte_ord.Focus();
        }

        private void lblPrix_Click(object sender, EventArgs e)
        {
            txt_prix_ord.Focus();
        }

        private void txt_code_ord_Leave(object sender, EventArgs e)
        {
            if (ClientADO.Existe_Client(Convert.ToInt64(txt_clt_ord.Text)))
            {
                MessageBox.Show("le client n'existe pas !!");
                txt_clt_ord.Focus();
            }else
            {
                client = Convert.ToInt64(txt_clt_ord.Text);
                txt_prod_ord.Focus();
                if (ProduitADO.Existe_Produit(Convert.ToInt64(txt_prod_ord.Text)))
                {
                    dgv_produit.DataSource = ProduitADO.Existe_Produit(Convert.ToInt64(txt_prod_ord.Text));
                }
            }
        }

      

        private void dgv_produit_DoubleClick(object sender, EventArgs e)
        {
            int i = dgv_produit.CurrentRow.Index;
            price=Convert.ToInt64(dgv_produit.Rows[i].Cells[2].Value.ToString());
            txt_prix_ord.Text = price.ToString();
            txt_qte_ord.Text = 1.ToString();
            btn_ajou_ord.Enabled = true;
            txt_qte_ord.Focus();
        }

        private void btn_ajou_ord_Click(object sender, EventArgs e)
        {
            PList.Add(Convert.ToInt64(txt_prod_ord.Text));
            QList.Add(Convert.ToInt64(txt_qte_ord.Text));
            DataGridViewRow row = (DataGridViewRow)dgv_produit.Rows[0].Clone();
            row.Cells[0].Value = txt_nprod_ord.Text;
            row.Cells[1].Value = txt_qte_ord.Text;
            row.Cells[2].Value = txt_prix_ord.Text;
            dgv_produit.Rows.Add(row);
            btn_sup_ord.Enabled = true;
            btn_Commander.Enabled = true;
        }

        private void txt_qte_ord_TextChanged(object sender, EventArgs e)
        {
            txt_prix_ord.Text = (price * Convert.ToInt64(txt_qte_ord.Text)).ToString();
        }

        private void btn_sup_ord_Click(object sender, EventArgs e)
        {
            int i = dgv_ord.CurrentRow.Index;
            dgv_ord.Rows.RemoveAt(i);
            PList.RemoveAt(i);
            QList.RemoveAt(i);
            if (dgv_ord.Rows.Count == 0)
            {
                btn_sup_ord.Enabled = false;
                btn_Commander.Enabled = false;
            }
        }

        private void btn_Commander_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < PList.Count; i++)
            {
                OrderADO.Insert_Cdm(PList[i], QList[i],client);
            }
        }
    }
}
