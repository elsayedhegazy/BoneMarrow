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
    public partial class frmCytogeneticsRep : Form
    {
        private int MyParam;

        public frmCytogeneticsRep(int PPiDD)
        {
            InitializeComponent();
            MyParam = PPiDD;

        }

        private void frmCytogeneticsRep_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BMDBDataSetCyto.SelectCytogeneticsData' table. You can move, or remove it, as needed.
            this.SelectCytogeneticsDataTableAdapter.FillBy(this.BMDBDataSetCyto.SelectCytogeneticsData,MyParam);
            

            
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
