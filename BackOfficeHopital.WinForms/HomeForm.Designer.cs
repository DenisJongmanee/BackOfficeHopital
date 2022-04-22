
namespace BackOfficeHopital.WinForms
{
    partial class HomeForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnComptesHabilites = new System.Windows.Forms.Button();
            this.lbxOccupationLits = new System.Windows.Forms.ListBox();
            this.lbxStockVaccins = new System.Windows.Forms.ListBox();
            this.lblOccupationLits = new System.Windows.Forms.Label();
            this.lblStocksVaccins = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnComptesHabilites
            // 
            this.btnComptesHabilites.Location = new System.Drawing.Point(24, 496);
            this.btnComptesHabilites.Name = "btnComptesHabilites";
            this.btnComptesHabilites.Size = new System.Drawing.Size(162, 49);
            this.btnComptesHabilites.TabIndex = 0;
            this.btnComptesHabilites.Text = "Comptes habilités";
            this.btnComptesHabilites.UseVisualStyleBackColor = true;
            this.btnComptesHabilites.Click += new System.EventHandler(this.btnComptesHabilites_Click);
            // 
            // lbxOccupationLits
            // 
            this.lbxOccupationLits.FormattingEnabled = true;
            this.lbxOccupationLits.ItemHeight = 16;
            this.lbxOccupationLits.Location = new System.Drawing.Point(24, 74);
            this.lbxOccupationLits.Name = "lbxOccupationLits";
            this.lbxOccupationLits.Size = new System.Drawing.Size(449, 388);
            this.lbxOccupationLits.TabIndex = 1;
            // 
            // lbxStockVaccins
            // 
            this.lbxStockVaccins.FormattingEnabled = true;
            this.lbxStockVaccins.ItemHeight = 16;
            this.lbxStockVaccins.Location = new System.Drawing.Point(499, 74);
            this.lbxStockVaccins.Name = "lbxStockVaccins";
            this.lbxStockVaccins.Size = new System.Drawing.Size(449, 388);
            this.lbxStockVaccins.TabIndex = 2;
            // 
            // lblOccupationLits
            // 
            this.lblOccupationLits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblOccupationLits.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblOccupationLits.Location = new System.Drawing.Point(119, 34);
            this.lblOccupationLits.Name = "lblOccupationLits";
            this.lblOccupationLits.Size = new System.Drawing.Size(267, 23);
            this.lblOccupationLits.TabIndex = 3;
            this.lblOccupationLits.Text = "Occupation des lits";
            this.lblOccupationLits.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblStocksVaccins
            // 
            this.lblStocksVaccins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblStocksVaccins.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblStocksVaccins.Location = new System.Drawing.Point(627, 34);
            this.lblStocksVaccins.Name = "lblStocksVaccins";
            this.lblStocksVaccins.Size = new System.Drawing.Size(221, 23);
            this.lblStocksVaccins.TabIndex = 4;
            this.lblStocksVaccins.Text = "Stock des vaccins";
            this.lblStocksVaccins.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 604);
            this.Controls.Add(this.lblStocksVaccins);
            this.Controls.Add(this.lblOccupationLits);
            this.Controls.Add(this.lbxStockVaccins);
            this.Controls.Add(this.lbxOccupationLits);
            this.Controls.Add(this.btnComptesHabilites);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblStocksVaccins;

        private System.Windows.Forms.Label lblOccupationLits;

        private System.Windows.Forms.ListBox lbxStockVaccins;

        private System.Windows.Forms.ListBox lbxOccupationLits;

        private System.Windows.Forms.ListBox listBox2;

        private System.Windows.Forms.Button btnComptesHabilites;
        private System.Windows.Forms.ListBox listBox1;

        #endregion
    }
}

