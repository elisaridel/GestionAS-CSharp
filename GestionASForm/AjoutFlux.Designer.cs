namespace GestionASForm
{
    partial class AjoutFlux
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.adherentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.typefluxBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.typefluxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.budgetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.etatPrelev = new System.Windows.Forms.ComboBox();
            this.gestionASDataSet9BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionASDataSet8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gestionASDataSet1 = new GestionASForm.gestionASDataSet1();
            this.typefluxBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.type_fluxTableAdapter = new GestionASForm.gestionASDataSet1TableAdapters.type_fluxTableAdapter();
            this.typefluxBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tout = new GestionASForm.tout();
            this.toutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budget = new GestionASForm.budget();
            this.budgetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.budgetTableAdapter = new GestionASForm.budgetTableAdapters.budgetTableAdapter();
            this.adherent = new GestionASForm.adherent();
            this.adherentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.adherentTableAdapter = new GestionASForm.adherentTableAdapters.adherentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typefluxBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typefluxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionASDataSet9BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionASDataSet8BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionASDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typefluxBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typefluxBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.adherentBindingSource1, "numtel_adherent", true));
            this.comboBox1.DataSource = this.adherentBindingSource1;
            this.comboBox1.DisplayMember = "nom_adherent";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(430, 78);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "id_adherent";
            // 
            // adherentBindingSource
            // 
            this.adherentBindingSource.DataMember = "adherent";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.typefluxBindingSource3, "id_typeflux", true));
            this.comboBox2.DataSource = this.typefluxBindingSource2;
            this.comboBox2.DisplayMember = "libelle_typeflux";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(430, 165);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(108, 24);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "id_typeflux";
            // 
            // typefluxBindingSource1
            // 
            this.typefluxBindingSource1.DataMember = "type_flux";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adherent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type flux";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.budgetBindingSource1;
            this.comboBox3.DisplayMember = "libelle_budget";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(430, 227);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(108, 24);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.ValueMember = "id_budget";
            // 
            // budgetBindingSource
            // 
            this.budgetBindingSource.DataMember = "budget";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Budget";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "libelle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Montant";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(72, 165);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 78);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 22);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 232);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(89, 22);
            this.textBox2.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 282);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Etat du prélèvement";
            // 
            // etatPrelev
            // 
            this.etatPrelev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.etatPrelev.FormattingEnabled = true;
            this.etatPrelev.Items.AddRange(new object[] {
            "Effectué",
            "En cours",
            "Aucun"});
            this.etatPrelev.Location = new System.Drawing.Point(71, 292);
            this.etatPrelev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.etatPrelev.Name = "etatPrelev";
            this.etatPrelev.Size = new System.Drawing.Size(108, 24);
            this.etatPrelev.TabIndex = 14;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // gestionASDataSet1
            // 
            this.gestionASDataSet1.DataSetName = "gestionASDataSet1";
            this.gestionASDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typefluxBindingSource2
            // 
            this.typefluxBindingSource2.DataMember = "type_flux";
            this.typefluxBindingSource2.DataSource = this.gestionASDataSet1;
            // 
            // type_fluxTableAdapter
            // 
            this.type_fluxTableAdapter.ClearBeforeFill = true;
            // 
            // typefluxBindingSource3
            // 
            this.typefluxBindingSource3.DataMember = "type_flux";
            this.typefluxBindingSource3.DataSource = this.gestionASDataSet1;
            // 
            // tout
            // 
            this.tout.DataSetName = "tout";
            this.tout.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toutBindingSource
            // 
            this.toutBindingSource.DataSource = this.tout;
            this.toutBindingSource.Position = 0;
            // 
            // budget
            // 
            this.budget.DataSetName = "budget";
            this.budget.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // budgetBindingSource1
            // 
            this.budgetBindingSource1.DataMember = "budget";
            this.budgetBindingSource1.DataSource = this.budget;
            // 
            // budgetTableAdapter
            // 
            this.budgetTableAdapter.ClearBeforeFill = true;
            // 
            // adherent
            // 
            this.adherent.DataSetName = "adherent";
            this.adherent.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adherentBindingSource1
            // 
            this.adherentBindingSource1.DataMember = "adherent";
            this.adherentBindingSource1.DataSource = this.adherent;
            // 
            // adherentTableAdapter
            // 
            this.adherentTableAdapter.ClearBeforeFill = true;
            // 
            // AjoutFlux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.etatPrelev);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AjoutFlux";
            this.Text = "AjoutFlux";
            this.Load += new System.EventHandler(this.AjoutFlux_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typefluxBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typefluxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionASDataSet9BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionASDataSet8BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionASDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typefluxBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typefluxBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource adherentBindingSource;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource typefluxBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource budgetBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox etatPrelev;
        private System.Windows.Forms.BindingSource gestionASDataSet8BindingSource;
        private System.Windows.Forms.BindingSource gestionASDataSet9BindingSource;
        private System.Windows.Forms.BindingSource typefluxBindingSource1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider7;
        private gestionASDataSet1 gestionASDataSet1;
        private System.Windows.Forms.BindingSource typefluxBindingSource2;
        private gestionASDataSet1TableAdapters.type_fluxTableAdapter type_fluxTableAdapter;
        private System.Windows.Forms.BindingSource typefluxBindingSource3;
        private System.Windows.Forms.BindingSource toutBindingSource;
        private tout tout;
        private budget budget;
        private System.Windows.Forms.BindingSource budgetBindingSource1;
        private budgetTableAdapters.budgetTableAdapter budgetTableAdapter;
        private adherent adherent;
        private System.Windows.Forms.BindingSource adherentBindingSource1;
        private adherentTableAdapters.adherentTableAdapter adherentTableAdapter;
    }
}