namespace GestionASForm
{
    partial class PageAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageAccueil));
            this.textBoxIdentifiant = new System.Windows.Forms.TextBox();
            this.textBoxMotDePasse = new System.Windows.Forms.TextBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.labelIdentifiant = new System.Windows.Forms.Label();
            this.labelMotDePasse = new System.Windows.Forms.Label();
            this.labelConnexion = new System.Windows.Forms.Label();
            this.panelConnexion = new System.Windows.Forms.Panel();
            this.logosv = new System.Windows.Forms.PictureBox();
            this.labelLyceeSaintVincent = new System.Windows.Forms.Label();
            this.labelAssociationSportive = new System.Windows.Forms.Label();
            this.panelConnexion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logosv)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxIdentifiant
            // 
            this.textBoxIdentifiant.Location = new System.Drawing.Point(45, 96);
            this.textBoxIdentifiant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxIdentifiant.Name = "textBoxIdentifiant";
            this.textBoxIdentifiant.Size = new System.Drawing.Size(286, 31);
            this.textBoxIdentifiant.TabIndex = 0;
            this.textBoxIdentifiant.TextChanged += new System.EventHandler(this.textBoxIdentifiant_TextChanged);
            // 
            // textBoxMotDePasse
            // 
            this.textBoxMotDePasse.Location = new System.Drawing.Point(45, 166);
            this.textBoxMotDePasse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMotDePasse.Name = "textBoxMotDePasse";
            this.textBoxMotDePasse.Size = new System.Drawing.Size(286, 31);
            this.textBoxMotDePasse.TabIndex = 1;
            this.textBoxMotDePasse.TextChanged += new System.EventHandler(this.textBoxMotDePasse_TextChanged);
            // 
            // buttonValider
            // 
            this.buttonValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.buttonValider.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.buttonValider.FlatAppearance.BorderSize = 5;
            this.buttonValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonValider.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValider.ForeColor = System.Drawing.Color.White;
            this.buttonValider.Location = new System.Drawing.Point(42, 244);
            this.buttonValider.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(144, 60);
            this.buttonValider.TabIndex = 2;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = false;
            this.buttonValider.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelIdentifiant
            // 
            this.labelIdentifiant.AutoSize = true;
            this.labelIdentifiant.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdentifiant.Location = new System.Drawing.Point(40, 68);
            this.labelIdentifiant.Name = "labelIdentifiant";
            this.labelIdentifiant.Size = new System.Drawing.Size(101, 24);
            this.labelIdentifiant.TabIndex = 3;
            this.labelIdentifiant.Text = "Identifiant";
            this.labelIdentifiant.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelMotDePasse
            // 
            this.labelMotDePasse.AutoSize = true;
            this.labelMotDePasse.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotDePasse.Location = new System.Drawing.Point(40, 138);
            this.labelMotDePasse.Name = "labelMotDePasse";
            this.labelMotDePasse.Size = new System.Drawing.Size(137, 24);
            this.labelMotDePasse.TabIndex = 4;
            this.labelMotDePasse.Text = "Mot de passe";
            this.labelMotDePasse.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelConnexion
            // 
            this.labelConnexion.AutoSize = true;
            this.labelConnexion.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnexion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.labelConnexion.Location = new System.Drawing.Point(39, 21);
            this.labelConnexion.Name = "labelConnexion";
            this.labelConnexion.Size = new System.Drawing.Size(147, 32);
            this.labelConnexion.TabIndex = 5;
            this.labelConnexion.Text = "Connexion";
            // 
            // panelConnexion
            // 
            this.panelConnexion.BackColor = System.Drawing.SystemColors.Window;
            this.panelConnexion.Controls.Add(this.labelIdentifiant);
            this.panelConnexion.Controls.Add(this.labelConnexion);
            this.panelConnexion.Controls.Add(this.textBoxIdentifiant);
            this.panelConnexion.Controls.Add(this.labelMotDePasse);
            this.panelConnexion.Controls.Add(this.textBoxMotDePasse);
            this.panelConnexion.Controls.Add(this.buttonValider);
            this.panelConnexion.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelConnexion.Location = new System.Drawing.Point(100, 256);
            this.panelConnexion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelConnexion.Name = "panelConnexion";
            this.panelConnexion.Size = new System.Drawing.Size(378, 324);
            this.panelConnexion.TabIndex = 6;
            this.panelConnexion.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logosv
            // 
            this.logosv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logosv.Image = ((System.Drawing.Image)(resources.GetObject("logosv.Image")));
            this.logosv.Location = new System.Drawing.Point(258, 31);
            this.logosv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logosv.Name = "logosv";
            this.logosv.Size = new System.Drawing.Size(64, 74);
            this.logosv.TabIndex = 7;
            this.logosv.TabStop = false;
            // 
            // labelLyceeSaintVincent
            // 
            this.labelLyceeSaintVincent.AutoSize = true;
            this.labelLyceeSaintVincent.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLyceeSaintVincent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.labelLyceeSaintVincent.Location = new System.Drawing.Point(100, 116);
            this.labelLyceeSaintVincent.Name = "labelLyceeSaintVincent";
            this.labelLyceeSaintVincent.Size = new System.Drawing.Size(391, 46);
            this.labelLyceeSaintVincent.TabIndex = 8;
            this.labelLyceeSaintVincent.Text = "Lycée Saint-Vincent";
            // 
            // labelAssociationSportive
            // 
            this.labelAssociationSportive.AutoSize = true;
            this.labelAssociationSportive.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssociationSportive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.labelAssociationSportive.Location = new System.Drawing.Point(125, 186);
            this.labelAssociationSportive.Name = "labelAssociationSportive";
            this.labelAssociationSportive.Size = new System.Drawing.Size(342, 38);
            this.labelAssociationSportive.TabIndex = 9;
            this.labelAssociationSportive.Text = "Association Sportive";
            // 
            // PageAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 635);
            this.Controls.Add(this.labelAssociationSportive);
            this.Controls.Add(this.labelLyceeSaintVincent);
            this.Controls.Add(this.logosv);
            this.Controls.Add(this.panelConnexion);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PageAccueil";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.PageAccueil_Load);
            this.panelConnexion.ResumeLayout(false);
            this.panelConnexion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logosv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Label labelIdentifiant;
        private System.Windows.Forms.Label labelMotDePasse;
        private System.Windows.Forms.Label labelConnexion;
        private System.Windows.Forms.Panel panelConnexion;
        private System.Windows.Forms.PictureBox logosv;
        private System.Windows.Forms.Label labelLyceeSaintVincent;
        private System.Windows.Forms.Label labelAssociationSportive;
        internal System.Windows.Forms.TextBox textBoxIdentifiant;
        internal System.Windows.Forms.TextBox textBoxMotDePasse;
    }
}