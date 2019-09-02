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
    public partial class frmImagesReport : Form
    {
        private int ParamIDD;
        public frmImagesReport(int IDID)
        {
            InitializeComponent();
            ParamIDD = IDID;
        }

        private void frmImagesReport_Load(object sender, EventArgs e)
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


            
            // TODO: This line of code loads data into the 'BMDBDataSet.SelectBoneMarrowImages' table. You can move, or remove it, as needed.
            this.SelectBoneMarrowImagesTableAdapter.FillBy(this.BMDBDataSet.SelectBoneMarrowImages, ParamIDD);
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            ParamIDD = int.Parse(listBox1.SelectedItem.ToString());
            this.SelectBoneMarrowImagesTableAdapter.FillBy(this.BMDBDataSet.SelectBoneMarrowImages, ParamIDD);
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                ParamIDD = int.Parse(textBox1.Text);
                this.SelectBoneMarrowImagesTableAdapter.FillBy(this.BMDBDataSet.SelectBoneMarrowImages, ParamIDD);
                this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                this.reportViewer1.RefreshReport();
            }
            catch { ;}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.PerformClick();
        }
    }
}
