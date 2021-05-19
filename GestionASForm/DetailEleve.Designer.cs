namespace GestionASForm
{
    partial class DetailEleve
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
            this.menuAS = new System.Windows.Forms.MenuStrip();
            this.ecranDeStatistiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nom = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.Label();
            this.classe = new System.Windows.Forms.Label();
            this.prelevLabel = new System.Windows.Forms.Label();
            this.prelev = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelFlux = new System.Windows.Forms.Label();
            this.menuAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuAS
            // 
            this.menuAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.menuAS.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuAS.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuAS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ecranDeStatistiqueToolStripMenuItem});
            this.menuAS.Location = new System.Drawing.Point(0, 0);
            this.menuAS.Name = "menuAS";
            this.menuAS.Padding = new System.Windows.Forms.Padding(9, 14, 14, 8);
            this.menuAS.Size = new System.Drawing.Size(1245, 49);
            this.menuAS.TabIndex = 7;
            this.menuAS.Text = "menuStrip1";
            // 
            // ecranDeStatistiqueToolStripMenuItem
            // 
            this.ecranDeStatistiqueToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ecranDeStatistiqueToolStripMenuItem.Name = "ecranDeStatistiqueToolStripMenuItem";
            this.ecranDeStatistiqueToolStripMenuItem.Size = new System.Drawing.Size(77, 27);
            this.ecranDeStatistiqueToolStripMenuItem.Text = "Retour";
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.98507F);
            this.nom.Location = new System.Drawing.Point(54, 72);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(67, 29);
            this.nom.TabIndex = 8;
            this.nom.Text = "Nom";
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.98507F);
            this.prenom.Location = new System.Drawing.Point(182, 72);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(99, 29);
            this.prenom.TabIndex = 9;
            this.prenom.Text = "prenom";
            // 
            // classe
            // 
            this.classe.AutoSize = true;
            this.classe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.98507F);
            this.classe.Location = new System.Drawing.Point(334, 72);
            this.classe.Name = "classe";
            this.classe.Size = new System.Drawing.Size(86, 29);
            this.classe.TabIndex = 10;
            this.classe.Text = "classe";
            // 
            // prelevLabel
            // 
            this.prelevLabel.AutoSize = true;
            this.prelevLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.98507F);
            this.prelevLabel.Location = new System.Drawing.Point(54, 143);
            this.prelevLabel.Name = "prelevLabel";
            this.prelevLabel.Size = new System.Drawing.Size(267, 29);
            this.prelevLabel.TabIndex = 11;
            this.prelevLabel.Text = "Prélèvement autorisé :";
            // 
            // prelev
            // 
            this.prelev.AutoSize = true;
            this.prelev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.98507F);
            this.prelev.Location = new System.Drawing.Point(339, 143);
            this.prelev.Name = "prelev";
            this.prelev.Size = new System.Drawing.Size(82, 29);
            this.prelev.TabIndex = 12;
            this.prelev.Text = "prelev";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 57;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1147, 238);
            this.dataGridView1.TabIndex = 13;
            // 
            // labelFlux
            // 
            this.labelFlux.AutoSize = true;
            this.labelFlux.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.98507F);
            this.labelFlux.Location = new System.Drawing.Point(59, 204);
            this.labelFlux.Name = "labelFlux";
            this.labelFlux.Size = new System.Drawing.Size(74, 29);
            this.labelFlux.TabIndex = 14;
            this.labelFlux.Text = "Flux :";
            // 
            // DetailEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 656);
            this.Controls.Add(this.labelFlux);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.prelev);
            this.Controls.Add(this.prelevLabel);
            this.Controls.Add(this.classe);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.menuAS);
            this.Name = "DetailEleve";
            this.Text = "DetailEleve";
            this.Load += new System.EventHandler(this.DetailEleve_Load);
            this.menuAS.ResumeLayout(false);
            this.menuAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuAS;
        private System.Windows.Forms.ToolStripMenuItem ecranDeStatistiqueToolStripMenuItem;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.Label classe;
        private System.Windows.Forms.Label prelevLabel;
        private System.Windows.Forms.Label prelev;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelFlux;
    }
}