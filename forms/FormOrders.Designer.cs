using System;

namespace MarketManagment.forms
{
    partial class FormOrders
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
            this.dgv_ord = new System.Windows.Forms.DataGridView();
            this.btn_ajou_ord = new System.Windows.Forms.Button();
            this.btn_sup_ord = new System.Windows.Forms.Button();
            this.txt_clt_ord = new System.Windows.Forms.TextBox();
            this.txt_prod_ord = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQte = new System.Windows.Forms.Label();
            this.txt_qte_ord = new System.Windows.Forms.TextBox();
            this.lblPrix = new System.Windows.Forms.Label();
            this.txt_prix_ord = new System.Windows.Forms.TextBox();
            this.lblLOrd = new System.Windows.Forms.Label();
            this.dgv_produit = new System.Windows.Forms.DataGridView();
            this.btn_Commander = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nprod_ord = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ord
            // 
            this.dgv_ord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.Qte,
            this.prix});
            this.dgv_ord.Location = new System.Drawing.Point(539, 71);
            this.dgv_ord.Name = "dgv_ord";
            this.dgv_ord.Size = new System.Drawing.Size(410, 258);
            this.dgv_ord.TabIndex = 0;
            // 
            // btn_ajou_ord
            // 
            this.btn_ajou_ord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ajou_ord.Enabled = false;
            this.btn_ajou_ord.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_ajou_ord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajou_ord.Location = new System.Drawing.Point(539, 392);
            this.btn_ajou_ord.Name = "btn_ajou_ord";
            this.btn_ajou_ord.Size = new System.Drawing.Size(110, 46);
            this.btn_ajou_ord.TabIndex = 3;
            this.btn_ajou_ord.Text = "Ajouter";
            this.btn_ajou_ord.UseVisualStyleBackColor = true;
            this.btn_ajou_ord.Click += new System.EventHandler(this.btn_ajou_ord_Click);
            // 
            // btn_sup_ord
            // 
            this.btn_sup_ord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sup_ord.Enabled = false;
            this.btn_sup_ord.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_sup_ord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sup_ord.Location = new System.Drawing.Point(691, 392);
            this.btn_sup_ord.Name = "btn_sup_ord";
            this.btn_sup_ord.Size = new System.Drawing.Size(110, 46);
            this.btn_sup_ord.TabIndex = 6;
            this.btn_sup_ord.Text = "Supprimer";
            this.btn_sup_ord.UseVisualStyleBackColor = true;
            this.btn_sup_ord.Click += new System.EventHandler(this.btn_sup_ord_Click);
            // 
            // txt_clt_ord
            // 
            this.txt_clt_ord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clt_ord.Location = new System.Drawing.Point(127, 36);
            this.txt_clt_ord.Name = "txt_clt_ord";
            this.txt_clt_ord.Size = new System.Drawing.Size(100, 23);
            this.txt_clt_ord.TabIndex = 8;
            this.txt_clt_ord.Leave += new System.EventHandler(this.txt_code_ord_Leave);
            // 
            // txt_prod_ord
            // 
            this.txt_prod_ord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prod_ord.Location = new System.Drawing.Point(127, 74);
            this.txt_prod_ord.Name = "txt_prod_ord";
            this.txt_prod_ord.Size = new System.Drawing.Size(100, 23);
            this.txt_prod_ord.TabIndex = 10;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(36, 36);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(80, 17);
            this.lblCode.TabIndex = 11;
            this.lblCode.Text = "Code Client";
            this.lblCode.Click += new System.EventHandler(this.lblCode_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(36, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 17);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Code Produit";
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
            // lblQte
            // 
            this.lblQte.AutoSize = true;
            this.lblQte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQte.Location = new System.Drawing.Point(36, 157);
            this.lblQte.Name = "lblQte";
            this.lblQte.Size = new System.Drawing.Size(67, 17);
            this.lblQte.TabIndex = 17;
            this.lblQte.Text = "Quantiter";
            this.lblQte.Click += new System.EventHandler(this.lblQte_Click);
            // 
            // txt_qte_ord
            // 
            this.txt_qte_ord.Enabled = false;
            this.txt_qte_ord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qte_ord.Location = new System.Drawing.Point(127, 154);
            this.txt_qte_ord.Name = "txt_qte_ord";
            this.txt_qte_ord.Size = new System.Drawing.Size(100, 23);
            this.txt_qte_ord.TabIndex = 16;
            this.txt_qte_ord.TextChanged += new System.EventHandler(this.txt_qte_ord_TextChanged);
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrix.Location = new System.Drawing.Point(36, 195);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(31, 17);
            this.lblPrix.TabIndex = 19;
            this.lblPrix.Text = "Prix";
            this.lblPrix.Click += new System.EventHandler(this.lblPrix_Click);
            // 
            // txt_prix_ord
            // 
            this.txt_prix_ord.Enabled = false;
            this.txt_prix_ord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prix_ord.Location = new System.Drawing.Point(127, 192);
            this.txt_prix_ord.Name = "txt_prix_ord";
            this.txt_prix_ord.Size = new System.Drawing.Size(100, 23);
            this.txt_prix_ord.TabIndex = 18;
            // 
            // lblLOrd
            // 
            this.lblLOrd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLOrd.AutoSize = true;
            this.lblLOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLOrd.Location = new System.Drawing.Point(536, 33);
            this.lblLOrd.Name = "lblLOrd";
            this.lblLOrd.Size = new System.Drawing.Size(129, 17);
            this.lblLOrd.TabIndex = 23;
            this.lblLOrd.Text = "Liste des Orders";
            // 
            // dgv_produit
            // 
            this.dgv_produit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_produit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produit.Location = new System.Drawing.Point(12, 239);
            this.dgv_produit.Name = "dgv_produit";
            this.dgv_produit.Size = new System.Drawing.Size(304, 219);
            this.dgv_produit.TabIndex = 24;
            this.dgv_produit.DoubleClick += new System.EventHandler(this.dgv_produit_DoubleClick);
            // 
            // btn_Commander
            // 
            this.btn_Commander.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Commander.Enabled = false;
            this.btn_Commander.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Commander.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Commander.Location = new System.Drawing.Point(839, 392);
            this.btn_Commander.Name = "btn_Commander";
            this.btn_Commander.Size = new System.Drawing.Size(110, 46);
            this.btn_Commander.TabIndex = 25;
            this.btn_Commander.Text = "Commander";
            this.btn_Commander.UseVisualStyleBackColor = true;
            this.btn_Commander.Click += new System.EventHandler(this.btn_Commander_Click);
            // 
            // name
            // 
            this.name.HeaderText = "Nom";
            this.name.Name = "name";
            // 
            // Qte
            // 
            this.Qte.HeaderText = "Qte";
            this.Qte.Name = "Qte";
            // 
            // prix
            // 
            this.prix.HeaderText = "Prix";
            this.prix.Name = "prix";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nom Produit";
            // 
            // txt_nprod_ord
            // 
            this.txt_nprod_ord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nprod_ord.Location = new System.Drawing.Point(127, 113);
            this.txt_nprod_ord.Name = "txt_nprod_ord";
            this.txt_nprod_ord.Size = new System.Drawing.Size(100, 23);
            this.txt_nprod_ord.TabIndex = 26;
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(973, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nprod_ord);
            this.Controls.Add(this.btn_Commander);
            this.Controls.Add(this.dgv_produit);
            this.Controls.Add(this.lblLOrd);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.txt_prix_ord);
            this.Controls.Add(this.lblQte);
            this.Controls.Add(this.txt_qte_ord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txt_prod_ord);
            this.Controls.Add(this.txt_clt_ord);
            this.Controls.Add(this.btn_sup_ord);
            this.Controls.Add(this.btn_ajou_ord);
            this.Controls.Add(this.dgv_ord);
            this.Name = "FormOrders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ord;
        private System.Windows.Forms.Button btn_ajou_ord;
        private System.Windows.Forms.Button btn_sup_ord;
        private System.Windows.Forms.TextBox txt_clt_ord;
        private System.Windows.Forms.TextBox txt_prod_ord;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblQte;
        private System.Windows.Forms.TextBox txt_qte_ord;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.TextBox txt_prix_ord;
        private System.Windows.Forms.Label lblLOrd;
        private System.Windows.Forms.DataGridView dgv_produit;
        private System.Windows.Forms.Button btn_Commander;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qte;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nprod_ord;
    }
}