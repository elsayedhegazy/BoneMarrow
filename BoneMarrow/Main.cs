using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace BoneMarrow
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();

            #region MyVariables

           
            //int _LabCode = int.Parse(textBoxLabCode.Text);
            //string _DoctorName = textBoxDoctorName.Text;
            //int _Age = Convert.ToInt32(numericUpDownAge.Value);
            //string _AgeType = comboBoxAge.Text;
            //DateTime _ResultDate = dateTimePickerResultDate.Value;
            //DateTime _VisitDate = dateTimePickerVisitDate.Value;

            //int _Blasts = Convert.ToInt32(numericUpDownBlasts.Value);
            //int _Promyelocytes = Convert.ToInt32(numericUpDownPromyelocytes.Value);
            //int _Myelocytes = Convert.ToInt32(numericUpDownMyelocytes.Value);
            //int _Juvenile = Convert.ToInt32(numericUpDownJuvenile.Value);
            //int _Staff = Convert.ToInt32(numericUpDownStaff.Value);
            //int _Segmented = Convert.ToInt32(numericUpDownSegmented.Value);
            //int _Lymphocytes = Convert.ToInt32(numericUpDownLymphocytes.Value);
            //int _Monocytes = Convert.ToInt32(numericUpDownMonocytes.Value);
            //int _Eosinophils = Convert.ToInt32(numericUpDownEosinophils.Value);
            //int _Basophils = Convert.ToInt32(numericUpDownBasophils.Value);
            //int _Normoblasts = Convert.ToInt32(numericUpDownNormoblasts.Value);
            //int _PlasmaCells = Convert.ToInt32(numericUpDownPlasmacells.Value);
           
            

            #endregion
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown13_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            ReportBMA ReportPreviwForm = new ReportBMA();
            ReportPreviwForm.Show(); 
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main.ActiveForm.Close();
        }

        private void numericUpDownPlasmacells_KeyUp(object sender, KeyEventArgs e)
        {
            decimal a = numericUpDownAge.Value;
            decimal b = numericUpDownBasophils.Value;
            decimal c = numericUpDownBlasts.Value;
            decimal d = numericUpDownEosinophils.Value;
            decimal p = numericUpDownJuvenile.Value;
            decimal f = numericUpDownLymphocytes.Value;
            decimal g = numericUpDownMonocytes.Value;
            decimal h = numericUpDownMyelocytes.Value;
            decimal i = numericUpDownNormoblasts.Value;
            decimal j = numericUpDownPlasmacells.Value;
            decimal k = numericUpDownPromyelocytes.Value;
            decimal l = numericUpDownSegmented.Value;

            

            if (a + b + c + d + p + f + g + h + i + j + k + l == 100)
            {

                MessageBox.Show("Cells more than 100 Please Recalculate", "Please Recalculate", MessageBoxButtons.OK);
            }
	
        }

        private void numericUpDownPlasmacells_Enter(object sender, EventArgs e)
        {

        }
    }
}
