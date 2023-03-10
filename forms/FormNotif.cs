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
    public partial class FormNotif : Form
    {
        public FormNotif()
        {
            InitializeComponent();
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
            lblLNote.ForeColor = ThemeColor.primaryColor;
            lblTries.ForeColor = ThemeColor.secondaryColor;
        }

        private void lblCode_Click(object sender, EventArgs e)
        {
            txt_code_notif.Focus();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            txt_name_notif.Focus();
        }

        private void lbltype_Click(object sender, EventArgs e)
        {
            txt_type_notif.Focus();
        }

        private void lblQte_Click(object sender, EventArgs e)
        {
            txt_qte_notif.Focus();
        }

        private void lblPrix_Click(object sender, EventArgs e)
        {
            txt_prix_notif.Focus();
        }

        private void lblFour_Click(object sender, EventArgs e)
        {
            txt_four_notif.Focus();
        }

        private void Notifications_Load(object sender, EventArgs e)
        {

        }


    }
}
