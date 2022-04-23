using System.ComponentModel;

namespace BackOfficeHopital.WinForms
{
    partial class ModifierCompteForm
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
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblModifierCompte = new System.Windows.Forms.Label();
            this.DTPDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.lblMDP = new System.Windows.Forms.Label();
            this.textBoxMDP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(183, 292);
            this.comboBoxRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(204, 24);
            this.comboBoxRole.TabIndex = 29;
            // 
            // lblRole
            // 
            this.lblRole.Location = new System.Drawing.Point(112, 293);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(65, 23);
            this.lblRole.TabIndex = 28;
            this.lblRole.Text = "Rôle :";
            // 
            // lblService
            // 
            this.lblService.Location = new System.Drawing.Point(91, 252);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(83, 23);
            this.lblService.TabIndex = 27;
            this.lblService.Text = "Service :";
            // 
            // comboBoxService
            // 
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new System.Drawing.Point(183, 251);
            this.comboBoxService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(204, 24);
            this.comboBoxService.TabIndex = 26;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(183, 177);
            this.textBoxMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(204, 22);
            this.textBoxMail.TabIndex = 23;
            // 
            // lblMail
            // 
            this.lblMail.Location = new System.Drawing.Point(59, 180);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(99, 23);
            this.lblMail.TabIndex = 22;
            this.lblMail.Text = "Adresse mail :";
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.Location = new System.Drawing.Point(23, 143);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(133, 23);
            this.lblDateNaissance.TabIndex = 20;
            this.lblDateNaissance.Text = "Date de naissance :";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(183, 105);
            this.textBoxPrenom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(204, 22);
            this.textBoxPrenom.TabIndex = 19;
            // 
            // lblPrenom
            // 
            this.lblPrenom.Location = new System.Drawing.Point(91, 108);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(67, 23);
            this.lblPrenom.TabIndex = 18;
            this.lblPrenom.Text = "Prenom :";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(183, 69);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(204, 22);
            this.textBoxNom.TabIndex = 17;
            // 
            // lblNom
            // 
            this.lblNom.Location = new System.Drawing.Point(111, 71);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(45, 23);
            this.lblNom.TabIndex = 16;
            this.lblNom.Text = "Nom :";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(183, 330);
            this.btnValider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(127, 37);
            this.btnValider.TabIndex = 15;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblModifierCompte
            // 
            this.lblModifierCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblModifierCompte.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblModifierCompte.Location = new System.Drawing.Point(183, 26);
            this.lblModifierCompte.Name = "lblModifierCompte";
            this.lblModifierCompte.Size = new System.Drawing.Size(193, 23);
            this.lblModifierCompte.TabIndex = 30;
            this.lblModifierCompte.Text = "Modifier le compte";
            this.lblModifierCompte.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DTPDateNaissance
            // 
            this.DTPDateNaissance.CustomFormat = "yyyy-MM-dd";
            this.DTPDateNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPDateNaissance.Location = new System.Drawing.Point(183, 143);
            this.DTPDateNaissance.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.DTPDateNaissance.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.DTPDateNaissance.Name = "DTPDateNaissance";
            this.DTPDateNaissance.Size = new System.Drawing.Size(204, 22);
            this.DTPDateNaissance.TabIndex = 31;
            // 
            // lblMDP
            // 
            this.lblMDP.Location = new System.Drawing.Point(57, 211);
            this.lblMDP.Name = "lblMDP";
            this.lblMDP.Size = new System.Drawing.Size(101, 23);
            this.lblMDP.TabIndex = 32;
            this.lblMDP.Text = "Mot de passe :";
            // 
            // textBoxMDP
            // 
            this.textBoxMDP.Location = new System.Drawing.Point(183, 212);
            this.textBoxMDP.Name = "textBoxMDP";
            this.textBoxMDP.Size = new System.Drawing.Size(204, 22);
            this.textBoxMDP.TabIndex = 33;
            this.textBoxMDP.UseSystemPasswordChar = true;
            // 
            // ModifierCompteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 392);
            this.Controls.Add(this.textBoxMDP);
            this.Controls.Add(this.lblMDP);
            this.Controls.Add(this.DTPDateNaissance);
            this.Controls.Add(this.lblModifierCompte);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.comboBoxService);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblDateNaissance);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnValider);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ModifierCompteForm";
            this.Text = "ModifierCompte";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxMDP;

        private System.Windows.Forms.Label lblMDP;

        private System.Windows.Forms.DateTimePicker DTPDateNaissance;

        private System.Windows.Forms.Label lblModifierCompte;

        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.ComboBox comboBoxService;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnValider;

        #endregion
    }
}