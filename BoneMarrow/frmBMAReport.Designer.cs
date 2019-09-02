namespace BoneMarrow
{
    partial class frmBMAReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBMAReport));
            this.SelectBMAsp_DATABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BMDBDataSet = new BoneMarrow.BMDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SelectBMAsp_DATATableAdapter = new BoneMarrow.BMDBDataSetTableAdapters.SelectBMAsp_DATATableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SelectBMAsp_DATABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectBMAsp_DATABindingSource
            // 
            this.SelectBMAsp_DATABindingSource.DataMember = "SelectBMAsp_DATA";
            this.SelectBMAsp_DATABindingSource.DataSource = this.BMDBDataSet;
            // 
            // BMDBDataSet
            // 
            this.BMDBDataSet.DataSetName = "BMDBDataSet";
            this.BMDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SelectBMAsp_DATABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BoneMarrow.Reports.BMAspReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(125, 36);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1147, 597);
            this.reportViewer1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 589);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(251, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show Aspirate Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ShowAspirateReport);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // SelectBMAsp_DATATableAdapter
            // 
            this.SelectBMAsp_DATATableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Medical Code";
            // 
            // frmBMAReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 640);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBMAReport";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bone Marrow Aspirate Report ";
            this.Load += new System.EventHandler(this.frmBMAReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectBMAsp_DATABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource SelectBMAsp_DATABindingSource;
        private BMDBDataSet BMDBDataSet;
        private BMDBDataSetTableAdapters.SelectBMAsp_DATATableAdapter SelectBMAsp_DATATableAdapter;
        private System.Windows.Forms.Label label1;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}