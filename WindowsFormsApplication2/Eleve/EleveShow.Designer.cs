namespace GestionEleve.Eleve
{
    partial class EleveShow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.eLEVEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recherche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.photo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.supprimer = new System.Windows.Forms.Button();
            this.stars = new System.Windows.Forms.Panel();
            this.modifier = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.nomComplet = new System.Windows.Forms.TextBox();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.dateINS = new System.Windows.Forms.DateTimePicker();
            this.Erreur = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NS = new System.Windows.Forms.ComboBox();
            this.nouveau = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLASSIFICATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eLEVEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBAgenceDataSet = new GestionEleve.DBAgenceDataSet();
            this.eLEVETableAdapter = new GestionEleve.DBAgenceDataSetTableAdapters.ELEVETableAdapter();
            this.draft = new System.Windows.Forms.Label();
            this.windowTitle = new System.Windows.Forms.Label();
            this.souscrire = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eLEVEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLEVEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBAgenceDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // recherche
            // 
            this.recherche.Location = new System.Drawing.Point(19, 84);
            this.recherche.Name = "recherche";
            this.recherche.Size = new System.Drawing.Size(708, 22);
            this.recherche.TabIndex = 2;
            this.recherche.TextChanged += new System.EventHandler(this.recherche_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Recherche";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // photo
            // 
            this.photo.InitialImage = null;
            this.photo.Location = new System.Drawing.Point(758, 33);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(176, 170);
            this.photo.TabIndex = 4;
            this.photo.TabStop = false;
            this.photo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(753, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nom Complet :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(753, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date de Naissance :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(754, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date d\'Inscription :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(962, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Score :";
            // 
            // supprimer
            // 
            this.supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.Location = new System.Drawing.Point(903, 419);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(108, 36);
            this.supprimer.TabIndex = 10;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // stars
            // 
            this.stars.Location = new System.Drawing.Point(966, 143);
            this.stars.Name = "stars";
            this.stars.Size = new System.Drawing.Size(178, 35);
            this.stars.TabIndex = 15;
            this.stars.Paint += new System.Windows.Forms.PaintEventHandler(this.stars_Paint_1);
            // 
            // modifier
            // 
            this.modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.Location = new System.Drawing.Point(772, 419);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(119, 36);
            this.modifier.TabIndex = 16;
            this.modifier.Text = "Enregistrer";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(1058, 191);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(40, 36);
            this.plus.TabIndex = 17;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(1012, 191);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(40, 36);
            this.minus.TabIndex = 18;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // nomComplet
            // 
            this.nomComplet.Location = new System.Drawing.Point(945, 244);
            this.nomComplet.Name = "nomComplet";
            this.nomComplet.Size = new System.Drawing.Size(187, 22);
            this.nomComplet.TabIndex = 19;
            this.nomComplet.TextChanged += new System.EventHandler(this.nomComplet_TextChanged);
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(945, 277);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(187, 22);
            this.dob.TabIndex = 20;
            this.dob.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dob.ValueChanged += new System.EventHandler(this.dob_ValueChanged);
            // 
            // dateINS
            // 
            this.dateINS.Location = new System.Drawing.Point(945, 310);
            this.dateINS.Name = "dateINS";
            this.dateINS.Size = new System.Drawing.Size(187, 22);
            this.dateINS.TabIndex = 21;
            this.dateINS.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dateINS.ValueChanged += new System.EventHandler(this.dateINS_ValueChanged);
            // 
            // Erreur
            // 
            this.Erreur.AutoSize = true;
            this.Erreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Erreur.ForeColor = System.Drawing.Color.Red;
            this.Erreur.Location = new System.Drawing.Point(780, 391);
            this.Erreur.Name = "Erreur";
            this.Erreur.Size = new System.Drawing.Size(0, 17);
            this.Erreur.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(754, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Niveau-Section";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NS
            // 
            this.NS.FormattingEnabled = true;
            this.NS.Location = new System.Drawing.Point(945, 340);
            this.NS.Name = "NS";
            this.NS.Size = new System.Drawing.Size(187, 24);
            this.NS.TabIndex = 24;
            this.NS.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // nouveau
            // 
            this.nouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouveau.Location = new System.Drawing.Point(997, 51);
            this.nouveau.Name = "nouveau";
            this.nouveau.Size = new System.Drawing.Size(101, 36);
            this.nouveau.TabIndex = 25;
            this.nouveau.Text = "Nouveau +";
            this.nouveau.UseVisualStyleBackColor = true;
            this.nouveau.Click += new System.EventHandler(this.nouveau_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.cLASSIFICATIONDataGridViewTextBoxColumn});
            this.dataGrid.DataSource = this.eLEVEBindingSource1;
            this.dataGrid.Location = new System.Drawing.Point(21, 143);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(705, 327);
            this.dataGrid.TabIndex = 26;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick_1);
            this.dataGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_RowHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_ELEVE";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_ELEVE";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOM_COMPLET";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOM_COMPLET";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DATE_DE_NAISSANCE";
            this.dataGridViewTextBoxColumn3.HeaderText = "DATE_DE_NAISSANCE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DATE_INSCRIPTION";
            this.dataGridViewTextBoxColumn4.HeaderText = "DATE_INSCRIPTION";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SCORE";
            this.dataGridViewTextBoxColumn5.HeaderText = "SCORE";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // cLASSIFICATIONDataGridViewTextBoxColumn
            // 
            this.cLASSIFICATIONDataGridViewTextBoxColumn.DataPropertyName = "CLASSIFICATION";
            this.cLASSIFICATIONDataGridViewTextBoxColumn.HeaderText = "CLASSIFICATION";
            this.cLASSIFICATIONDataGridViewTextBoxColumn.Name = "cLASSIFICATIONDataGridViewTextBoxColumn";
            // 
            // eLEVEBindingSource1
            // 
            this.eLEVEBindingSource1.DataMember = "ELEVE";
            this.eLEVEBindingSource1.DataSource = this.dBAgenceDataSet;
            // 
            // dBAgenceDataSet
            // 
            this.dBAgenceDataSet.DataSetName = "DBAgenceDataSet";
            this.dBAgenceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eLEVETableAdapter
            // 
            this.eLEVETableAdapter.ClearBeforeFill = true;
            // 
            // draft
            // 
            this.draft.AutoSize = true;
            this.draft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draft.Location = new System.Drawing.Point(811, 207);
            this.draft.Name = "draft";
            this.draft.Size = new System.Drawing.Size(0, 20);
            this.draft.TabIndex = 27;
            // 
            // windowTitle
            // 
            this.windowTitle.AutoSize = true;
            this.windowTitle.Font = new System.Drawing.Font("Cooper Black", 22.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowTitle.Location = new System.Drawing.Point(205, 16);
            this.windowTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.windowTitle.Name = "windowTitle";
            this.windowTitle.Size = new System.Drawing.Size(300, 44);
            this.windowTitle.TabIndex = 28;
            this.windowTitle.Text = "Gestion Eleves";
            // 
            // souscrire
            // 
            this.souscrire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.souscrire.Location = new System.Drawing.Point(1026, 418);
            this.souscrire.Name = "souscrire";
            this.souscrire.Size = new System.Drawing.Size(108, 36);
            this.souscrire.TabIndex = 29;
            this.souscrire.Text = "Souscrire ";
            this.souscrire.UseVisualStyleBackColor = true;
            this.souscrire.Click += new System.EventHandler(this.souscrire_Click);
            // 
            // EleveShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.souscrire);
            this.Controls.Add(this.windowTitle);
            this.Controls.Add(this.draft);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.nouveau);
            this.Controls.Add(this.NS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Erreur);
            this.Controls.Add(this.dateINS);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.nomComplet);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.stars);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.photo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recherche);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EleveShow";
            this.Size = new System.Drawing.Size(1177, 479);
            this.Load += new System.EventHandler(this.EleveShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eLEVEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLEVEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBAgenceDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.BindingSource eLEVEBindingSource;
        
        private System.Windows.Forms.TextBox recherche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Panel stars;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.TextBox nomComplet;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.DateTimePicker dateINS;
        private System.Windows.Forms.Label Erreur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox NS;
        private System.Windows.Forms.Button nouveau;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLASSIFICATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource eLEVEBindingSource1;
        private DBAgenceDataSet dBAgenceDataSet;
        private DBAgenceDataSetTableAdapters.ELEVETableAdapter eLEVETableAdapter;
        private System.Windows.Forms.Label draft;
        private System.Windows.Forms.Label windowTitle;
        private System.Windows.Forms.Button souscrire;

    }
}
