using System.ComponentModel;

namespace BackOfficeHopital.WinForms
{
    partial class Comptes
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
            this.lbxComptes = new System.Windows.Forms.ListBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblComptes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxComptes
            // 
            this.lbxComptes.FormattingEnabled = true;
            this.lbxComptes.ItemHeight = 16;
            this.lbxComptes.Location = new System.Drawing.Point(26, 69);
            this.lbxComptes.Name = "lbxComptes";
            this.lbxComptes.Size = new System.Drawing.Size(673, 516);
            this.lbxComptes.TabIndex = 0;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(750, 69);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(179, 45);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter un compte";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(750, 139);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(179, 45);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(750, 208);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(179, 45);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(750, 540);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(179, 45);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Retour à l\'accueil";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblComptes
            // 
            this.lblComptes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblComptes.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblComptes.Location = new System.Drawing.Point(219, 24);
            this.lblComptes.Name = "lblComptes";
            this.lblComptes.Size = new System.Drawing.Size(372, 23);
            this.lblComptes.TabIndex = 5;
            this.lblComptes.Text = "Gestion des comptes habilités";
            this.lblComptes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblComptes.Click += new System.EventHandler(this.lblComptes_Click);
            // 
            // Comptes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 605);
            this.Controls.Add(this.lblComptes);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lbxComptes);
            this.Name = "Comptes";
            this.Text = "Comptes";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblComptes;

        private System.Windows.Forms.Button btnHome;

        private System.Windows.Forms.Button btnSupprimer;

        private System.Windows.Forms.Button btnModifier;

        private System.Windows.Forms.ListBox lbxComptes;
        private System.Windows.Forms.Button btnAjouter;

        private System.Windows.Forms.ListBox listBox1;

        #endregion
    }
}