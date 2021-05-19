namespace GestionASForm
{
    partial class GestionBudgetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionBudgetForm));
            this.menuAS = new System.Windows.Forms.MenuStrip();
            this.ecranDeStatistiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionÉlèvesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionBudgetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comptabilitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoLycee = new System.Windows.Forms.PictureBox();
            this.lblBudget = new System.Windows.Forms.Label();
            this.addBudget = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.affichageFlux = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.menuAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoLycee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.menuAS.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuAS.Location = new System.Drawing.Point(0, 0);
            this.menuAS.Name = "menuAS";
            this.menuAS.Padding = new System.Windows.Forms.Padding(9, 14, 14, 8);
            this.menuAS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuAS.Size = new System.Drawing.Size(1172, 49);
            this.menuAS.TabIndex = 1;
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
            this.gestionÉlèvesToolStripMenuItem.Click += new System.EventHandler(this.gestionÉlèvesToolStripMenuItem_Click);
            // 
            // gestionBudgetsToolStripMenuItem
            // 
            this.gestionBudgetsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gestionBudgetsToolStripMenuItem.Name = "gestionBudgetsToolStripMenuItem";
            this.gestionBudgetsToolStripMenuItem.Size = new System.Drawing.Size(151, 27);
            this.gestionBudgetsToolStripMenuItem.Text = "Gestion budgets";
            // 
            // comptabilitéToolStripMenuItem
            // 
            this.comptabilitéToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.comptabilitéToolStripMenuItem.Name = "comptabilitéToolStripMenuItem";
            this.comptabilitéToolStripMenuItem.Size = new System.Drawing.Size(124, 27);
            this.comptabilitéToolStripMenuItem.Text = "Comptabilité";
            // 
            // logoLycee
            // 
            this.logoLycee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.logoLycee.Image = ((System.Drawing.Image)(resources.GetObject("logoLycee.Image")));
            this.logoLycee.Location = new System.Drawing.Point(41, 0);
            this.logoLycee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoLycee.Name = "logoLycee";
            this.logoLycee.Size = new System.Drawing.Size(50, 46);
            this.logoLycee.TabIndex = 2;
            this.logoLycee.TabStop = false;
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblBudget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.lblBudget.Location = new System.Drawing.Point(34, 60);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(177, 44);
            this.lblBudget.TabIndex = 3;
            this.lblBudget.Text = "BUDGET";
            // 
            // addBudget
            // 
            this.addBudget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.addBudget.ForeColor = System.Drawing.Color.White;
            this.addBudget.Location = new System.Drawing.Point(251, 60);
            this.addBudget.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBudget.Name = "addBudget";
            this.addBudget.Size = new System.Drawing.Size(144, 37);
            this.addBudget.TabIndex = 4;
            this.addBudget.Text = "Ajouter un budget";
            this.addBudget.UseVisualStyleBackColor = false;
            this.addBudget.Click += new System.EventHandler(this.addBudget_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 133);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(929, 218);
            this.dataGridView1.TabIndex = 5;
            // 
            // affichageFlux
            // 
            this.affichageFlux.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.affichageFlux.ForeColor = System.Drawing.Color.White;
            this.affichageFlux.Location = new System.Drawing.Point(41, 373);
            this.affichageFlux.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.affichageFlux.Name = "affichageFlux";
            this.affichageFlux.Size = new System.Drawing.Size(144, 37);
            this.affichageFlux.TabIndex = 6;
            this.affichageFlux.Text = "Afficher les flux";
            this.affichageFlux.UseVisualStyleBackColor = false;
            this.affichageFlux.Click += new System.EventHandler(this.affichageFlux_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(228, 373);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Modifier un budget";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(419, 373);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Supprimer un budget";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(53, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 44);
            this.label1.TabIndex = 9;
            this.label1.Text = "Budget AS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.label2.Location = new System.Drawing.Point(53, 570);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 44);
            this.label2.TabIndex = 12;
            this.label2.Text = "Budget EPS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(269, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(269, 579);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(826, 60);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 37);
            this.button3.TabIndex = 15;
            this.button3.Text = "Actualiser";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GestionBudgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 840);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.affichageFlux);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addBudget);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.logoLycee);
            this.Controls.Add(this.menuAS);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GestionBudgetForm";
            this.Text = "GestionBudgetForm";
            this.Load += new System.EventHandler(this.GestionBudgetForm_Load);
            this.menuAS.ResumeLayout(false);
            this.menuAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoLycee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Button addBudget;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button affichageFlux;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
    }
}