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
    public partial class FormRap : Form
    {
        public FormRap()
        {
            InitializeComponent();
        }
        private void Rapports_Load(object sender, EventArgs e)
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
            lblLRap.ForeColor = ThemeColor.primaryColor;
            lblTries.ForeColor = ThemeColor.secondaryColor;
        }

        private void lblCode_Click(object sender, EventArgs e)
        {
            txt_code_rapp.Focus();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            txt_name_rapp.Focus();
        }

        private void lbltype_Click(object sender, EventArgs e)
        {
            txt_type_rapp.Focus();
        }

        private void lblQte_Click(object sender, EventArgs e)
        {
            txt_qte_rapp.Focus();
        }

        private void lblPrix_Click(object sender, EventArgs e)
        {
            txt_prix_rapp.Focus();
        }

        private void lblFour_Click(object sender, EventArgs e)
        {
            txt_four_rapp.Focus();
        }

       


    }
}
