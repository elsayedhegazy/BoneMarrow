//using CrystalDecisions.Shared;
using System.Windows.Forms;
namespace BoneMarrow
{
    partial class ReportBMA 
    {
        
        public int SetParamForPID
        {
            get;
            set ; 
        }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportBMA));
            //this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            
            
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            //this.crystalReportViewer1.ActiveViewIndex = 0;
            //this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            //resources.ApplyResources(this.crystalReportViewer1, "crystalReportViewer1");
            //this.crystalReportViewer1.Name = "crystalReportViewer1";
            
            // 
            // procSelectBMAsp_DataTableAdapter1
            // 
            
            // 
            // ReportBMA
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.Controls.Add(this.crystalReportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ReportBMA";
            this.Load += new System.EventHandler(this.ReportBMA_Load);
            this.ResumeLayout(false);

        }

        #endregion

        //private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        
        
       
        
        
        

    }
}