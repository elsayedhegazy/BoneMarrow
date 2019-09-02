using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BoneMarrow
{
    public partial class frmBMAReport : Form
    {
        private int MyParam;

        public frmBMAReport(int PPiDD)
        {
            InitializeComponent();

            MyParam = PPiDD;
        }

        private void frmBMAReport_Load(object sender, EventArgs e)
        {
            try
            {
                var DC1Context = new DataClasses1DataContext();
                var PatintDataTable = new PatientDetail();

                //=============================================================================

                var LoopListBox = from DD in DC1Context.PatientDetails
                                  
                                  select DD;
                foreach (var DD in LoopListBox)
                {
                    listBox1.Items.Add(DD.PatientID);
                }




            }
            catch { ; }

            
            //this.reportViewer1.RefreshReport();
            this.SelectBMAsp_DATATableAdapter.FillBy(this.BMDBDataSet.SelectBMAsp_DATA, MyParam);
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            
            this.reportViewer1.RefreshReport();
            
            
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SelectBMAsp_DATABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BoneMarrow.Reports.BMAspReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(125, 34);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1106, 718);
            this.reportViewer1.TabIndex = 0;

           // reportViewer1.Reset();
            MyParam = int.Parse(listBox1.SelectedItem.ToString());

            this.SelectBMAsp_DATATableAdapter.FillBy(this.BMDBDataSet.SelectBMAsp_DATA, MyParam);
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

            this.reportViewer1.RefreshReport();

        }

        private void ShowAspirateReport(object sender, EventArgs e)
        {
            //Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            //reportDataSource1.Name = "DataSet1";
            //reportDataSource1.Value = this.SelectBMAsp_DATABindingSource;
            //this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            //this.reportViewer1.LocalReport.ReportEmbeddedResource = "BoneMarrow.Reports.BMAspReport.rdlc";
            //this.reportViewer1.Location = new System.Drawing.Point(125, 34);
            //this.reportViewer1.Name = "reportViewer1";
            //this.reportViewer1.Size = new System.Drawing.Size(1106, 718);
            //this.reportViewer1.TabIndex = 0;

            try
            {
                //reportViewer1.Reset();
                MyParam = int.Parse(textBox1.Text);

                this.SelectBMAsp_DATATableAdapter.FillBy(this.BMDBDataSet.SelectBMAsp_DATA, MyParam);
                this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

                this.reportViewer1.RefreshReport();
            }
            catch { ;}
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.PerformClick();
        }
    }
}
