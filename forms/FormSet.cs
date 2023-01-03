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
    public partial class FormSet : Form
    {
        public FormSet()
        {
            InitializeComponent();
        }
        private void Setting_Load(object sender, EventArgs e)
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
            lblLSet.ForeColor = ThemeColor.primaryColor;
            lblTries.ForeColor = ThemeColor.secondaryColor;
        }

        private void lblCode_Click(object sender, EventArgs e)
        {
            txt_code_set.Focus();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            txt_name_set.Focus();
        }

        private void lbltype_Click(object sender, EventArgs e)
        {
            txt_type_set.Focus();
        }

        private void lblQte_Click(object sender, EventArgs e)
        {
            txt_qte_set.Focus();
        }

        private void lblPrix_Click(object sender, EventArgs e)
        {
            txt_prix_set.Focus();
        }

        private void lblFour_Click(object sender, EventArgs e)
        {
            txt_four_set.Focus();
        }

      


    }
}
