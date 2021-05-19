namespace GestionASForm
{
    partial class PageAccueilForm
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
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageAccueilForm));
            this.menuAS = new System.Windows.Forms.MenuStrip();
            this.ecranDeStatistiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionÉlèvesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionBudgetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comptabilitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoLycee = new System.Windows.Forms.PictureBox();
            this.bienvenueLabel = new System.Windows.Forms.Label();
            this.menuAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoLycee)).BeginInit();
            this.SuspendLayout();
            // 
            // menuAS
            // 
            this.menuAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.menuAS.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuAS.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuAS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ecranDeStatistiqueToolStripMenuItem,
            this.gestionÉlèvesToolStripMenuItem,
            this.gestionBudgetsToolStripMenuItem,
            this.comptabilitéToolStripMenuItem});
            this.menuAS.Location = new System.Drawing.Point(89, 0);
            this.menuAS.Name = "menuAS";
            this.menuAS.Padding = new System.Windows.Forms.Padding(9, 14, 14, 8);
            this.menuAS.Size = new System.Drawing.Size(933, 49);
            this.menuAS.TabIndex = 0;
            this.menuAS.Text = "menuStrip1";
            this.menuAS.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuAS_ItemClicked);
            // 
            // ecranDeStatistiqueToolStripMenuItem
            // 
            this.ecranDeStatistiqueToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ecranDeStatistiqueToolStripMenuItem.Name = "ecranDeStatistiqueToolStripMenuItem";
            this.ecranDeStatistiqueToolStripMenuItem.Size = new System.Drawing.Size(175, 27);
            this.ecranDeStatistiqueToolStripMenuItem.Text = "Ecran de statistique";
            this.ecranDeStatistiqueToolStripMenuItem.Click += new System.EventHandler(this.ecranDeStatistiqueToolStripMenuItem_Click);
            // 
            // gestionÉlèvesToolStripMenuItem
            // 
            this.gestionÉlèvesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gestionÉlèvesToolStripMenuItem.Name = "gestionÉlèvesToolStripMenuItem";
            this.gestionÉlèvesToolStripMenuItem.Size = new System.Drawing.Size(135, 27);
            this.gestionÉlèvesToolStripMenuItem.Text = "Gestion élèves";
            this.gestionÉlèvesToolStripMenuItem.Click += new System.EventHandler(this.gestionÉlèvesToolStripMenuItem_Click);
            // 
            // gestionBudgetsToolStripMenuItem
            // 
            this.gestionBudgetsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gestionBudgetsToolStripMenuItem.Name = "gestionBudgetsToolStripMenuItem";
            this.gestionBudgetsToolStripMenuItem.Size = new System.Drawing.Size(151, 27);
            this.gestionBudgetsToolStripMenuItem.Text = "Gestion budgets";
            this.gestionBudgetsToolStripMenuItem.Click += new System.EventHandler(this.gestionBudgetsToolStripMenuItem_Click);
            // 
            // comptabilitéToolStripMenuItem
            // 
            this.comptabilitéToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.comptabilitéToolStripMenuItem.Name = "comptabilitéToolStripMenuItem";
            this.comptabilitéToolStripMenuItem.Size = new System.Drawing.Size(124, 27);
            this.comptabilitéToolStripMenuItem.Text = "Comptabilité";
            this.comptabilitéToolStripMenuItem.Click += new System.EventHandler(this.comptabilitéToolStripMenuItem_Click);
            // 
            // logoLycee
            // 
            this.logoLycee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.logoLycee.Image = ((System.Drawing.Image)(resources.GetObject("logoLycee.Image")));
            this.logoLycee.Location = new System.Drawing.Point(101, 0);
            this.logoLycee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoLycee.Name = "logoLycee";
            this.logoLycee.Size = new System.Drawing.Size(51, 46);
            this.logoLycee.TabIndex = 1;
            this.logoLycee.TabStop = false;
            // 
            // bienvenueLabel
            // 
            this.bienvenueLabel.AutoSize = true;
            this.bienvenueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.bienvenueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.bienvenueLabel.Location = new System.Drawing.Point(380, 116);
            this.bienvenueLabel.Name = "bienvenueLabel";
            this.bienvenueLabel.Size = new System.Drawing.Size(349, 64);
            this.bienvenueLabel.TabIndex = 2;
            this.bienvenueLabel.Text = "BIENVENUE";
            this.bienvenueLabel.Click += new System.EventHandler(this.bienvenueLabel_Click);
            // 
            // PageAccueilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 383);
            this.Controls.Add(this.bienvenueLabel);
            this.Controls.Add(this.logoLycee);
            this.Controls.Add(this.menuAS);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PageAccueilForm";
            this.Padding = new System.Windows.Forms.Padding(89, 0, 0, 4);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PageAccueilForm_Load);
            this.menuAS.ResumeLayout(false);
            this.menuAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoLycee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuAS;
        private System.Windows.Forms.ToolStripMenuItem ecranDeStatistiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionÉlèvesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionBudgetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comptabilitéToolStripMenuItem;
        private System.Windows.Forms.PictureBox logoLycee;
        private System.Windows.Forms.Label bienvenueLabel;
    }
}

