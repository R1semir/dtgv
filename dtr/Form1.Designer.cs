namespace dtr
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbPersonelDataSet3 = new dtr.DbPersonelDataSet3();
            this.tBLBILGIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLBILGITableAdapter = new dtr.DbPersonelDataSet3TableAdapters.TBLBILGITableAdapter();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEHIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gOREVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durum2DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbPersonelDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLBILGIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.aDDataGridViewTextBoxColumn,
            this.sOYADDataGridViewTextBoxColumn,
            this.sEHIRDataGridViewTextBoxColumn,
            this.gOREVDataGridViewTextBoxColumn,
            this.mAASDataGridViewTextBoxColumn,
            this.durum2DataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tBLBILGIBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // dbPersonelDataSet3
            // 
            this.dbPersonelDataSet3.DataSetName = "DbPersonelDataSet3";
            this.dbPersonelDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLBILGIBindingSource
            // 
            this.tBLBILGIBindingSource.DataMember = "TBLBILGI";
            this.tBLBILGIBindingSource.DataSource = this.dbPersonelDataSet3;
            // 
            // tBLBILGITableAdapter
            // 
            this.tBLBILGITableAdapter.ClearBeforeFill = true;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDDataGridViewTextBoxColumn
            // 
            this.aDDataGridViewTextBoxColumn.DataPropertyName = "AD";
            this.aDDataGridViewTextBoxColumn.HeaderText = "AD";
            this.aDDataGridViewTextBoxColumn.Name = "aDDataGridViewTextBoxColumn";
            // 
            // sOYADDataGridViewTextBoxColumn
            // 
            this.sOYADDataGridViewTextBoxColumn.DataPropertyName = "SOYAD";
            this.sOYADDataGridViewTextBoxColumn.HeaderText = "SOYAD";
            this.sOYADDataGridViewTextBoxColumn.Name = "sOYADDataGridViewTextBoxColumn";
            // 
            // sEHIRDataGridViewTextBoxColumn
            // 
            this.sEHIRDataGridViewTextBoxColumn.DataPropertyName = "SEHIR";
            this.sEHIRDataGridViewTextBoxColumn.HeaderText = "SEHIR";
            this.sEHIRDataGridViewTextBoxColumn.Name = "sEHIRDataGridViewTextBoxColumn";
            // 
            // gOREVDataGridViewTextBoxColumn
            // 
            this.gOREVDataGridViewTextBoxColumn.DataPropertyName = "GOREV";
            this.gOREVDataGridViewTextBoxColumn.HeaderText = "GOREV";
            this.gOREVDataGridViewTextBoxColumn.Name = "gOREVDataGridViewTextBoxColumn";
            // 
            // mAASDataGridViewTextBoxColumn
            // 
            this.mAASDataGridViewTextBoxColumn.DataPropertyName = "MAAS";
            this.mAASDataGridViewTextBoxColumn.HeaderText = "MAAS";
            this.mAASDataGridViewTextBoxColumn.Name = "mAASDataGridViewTextBoxColumn";
            // 
            // durum2DataGridViewCheckBoxColumn
            // 
            this.durum2DataGridViewCheckBoxColumn.DataPropertyName = "Durum2";
            this.durum2DataGridViewCheckBoxColumn.HeaderText = "Durum2";
            this.durum2DataGridViewCheckBoxColumn.Name = "durum2DataGridViewCheckBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbPersonelDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLBILGIBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DbPersonelDataSet3 dbPersonelDataSet3;
        private System.Windows.Forms.BindingSource tBLBILGIBindingSource;
        private DbPersonelDataSet3TableAdapters.TBLBILGITableAdapter tBLBILGITableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEHIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gOREVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn durum2DataGridViewCheckBoxColumn;
    }
}

