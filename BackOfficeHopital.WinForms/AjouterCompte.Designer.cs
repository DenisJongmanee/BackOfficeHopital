using System.ComponentModel;

namespace BackOfficeHopital.WinForms
{
    partial class AjouterCompte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.btnValider = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.textBoxDateNaissance = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.lblMDP = new System.Windows.Forms.Label();
            this.textBoxMDP = new System.Windows.Forms.TextBox();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.lblService = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.lblAjouterCompte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(183, 334);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(127, 37);
            this.btnValider.TabIndex = 0;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // lblNom
            // 
            this.lblNom.Location = new System.Drawing.Point(111, 69);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(46, 23);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom :";
            this.lblNom.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(183, 66);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(204, 22);
            this.textBoxNom.TabIndex = 2;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            // 
            // lblPrenom
            // 
            this.lblPrenom.Location = new System.Drawing.Point(91, 105);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(66, 23);
            this.lblPrenom.TabIndex = 3;
            this.lblPrenom.Text = "Prenom :";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(183, 102);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(204, 22);
            this.textBoxPrenom.TabIndex = 4;
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.Location = new System.Drawing.Point(23, 140);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(134, 23);
            this.lblDateNaissance.TabIndex = 5;
            this.lblDateNaissance.Text = "Date de naissance :";
            // 
            // textBoxDateNaissance
            // 
            this.textBoxDateNaissance.Location = new System.Drawing.Point(183, 137);
            this.textBoxDateNaissance.Name = "textBoxDateNaissance";
            this.textBoxDateNaissance.Size = new System.Drawing.Size(204, 22);
            this.textBoxDateNaissance.TabIndex = 6;
            // 
            // lblMail
            // 
            this.lblMail.Location = new System.Drawing.Point(59, 177);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(98, 23);
            this.lblMail.TabIndex = 7;
            this.lblMail.Text = "Adresse mail :";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(183, 174);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(204, 22);
            this.textBoxMail.TabIndex = 8;
            // 
            // lblMDP
            // 
            this.lblMDP.Location = new System.Drawing.Point(56, 214);
            this.lblMDP.Name = "lblMDP";
            this.lblMDP.Size = new System.Drawing.Size(101, 23);
            this.lblMDP.TabIndex = 9;
            this.lblMDP.Text = "Mot de passe :";
            // 
            // textBoxMDP
            // 
            this.textBoxMDP.Location = new System.Drawing.Point(183, 211);
            this.textBoxMDP.Name = "textBoxMDP";
            this.textBoxMDP.Size = new System.Drawing.Size(204, 22);
            this.textBoxMDP.TabIndex = 10;
            // 
            // comboBoxService
            // 
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new System.Drawing.Point(183, 248);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(204, 24);
            this.comboBoxService.TabIndex = 11;
            // 
            // lblService
            // 
            this.lblService.Location = new System.Drawing.Point(94, 251);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(63, 23);
            this.lblService.TabIndex = 12;
            this.lblService.Text = "Service :";
            // 
            // lblRole
            // 
            this.lblRole.Location = new System.Drawing.Point(112, 287);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(45, 23);
            this.lblRole.TabIndex = 13;
            this.lblRole.Text = "Rôle :";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(183, 284);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(204, 24);
            this.comboBoxRole.TabIndex = 14;
            // 
            // lblAjouterCompte
            // 
            this.lblAjouterCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAjouterCompte.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAjouterCompte.Location = new System.Drawing.Point(183, 20);
            this.lblAjouterCompte.Name = "lblAjouterCompte";
            this.lblAjouterCompte.Size = new System.Drawing.Size(196, 23);
            this.lblAjouterCompte.TabIndex = 15;
            this.lblAjouterCompte.Text = "Ajouter un compte";
            this.lblAjouterCompte.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AjouterCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAjouterCompte);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.comboBoxService);
            this.Controls.Add(this.textBoxMDP);
            this.Controls.Add(this.lblMDP);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.textBoxDateNaissance);
            this.Controls.Add(this.lblDateNaissance);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnValider);
            this.Name = "AjouterCompte";
            this.Text = "AjouterCompte";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblAjouterCompte;

        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox textBoxNom;

        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.ComboBox comboBoxService;

        private System.Windows.Forms.Label lblMDP;
        private System.Windows.Forms.TextBox textBoxMDP;
        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox textBoxMail;

        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.TextBox textBoxDateNaissance;

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}