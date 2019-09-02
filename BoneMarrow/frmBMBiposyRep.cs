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
    public partial class frmBMBiposyRep : Form
    {
        private int MyParam;
        public frmBMBiposyRep(int BiopsyParam)
        {
            InitializeComponent();
             MyParam = BiopsyParam;
        }

        private void frmBMBiposyRep_Load(object sender, EventArgs e)
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

            
            
           
            
            // TODO: This line of code loads data into the 'bMDBDataSet1.SelectBMB_DATA' table. You can move, or remove it, as needed.
            this.selectBMB_DATATableAdapter.FillBy(this.bMDBDataSet1.SelectBMB_DATA,MyParam);
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            
            this.reportViewer1.RefreshReport();
           
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void ShowBiopsyReport(object sender, EventArgs e)

        {
            try
            {
                MyParam = int.Parse(textBox1.Text);
                this.selectBMB_DATATableAdapter.FillBy(this.bMDBDataSet1.SelectBMB_DATA, MyParam);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

                this.reportViewer1.RefreshReport();
            }
            catch { ;}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                MyParam = int.Parse(listBox1.SelectedItem.ToString());
                this.selectBMB_DATATableAdapter.FillBy(this.bMDBDataSet1.SelectBMB_DATA, MyParam);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

                this.reportViewer1.RefreshReport();
            }
            catch { ;}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Drawing.Image Iuuuu = new Bitmap("E:\\Project\\BoneMarrow\\BoneMarrow\\333 red blood cells.jpg");
            
            try
            {
                MyParam = int.Parse(listBox1.SelectedItem.ToString());
                this.selectBMB_DATATableAdapter.FillBy(this.bMDBDataSet1.SelectBMB_DATA, MyParam);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.BackgroundImage = Iuuuu;
                reportViewer1.BackColor = Color.Aqua;
                this.reportViewer1.RefreshReport();
            }
            catch { ;}
            
        }
    }
}
