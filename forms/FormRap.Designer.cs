using System;

namespace MarketManagment.forms
{
    partial class FormRap
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
            this.dgv_rapp = new System.Windows.Forms.DataGridView();
            this.btn_ajou_rapp = new System.Windows.Forms.Button();
            this.btn_mod_rapp = new System.Windows.Forms.Button();
            this.btn_sup_rapp = new System.Windows.Forms.Button();
            this.txt_code_rapp = new System.Windows.Forms.TextBox();
            this.txt_type_rapp = new System.Windows.Forms.TextBox();
            this.txt_name_rapp = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_rad_four_rapp = new System.Windows.Forms.RadioButton();
            this.btn_rad_prix_rapp = new System.Windows.Forms.RadioButton();
            this.btn_rad_qte_rapp = new System.Windows.Forms.RadioButton();
            this.btn_rad_type_rapp = new System.Windows.Forms.RadioButton();
            this.btn_rad_code_rapp = new System.Windows.Forms.RadioButton();
            this.btn_rad_name_rapp = new System.Windows.Forms.RadioButton();
            this.lbltype = new System.Windows.Forms.Label();
            this.lblQte = new System.Windows.Forms.Label();
            this.txt_qte_rapp = new System.Windows.Forms.TextBox();
            this.lblPrix = new System.Windows.Forms.Label();
            this.txt_prix_rapp = new System.Windows.Forms.TextBox();
            this.lblFour = new System.Windows.Forms.Label();
            this.txt_four_rapp = new System.Windows.Forms.TextBox();
            this.lblTries = new System.Windows.Forms.Label();
            this.lblLRap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rapp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_rapp
            // 
            this.dgv_rapp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_rapp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rapp.Location = new System.Drawing.Point(539, 71);
            this.dgv_rapp.Name = "dgv_rapp";
            this.dgv_rapp.Size = new System.Drawing.Size(410, 258);
            this.dgv_rapp.TabIndex = 0;
            // 
            // btn_ajou_rapp
            // 
            this.btn_ajou_rapp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ajou_rapp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_ajou_rapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajou_rapp.Location = new System.Drawing.Point(539, 392);
            this.btn_ajou_rapp.Name = "btn_ajou_rapp";
            this.btn_ajou_rapp.Size = new System.Drawing.Size(110, 46);
            this.btn_ajou_rapp.TabIndex = 3;
            this.btn_ajou_rapp.Text = "Ajouter";
            this.btn_ajou_rapp.UseVisualStyleBackColor = true;
            // 
            // btn_mod_rapp
            // 
            this.btn_mod_rapp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mod_rapp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_mod_rapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mod_rapp.Location = new System.Drawing.Point(839, 392);
            this.btn_mod_rapp.Name = "btn_mod_rapp";
            this.btn_mod_rapp.Size = new System.Drawing.Size(110, 46);
            this.btn_mod_rapp.TabIndex = 5;
            this.btn_mod_rapp.Text = "Modifier";
            this.btn_mod_rapp.UseVisualStyleBackColor = true;
            // 
            // btn_sup_rapp
            // 
            this.btn_sup_rapp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sup_rapp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_sup_rapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sup_rapp.Location = new System.Drawing.Point(689, 392);
            this.btn_sup_rapp.Name = "btn_sup_rapp";
            this.btn_sup_rapp.Size = new System.Drawing.Size(110, 46);
            this.btn_sup_rapp.TabIndex = 6;
            this.btn_sup_rapp.Text = "Supprimer";
            this.btn_sup_rapp.UseVisualStyleBackColor = true;
            // 
            // txt_code_rapp
            // 
            this.txt_code_rapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_code_rapp.Location = new System.Drawing.Point(130, 33);
            this.txt_code_rapp.Name = "txt_code_rapp";
            this.txt_code_rapp.Size = new System.Drawing.Size(100, 23);
            this.txt_code_rapp.TabIndex = 8;
            // 
            // txt_type_rapp
            // 
            this.txt_type_rapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_type_rapp.Location = new System.Drawing.Point(130, 110);
            this.txt_type_rapp.Name = "txt_type_rapp";
            this.txt_type_rapp.Size = new System.Drawing.Size(100, 23);
            this.txt_type_rapp.TabIndex = 9;
            // 
            // txt_name_rapp
            // 
            this.txt_name_rapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_rapp.Location = new System.Drawing.Point(130, 71);
            this.txt_name_rapp.Name = "txt_name_rapp";
            this.txt_name_rapp.Size = new System.Drawing.Size(100, 23);
            this.txt_name_rapp.TabIndex = 10;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(36, 36);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(41, 17);
            this.lblCode.TabIndex = 11;
            this.lblCode.Text = "Code";
            this.lblCode.Click += new System.EventHandler(this.lblCode_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(36, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 17);
            this.lblName.TabIndex = 12;
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
            // btn_rad_four_rapp
            // 
            this.btn_rad_four_rapp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_rad_four_rapp.AutoSize = true;
            this.btn_rad_four_rapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rad_four_rapp.Location = new System.Drawing.Point(148, 400);
            this.btn_rad_four_rapp.Name = "btn_rad_four_rapp";
            this.btn_rad_four_rapp.Padding = new System.Windows.Forms.Padding(5);
            this.btn_rad_four_rapp.Size = new System.Drawing.Size(107, 31);
            this.btn_rad_four_rapp.TabIndex = 5;
            this.btn_rad_four_rapp.TabStop = true;
            this.btn_rad_four_rapp.Text = "fournisseur";
            this.btn_rad_four_rapp.UseVisualStyleBackColor = true;
            // 
            // btn_rad_prix_rapp
            // 
            this.btn_rad_prix_rapp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_rad_prix_rapp.AutoSize = true;
            this.btn_rad_prix_rapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rad_prix_rapp.Location = new System.Drawing.Point(148, 367);
            this.btn_rad_prix_rapp.Name = "btn_rad_prix_rapp";
            this.btn_rad_prix_rapp.Padding = new System.Windows.Forms.Padding(5);
            this.btn_rad_prix_rapp.Size = new System.Drawing.Size(59, 31);
            this.btn_rad_prix_rapp.TabIndex = 4;
            this.btn_rad_prix_rapp.TabStop = true;
            this.btn_rad_prix_rapp.Text = "Prix";
            this.btn_rad_prix_rapp.UseVisualStyleBackColor = true;
            // 
            // btn_rad_qte_rapp
            // 
            this.btn_rad_qte_rapp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_rad_qte_rapp.AutoSize = true;
            this.btn_rad_qte_rapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rad_qte_rapp.Location = new System.Drawing.Point(148, 334);
            this.btn_rad_qte_rapp.Name = "btn_rad_qte_rapp";
            this.btn_rad_qte_rapp.Padding = new System.Windows.Forms.Padding(5);
            this.btn_rad_qte_rapp.Size = new System.Drawing.Size(95, 31);
            this.btn_rad_qte_rapp.TabIndex = 3;
            this.btn_rad_qte_rapp.TabStop = true;
            this.btn_rad_qte_rapp.Text = "Quantiter";
            this.btn_rad_qte_rapp.UseVisualStyleBackColor = true;
            // 
            // btn_rad_type_rapp
            // 
            this.btn_rad_type_rapp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_rad_type_rapp.AutoSize = true;
            this.btn_rad_type_rapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rad_type_rapp.Location = new System.Drawing.Point(42, 367);
            this.btn_rad_type_rapp.Name = "btn_rad_type_rapp";
            this.btn_rad_type_rapp.Padding = new System.Windows.Forms.Padding(5);
            this.btn_rad_type_rapp.Size = new System.Drawing.Size(68, 31);
            this.btn_rad_type_rapp.TabIndex = 2;
            this.btn_rad_type_rapp.TabStop = true;
            this.btn_rad_type_rapp.Text = "Type";
            this.btn_rad_type_rapp.UseVisualStyleBackColor = true;
            // 
            // btn_rad_code_rapp
            // 
            this.btn_rad_code_rapp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_rad_code_rapp.AutoSize = true;
            this.btn_rad_code_rapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rad_code_rapp.Location = new System.Drawing.Point(42, 334);
            this.btn_rad_code_rapp.Name = "btn_rad_code_rapp";
            this.btn_rad_code_rapp.Padding = new System.Windows.Forms.Padding(5);
            this.btn_rad_code_rapp.Size = new System.Drawing.Size(69, 31);
            this.btn_rad_code_rapp.TabIndex = 1;
            this.btn_rad_code_rapp.TabStop = true;
            this.btn_rad_code_rapp.Text = "Code";
            this.btn_rad_code_rapp.UseVisualStyleBackColor = true;
            // 
            // btn_rad_name_rapp
            // 
            this.btn_rad_name_rapp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_rad_name_rapp.AutoSize = true;
            this.btn_rad_name_rapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rad_name_rapp.Location = new System.Drawing.Point(42, 400);
            this.btn_rad_name_rapp.Name = "btn_rad_name_rapp";
            this.btn_rad_name_rapp.Padding = new System.Windows.Forms.Padding(5);
            this.btn_rad_name_rapp.Size = new System.Drawing.Size(73, 31);
            this.btn_rad_name_rapp.TabIndex = 0;
            this.btn_rad_name_rapp.TabStop = true;
            this.btn_rad_name_rapp.Text = "Name";
            this.btn_rad_name_rapp.UseVisualStyleBackColor = true;
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltype.Location = new System.Drawing.Point(36, 113);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(40, 17);
            this.lbltype.TabIndex = 15;
            this.lbltype.Text = "Type";
            this.lbltype.Click += new System.EventHandler(this.lbltype_Click);
            // 
            // lblQte
            // 
            this.lblQte.AutoSize = true;
            this.lblQte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQte.Location = new System.Drawing.Point(36, 154);
            this.lblQte.Name = "lblQte";
            this.lblQte.Size = new System.Drawing.Size(67, 17);
            this.lblQte.TabIndex = 17;
            this.lblQte.Text = "Quantiter";
            this.lblQte.Click += new System.EventHandler(this.lblQte_Click);
            // 
            // txt_qte_rapp
            // 
            this.txt_qte_rapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qte_rapp.Location = new System.Drawing.Point(130, 151);
            this.txt_qte_rapp.Name = "txt_qte_rapp";
            this.txt_qte_rapp.Size = new System.Drawing.Size(100, 23);
            this.txt_qte_rapp.TabIndex = 16;
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrix.Location = new System.Drawing.Point(39, 195);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(31, 17);
            this.lblPrix.TabIndex = 19;
            this.lblPrix.Text = "Prix";
            this.lblPrix.Click += new System.EventHandler(this.lblPrix_Click);
            // 
            // txt_prix_rapp
            // 
            this.txt_prix_rapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prix_rapp.Location = new System.Drawing.Point(130, 192);
            this.txt_prix_rapp.Name = "txt_prix_rapp";
            this.txt_prix_rapp.Size = new System.Drawing.Size(100, 23);
            this.txt_prix_rapp.TabIndex = 18;
            // 
            // lblFour
            // 
            this.lblFour.AutoSize = true;
            this.lblFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFour.Location = new System.Drawing.Point(39, 233);
            this.lblFour.Name = "lblFour";
            this.lblFour.Size = new System.Drawing.Size(78, 17);
            this.lblFour.TabIndex = 21;
            this.lblFour.Text = "Founisseur";
            this.lblFour.Click += new System.EventHandler(this.lblFour_Click);
            // 
            // txt_four_rapp
            // 
            this.txt_four_rapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_four_rapp.Location = new System.Drawing.Point(130, 230);
            this.txt_four_rapp.Name = "txt_four_rapp";
            this.txt_four_rapp.Size = new System.Drawing.Size(100, 23);
            this.txt_four_rapp.TabIndex = 20;
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
            // lblLRap
            // 
            this.lblLRap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLRap.AutoSize = true;
            this.lblLRap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLRap.Location = new System.Drawing.Point(536, 33);
            this.lblLRap.Name = "lblLRap";
            this.lblLRap.Size = new System.Drawing.Size(145, 17);
            this.lblLRap.TabIndex = 23;
            this.lblLRap.Text = "Liste des Rapports";
            // 
            // Rapports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(973, 470);
            this.Controls.Add(this.lblLRap);
            this.Controls.Add(this.lblTries);
            this.Controls.Add(this.btn_rad_four_rapp);
            this.Controls.Add(this.lblFour);
            this.Controls.Add(this.btn_rad_prix_rapp);
            this.Controls.Add(this.txt_four_rapp);
            this.Controls.Add(this.btn_rad_qte_rapp);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.btn_rad_type_rapp);
            this.Controls.Add(this.btn_rad_code_rapp);
            this.Controls.Add(this.txt_prix_rapp);
            this.Controls.Add(this.btn_rad_name_rapp);
            this.Controls.Add(this.lblQte);
            this.Controls.Add(this.txt_qte_rapp);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txt_name_rapp);
            this.Controls.Add(this.txt_type_rapp);
            this.Controls.Add(this.txt_code_rapp);
            this.Controls.Add(this.btn_sup_rapp);
            this.Controls.Add(this.btn_mod_rapp);
            this.Controls.Add(this.btn_ajou_rapp);
            this.Controls.Add(this.dgv_rapp);
            this.Name = "Rapports";
            this.Text = "Rapports";
            this.Load += new System.EventHandler(this.Rapports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rapp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.DataGridView dgv_rapp;
        private System.Windows.Forms.Button btn_ajou_rapp;
        private System.Windows.Forms.Button btn_mod_rapp;
        private System.Windows.Forms.Button btn_sup_rapp;
        private System.Windows.Forms.TextBox txt_code_rapp;
        private System.Windows.Forms.TextBox txt_type_rapp;
        private System.Windows.Forms.TextBox txt_name_rapp;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton btn_rad_type_rapp;
        private System.Windows.Forms.RadioButton btn_rad_code_rapp;
        private System.Windows.Forms.RadioButton btn_rad_name_rapp;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.RadioButton btn_rad_prix_rapp;
        private System.Windows.Forms.RadioButton btn_rad_qte_rapp;
        private System.Windows.Forms.Label lblQte;
        private System.Windows.Forms.TextBox txt_qte_rapp;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.TextBox txt_prix_rapp;
        private System.Windows.Forms.Label lblFour;
        private System.Windows.Forms.TextBox txt_four_rapp;
        private System.Windows.Forms.RadioButton btn_rad_four_rapp;
        private System.Windows.Forms.Label lblTries;
        private System.Windows.Forms.Label lblLRap;
    }
}