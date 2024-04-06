namespace GestionEleve.Instructeur
{
    partial class InstructeurShow
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
            this.eLEVEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBAgenceDataSet = new GestionEleve.DBAgenceDataSet();
            this.nouveau = new System.Windows.Forms.Button();
            this.windowTitle = new System.Windows.Forms.Label();
            this.eLEVETableAdapter = new GestionEleve.DBAgenceDataSetTableAdapters.ELEVETableAdapter();
            this.draft = new System.Windows.Forms.Label();
            this.Erreur = new System.Windows.Forms.Label();
            this.eLEVEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.nomComplet = new System.Windows.Forms.TextBox();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.stars = new System.Windows.Forms.Panel();
            this.supprimer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.photo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.recherche = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.iDINSTRUCTEURDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMCOMPLETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEDENAISSANCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCOREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATIEREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNSTRUCTEURBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNSTRUCTEURTableAdapter = new GestionEleve.DBAgenceDataSetTableAdapters.INSTRUCTEURTableAdapter();
            this.tableAdapterManager = new GestionEleve.DBAgenceDataSetTableAdapters.TableAdapterManager();
            this.label2 = new System.Windows.Forms.Label();
            this.cin1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.matiere1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.eLEVEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBAgenceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLEVEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSTRUCTEURBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // nouveau
            // 
            this.nouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouveau.Location = new System.Drawing.Point(998, 34);
            this.nouveau.Name = "nouveau";
            this.nouveau.Size = new System.Drawing.Size(101, 36);
            this.nouveau.TabIndex = 48;
            this.nouveau.Text = "Nouveau +";
            this.nouveau.UseVisualStyleBackColor = true;
            this.nouveau.Click += new System.EventHandler(this.nouveau_Click);
            // 
            // windowTitle
            // 
            this.windowTitle.AutoSize = true;
            this.windowTitle.Font = new System.Drawing.Font("Cooper Black", 22.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowTitle.Location = new System.Drawing.Point(206, -1);
            this.windowTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.windowTitle.Name = "windowTitle";
            this.windowTitle.Size = new System.Drawing.Size(423, 44);
            this.windowTitle.TabIndex = 51;
            this.windowTitle.Text = "Gestion Instructeurs";
            // 
            // eLEVETableAdapter
            // 
            this.eLEVETableAdapter.ClearBeforeFill = true;
            // 
            // draft
            // 
            this.draft.AutoSize = true;
            this.draft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draft.Location = new System.Drawing.Point(810, 212);
            this.draft.Name = "draft";
            this.draft.Size = new System.Drawing.Size(0, 20);
            this.draft.TabIndex = 50;
            // 
            // Erreur
            // 
            this.Erreur.AutoSize = true;
            this.Erreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Erreur.ForeColor = System.Drawing.Color.Red;
            this.Erreur.Location = new System.Drawing.Point(778, 379);
            this.Erreur.Name = "Erreur";
            this.Erreur.Size = new System.Drawing.Size(0, 17);
            this.Erreur.TabIndex = 45;
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(939, 304);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(187, 22);
            this.dob.TabIndex = 43;
            this.dob.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dob.ValueChanged += new System.EventHandler(this.dob_ValueChanged);
            // 
            // nomComplet
            // 
            this.nomComplet.Location = new System.Drawing.Point(939, 271);
            this.nomComplet.Name = "nomComplet";
            this.nomComplet.Size = new System.Drawing.Size(187, 22);
            this.nomComplet.TabIndex = 42;
            this.nomComplet.TextChanged += new System.EventHandler(this.nomComplet_TextChanged);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(1013, 174);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(40, 36);
            this.minus.TabIndex = 41;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(1059, 174);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(40, 36);
            this.plus.TabIndex = 40;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // modifier
            // 
            this.modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.Location = new System.Drawing.Point(809, 402);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(119, 36);
            this.modifier.TabIndex = 39;
            this.modifier.Text = "Enregistrer";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // stars
            // 
            this.stars.Location = new System.Drawing.Point(967, 126);
            this.stars.Name = "stars";
            this.stars.Size = new System.Drawing.Size(178, 35);
            this.stars.TabIndex = 38;
            // 
            // supprimer
            // 
            this.supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.Location = new System.Drawing.Point(955, 402);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(108, 36);
            this.supprimer.TabIndex = 37;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(963, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Score :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(747, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Date de Naissance :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(747, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nom Complet :";
            // 
            // photo
            // 
            this.photo.InitialImage = null;
            this.photo.Location = new System.Drawing.Point(749, 34);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(176, 170);
            this.photo.TabIndex = 32;
            this.photo.TabStop = false;
            this.photo.Click += new System.EventHandler(this.photo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Recherche";
            // 
            // recherche
            // 
            this.recherche.Location = new System.Drawing.Point(20, 67);
            this.recherche.Name = "recherche";
            this.recherche.Size = new System.Drawing.Size(708, 22);
            this.recherche.TabIndex = 30;
            this.recherche.TextChanged += new System.EventHandler(this.recherche_TextChanged);
            // 
            // dataGrid
            // 
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDINSTRUCTEURDataGridViewTextBoxColumn,
            this.cINDataGridViewTextBoxColumn,
            this.nOMCOMPLETDataGridViewTextBoxColumn,
            this.dATEDENAISSANCEDataGridViewTextBoxColumn,
            this.sCOREDataGridViewTextBoxColumn,
            this.mATIEREDataGridViewTextBoxColumn});
            this.dataGrid.DataSource = this.iNSTRUCTEURBindingSource;
            this.dataGrid.Location = new System.Drawing.Point(20, 103);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(705, 323);
            this.dataGrid.TabIndex = 53;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick_1);
            this.dataGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_RowHeaderMouseClick);
            // 
            // iDINSTRUCTEURDataGridViewTextBoxColumn
            // 
            this.iDINSTRUCTEURDataGridViewTextBoxColumn.DataPropertyName = "ID_INSTRUCTEUR";
            this.iDINSTRUCTEURDataGridViewTextBoxColumn.HeaderText = "ID_INSTRUCTEUR";
            this.iDINSTRUCTEURDataGridViewTextBoxColumn.Name = "iDINSTRUCTEURDataGridViewTextBoxColumn";
            this.iDINSTRUCTEURDataGridViewTextBoxColumn.Width = 70;
            // 
            // cINDataGridViewTextBoxColumn
            // 
            this.cINDataGridViewTextBoxColumn.DataPropertyName = "CIN";
            this.cINDataGridViewTextBoxColumn.HeaderText = "CIN";
            this.cINDataGridViewTextBoxColumn.Name = "cINDataGridViewTextBoxColumn";
            // 
            // nOMCOMPLETDataGridViewTextBoxColumn
            // 
            this.nOMCOMPLETDataGridViewTextBoxColumn.DataPropertyName = "NOM_COMPLET";
            this.nOMCOMPLETDataGridViewTextBoxColumn.HeaderText = "NOM_COMPLET";
            this.nOMCOMPLETDataGridViewTextBoxColumn.Name = "nOMCOMPLETDataGridViewTextBoxColumn";
            this.nOMCOMPLETDataGridViewTextBoxColumn.Width = 150;
            // 
            // dATEDENAISSANCEDataGridViewTextBoxColumn
            // 
            this.dATEDENAISSANCEDataGridViewTextBoxColumn.DataPropertyName = "DATE_DE_NAISSANCE";
            this.dATEDENAISSANCEDataGridViewTextBoxColumn.HeaderText = "DATE_DE_NAISSANCE";
            this.dATEDENAISSANCEDataGridViewTextBoxColumn.Name = "dATEDENAISSANCEDataGridViewTextBoxColumn";
            this.dATEDENAISSANCEDataGridViewTextBoxColumn.Width = 170;
            // 
            // sCOREDataGridViewTextBoxColumn
            // 
            this.sCOREDataGridViewTextBoxColumn.DataPropertyName = "SCORE";
            this.sCOREDataGridViewTextBoxColumn.HeaderText = "SCORE";
            this.sCOREDataGridViewTextBoxColumn.Name = "sCOREDataGridViewTextBoxColumn";
            this.sCOREDataGridViewTextBoxColumn.Width = 70;
            // 
            // mATIEREDataGridViewTextBoxColumn
            // 
            this.mATIEREDataGridViewTextBoxColumn.DataPropertyName = "MATIERE";
            this.mATIEREDataGridViewTextBoxColumn.HeaderText = "MATIERE";
            this.mATIEREDataGridViewTextBoxColumn.Name = "mATIEREDataGridViewTextBoxColumn";
            // 
            // iNSTRUCTEURBindingSource
            // 
            this.iNSTRUCTEURBindingSource.DataMember = "INSTRUCTEUR";
            this.iNSTRUCTEURBindingSource.DataSource = this.dBAgenceDataSet;
            // 
            // iNSTRUCTEURTableAdapter
            // 
            this.iNSTRUCTEURTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ANNEE_SCOLAIRETableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ELEVETableAdapter = this.eLEVETableAdapter;
            this.tableAdapterManager.INSCRIPTIONTableAdapter = null;
            this.tableAdapterManager.INSTRUCTEURTableAdapter = this.iNSTRUCTEURTableAdapter;
            this.tableAdapterManager.UpdateOrder = GestionEleve.DBAgenceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(747, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Matiere :";
            // 
            // cin1
            // 
            this.cin1.Location = new System.Drawing.Point(939, 237);
            this.cin1.Name = "cin1";
            this.cin1.Size = new System.Drawing.Size(187, 22);
            this.cin1.TabIndex = 55;
            this.cin1.TextChanged += new System.EventHandler(this.cin1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(747, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "CIN :";
            // 
            // matiere1
            // 
            this.matiere1.FormattingEnabled = true;
            this.matiere1.Location = new System.Drawing.Point(939, 339);
            this.matiere1.Name = "matiere1";
            this.matiere1.Size = new System.Drawing.Size(187, 24);
            this.matiere1.TabIndex = 56;
            this.matiere1.SelectedIndexChanged += new System.EventHandler(this.matiere1_SelectedIndexChanged);
            // 
            // InstructeurShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.matiere1);
            this.Controls.Add(this.cin1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.nouveau);
            this.Controls.Add(this.windowTitle);
            this.Controls.Add(this.draft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Erreur);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.nomComplet);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.stars);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.photo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recherche);
            this.Name = "InstructeurShow";
            this.Size = new System.Drawing.Size(1164, 453);
            this.Load += new System.EventHandler(this.InstructeurShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eLEVEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBAgenceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLEVEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSTRUCTEURBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource eLEVEBindingSource1;
        private DBAgenceDataSet dBAgenceDataSet;
        private System.Windows.Forms.Button nouveau;
        private System.Windows.Forms.Label windowTitle;
        private DBAgenceDataSetTableAdapters.ELEVETableAdapter eLEVETableAdapter;
        private System.Windows.Forms.Label draft;
        private System.Windows.Forms.Label Erreur;
        private System.Windows.Forms.BindingSource eLEVEBindingSource;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.TextBox nomComplet;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Panel stars;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox recherche;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.BindingSource iNSTRUCTEURBindingSource;
        private DBAgenceDataSetTableAdapters.INSTRUCTEURTableAdapter iNSTRUCTEURTableAdapter;
        private DBAgenceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cin1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox matiere1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDINSTRUCTEURDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMCOMPLETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEDENAISSANCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCOREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATIEREDataGridViewTextBoxColumn;
    }
}
