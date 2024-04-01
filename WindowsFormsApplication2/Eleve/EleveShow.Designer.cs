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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.iDELEVEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMCOMPLETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEDENAISSANCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEINSCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCOREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eLEVEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new GestionEleve.DBDataSet();
            this.eLEVETableAdapter = new GestionEleve.DBDataSetTableAdapters.ELEVETableAdapter();
            this.button1 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLEVEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDELEVEDataGridViewTextBoxColumn,
            this.nOMCOMPLETDataGridViewTextBoxColumn,
            this.dATEDENAISSANCEDataGridViewTextBoxColumn,
            this.dATEINSCRIPTIONDataGridViewTextBoxColumn,
            this.sCOREDataGridViewTextBoxColumn});
            this.dataGrid.DataSource = this.eLEVEBindingSource;
            this.dataGrid.Location = new System.Drawing.Point(18, 67);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(708, 241);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            this.dataGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_RowHeaderMouseClick);
            // 
            // iDELEVEDataGridViewTextBoxColumn
            // 
            this.iDELEVEDataGridViewTextBoxColumn.DataPropertyName = "ID_ELEVE";
            this.iDELEVEDataGridViewTextBoxColumn.HeaderText = "ID_ELEVE";
            this.iDELEVEDataGridViewTextBoxColumn.Name = "iDELEVEDataGridViewTextBoxColumn";
            // 
            // nOMCOMPLETDataGridViewTextBoxColumn
            // 
            this.nOMCOMPLETDataGridViewTextBoxColumn.DataPropertyName = "NOM_COMPLET";
            this.nOMCOMPLETDataGridViewTextBoxColumn.HeaderText = "NOM_COMPLET";
            this.nOMCOMPLETDataGridViewTextBoxColumn.Name = "nOMCOMPLETDataGridViewTextBoxColumn";
            // 
            // dATEDENAISSANCEDataGridViewTextBoxColumn
            // 
            this.dATEDENAISSANCEDataGridViewTextBoxColumn.DataPropertyName = "DATE_DE_NAISSANCE";
            this.dATEDENAISSANCEDataGridViewTextBoxColumn.HeaderText = "DATE_DE_NAISSANCE";
            this.dATEDENAISSANCEDataGridViewTextBoxColumn.Name = "dATEDENAISSANCEDataGridViewTextBoxColumn";
            // 
            // dATEINSCRIPTIONDataGridViewTextBoxColumn
            // 
            this.dATEINSCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DATE_INSCRIPTION";
            this.dATEINSCRIPTIONDataGridViewTextBoxColumn.HeaderText = "DATE_INSCRIPTION";
            this.dATEINSCRIPTIONDataGridViewTextBoxColumn.Name = "dATEINSCRIPTIONDataGridViewTextBoxColumn";
            // 
            // sCOREDataGridViewTextBoxColumn
            // 
            this.sCOREDataGridViewTextBoxColumn.DataPropertyName = "SCORE";
            this.sCOREDataGridViewTextBoxColumn.HeaderText = "SCORE";
            this.sCOREDataGridViewTextBoxColumn.Name = "sCOREDataGridViewTextBoxColumn";
            // 
            // eLEVEBindingSource
            // 
            this.eLEVEBindingSource.DataMember = "ELEVE";
            this.eLEVEBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eLEVETableAdapter
            // 
            this.eLEVETableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(324, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // recherche
            // 
            this.recherche.Location = new System.Drawing.Point(18, 34);
            this.recherche.Name = "recherche";
            this.recherche.Size = new System.Drawing.Size(708, 22);
            this.recherche.TabIndex = 2;
            this.recherche.TextChanged += new System.EventHandler(this.recherche_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Recherche";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // photo
            // 
            this.photo.InitialImage = null;
            this.photo.Location = new System.Drawing.Point(866, 11);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(166, 156);
            this.photo.TabIndex = 4;
            this.photo.TabStop = false;
            this.photo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(753, 234);
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
            this.label4.Location = new System.Drawing.Point(753, 267);
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
            this.label5.Location = new System.Drawing.Point(754, 298);
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
            this.label6.Location = new System.Drawing.Point(752, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Score :";
            // 
            // supprimer
            // 
            this.supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.Location = new System.Drawing.Point(961, 360);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(108, 36);
            this.supprimer.TabIndex = 10;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // stars
            // 
            this.stars.Location = new System.Drawing.Point(820, 186);
            this.stars.Name = "stars";
            this.stars.Size = new System.Drawing.Size(178, 35);
            this.stars.TabIndex = 15;
            this.stars.Paint += new System.Windows.Forms.PaintEventHandler(this.stars_Paint_1);
            // 
            // modifier
            // 
            this.modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.Location = new System.Drawing.Point(821, 360);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(119, 36);
            this.modifier.TabIndex = 16;
            this.modifier.Text = "Enregistrer";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(1050, 185);
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
            this.minus.Location = new System.Drawing.Point(1004, 185);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(40, 36);
            this.minus.TabIndex = 18;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // nomComplet
            // 
            this.nomComplet.Location = new System.Drawing.Point(945, 232);
            this.nomComplet.Name = "nomComplet";
            this.nomComplet.Size = new System.Drawing.Size(187, 22);
            this.nomComplet.TabIndex = 19;
            this.nomComplet.TextChanged += new System.EventHandler(this.nomComplet_TextChanged);
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(945, 265);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(187, 22);
            this.dob.TabIndex = 20;
            this.dob.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dob.ValueChanged += new System.EventHandler(this.dob_ValueChanged);
            // 
            // dateINS
            // 
            this.dateINS.Location = new System.Drawing.Point(945, 298);
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
            this.Erreur.Location = new System.Drawing.Point(863, 331);
            this.Erreur.Name = "Erreur";
            this.Erreur.Size = new System.Drawing.Size(0, 17);
            this.Erreur.TabIndex = 22;
            // 
            // EleveShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGrid);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EleveShow";
            this.Size = new System.Drawing.Size(1177, 410);
            this.Load += new System.EventHandler(this.EleveShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLEVEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDELEVEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMCOMPLETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEDENAISSANCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEINSCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCOREDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource eLEVEBindingSource;
        private DBDataSet dBDataSet;
        private DBDataSetTableAdapters.ELEVETableAdapter eLEVETableAdapter;
        private System.Windows.Forms.Button button1;
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

    }
}
