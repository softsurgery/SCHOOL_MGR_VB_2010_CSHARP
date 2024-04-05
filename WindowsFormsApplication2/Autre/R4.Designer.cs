namespace GestionEleve.Autre
{
    partial class R4
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
            this.iNSTRUCTEURBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNSTRUCTEURTableAdapter = new GestionEleve.DBAgenceDataSetTableAdapters.INSTRUCTEURTableAdapter();
            this.cINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMCOMPLETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBAgenceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSTRUCTEURBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cINDataGridViewTextBoxColumn,
            this.nOMCOMPLETDataGridViewTextBoxColumn});
            this.dataGrid.DataSource = this.iNSTRUCTEURBindingSource;
            this.dataGrid.Location = new System.Drawing.Point(23, 22);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(294, 277);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // dBAgenceDataSet
            // 
            this.dBAgenceDataSet.DataSetName = "DBAgenceDataSet";
            this.dBAgenceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // R4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGrid);
            this.Name = "R4";
            this.Size = new System.Drawing.Size(344, 329);
            this.Load += new System.EventHandler(this.R4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBAgenceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSTRUCTEURBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMCOMPLETDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource iNSTRUCTEURBindingSource;
        private DBAgenceDataSet dBAgenceDataSet;
        private DBAgenceDataSetTableAdapters.INSTRUCTEURTableAdapter iNSTRUCTEURTableAdapter;
    }
}
