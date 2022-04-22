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
            this.textBoxDateNaissance = new System.Windows.Forms.TextBox();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblModifierCompte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(136, 205);
            this.comboBoxRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(154, 21);
            this.comboBoxRole.TabIndex = 29;
            // 
            // lblRole
            // 
            this.lblRole.Location = new System.Drawing.Point(83, 205);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(49, 19);
            this.lblRole.TabIndex = 28;
            this.lblRole.Text = "Rôle :";
            // 
            // lblService
            // 
            this.lblService.Location = new System.Drawing.Point(71, 176);
            this.lblService.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(62, 19);
            this.lblService.TabIndex = 27;
            this.lblService.Text = "Service :";
            // 
            // comboBoxService
            // 
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new System.Drawing.Point(137, 176);
            this.comboBoxService.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(154, 21);
            this.comboBoxService.TabIndex = 26;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(137, 144);
            this.textBoxMail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(154, 20);
            this.textBoxMail.TabIndex = 23;
            // 
            // lblMail
            // 
            this.lblMail.Location = new System.Drawing.Point(44, 146);
            this.lblMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(74, 19);
            this.lblMail.TabIndex = 22;
            this.lblMail.Text = "Adresse mail :";
            // 
            // textBoxDateNaissance
            // 
            this.textBoxDateNaissance.Location = new System.Drawing.Point(137, 114);
            this.textBoxDateNaissance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDateNaissance.Name = "textBoxDateNaissance";
            this.textBoxDateNaissance.Size = new System.Drawing.Size(154, 20);
            this.textBoxDateNaissance.TabIndex = 21;
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.Location = new System.Drawing.Point(17, 116);
            this.lblDateNaissance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(100, 19);
            this.lblDateNaissance.TabIndex = 20;
            this.lblDateNaissance.Text = "Date de naissance :";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(137, 85);
            this.textBoxPrenom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(154, 20);
            this.textBoxPrenom.TabIndex = 19;
            // 
            // lblPrenom
            // 
            this.lblPrenom.Location = new System.Drawing.Point(68, 88);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(50, 19);
            this.lblPrenom.TabIndex = 18;
            this.lblPrenom.Text = "Prenom :";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(137, 56);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(154, 20);
            this.textBoxNom.TabIndex = 17;
            // 
            // lblNom
            // 
            this.lblNom.Location = new System.Drawing.Point(83, 58);
            this.lblNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(34, 19);
            this.lblNom.TabIndex = 16;
            this.lblNom.Text = "Nom :";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(136, 252);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(95, 30);
            this.btnValider.TabIndex = 15;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblModifierCompte
            // 
            this.lblModifierCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifierCompte.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblModifierCompte.Location = new System.Drawing.Point(137, 21);
            this.lblModifierCompte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModifierCompte.Name = "lblModifierCompte";
            this.lblModifierCompte.Size = new System.Drawing.Size(145, 19);
            this.lblModifierCompte.TabIndex = 30;
            this.lblModifierCompte.Text = "Modifier le compte";
            this.lblModifierCompte.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ModifierCompteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 299);
            this.Controls.Add(this.lblModifierCompte);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.comboBoxService);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.textBoxDateNaissance);
            this.Controls.Add(this.lblDateNaissance);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnValider);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModifierCompteForm";
            this.Text = "ModifierCompte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblModifierCompte;

        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.ComboBox comboBoxService;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox textBoxDateNaissance;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnValider;

        #endregion
    }
}