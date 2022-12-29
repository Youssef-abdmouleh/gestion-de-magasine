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
    public partial class FormProd : Form
    {
        public FormProd()
        {
            InitializeComponent();
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
