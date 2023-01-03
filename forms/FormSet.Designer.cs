using System;

namespace MarketManagment.forms
{
    partial class FormSet
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
            this.dgv_set = new System.Windows.Forms.DataGridView();
            this.btn_ajou_set = new System.Windows.Forms.Button();
            this.btn_mod_set = new System.Windows.Forms.Button();
            this.btn_sup_set = new System.Windows.Forms.Button();
            this.txt_code_set = new System.Windows.Forms.TextBox();
            this.txt_type_set = new System.Windows.Forms.TextBox();
            this.txt_name_set = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_rad_four_set = new System.Windows.Forms.RadioButton();
            this.btn_rad_prix_set = new System.Windows.Forms.RadioButton();
            this.btn_rad_qte_set = new System.Windows.Forms.RadioButton();
            this.btn_rad_type_set = new System.Windows.Forms.RadioButton();
            this.btn_rad_code_set = new System.Windows.Forms.RadioButton();
            this.btn_rad_name_set = new System.Windows.Forms.RadioButton();
            this.lbltype = new System.Windows.Forms.Label();
            this.lblQte = new System.Windows.Forms.Label();
            this.txt_qte_set = new System.Windows.Forms.TextBox();
            this.lblPrix = new System.Windows.Forms.Label();
            this.txt_prix_set = new System.Windows.Forms.TextBox();
            this.lblFour = new System.Windows.Forms.Label();
            this.txt_four_set = new System.Windows.Forms.TextBox();
            this.lblTries = new System.Windows.Forms.Label();
            this.lblLSet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_set)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_set
            // 
            this.dgv_set.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_set.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_set.Location = new System.Drawing.Point(539, 71);
            this.dgv_set.Name = "dgv_set";
            this.dgv_set.Size = new System.Drawing.Size(410, 258);
            this.dgv_set.TabIndex = 0;
            // 
            // btn_ajou_set
            // 
            this.btn_ajou_set.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ajou_set.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_ajou_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajou_set.Location = new System.Drawing.Point(539, 392);
            this.btn_ajou_set.Name = "btn_ajou_set";
            this.btn_ajou_set.Size = new System.Drawing.Size(110, 46);
            this.btn_ajou_set.TabIndex = 3;
            this.btn_ajou_set.Text = "Ajouter";
            this.btn_ajou_set.UseVisualStyleBackColor = true;
            // 
            // btn_mod_set
            // 
            this.btn_mod_set.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mod_set.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_mod_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mod_set.Location = new System.Drawing.Point(839, 392);
            this.btn_mod_set.Name = "btn_mod_set";
            this.btn_mod_set.Size = new System.Drawing.Size(110, 46);
            this.btn_mod_set.TabIndex = 5;
            this.btn_mod_set.Text = "Modifier";
            this.btn_mod_set.UseVisualStyleBackColor = true;
            // 
            // btn_sup_set
            // 
            this.btn_sup_set.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sup_set.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_sup_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sup_set.Location = new System.Drawing.Point(689, 392);
            this.btn_sup_set.Name = "btn_sup_set";
            this.btn_sup_set.Size = new System.Drawing.Size(110, 46);
            this.btn_sup_set.TabIndex = 6;
            this.btn_sup_set.Text = "Supprimer";
            this.btn_sup_set.UseVisualStyleBackColor = true;
            // 
            // txt_code_set
            // 
            this.txt_code_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_code_set.Location = new System.Drawing.Point(130, 33);
            this.txt_code_set.Name = "txt_code_set";
            this.txt_code_set.Size = new System.Drawing.Size(100, 23);
            this.txt_code_set.TabIndex = 8;
            // 
            // txt_type_set
            // 
            this.txt_type_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_type_set.Location = new System.Drawing.Point(130, 110);
            this.txt_type_set.Name = "txt_type_set";
            this.txt_type_set.Size = new System.Drawing.Size(100, 23);
            this.txt_type_set.TabIndex = 9;
            // 
            // txt_name_set
            // 
            this.txt_name_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_set.Location = new System.Drawing.Point(130, 71);
            this.txt_name_set.Name = "txt_name_set";
            this.txt_name_set.Size = new System.Drawing.Size(100, 23);
            this.txt_name_set.TabIndex = 10;
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
            // btn_rad_four_set
            // 
            this.btn_rad_four_set.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_rad_four_set.AutoSize = true;
            this.btn_rad_four_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rad_four_set.Location = new System.Drawing.Point(148, 400);
            this.btn_rad_four_set.Name = "btn_rad_four_set";
            this.btn_rad_four_set.Padding = new System.Windows.Forms.Padding(5);
            this.btn_rad_four_set.Size = new System.Drawing.Size(107, 31);
            this.btn_rad_four_set.TabIndex = 5;
            this.btn_rad_four_set.TabStop = true;
            this.btn_rad_four_set.Text = "fournisseur";
            this.btn_rad_four_set.UseVisualStyleBackColor = true;
            // 
            // btn_rad_prix_set
            // 
            this.btn_rad_prix_set.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_rad_prix_set.AutoSize = true;
            this.btn_rad_prix_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rad_prix_set.Location = new System.Drawing.Point(148, 367);
            this.btn_rad_prix_set.Name = "btn_rad_prix_set";
            this.btn_rad_prix_set.Padding = new System.Windows.Forms.Padding(5);
            this.btn_rad_prix_set.Size = new System.Drawing.Size(59, 31);
            this.btn_rad_prix_set.TabIndex = 4;
            this.btn_rad_prix_set.TabStop = true;
            this.btn_rad_prix_set.Text = "Prix";
            this.btn_rad_prix_set.UseVisualStyleBackColor = true;
            // 
            // btn_rad_qte_set
            // 
            this.btn_rad_qte_set.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_rad_qte_set.AutoSize = true;
            this.btn_rad_qte_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rad_qte_set.Location = new System.Drawing.Point(148, 334);
            this.btn_rad_qte_set.Name = "btn_rad_qte_set";
            this.btn_rad_qte_set.Padding = new System.Windows.Forms.Padding(5);
            this.btn_rad_qte_set.Size = new System.Drawing.Size(95, 31);
            this.btn_rad_qte_set.TabIndex = 3;
            this.btn_rad_qte_set.TabStop = true;
            this.btn_rad_qte_set.Text = "Quantiter";
            this.btn_rad_qte_set.UseVisualStyleBackColor = true;
            // 
            // btn_rad_type_set
            // 
            this.btn_rad_type_set.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_rad_type_set.AutoSize = true;
            this.btn_rad_type_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rad_type_set.Location = new System.Drawing.Point(42, 367);
            this.btn_rad_type_set.Name = "btn_rad_type_set";
            this.btn_rad_type_set.Padding = new System.Windows.Forms.Padding(5);
            this.btn_rad_type_set.Size = new System.Drawing.Size(68, 31);
            this.btn_rad_type_set.TabIndex = 2;
            this.btn_rad_type_set.TabStop = true;
            this.btn_rad_type_set.Text = "Type";
            this.btn_rad_type_set.UseVisualStyleBackColor = true;
            // 
            // btn_rad_code_set
            // 
            this.btn_rad_code_set.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_rad_code_set.AutoSize = true;
            this.btn_rad_code_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rad_code_set.Location = new System.Drawing.Point(42, 334);
            this.btn_rad_code_set.Name = "btn_rad_code_set";
            this.btn_rad_code_set.Padding = new System.Windows.Forms.Padding(5);
            this.btn_rad_code_set.Size = new System.Drawing.Size(69, 31);
            this.btn_rad_code_set.TabIndex = 1;
            this.btn_rad_code_set.TabStop = true;
            this.btn_rad_code_set.Text = "Code";
            this.btn_rad_code_set.UseVisualStyleBackColor = true;
            // 
            // btn_rad_name_set
            // 
            this.btn_rad_name_set.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_rad_name_set.AutoSize = true;
            this.btn_rad_name_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rad_name_set.Location = new System.Drawing.Point(42, 400);
            this.btn_rad_name_set.Name = "btn_rad_name_set";
            this.btn_rad_name_set.Padding = new System.Windows.Forms.Padding(5);
            this.btn_rad_name_set.Size = new System.Drawing.Size(73, 31);
            this.btn_rad_name_set.TabIndex = 0;
            this.btn_rad_name_set.TabStop = true;
            this.btn_rad_name_set.Text = "Name";
            this.btn_rad_name_set.UseVisualStyleBackColor = true;
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
            // txt_qte_set
            // 
            this.txt_qte_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qte_set.Location = new System.Drawing.Point(130, 151);
            this.txt_qte_set.Name = "txt_qte_set";
            this.txt_qte_set.Size = new System.Drawing.Size(100, 23);
            this.txt_qte_set.TabIndex = 16;
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrix.Location = new System.Drawing.Point(39, 194);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(31, 17);
            this.lblPrix.TabIndex = 19;
            this.lblPrix.Text = "Prix";
            this.lblPrix.Click += new System.EventHandler(this.lblPrix_Click);
            // 
            // txt_prix_set
            // 
            this.txt_prix_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prix_set.Location = new System.Drawing.Point(130, 191);
            this.txt_prix_set.Name = "txt_prix_set";
            this.txt_prix_set.Size = new System.Drawing.Size(100, 23);
            this.txt_prix_set.TabIndex = 18;
            // 
            // lblFour
            // 
            this.lblFour.AutoSize = true;
            this.lblFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFour.Location = new System.Drawing.Point(39, 232);
            this.lblFour.Name = "lblFour";
            this.lblFour.Size = new System.Drawing.Size(78, 17);
            this.lblFour.TabIndex = 21;
            this.lblFour.Text = "Founisseur";
            this.lblFour.Click += new System.EventHandler(this.lblFour_Click);
            // 
            // txt_four_set
            // 
            this.txt_four_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_four_set.Location = new System.Drawing.Point(130, 229);
            this.txt_four_set.Name = "txt_four_set";
            this.txt_four_set.Size = new System.Drawing.Size(100, 23);
            this.txt_four_set.TabIndex = 20;
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
            // lblLSet
            // 
            this.lblLSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLSet.AutoSize = true;
            this.lblLSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLSet.Location = new System.Drawing.Point(536, 33);
            this.lblLSet.Name = "lblLSet";
            this.lblLSet.Size = new System.Drawing.Size(130, 17);
            this.lblLSet.TabIndex = 23;
            this.lblLSet.Text = "Liste des Setting";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(973, 470);
            this.Controls.Add(this.lblLSet);
            this.Controls.Add(this.lblTries);
            this.Controls.Add(this.btn_rad_four_set);
            this.Controls.Add(this.lblFour);
            this.Controls.Add(this.btn_rad_prix_set);
            this.Controls.Add(this.txt_four_set);
            this.Controls.Add(this.btn_rad_qte_set);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.btn_rad_type_set);
            this.Controls.Add(this.btn_rad_code_set);
            this.Controls.Add(this.txt_prix_set);
            this.Controls.Add(this.btn_rad_name_set);
            this.Controls.Add(this.lblQte);
            this.Controls.Add(this.txt_qte_set);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txt_name_set);
            this.Controls.Add(this.txt_type_set);
            this.Controls.Add(this.txt_code_set);
            this.Controls.Add(this.btn_sup_set);
            this.Controls.Add(this.btn_mod_set);
            this.Controls.Add(this.btn_ajou_set);
            this.Controls.Add(this.dgv_set);
            this.Name = "Setting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_set)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_set;
        private System.Windows.Forms.Button btn_ajou_set;
        private System.Windows.Forms.Button btn_mod_set;
        private System.Windows.Forms.Button btn_sup_set;
        private System.Windows.Forms.TextBox txt_code_set;
        private System.Windows.Forms.TextBox txt_type_set;
        private System.Windows.Forms.TextBox txt_name_set;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton btn_rad_type_set;
        private System.Windows.Forms.RadioButton btn_rad_code_set;
        private System.Windows.Forms.RadioButton btn_rad_name_set;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.RadioButton btn_rad_prix_set;
        private System.Windows.Forms.RadioButton btn_rad_qte_set;
        private System.Windows.Forms.Label lblQte;
        private System.Windows.Forms.TextBox txt_qte_set;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.TextBox txt_prix_set;
        private System.Windows.Forms.Label lblFour;
        private System.Windows.Forms.TextBox txt_four_set;
        private System.Windows.Forms.RadioButton btn_rad_four_set;
        private System.Windows.Forms.Label lblTries;
        private System.Windows.Forms.Label lblLSet;
    }
}