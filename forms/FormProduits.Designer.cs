namespace MarketManagment.forms
{
    partial class FormProduits
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
            this.dgv_prod = new System.Windows.Forms.DataGridView();
            this.btn_ajou_prod = new System.Windows.Forms.Button();
            this.btn_mod_prod = new System.Windows.Forms.Button();
            this.btn_sup_prod = new System.Windows.Forms.Button();
            this.txt_code_prod = new System.Windows.Forms.TextBox();
            this.txt_type_prod = new System.Windows.Forms.TextBox();
            this.txt_name_prod = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_rad_four_prod = new System.Windows.Forms.RadioButton();
            this.btn_rad_prix_prod = new System.Windows.Forms.RadioButton();
            this.btn_rad_qte_prod = new System.Windows.Forms.RadioButton();
            this.btn_rad_type_prod = new System.Windows.Forms.RadioButton();
            this.btn_rad_code_prod = new System.Windows.Forms.RadioButton();
            this.btn_rad_name_prod = new System.Windows.Forms.RadioButton();
            this.lbltype = new System.Windows.Forms.Label();
            this.lblQte = new System.Windows.Forms.Label();
            this.txt_qte_prod = new System.Windows.Forms.TextBox();
            this.lblPrix = new System.Windows.Forms.Label();
            this.txt_prix_prod = new System.Windows.Forms.TextBox();
            this.lblFour = new System.Windows.Forms.Label();
            this.txt_four_prod = new System.Windows.Forms.TextBox();
            this.lblTries = new System.Windows.Forms.Label();
            this.lblLPd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prod)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_prod
            // 
            this.dgv_prod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_prod.Location = new System.Drawing.Point(539, 71);
            this.dgv_prod.Name = "dgv_prod";
            this.dgv_prod.Size = new System.Drawing.Size(521, 299);
            this.dgv_prod.TabIndex = 0;
            this.dgv_prod.DoubleClick += new System.EventHandler(this.dgv_prod_DoubleClick);
            // 
            // btn_ajou_prod
            // 
            this.btn_ajou_prod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ajou_prod.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_ajou_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajou_prod.Location = new System.Drawing.Point(650, 433);
            this.btn_ajou_prod.Name = "btn_ajou_prod";
            this.btn_ajou_prod.Size = new System.Drawing.Size(110, 46);
            this.btn_ajou_prod.TabIndex = 3;
            this.btn_ajou_prod.Text = "Ajouter";
            this.btn_ajou_prod.UseVisualStyleBackColor = true;
            this.btn_ajou_prod.Click += new System.EventHandler(this.btn_ajou_prod_Click);
            // 
            // btn_mod_prod
            // 
            this.btn_mod_prod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mod_prod.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_mod_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mod_prod.Location = new System.Drawing.Point(950, 433);
            this.btn_mod_prod.Name = "btn_mod_prod";
            this.btn_mod_prod.Size = new System.Drawing.Size(110, 46);
            this.btn_mod_prod.TabIndex = 5;
            this.btn_mod_prod.Text = "Modifier";
            this.btn_mod_prod.UseVisualStyleBackColor = true;
            this.btn_mod_prod.Click += new System.EventHandler(this.btn_mod_prod_Click);
            // 
            // btn_sup_prod
            // 
            this.btn_sup_prod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sup_prod.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_sup_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sup_prod.Location = new System.Drawing.Point(800, 433);
            this.btn_sup_prod.Name = "btn_sup_prod";
            this.btn_sup_prod.Size = new System.Drawing.Size(110, 46);
            this.btn_sup_prod.TabIndex = 6;
            this.btn_sup_prod.Text = "Supprimer";
            this.btn_sup_prod.UseVisualStyleBackColor = true;
            this.btn_sup_prod.Click += new System.EventHandler(this.btn_sup_prod_Click);
            // 
            // txt_code_prod
            // 
            this.txt_code_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_code_prod.Location = new System.Drawing.Point(130, 36);
            this.txt_code_prod.Name = "txt_code_prod";
            this.txt_code_prod.Size = new System.Drawing.Size(100, 23);
            this.txt_code_prod.TabIndex = 8;
            this.txt_code_prod.TextChanged += new System.EventHandler(this.Get_Produits);
            // 
            // txt_type_prod
            // 
            this.txt_type_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_type_prod.Location = new System.Drawing.Point(130, 113);
            this.txt_type_prod.Name = "txt_type_prod";
            this.txt_type_prod.Size = new System.Drawing.Size(100, 23);
            this.txt_type_prod.TabIndex = 9;
            this.txt_type_prod.TextChanged += new System.EventHandler(this.Get_Produits);
            // 
            // txt_name_prod
            // 
            this.txt_name_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_prod.Location = new System.Drawing.Point(130, 74);
            this.txt_name_prod.Name = "txt_name_prod";
            this.txt_name_prod.Size = new System.Drawing.Size(100, 23);
            this.txt_name_prod.TabIndex = 10;
            this.txt_name_prod.TextChanged += new System.EventHandler(this.Get_Produits);
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
            // btn_rad_four_prod
            // 
            this.btn_rad_four_prod.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_rad_four_prod.AutoSize = true;
            this.btn_rad_four_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rad_four_prod.Location = new System.Drawing.Point(161, 441);
            this.btn_rad_four_prod.Name = "btn_rad_four_prod";
            this.btn_rad_four_prod.Padding = new System.Windows.Forms.Padding(5);
            this.btn_rad_four_prod.Size = new System.Drawing.Size(107, 31);
            this.btn_rad_four_prod.TabIndex = 5;
            this.btn_rad_four_prod.TabStop = true;
            this.btn_rad_four_prod.Text = "fournisseur";
            this.btn_rad_four_prod.UseVisualStyleBackColor = true;
            this.btn_rad_four_prod.CheckedChanged += new System.EventHandler(this.btn_rad_four_prod_CheckedChanged);
            // 
            // btn_rad_prix_prod
            // 
            this.btn_rad_prix_prod.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_rad_prix_prod.AutoSize = true;
            this.btn_rad_prix_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rad_prix_prod.Location = new System.Drawing.Point(42, 441);
            this.btn_rad_prix_prod.Name = "btn_rad_prix_prod";
            this.btn_rad_prix_prod.Padding = new System.Windows.Forms.Padding(5);
            this.btn_rad_prix_prod.Size = new System.Drawing.Size(59, 31);
            this.btn_rad_prix_prod.TabIndex = 4;
            this.btn_rad_prix_prod.TabStop = true;
            this.btn_rad_prix_prod.Text = "Prix";
            this.btn_rad_prix_prod.UseVisualStyleBackColor = true;
            this.btn_rad_prix_prod.CheckedChanged += new System.EventHandler(this.btn_rad_prix_prod_CheckedChanged);
            // 
            // btn_rad_qte_prod
            // 
            this.btn_rad_qte_prod.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_rad_qte_prod.AutoSize = true;
            this.btn_rad_qte_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rad_qte_prod.Location = new System.Drawing.Point(161, 375);
            this.btn_rad_qte_prod.Name = "btn_rad_qte_prod";
            this.btn_rad_qte_prod.Padding = new System.Windows.Forms.Padding(5);
            this.btn_rad_qte_prod.Size = new System.Drawing.Size(95, 31);
            this.btn_rad_qte_prod.TabIndex = 3;
            this.btn_rad_qte_prod.TabStop = true;
            this.btn_rad_qte_prod.Text = "Quantiter";
            this.btn_rad_qte_prod.UseVisualStyleBackColor = true;
            this.btn_rad_qte_prod.CheckedChanged += new System.EventHandler(this.btn_rad_qte_prod_CheckedChanged);
            // 
            // btn_rad_type_prod
            // 
            this.btn_rad_type_prod.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_rad_type_prod.AutoSize = true;
            this.btn_rad_type_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rad_type_prod.Location = new System.Drawing.Point(161, 408);
            this.btn_rad_type_prod.Name = "btn_rad_type_prod";
            this.btn_rad_type_prod.Padding = new System.Windows.Forms.Padding(5);
            this.btn_rad_type_prod.Size = new System.Drawing.Size(68, 31);
            this.btn_rad_type_prod.TabIndex = 2;
            this.btn_rad_type_prod.TabStop = true;
            this.btn_rad_type_prod.Text = "Type";
            this.btn_rad_type_prod.UseVisualStyleBackColor = true;
            this.btn_rad_type_prod.CheckedChanged += new System.EventHandler(this.btn_rad_type_prod_CheckedChanged);
            // 
            // btn_rad_code_prod
            // 
            this.btn_rad_code_prod.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_rad_code_prod.AutoSize = true;
            this.btn_rad_code_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rad_code_prod.Location = new System.Drawing.Point(42, 375);
            this.btn_rad_code_prod.Name = "btn_rad_code_prod";
            this.btn_rad_code_prod.Padding = new System.Windows.Forms.Padding(5);
            this.btn_rad_code_prod.Size = new System.Drawing.Size(69, 31);
            this.btn_rad_code_prod.TabIndex = 1;
            this.btn_rad_code_prod.TabStop = true;
            this.btn_rad_code_prod.Text = "Code";
            this.btn_rad_code_prod.UseVisualStyleBackColor = true;
            this.btn_rad_code_prod.CheckedChanged += new System.EventHandler(this.btn_rad_code_prod_CheckedChanged);
            // 
            // btn_rad_name_prod
            // 
            this.btn_rad_name_prod.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_rad_name_prod.AutoSize = true;
            this.btn_rad_name_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rad_name_prod.Location = new System.Drawing.Point(42, 408);
            this.btn_rad_name_prod.Name = "btn_rad_name_prod";
            this.btn_rad_name_prod.Padding = new System.Windows.Forms.Padding(5);
            this.btn_rad_name_prod.Size = new System.Drawing.Size(73, 31);
            this.btn_rad_name_prod.TabIndex = 0;
            this.btn_rad_name_prod.TabStop = true;
            this.btn_rad_name_prod.Text = "Name";
            this.btn_rad_name_prod.UseVisualStyleBackColor = true;
            this.btn_rad_name_prod.CheckedChanged += new System.EventHandler(this.btn_rad_name_prod_CheckedChanged);
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
            // txt_qte_prod
            // 
            this.txt_qte_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qte_prod.Location = new System.Drawing.Point(130, 154);
            this.txt_qte_prod.Name = "txt_qte_prod";
            this.txt_qte_prod.Size = new System.Drawing.Size(100, 23);
            this.txt_qte_prod.TabIndex = 16;
            this.txt_qte_prod.TextChanged += new System.EventHandler(this.Get_Produits);
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrix.Location = new System.Drawing.Point(39, 198);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(31, 17);
            this.lblPrix.TabIndex = 19;
            this.lblPrix.Text = "Prix";
            this.lblPrix.Click += new System.EventHandler(this.lblPrix_Click);
            // 
            // txt_prix_prod
            // 
            this.txt_prix_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prix_prod.Location = new System.Drawing.Point(130, 195);
            this.txt_prix_prod.Name = "txt_prix_prod";
            this.txt_prix_prod.Size = new System.Drawing.Size(100, 23);
            this.txt_prix_prod.TabIndex = 18;
            this.txt_prix_prod.TextChanged += new System.EventHandler(this.Get_Produits);
            // 
            // lblFour
            // 
            this.lblFour.AutoSize = true;
            this.lblFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFour.Location = new System.Drawing.Point(39, 236);
            this.lblFour.Name = "lblFour";
            this.lblFour.Size = new System.Drawing.Size(78, 17);
            this.lblFour.TabIndex = 21;
            this.lblFour.Text = "Founisseur";
            this.lblFour.Click += new System.EventHandler(this.lblFour_Click);
            // 
            // txt_four_prod
            // 
            this.txt_four_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_four_prod.Location = new System.Drawing.Point(130, 233);
            this.txt_four_prod.Name = "txt_four_prod";
            this.txt_four_prod.Size = new System.Drawing.Size(100, 23);
            this.txt_four_prod.TabIndex = 20;
            this.txt_four_prod.TextChanged += new System.EventHandler(this.Get_Produits);
            // 
            // lblTries
            // 
            this.lblTries.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTries.AutoSize = true;
            this.lblTries.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTries.Location = new System.Drawing.Point(39, 345);
            this.lblTries.Name = "lblTries";
            this.lblTries.Size = new System.Drawing.Size(45, 17);
            this.lblTries.TabIndex = 22;
            this.lblTries.Text = "Tries";
            // 
            // lblLPd
            // 
            this.lblLPd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLPd.AutoSize = true;
            this.lblLPd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLPd.Location = new System.Drawing.Point(536, 36);
            this.lblLPd.Name = "lblLPd";
            this.lblLPd.Size = new System.Drawing.Size(139, 17);
            this.lblLPd.TabIndex = 23;
            this.lblLPd.Text = "Liste des Produits";
            // 
            // FormProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 511);
            this.Controls.Add(this.lblLPd);
            this.Controls.Add(this.lblTries);
            this.Controls.Add(this.btn_rad_four_prod);
            this.Controls.Add(this.lblFour);
            this.Controls.Add(this.btn_rad_prix_prod);
            this.Controls.Add(this.txt_four_prod);
            this.Controls.Add(this.btn_rad_qte_prod);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.btn_rad_type_prod);
            this.Controls.Add(this.btn_rad_code_prod);
            this.Controls.Add(this.txt_prix_prod);
            this.Controls.Add(this.btn_rad_name_prod);
            this.Controls.Add(this.lblQte);
            this.Controls.Add(this.txt_qte_prod);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txt_name_prod);
            this.Controls.Add(this.txt_type_prod);
            this.Controls.Add(this.txt_code_prod);
            this.Controls.Add(this.btn_sup_prod);
            this.Controls.Add(this.btn_mod_prod);
            this.Controls.Add(this.btn_ajou_prod);
            this.Controls.Add(this.dgv_prod);
            this.Name = "FormProduits";
            this.Text = "Produits";
            this.Load += new System.EventHandler(this.Produits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_prod;
        private System.Windows.Forms.Button btn_ajou_prod;
        private System.Windows.Forms.Button btn_mod_prod;
        private System.Windows.Forms.Button btn_sup_prod;
        private System.Windows.Forms.TextBox txt_code_prod;
        private System.Windows.Forms.TextBox txt_type_prod;
        private System.Windows.Forms.TextBox txt_name_prod;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton btn_rad_type_prod;
        private System.Windows.Forms.RadioButton btn_rad_code_prod;
        private System.Windows.Forms.RadioButton btn_rad_name_prod;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.RadioButton btn_rad_prix_prod;
        private System.Windows.Forms.RadioButton btn_rad_qte_prod;
        private System.Windows.Forms.Label lblQte;
        private System.Windows.Forms.TextBox txt_qte_prod;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.TextBox txt_prix_prod;
        private System.Windows.Forms.Label lblFour;
        private System.Windows.Forms.TextBox txt_four_prod;
        private System.Windows.Forms.RadioButton btn_rad_four_prod;
        private System.Windows.Forms.Label lblTries;
        private System.Windows.Forms.Label lblLPd;
    }
}