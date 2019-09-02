namespace BoneMarrow
{
    partial class frmCytogeneticsRep
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BoneMarrowResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BoneMarrowResultsTableAdapter = new BoneMarrow.BMDBDataSet4TableAdapters.BoneMarrowResultsTableAdapter();
            this.procSelectCytogeneticsTableAdapter1 = new BoneMarrow.BMDBDataSet4TableAdapters.ProcSelectCytogeneticsTableAdapter();
            this.selectCytogeneticsDataTableAdapter1 = new BoneMarrow.BMDBDataSetCytoTableAdapters.SelectCytogeneticsDataTableAdapter();
            this.bmdbDataSetCyto1 = new BoneMarrow.BMDBDataSetCyto();
            this.selectCytogeneticsDataTableAdapter2 = new BoneMarrow.BMDBDataSetCytoTableAdapters.SelectCytogeneticsDataTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BMDBDataSetCyto = new BoneMarrow.BMDBDataSetCyto();
            this.SelectCytogeneticsDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SelectCytogeneticsDataTableAdapter = new BoneMarrow.BMDBDataSetCytoTableAdapters.SelectCytogeneticsDataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BoneMarrowResultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmdbDataSetCyto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMDBDataSetCyto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectCytogeneticsDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BoneMarrowResultsTableAdapter
            // 
            this.BoneMarrowResultsTableAdapter.ClearBeforeFill = true;
            // 
            // procSelectCytogeneticsTableAdapter1
            // 
            this.procSelectCytogeneticsTableAdapter1.ClearBeforeFill = true;
            // 
            // selectCytogeneticsDataTableAdapter1
            // 
            this.selectCytogeneticsDataTableAdapter1.ClearBeforeFill = true;
            // 
            // bmdbDataSetCyto1
            // 
            this.bmdbDataSetCyto1.DataSetName = "BMDBDataSetCyto";
            this.bmdbDataSetCyto1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectCytogeneticsDataTableAdapter2
            // 
            this.selectCytogeneticsDataTableAdapter2.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SelectCytogeneticsDataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BoneMarrow.Reports.CytoGeneticsBMReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1274, 640);
            this.reportViewer1.TabIndex = 0;
            // 
            // BMDBDataSetCyto
            // 
            this.BMDBDataSetCyto.DataSetName = "BMDBDataSetCyto";
            this.BMDBDataSetCyto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SelectCytogeneticsDataBindingSource
            // 
            this.SelectCytogeneticsDataBindingSource.DataMember = "SelectCytogeneticsData";
            this.SelectCytogeneticsDataBindingSource.DataSource = this.BMDBDataSetCyto;
            // 
            // SelectCytogeneticsDataTableAdapter
            // 
            this.SelectCytogeneticsDataTableAdapter.ClearBeforeFill = true;
            // 
            // frmCytogeneticsRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 640);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmCytogeneticsRep";
            this.Text = "Cytogenetics Report";
            this.Load += new System.EventHandler(this.frmCytogeneticsRep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BoneMarrowResultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmdbDataSetCyto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMDBDataSetCyto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectCytogeneticsDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource BoneMarrowResultsBindingSource;
        private BMDBDataSet4TableAdapters.BoneMarrowResultsTableAdapter BoneMarrowResultsTableAdapter;
        private BMDBDataSet4TableAdapters.ProcSelectCytogeneticsTableAdapter procSelectCytogeneticsTableAdapter1;
        private BMDBDataSetCytoTableAdapters.SelectCytogeneticsDataTableAdapter selectCytogeneticsDataTableAdapter1;
        private BMDBDataSetCyto bmdbDataSetCyto1;
        private BMDBDataSetCytoTableAdapters.SelectCytogeneticsDataTableAdapter selectCytogeneticsDataTableAdapter2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SelectCytogeneticsDataBindingSource;
        private BMDBDataSetCyto BMDBDataSetCyto;
        private BMDBDataSetCytoTableAdapters.SelectCytogeneticsDataTableAdapter SelectCytogeneticsDataTableAdapter;
    }
}