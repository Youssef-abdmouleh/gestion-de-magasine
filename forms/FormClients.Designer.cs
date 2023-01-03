using System;

namespace MarketManagment.forms
{
    partial class FormClients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_client = new System.Windows.Forms.DataGridView();
            this.btn_ajou_client = new System.Windows.Forms.Button();
            this.btn_mod_client = new System.Windows.Forms.Button();
            this.btn_sup_client = new System.Windows.Forms.Button();
            this.txt_cin_client = new System.Windows.Forms.TextBox();
            this.txt_pren_client = new System.Windows.Forms.TextBox();
            this.txt_name_client = new System.Windows.Forms.TextBox();
            this.lblCIN = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_rad_tele_client = new System.Windows.Forms.RadioButton();
            this.btn_rad_vil_client = new System.Windows.Forms.RadioButton();
            this.btn_rad_name_client = new System.Windows.Forms.RadioButton();
            this.btn_rad_cin_client = new System.Windows.Forms.RadioButton();
            this.btn_rad_pren_client = new System.Windows.Forms.RadioButton();
            this.lblPren = new System.Windows.Forms.Label();
            this.lblVil = new System.Windows.Forms.Label();
            this.txt_vil_client = new System.Windows.Forms.TextBox();
            this.lblTele = new System.Windows.Forms.Label();
            this.txt_tele_client = new System.Windows.Forms.TextBox();
            this.lblCart = new System.Windows.Forms.Label();
            this.txt_cart_client = new System.Windows.Forms.TextBox();
            this.lblTries = new System.Windows.Forms.Label();
            this.lblLCL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_client
            // 
            this.dgv_client.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_client.Location = new System.Drawing.Point(539, 71);
            this.dgv_client.Name = "dgv_client";
            this.dgv_client.Size = new System.Drawing.Size(410, 258);
            this.dgv_client.TabIndex = 0;
            this.dgv_client.DoubleClick += new System.EventHandler(this.dgv_client_DoubleClick);
            // 
            // btn_ajou_client
            // 
            this.btn_ajou_client.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ajou_client.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_ajou_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajou_client.Location = new System.Drawing.Point(539, 392);
            this.btn_ajou_client.Name = "btn_ajou_client";
            this.btn_ajou_client.Size = new System.Drawing.Size(110, 46);
            this.btn_ajou_client.TabIndex = 1;
            this.btn_ajou_client.Text = "Ajouter";
            this.btn_ajou_client.UseVisualStyleBackColor = true;
            this.btn_ajou_client.Click += new System.EventHandler(this.btn_ajou_client_Click);
            // 
            // btn_mod_client
            // 
            this.btn_mod_client.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mod_client.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_mod_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mod_client.Location = new System.Drawing.Point(839, 392);
            this.btn_mod_client.Name = "btn_mod_client";
            this.btn_mod_client.Size = new System.Drawing.Size(110, 46);
            this.btn_mod_client.TabIndex = 2;
            this.btn_mod_client.Text = "Modifier";
            this.btn_mod_client.UseVisualStyleBackColor = true;
            this.btn_mod_client.Click += new System.EventHandler(this.btn_mod_client_Click);
            // 
            // btn_sup_client
            // 
            this.btn_sup_client.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sup_client.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_sup_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sup_client.Location = new System.Drawing.Point(689, 392);
            this.btn_sup_client.Name = "btn_sup_client";
            this.btn_sup_client.Size = new System.Drawing.Size(110, 46);
            this.btn_sup_client.TabIndex = 3;
            this.btn_sup_client.Text = "Supprimer";
            this.btn_sup_client.UseVisualStyleBackColor = true;
            this.btn_sup_client.Click += new System.EventHandler(this.btn_sup_client_Click);
            // 
            // txt_cin_client
            // 
            this.txt_cin_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cin_client.Location = new System.Drawing.Point(130, 33);
            this.txt_cin_client.Name = "txt_cin_client";
            this.txt_cin_client.Size = new System.Drawing.Size(100, 23);
            this.txt_cin_client.TabIndex = 5;
            this.txt_cin_client.TextChanged += new System.EventHandler(this.Get_Clients);
            // 
            // txt_pren_client
            // 
            this.txt_pren_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pren_client.Location = new System.Drawing.Point(130, 110);
            this.txt_pren_client.Name = "txt_pren_client";
            this.txt_pren_client.Size = new System.Drawing.Size(100, 23);
            this.txt_pren_client.TabIndex = 7;
            this.txt_pren_client.TextChanged += new System.EventHandler(this.Get_Clients);
            // 
            // txt_name_client
            // 
            this.txt_name_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_client.Location = new System.Drawing.Point(130, 71);
            this.txt_name_client.Name = "txt_name_client";
            this.txt_name_client.Size = new System.Drawing.Size(100, 23);
            this.txt_name_client.TabIndex = 9;
            this.txt_name_client.TextChanged += new System.EventHandler(this.Get_Clients);
            // 
            // lblCIN
            // 
            this.lblCIN.AutoSize = true;
            this.lblCIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCIN.Location = new System.Drawing.Point(36, 36);
            this.lblCIN.Name = "lblCIN";
            this.lblCIN.Size = new System.Drawing.Size(30, 17);
            this.lblCIN.TabIndex = 4;
            this.lblCIN.Text = "CIN";
            this.lblCIN.Click += new System.EventHandler(this.lblCIN_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(36, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 17);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Nom";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 13;
            // 
            // btn_rad_tele_client
            // 
            this.btn_rad_tele_client.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_rad_tele_client.AutoSize = true;
            this.btn_rad_tele_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rad_tele_client.Location = new System.Drawing.Point(148, 367);
            this.btn_rad_tele_client.Name = "btn_rad_tele_client";
            this.btn_rad_tele_client.Padding = new System.Windows.Forms.Padding(5);
            this.btn_rad_tele_client.Size = new System.Drawing.Size(104, 31);
            this.btn_rad_tele_client.TabIndex = 4;
            this.btn_rad_tele_client.TabStop = true;
            this.btn_rad_tele_client.Text = "Telephone";
            this.btn_rad_tele_client.UseVisualStyleBackColor = true;
            this.btn_rad_tele_client.CheckedChanged += new System.EventHandler(this.btn_rad_tele_client_CheckedChanged);
            // 
            // btn_rad_vil_client
            // 
            this.btn_rad_vil_client.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_rad_vil_client.AutoSize = true;
            this.btn_rad_vil_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rad_vil_client.Location = new System.Drawing.Point(148, 334);
            this.btn_rad_vil_client.Name = "btn_rad_vil_client";
            this.btn_rad_vil_client.Padding = new System.Windows.Forms.Padding(5);
            this.btn_rad_vil_client.Size = new System.Drawing.Size(62, 31);
            this.btn_rad_vil_client.TabIndex = 3;
            this.btn_rad_vil_client.TabStop = true;
            this.btn_rad_vil_client.Text = "Ville";
            this.btn_rad_vil_client.UseVisualStyleBackColor = true;
            this.btn_rad_vil_client.CheckedChanged += new System.EventHandler(this.btn_rad_vil_client_CheckedChanged);
            // 
            // btn_rad_name_client
            // 
            this.btn_rad_name_client.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_rad_name_client.AutoSize = true;
            this.btn_rad_name_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rad_name_client.Location = new System.Drawing.Point(42, 367);
            this.btn_rad_name_client.Name = "btn_rad_name_client";
            this.btn_rad_name_client.Padding = new System.Windows.Forms.Padding(5);
            this.btn_rad_name_client.Size = new System.Drawing.Size(65, 31);
            this.btn_rad_name_client.TabIndex = 2;
            this.btn_rad_name_client.TabStop = true;
            this.btn_rad_name_client.Text = "Nom";
            this.btn_rad_name_client.UseVisualStyleBackColor = true;
            this.btn_rad_name_client.CheckedChanged += new System.EventHandler(this.btn_rad_name_client_CheckedChanged);
            // 
            // btn_rad_cin_client
            // 
            this.btn_rad_cin_client.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_rad_cin_client.AutoSize = true;
            this.btn_rad_cin_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rad_cin_client.Location = new System.Drawing.Point(42, 334);
            this.btn_rad_cin_client.Name = "btn_rad_cin_client";
            this.btn_rad_cin_client.Padding = new System.Windows.Forms.Padding(5);
            this.btn_rad_cin_client.Size = new System.Drawing.Size(58, 31);
            this.btn_rad_cin_client.TabIndex = 1;
            this.btn_rad_cin_client.TabStop = true;
            this.btn_rad_cin_client.Text = "CIN";
            this.btn_rad_cin_client.UseVisualStyleBackColor = true;
            this.btn_rad_cin_client.CheckedChanged += new System.EventHandler(this.btn_rad_cin_client_CheckedChanged);
            // 
            // btn_rad_pren_client
            // 
            this.btn_rad_pren_client.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_rad_pren_client.AutoSize = true;
            this.btn_rad_pren_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rad_pren_client.Location = new System.Drawing.Point(42, 400);
            this.btn_rad_pren_client.Name = "btn_rad_pren_client";
            this.btn_rad_pren_client.Padding = new System.Windows.Forms.Padding(5);
            this.btn_rad_pren_client.Size = new System.Drawing.Size(85, 31);
            this.btn_rad_pren_client.TabIndex = 0;
            this.btn_rad_pren_client.TabStop = true;
            this.btn_rad_pren_client.Text = "Prenom";
            this.btn_rad_pren_client.UseVisualStyleBackColor = true;
            this.btn_rad_pren_client.CheckedChanged += new System.EventHandler(this.btn_rad_pren_client_CheckedChanged);
            // 
            // lblPren
            // 
            this.lblPren.AutoSize = true;
            this.lblPren.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPren.Location = new System.Drawing.Point(36, 113);
            this.lblPren.Name = "lblPren";
            this.lblPren.Size = new System.Drawing.Size(57, 17);
            this.lblPren.TabIndex = 6;
            this.lblPren.Text = "Prenom";
            this.lblPren.Click += new System.EventHandler(this.lblPren_Click);
            // 
            // lblVil
            // 
            this.lblVil.AutoSize = true;
            this.lblVil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVil.Location = new System.Drawing.Point(36, 154);
            this.lblVil.Name = "lblVil";
            this.lblVil.Size = new System.Drawing.Size(34, 17);
            this.lblVil.TabIndex = 10;
            this.lblVil.Text = "Ville";
            this.lblVil.Click += new System.EventHandler(this.lblVil_Click);
            // 
            // txt_vil_client
            // 
            this.txt_vil_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vil_client.Location = new System.Drawing.Point(130, 151);
            this.txt_vil_client.Name = "txt_vil_client";
            this.txt_vil_client.Size = new System.Drawing.Size(100, 23);
            this.txt_vil_client.TabIndex = 11;
            this.txt_vil_client.TextChanged += new System.EventHandler(this.Get_Clients);
            // 
            // lblTele
            // 
            this.lblTele.AutoSize = true;
            this.lblTele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTele.Location = new System.Drawing.Point(39, 194);
            this.lblTele.Name = "lblTele";
            this.lblTele.Size = new System.Drawing.Size(76, 17);
            this.lblTele.TabIndex = 12;
            this.lblTele.Text = "Telephone";
            this.lblTele.Click += new System.EventHandler(this.lblTele_Click);
            // 
            // txt_tele_client
            // 
            this.txt_tele_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tele_client.Location = new System.Drawing.Point(130, 191);
            this.txt_tele_client.Name = "txt_tele_client";
            this.txt_tele_client.Size = new System.Drawing.Size(100, 23);
            this.txt_tele_client.TabIndex = 13;
            this.txt_tele_client.TextChanged += new System.EventHandler(this.Get_Clients);
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.Location = new System.Drawing.Point(39, 232);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(66, 17);
            this.lblCart.TabIndex = 14;
            this.lblCart.Text = "Carte ****";
            this.lblCart.Click += new System.EventHandler(this.lblCart_Click);
            // 
            // txt_cart_client
            // 
            this.txt_cart_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cart_client.Location = new System.Drawing.Point(130, 229);
            this.txt_cart_client.Name = "txt_cart_client";
            this.txt_cart_client.Size = new System.Drawing.Size(100, 23);
            this.txt_cart_client.TabIndex = 15;
            this.txt_cart_client.TextChanged += new System.EventHandler(this.Get_Clients);
            // 
            // lblTries
            // 
            this.lblTries.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTries.AutoSize = true;
            this.lblTries.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTries.Location = new System.Drawing.Point(39, 304);
            this.lblTries.Name = "lblTries";
            this.lblTries.Size = new System.Drawing.Size(45, 17);
            this.lblTries.TabIndex = 22;
            this.lblTries.Text = "Tries";
            // 
            // lblLCL
            // 
            this.lblLCL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLCL.AutoSize = true;
            this.lblLCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLCL.Location = new System.Drawing.Point(536, 33);
            this.lblLCL.Name = "lblLCL";
            this.lblLCL.Size = new System.Drawing.Size(126, 17);
            this.lblLCL.TabIndex = 23;
            this.lblLCL.Text = "Liste des clients";
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(973, 470);
            this.Controls.Add(this.lblLCL);
            this.Controls.Add(this.lblTries);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.btn_rad_tele_client);
            this.Controls.Add(this.txt_cart_client);
            this.Controls.Add(this.btn_rad_vil_client);
            this.Controls.Add(this.lblTele);
            this.Controls.Add(this.btn_rad_name_client);
            this.Controls.Add(this.btn_rad_cin_client);
            this.Controls.Add(this.txt_tele_client);
            this.Controls.Add(this.btn_rad_pren_client);
            this.Controls.Add(this.lblVil);
            this.Controls.Add(this.txt_vil_client);
            this.Controls.Add(this.lblPren);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCIN);
            this.Controls.Add(this.txt_name_client);
            this.Controls.Add(this.txt_pren_client);
            this.Controls.Add(this.txt_cin_client);
            this.Controls.Add(this.btn_sup_client);
            this.Controls.Add(this.btn_mod_client);
            this.Controls.Add(this.btn_ajou_client);
            this.Controls.Add(this.dgv_client);
            this.Name = "Clients";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.DataGridView dgv_client;
        private System.Windows.Forms.Button btn_ajou_client;
        private System.Windows.Forms.Button btn_mod_client;
        private System.Windows.Forms.Button btn_sup_client;
        private System.Windows.Forms.TextBox txt_cin_client;
        private System.Windows.Forms.TextBox txt_pren_client;
        private System.Windows.Forms.TextBox txt_name_client;
        private System.Windows.Forms.Label lblCIN;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton btn_rad_name_client;
        private System.Windows.Forms.RadioButton btn_rad_cin_client;
        private System.Windows.Forms.RadioButton btn_rad_pren_client;
        private System.Windows.Forms.Label lblPren;
        private System.Windows.Forms.RadioButton btn_rad_tele_client;
        private System.Windows.Forms.RadioButton btn_rad_vil_client;
        private System.Windows.Forms.Label lblVil;
        private System.Windows.Forms.TextBox txt_vil_client;
        private System.Windows.Forms.Label lblTele;
        private System.Windows.Forms.TextBox txt_tele_client;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.TextBox txt_cart_client;
        private System.Windows.Forms.Label lblTries;
        private System.Windows.Forms.Label lblLCL;
    }
}