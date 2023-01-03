using System;

namespace MarketManagment.forms
{
    partial class FormNotif

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
            this.dgv_notif = new System.Windows.Forms.DataGridView();
            this.btn_ajou_notif = new System.Windows.Forms.Button();
            this.btn_mod_notif = new System.Windows.Forms.Button();
            this.btn_sup_notif = new System.Windows.Forms.Button();
            this.txt_code_notif = new System.Windows.Forms.TextBox();
            this.txt_type_notif = new System.Windows.Forms.TextBox();
            this.txt_name_notif = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_rad_four_notif = new System.Windows.Forms.RadioButton();
            this.btn_rad_prix_notif = new System.Windows.Forms.RadioButton();
            this.btn_rad_qte_notif = new System.Windows.Forms.RadioButton();
            this.btn_rad_type_notif = new System.Windows.Forms.RadioButton();
            this.btn_rad_code_notif = new System.Windows.Forms.RadioButton();
            this.btn_rad_name_notif = new System.Windows.Forms.RadioButton();
            this.lbltype = new System.Windows.Forms.Label();
            this.lblQte = new System.Windows.Forms.Label();
            this.txt_qte_notif = new System.Windows.Forms.TextBox();
            this.lblPrix = new System.Windows.Forms.Label();
            this.txt_prix_notif = new System.Windows.Forms.TextBox();
            this.lblFour = new System.Windows.Forms.Label();
            this.txt_four_notif = new System.Windows.Forms.TextBox();
            this.lblTries = new System.Windows.Forms.Label();
            this.lblLNote = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notif)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_notif
            // 
            this.dgv_notif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_notif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_notif.Location = new System.Drawing.Point(539, 71);
            this.dgv_notif.Name = "dgv_notif";
            this.dgv_notif.Size = new System.Drawing.Size(410, 258);
            this.dgv_notif.TabIndex = 0;
            // 
            // btn_ajou_notif
            // 
            this.btn_ajou_notif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ajou_notif.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_ajou_notif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajou_notif.Location = new System.Drawing.Point(539, 392);
            this.btn_ajou_notif.Name = "btn_ajou_notif";
            this.btn_ajou_notif.Size = new System.Drawing.Size(110, 46);
            this.btn_ajou_notif.TabIndex = 3;
            this.btn_ajou_notif.Text = "Ajouter";
            this.btn_ajou_notif.UseVisualStyleBackColor = true;
            // 
            // btn_mod_notif
            // 
            this.btn_mod_notif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mod_notif.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_mod_notif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mod_notif.Location = new System.Drawing.Point(839, 392);
            this.btn_mod_notif.Name = "btn_mod_notif";
            this.btn_mod_notif.Size = new System.Drawing.Size(110, 46);
            this.btn_mod_notif.TabIndex = 5;
            this.btn_mod_notif.Text = "Modifier";
            this.btn_mod_notif.UseVisualStyleBackColor = true;
            // 
            // btn_sup_notif
            // 
            this.btn_sup_notif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sup_notif.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_sup_notif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sup_notif.Location = new System.Drawing.Point(689, 392);
            this.btn_sup_notif.Name = "btn_sup_notif";
            this.btn_sup_notif.Size = new System.Drawing.Size(110, 46);
            this.btn_sup_notif.TabIndex = 6;
            this.btn_sup_notif.Text = "Supprimer";
            this.btn_sup_notif.UseVisualStyleBackColor = true;
            // 
            // txt_code_notif
            // 
            this.txt_code_notif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_code_notif.Location = new System.Drawing.Point(130, 33);
            this.txt_code_notif.Name = "txt_code_notif";
            this.txt_code_notif.Size = new System.Drawing.Size(100, 23);
            this.txt_code_notif.TabIndex = 8;
            // 
            // txt_type_notif
            // 
            this.txt_type_notif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_type_notif.Location = new System.Drawing.Point(130, 110);
            this.txt_type_notif.Name = "txt_type_notif";
            this.txt_type_notif.Size = new System.Drawing.Size(100, 23);
            this.txt_type_notif.TabIndex = 9;
            // 
            // txt_name_notif
            // 
            this.txt_name_notif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_notif.Location = new System.Drawing.Point(130, 71);
            this.txt_name_notif.Name = "txt_name_notif";
            this.txt_name_notif.Size = new System.Drawing.Size(100, 23);
            this.txt_name_notif.TabIndex = 10;
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
            // btn_rad_four_notif
            // 
            this.btn_rad_four_notif.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_rad_four_notif.AutoSize = true;
            this.btn_rad_four_notif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rad_four_notif.Location = new System.Drawing.Point(148, 400);
            this.btn_rad_four_notif.Name = "btn_rad_four_notif";
            this.btn_rad_four_notif.Padding = new System.Windows.Forms.Padding(5);
            this.btn_rad_four_notif.Size = new System.Drawing.Size(107, 31);
            this.btn_rad_four_notif.TabIndex = 5;
            this.btn_rad_four_notif.TabStop = true;
            this.btn_rad_four_notif.Text = "fournisseur";
            this.btn_rad_four_notif.UseVisualStyleBackColor = true;
            // 
            // btn_rad_prix_notif
            // 
            this.btn_rad_prix_notif.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_rad_prix_notif.AutoSize = true;
            this.btn_rad_prix_notif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rad_prix_notif.Location = new System.Drawing.Point(148, 367);
            this.btn_rad_prix_notif.Name = "btn_rad_prix_notif";
            this.btn_rad_prix_notif.Padding = new System.Windows.Forms.Padding(5);
            this.btn_rad_prix_notif.Size = new System.Drawing.Size(59, 31);
            this.btn_rad_prix_notif.TabIndex = 4;
            this.btn_rad_prix_notif.TabStop = true;
            this.btn_rad_prix_notif.Text = "Prix";
            this.btn_rad_prix_notif.UseVisualStyleBackColor = true;
            // 
            // btn_rad_qte_notif
            // 
            this.btn_rad_qte_notif.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_rad_qte_notif.AutoSize = true;
            this.btn_rad_qte_notif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rad_qte_notif.Location = new System.Drawing.Point(148, 334);
            this.btn_rad_qte_notif.Name = "btn_rad_qte_notif";
            this.btn_rad_qte_notif.Padding = new System.Windows.Forms.Padding(5);
            this.btn_rad_qte_notif.Size = new System.Drawing.Size(95, 31);
            this.btn_rad_qte_notif.TabIndex = 3;
            this.btn_rad_qte_notif.TabStop = true;
            this.btn_rad_qte_notif.Text = "Quantiter";
            this.btn_rad_qte_notif.UseVisualStyleBackColor = true;
            // 
            // btn_rad_type_notif
            // 
            this.btn_rad_type_notif.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_rad_type_notif.AutoSize = true;
            this.btn_rad_type_notif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rad_type_notif.Location = new System.Drawing.Point(42, 367);
            this.btn_rad_type_notif.Name = "btn_rad_type_notif";
            this.btn_rad_type_notif.Padding = new System.Windows.Forms.Padding(5);
            this.btn_rad_type_notif.Size = new System.Drawing.Size(68, 31);
            this.btn_rad_type_notif.TabIndex = 2;
            this.btn_rad_type_notif.TabStop = true;
            this.btn_rad_type_notif.Text = "Type";
            this.btn_rad_type_notif.UseVisualStyleBackColor = true;
            // 
            // btn_rad_code_notif
            // 
            this.btn_rad_code_notif.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_rad_code_notif.AutoSize = true;
            this.btn_rad_code_notif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rad_code_notif.Location = new System.Drawing.Point(42, 334);
            this.btn_rad_code_notif.Name = "btn_rad_code_notif";
            this.btn_rad_code_notif.Padding = new System.Windows.Forms.Padding(5);
            this.btn_rad_code_notif.Size = new System.Drawing.Size(69, 31);
            this.btn_rad_code_notif.TabIndex = 1;
            this.btn_rad_code_notif.TabStop = true;
            this.btn_rad_code_notif.Text = "Code";
            this.btn_rad_code_notif.UseVisualStyleBackColor = true;
            // 
            // btn_rad_name_notif
            // 
            this.btn_rad_name_notif.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_rad_name_notif.AutoSize = true;
            this.btn_rad_name_notif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rad_name_notif.Location = new System.Drawing.Point(42, 400);
            this.btn_rad_name_notif.Name = "btn_rad_name_notif";
            this.btn_rad_name_notif.Padding = new System.Windows.Forms.Padding(5);
            this.btn_rad_name_notif.Size = new System.Drawing.Size(73, 31);
            this.btn_rad_name_notif.TabIndex = 0;
            this.btn_rad_name_notif.TabStop = true;
            this.btn_rad_name_notif.Text = "Name";
            this.btn_rad_name_notif.UseVisualStyleBackColor = true;
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
            // txt_qte_notif
            // 
            this.txt_qte_notif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qte_notif.Location = new System.Drawing.Point(130, 151);
            this.txt_qte_notif.Name = "txt_qte_notif";
            this.txt_qte_notif.Size = new System.Drawing.Size(100, 23);
            this.txt_qte_notif.TabIndex = 16;
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
            // txt_prix_notif
            // 
            this.txt_prix_notif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prix_notif.Location = new System.Drawing.Point(130, 192);
            this.txt_prix_notif.Name = "txt_prix_notif";
            this.txt_prix_notif.Size = new System.Drawing.Size(100, 23);
            this.txt_prix_notif.TabIndex = 18;
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
            // txt_four_notif
            // 
            this.txt_four_notif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_four_notif.Location = new System.Drawing.Point(130, 230);
            this.txt_four_notif.Name = "txt_four_notif";
            this.txt_four_notif.Size = new System.Drawing.Size(100, 23);
            this.txt_four_notif.TabIndex = 20;
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
            // lblLNote
            // 
            this.lblLNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLNote.AutoSize = true;
            this.lblLNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLNote.Location = new System.Drawing.Point(536, 33);
            this.lblLNote.Name = "lblLNote";
            this.lblLNote.Size = new System.Drawing.Size(161, 17);
            this.lblLNote.TabIndex = 23;
            this.lblLNote.Text = "Liste des Notification";
            // 
            // FormNotif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(973, 470);
            this.Controls.Add(this.lblLNote);
            this.Controls.Add(this.lblTries);
            this.Controls.Add(this.btn_rad_four_notif);
            this.Controls.Add(this.lblFour);
            this.Controls.Add(this.btn_rad_prix_notif);
            this.Controls.Add(this.txt_four_notif);
            this.Controls.Add(this.btn_rad_qte_notif);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.btn_rad_type_notif);
            this.Controls.Add(this.btn_rad_code_notif);
            this.Controls.Add(this.txt_prix_notif);
            this.Controls.Add(this.btn_rad_name_notif);
            this.Controls.Add(this.lblQte);
            this.Controls.Add(this.txt_qte_notif);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txt_name_notif);
            this.Controls.Add(this.txt_type_notif);
            this.Controls.Add(this.txt_code_notif);
            this.Controls.Add(this.btn_sup_notif);
            this.Controls.Add(this.btn_mod_notif);
            this.Controls.Add(this.btn_ajou_notif);
            this.Controls.Add(this.dgv_notif);
            this.Name = "FormNotif";
            this.Text = "Notifications";
            this.Load += new System.EventHandler(this.Notifications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.DataGridView dgv_notif;
        private System.Windows.Forms.Button btn_ajou_notif;
        private System.Windows.Forms.Button btn_mod_notif;
        private System.Windows.Forms.Button btn_sup_notif;
        private System.Windows.Forms.TextBox txt_code_notif;
        private System.Windows.Forms.TextBox txt_type_notif;
        private System.Windows.Forms.TextBox txt_name_notif;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton btn_rad_type_notif;
        private System.Windows.Forms.RadioButton btn_rad_code_notif;
        private System.Windows.Forms.RadioButton btn_rad_name_notif;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.RadioButton btn_rad_prix_notif;
        private System.Windows.Forms.RadioButton btn_rad_qte_notif;
        private System.Windows.Forms.Label lblQte;
        private System.Windows.Forms.TextBox txt_qte_notif;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.TextBox txt_prix_notif;
        private System.Windows.Forms.Label lblFour;
        private System.Windows.Forms.TextBox txt_four_notif;
        private System.Windows.Forms.RadioButton btn_rad_four_notif;
        private System.Windows.Forms.Label lblTries;
        private System.Windows.Forms.Label lblLNote;
    }
}