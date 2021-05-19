namespace GestionASForm
{
    partial class GestionEleveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionEleveForm));
            this.logoLycee = new System.Windows.Forms.PictureBox();
            this.menuAS = new System.Windows.Forms.MenuStrip();
            this.ecranDeStatistiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionÉlèvesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionBudgetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comptabilitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.modifEleve = new System.Windows.Forms.Button();
            this.supp = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxRechercher = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.detailEleve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoLycee)).BeginInit();
            this.menuAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // logoLycee
            // 
            this.logoLycee.BackColor = System.Drawing.Color.MidnightBlue;
            this.logoLycee.Image = ((System.Drawing.Image)(resources.GetObject("logoLycee.Image")));
            this.logoLycee.Location = new System.Drawing.Point(11, 0);
            this.logoLycee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoLycee.Name = "logoLycee";
            this.logoLycee.Size = new System.Drawing.Size(51, 46);
            this.logoLycee.TabIndex = 3;
            this.logoLycee.TabStop = false;
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
            this.menuAS.Location = new System.Drawing.Point(0, 0);
            this.menuAS.Name = "menuAS";
            this.menuAS.Padding = new System.Windows.Forms.Padding(9, 14, 14, 7);
            this.menuAS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuAS.Size = new System.Drawing.Size(1604, 48);
            this.menuAS.TabIndex = 2;
            this.menuAS.Text = "menuStrip1";
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 178);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1355, 265);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // modifEleve
            // 
            this.modifEleve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.modifEleve.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.modifEleve.Location = new System.Drawing.Point(56, 495);
            this.modifEleve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifEleve.Name = "modifEleve";
            this.modifEleve.Size = new System.Drawing.Size(180, 35);
            this.modifEleve.TabIndex = 5;
            this.modifEleve.Text = "Modifier un élève";
            this.modifEleve.UseVisualStyleBackColor = false;
            this.modifEleve.Click += new System.EventHandler(this.modifEleve_Click);
            // 
            // supp
            // 
            this.supp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.supp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.supp.Location = new System.Drawing.Point(316, 495);
            this.supp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.supp.Name = "supp";
            this.supp.Size = new System.Drawing.Size(180, 35);
            this.supp.TabIndex = 6;
            this.supp.Text = "Supprimer un élève";
            this.supp.UseVisualStyleBackColor = false;
            this.supp.Click += new System.EventHandler(this.supp_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.buttonAjouter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAjouter.Location = new System.Drawing.Point(588, 495);
            this.buttonAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(147, 35);
            this.buttonAjouter.TabIndex = 7;
            this.buttonAjouter.Text = "Ajouter un élève";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1024, 495);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Actualiser";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxRechercher
            // 
            this.textBoxRechercher.Location = new System.Drawing.Point(196, 105);
            this.textBoxRechercher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRechercher.Name = "textBoxRechercher";
            this.textBoxRechercher.Size = new System.Drawing.Size(386, 22);
            this.textBoxRechercher.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(667, 98);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 43);
            this.button2.TabIndex = 10;
            this.button2.Text = "Rechercher un élève";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // detailEleve
            // 
            this.detailEleve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.detailEleve.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.detailEleve.Location = new System.Drawing.Point(792, 495);
            this.detailEleve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.detailEleve.Name = "detailEleve";
            this.detailEleve.Size = new System.Drawing.Size(180, 35);
            this.detailEleve.TabIndex = 11;
            this.detailEleve.Text = "Voir le détail";
            this.detailEleve.UseVisualStyleBackColor = false;
            this.detailEleve.Click += new System.EventHandler(this.detailEleve_Click);
            // 
            // GestionEleveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 580);
            this.Controls.Add(this.detailEleve);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxRechercher);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.supp);
            this.Controls.Add(this.modifEleve);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.logoLycee);
            this.Controls.Add(this.menuAS);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GestionEleveForm";
            this.Text = "GestionEleveForm";
            this.Load += new System.EventHandler(this.GestionEleveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoLycee)).EndInit();
            this.menuAS.ResumeLayout(false);
            this.menuAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoLycee;
        private System.Windows.Forms.MenuStrip menuAS;
        private System.Windows.Forms.ToolStripMenuItem ecranDeStatistiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionÉlèvesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionBudgetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comptabilitéToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button modifEleve;
        private System.Windows.Forms.Button supp;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxRechercher;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button detailEleve;
    }
}