using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace MarketManagment
{
    public partial class MainForm : Form
    {
        private Random random;
        private Button currentButton;
        private int tempIndex;
        private Form activeForm;
        public MainForm()
        {
            InitializeComponent();
            random= new Random();
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index=random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pan_Logo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    pan_Title.BackColor = color;
                }
            }
        }


        private void OpenChildForm(object btnSender, Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pan_main.Controls.Add(childForm);
            this.pan_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            Title.Text = childForm.Text; //btnSender.text;
        }




        private void DisableButton()
        {
            foreach (Control previousBtn in pan_Menu.Controls)
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
        }

        private void btn_prod_Click(object sender, EventArgs e)
        {
            OpenChildForm(sender,new forms.FormProd());
        }

        private void btn_ord_Click(object sender, EventArgs e)
        {
            OpenChildForm(sender, new forms.FormOrder());
        }

        private void btn_clt_Click(object sender, EventArgs e)
        {
            OpenChildForm(sender, new forms.FormClients());
        }

        private void btn_rpo_Click(object sender, EventArgs e)
        {
            OpenChildForm(sender, new forms.FormRaport());
        }

        private void btn_notif_Click(object sender, EventArgs e)
        {
            OpenChildForm(sender, new forms.FormNotif());
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            OpenChildForm(sender, new forms.FormSetting());
        }
    }
}
