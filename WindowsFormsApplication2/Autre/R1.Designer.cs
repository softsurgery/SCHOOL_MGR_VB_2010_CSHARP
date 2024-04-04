namespace GestionEleve.Autre
{
    partial class R1
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
            this.dBAgenceDataSet = new GestionEleve.DBAgenceDataSet();
            this.eLEVEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eLEVETableAdapter = new GestionEleve.DBAgenceDataSetTableAdapters.ELEVETableAdapter();
            this.iDELEVEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMCOMPLETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBAgenceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLEVEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDELEVEDataGridViewTextBoxColumn,
            this.nOMCOMPLETDataGridViewTextBoxColumn});
            this.dataGrid.DataSource = this.eLEVEBindingSource;
            this.dataGrid.Location = new System.Drawing.Point(21, 21);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(293, 244);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // dBAgenceDataSet
            // 
            this.dBAgenceDataSet.DataSetName = "DBAgenceDataSet";
            this.dBAgenceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eLEVEBindingSource
            // 
            this.eLEVEBindingSource.DataMember = "ELEVE";
            this.eLEVEBindingSource.DataSource = this.dBAgenceDataSet;
            // 
            // eLEVETableAdapter
            // 
            this.eLEVETableAdapter.ClearBeforeFill = true;
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
            this.nOMCOMPLETDataGridViewTextBoxColumn.Width = 150;
            // 
            // R1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGrid);
            this.Name = "R1";
            this.Size = new System.Drawing.Size(339, 308);
            this.Load += new System.EventHandler(this.R1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBAgenceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLEVEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.BindingSource eLEVEBindingSource;
        private DBAgenceDataSet dBAgenceDataSet;
        private DBAgenceDataSetTableAdapters.ELEVETableAdapter eLEVETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDELEVEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMCOMPLETDataGridViewTextBoxColumn;
    }
}
