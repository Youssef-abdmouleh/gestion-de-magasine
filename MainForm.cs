using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

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
            btn_close_childForms.Visible = false;
            random = new Random();
            this.ControlBox = false;
            this.Text = string.Empty;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void pan_Title_MouseDown(object sender, MouseEventArgs e)
        {
            RealiseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RealiseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
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
                    ThemeColor.secondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.primaryColor = color;
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pan_Logo.BackColor = ThemeColor.secondaryColor;
                    pan_Title.BackColor = ThemeColor.primaryColor;
                    btn_close_childForms.Visible = true;
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
            Title.Text = childForm.Text;



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
            OpenChildForm(sender, new forms.FormProduits());
        }

        private void btn_ord_Click(object sender, EventArgs e)
        {
            OpenChildForm(sender, new forms.FormOrders());
        }

        private void btn_clt_Click(object sender, EventArgs e)
        {
            OpenChildForm(sender, new forms.FormClients());
        }

        private void btn_rpo_Click(object sender, EventArgs e)
        {
            OpenChildForm(sender, new forms.FormRap());
        }

        private void btn_notif_Click(object sender, EventArgs e)
        {
            OpenChildForm(sender, new forms.FormNotif());
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            OpenChildForm(sender, new forms.FormSet());
        }

        private void btn_close_childForms_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                Reset();

            }
        }

        private void Reset()
        {
            DisableButton();
            Title.Text = "HOME";
            btn_close_childForms.Visible = false;
            pan_Title.BackColor = Color.FromArgb(0, 150, 136);
            pan_Logo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
        }
        private void btn_close_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.Red;
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_maxi_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btn_mini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
