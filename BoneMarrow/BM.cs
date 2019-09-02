using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using CrystalDecisions.Shared;
using Microsoft.VisualBasic;
using System.Threading;
using System.Windows.Controls.Primitives;

namespace BoneMarrow
{
    public partial class BM : Form
    {

        private int MainParam;

        public bool SavingStatus;
        public BM()
        {
            Thread tt = new Thread(new ThreadStart(SplashhScreen));
            tt.Start();
            Thread.Sleep(5000);
            tt.Abort();
            InitializeComponent();
        }
        public void SplashhScreen()
        {
            Application.Run(new SplashScreen());
        }


        private void byDateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fullDataSet.CulturesResult' table. You can move, or remove it, as needed.
            this.culturesResultTableAdapter.Fill(this.fullDataSet.CulturesResult);
            // TODO: This line of code loads data into the 'bMDBDataSet6.OrganismSource' table. You can move, or remove it, as needed.
            this.organismSourceTableAdapter.Fill(this.bMDBDataSet6.OrganismSource);
            // TODO: This line of code loads data into the 'bMDBDataSet5.CulturesSource' table. You can move, or remove it, as needed.
            this.culturesSourceTableAdapter.Fill(this.bMDBDataSet5.CulturesSource);

            // Bind to a DataGrid

            //====bindingSource1.DataSource = allAuthors;

            // Bind to a DataGridView control
            //=====dataGridViewImmuno.DataSource = bindingSource1;
            //====dataGridViewImmuno.DataSource = allAuthors;



            //===========================================================================================
            // TODO: This line of code loads data into the 'bMDBDataSet.PatientDetails' table. You can move, or remove it, as needed.
            //this.patientDetailsTableAdapter.Fill(this.bMDBDataSet.PatientDetails);

            //var query = from c in bMDBDataSet.Select_Immunophenotyping where c.PatientID == 252500 select c;
            //dataGridViewImmuno.DataSource = query.AsDataView();
            DataClasses1DataContext dbcul = new DataClasses1DataContext();
            var popChkAntibiotic = (from P in dbcul.AntibioticsSources
                                    select P).ToArray();

            foreach (var item in popChkAntibiotic)
            {
                checkedListBox1.Items.Add(item.AntibioticName);

            }


            LoopForListBoxForID();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddPatientToDataBase();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxMedicalCodeBMASP.Text == "")
            { MessageBox.Show("Select Patient ID to view || فضلا قم باختيار رقم المريض", "Selection missing", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            ShowImagesForm();
        }

        public void AddPatientToDataBase()
        {
            var DC1Context = new DataClasses1DataContext();
            var PatintDataTable = new PatientDetail();
            //======================================================================
            //================= Add Patient to database ============================
            var BMResultsTable = new BoneMarrowResult();
            {
                PatintDataTable.PatientID = int.Parse(textBoxMedicalCodeBMASP.Text);
                PatintDataTable.PName = textBoxPatientName.Text;

                PatintDataTable.DrName = textBoxDoctorName.Text;
                PatintDataTable.email = textBoxEmail.Text;
                PatintDataTable.Gender = comboBoxGender.Text;
                PatintDataTable.Age = numericUpDownAge.Value;
                PatintDataTable.AgeType = comboBoxAge.Text;
                PatintDataTable.ResultDate = dateTimePickerResultDate.Value;
                PatintDataTable.VisitDate = dateTimePickerVisitDate.Value;
                PatintDataTable.Adress = textBoxAddress.Text;
                BMResultsTable.ID = int.Parse(textBoxMedicalCodeBMASP.Text);
                BMResultsTable.BMAspSite = comboBoxSiteBMA.Text;
                BMResultsTable.BMAspComment = richTextBoxCommentBMA.Text;
                BMResultsTable.Blasts = numericUpDownBlasts.Value;
                BMResultsTable.Promyelocytes = numericUpDownPromyelocytes.Value;
                BMResultsTable.Myelocytes = numericUpDownMyelocytes.Value;
                BMResultsTable.Juvenile = numericUpDownJuvenile.Value;
                BMResultsTable.Staff = numericUpDownStaff.Value;
                BMResultsTable.Segmented = numericUpDownSegmented.Value;
                BMResultsTable.Lymphocytes = numericUpDownLymphocytes.Value;
                BMResultsTable.Monocytes = numericUpDownMonocytes.Value;
                BMResultsTable.Eosinophils = numericUpDownEosinophils.Value;
                BMResultsTable.Basophils = numericUpDownBasophils.Value;
                BMResultsTable.Normoblasts = numericUpDownNormoblasts.Value;
                BMResultsTable.PlasmaCells = numericUpDownPlasmacells.Value;
                BMResultsTable.BMBsite = comboBoxSiteBMBiopsy.Text;
                BMResultsTable.BMB_HistoExamin = richTextBoxHistologicalExamination.Text;
                BMResultsTable.BMAconclusion = richTextBoxBMAConclusion.Text;
                BMResultsTable.BMBconclusion = richTextBoxBiopsyConclusion.Text;
                BMResultsTable.BoneSize = numericUpDownSizeBMBiopsy.Value;
                BMResultsTable.BoneHardness = comboBoxBonehardness.Text;
                BMResultsTable.CytoCellsCounted45 = numericUpDown45CellsCount.Value;
                BMResultsTable.CytoCellsCounted46 = numericUpDown46CellsCount.Value;
                BMResultsTable.CytoCellsCounted47 = numericUpDown47CellsCount.Value;
                BMResultsTable.CytoCellsCounted4Total = numericUpDownTotalCellsCount.Value;

                BMResultsTable.CytoCellsKayrotyped45 = numericUpDown45Karyo.Value;
                BMResultsTable.CytoCellsKayrotyped46 = numericUpDown46Karyo.Value;
                BMResultsTable.CytoCellsKayrotyped47 = numericUpDown47Karyo.Value;
                BMResultsTable.CytoCellsKayrotypedTotal = numericUpDownTotalKaryo.Value;

                BMResultsTable.CytoCellsPhotographed45 = numericUpDown45Photographed.Value;
                BMResultsTable.CytoCellsPhotographed46 = numericUpDown46Photographed.Value;
                BMResultsTable.CytoCellsPhotographed47 = numericUpDown47Photographed.Value;
                BMResultsTable.CytoCellsPhotographedTotal = numericUpDownTotalPhotographed.Value;

                BMResultsTable.CytoChromosomeCount45 = numericUpDown45ChroCount.Value;
                BMResultsTable.CytoChromosomeCount46 = numericUpDown46ChroCount.Value;
                BMResultsTable.CytoChromosomeCount47 = numericUpDown47ChroCount.Value;
                BMResultsTable.CytoChromosomeCountTotal = numericUpDownTotalChroCount.Value;

                BMResultsTable.CytoInterpretation = textBoxInterpretation.Text;
                BMResultsTable.CytoKaryotype = textBoxKaryotype.Text;
                BMResultsTable.CytoRecommendation = textBoxRecommendation.Text;

                BMResultsTable.CytoSpecimen = textBoxSpecimenCyto.Text;
                BMResultsTable.CytoTestName = textBoxTestNameCytogenetics.Text;
            }

            DC1Context.PatientDetails.InsertOnSubmit(PatintDataTable);
            DC1Context.BoneMarrowResults.InsertOnSubmit(BMResultsTable);
            DC1Context.SubmitChanges();
            listBoxBMASP.Items.Clear();
            LoopForListBoxForID();
            //====================================================================================
            //MessageBox.Show("Pateint Added Successfully into database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }
        public void ShowImagesForm()
        {
            FormAddImages frmAddImages = new FormAddImages(int.Parse(textBoxMedicalCodeBMASP.Text), textBoxPatientName.Text);
            frmAddImages.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowImagesForm();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var DC1Context = new DataClasses1DataContext();
            var PatintDataTable = new PatientDetail();
            var BMResultsTable = new BoneMarrowResult();

            AddPatientToDataBase();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DeletePatienAndBMResults();


        }
        public void DeletePatienAndBMResults()
        {
            var DC1Context = new DataClasses1DataContext();
            var PatintDataTable = new PatientDetail();
            var BMResultsTable = new BoneMarrowResult();
            //=============================================================================
            //======== Delete Patient from data base ======================================
            var VarDeletePatintData = from P in DC1Context.PatientDetails
                                      where P.PatientID == int.Parse(textBoxMedicalCodeBMASP.Text)
                                      select P;
            foreach (var P in VarDeletePatintData)
            {
                DC1Context.PatientDetails.DeleteOnSubmit(P);
            }
            var VarDeleteBMResults = from PP in DC1Context.BoneMarrowResults
                                     where PP.ID == int.Parse(textBoxMedicalCodeBMASP.Text)
                                     select PP;
            foreach (var PP in VarDeleteBMResults)
            {
                DC1Context.BoneMarrowResults.DeleteOnSubmit(PP);
            }
            try
            {
                DC1Context.SubmitChanges();
                listBoxBMASP.Items.Clear();
                LoopForListBoxForID();

            }


            //=================================================================


            catch
            {
                ;
            }
            finally { MessageBox.Show("Patient Deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information); }


        }

        private void LoopForListBoxForID()
        {
            try
            {
                var DC1Context = new DataClasses1DataContext();
                var PatintDataTable = new PatientDetail();
                var BMResultsTable = new BoneMarrowResult();

                //=============================================================================

                var LoopListBox = from DD in DC1Context.PatientDetails
                                  select DD;
                foreach (var DD in LoopListBox)
                {
                    listBoxBMASP.Items.Add(DD.PatientID);


                    ////--------------------------------------------------
                    //textBoxDoctorName.Text = DD.DrName;
                    //textBoxDrNameBiopsy.Text = DD.DrName;
                    ////--------------------------------------------------
                    //textBoxPatientName.Text = DD.PName;
                    //textBoxPnameBiopsy.Text = DD.PName;
                    ////--------------------------------------------------
                    ////comboBoxLabCodeBMA.Text = DD.PatientID.ToString();

                    ////--------------------------------------------------
                    //textBoxEmail.Text = DD.email;
                    //textBoxEmailBiopsy.Text = DD.email;

                    ////--------------------------------------------------
                    //comboBoxGender.Text = DD.Gender;
                    //comboBoxGenderBiopsy.Text = DD.Gender;

                    ////--------------------------------------------------
                    //numericUpDownAge.Value =Convert.ToDecimal( DD.Age);
                    //numericUpDownAgeBiopsy.Value = Convert.ToDecimal(DD.Age);

                    ////--------------------------------------------------
                    //comboBoxAge.Text = DD.AgeType.ToString();
                    //comboBoxAgeTypeBiopsy.Text = DD.AgeType.ToString();

                    ////--------------------------------------------------
                    //dateTimePickerResultBiopsy.Value = DD.ResultDate.Value;
                    //dateTimePickerResultDate.Value = DD.ResultDate.Value;

                    ////--------------------------------------------------
                    //dateTimePickerVisitBiopsy.Value = DD.VisitDate.Value;
                    //dateTimePickerVisitDate.Value = DD.VisitDate.Value;

                    ////-------------------------------------------------

                    //textBoxAddressBiopsy.Text = DD.Adress;
                    //textBoxAddress.Text = DD.Adress;

                }
            }
            catch { ; }
        }
        static bool IsNumber(string value)
        {
            // Return true if this is a number.
            int number1;
            return int.TryParse(value, out number1);
        }
        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            textBoxMedicalCodeBMASP.Enabled = false;
            try
            {
                bool flag1 = IsNumber(listBoxBMASP.SelectedItem.ToString());
                var DC1Context = new DataClasses1DataContext();
                var PatintDataTable = new PatientDetail();
                var BMResultsTable = new BoneMarrowResult();
                var ImmunoPhenoTable = new Immunophenotyping();
                var CulturesResultsTable = new CulturesResult();
                var InputToMainParamByNameButton = from ff in DC1Context.PatientDetails
                                                   where ff.PName == listBoxBMASP.Text
                                                   select ff;



                //=============================================================================
                if (flag1 == true)
                {
                    MainParam = int.Parse(listBoxBMASP.SelectedItem.ToString());
                }
                else
                {
                    foreach (var pop in InputToMainParamByNameButton)
                    { MainParam = pop.PatientID; }

                }

                var LoopListBox = from DD in DC1Context.PatientDetails
                                  where DD.PatientID == MainParam
                                  select DD;
                var LoopForBMResults = from BMBM in DC1Context.BoneMarrowResults
                                       where BMBM.ID == MainParam
                                       select BMBM;
                var LoopForCultureResults = from CR in DC1Context.CulturesResults
                                            where CR.PatientID == MainParam
                                            select CR;
                //======================================================================
                

                foreach (var item in LoopForCultureResults)
                {
                    labelOrganismUIDHidden.Text = item.OrganismUID.ToString();
                    labelCultureUIDHidden.Text = item.CulturesResultsUID.ToString();
                    comboBoxCultureSource.Text = item.CulturesSource.CultureName;
                    textBoxDirectFilm.Text = item.DirectFilm;
                    textBoxPus.Text = item.PUS;
                    textBoxRBCs.Text = item.RBCs;
                    textBoxEpithelial.Text = item.Epithelial;
                    comboBoxCondition.Text = item.CultureCondition;
                    comboBoxGrowth.Text = item.OrganismSource.OrganismName;
                    richTextBoxCultureComment.Text = item.NotesOrComment;
                    comboBoxCurrentCulture.Text = item.CultureNameForResult;
                }

                var loopForResistant = from Resist in DC1Context.AntibioticResults
                                       where Resist.CulturesResultsUID == int.Parse(labelCultureUIDHidden.Text) && Resist.AntibioticStatus == "R"
                                       select Resist;
                foreach (var item in loopForResistant)
                {
                    listBoxResistant.Items.Add(item.AntibioticNameForResult);
                }
                var loopForModerate = from mod in DC1Context.AntibioticResults
                                       where mod.CulturesResultsUID == int.Parse(labelCultureUIDHidden.Text) && mod.AntibioticStatus == "M"
                                       select mod;
                foreach (var item in loopForModerate)
                {
                    listBoxModerate.Items.Add(item.AntibioticNameForResult);
                }

                var loopForSensitive = from Sen in DC1Context.AntibioticResults
                                       where Sen.CulturesResultsUID == int.Parse(labelCultureUIDHidden.Text) && Sen.AntibioticStatus == "S"
                                       select Sen;
                foreach (var item in loopForSensitive)
                {
                    listBoxSensitive.Items.Add(item.AntibioticNameForResult);
                }
                //======================================================================

                foreach (var DD in LoopListBox)
                {
                    textBoxDoctorName.Text = DD.DrName;
                    textBoxDrNameBiopsy.Text = DD.DrName;
                    textBoxDrNameCyto.Text = DD.DrName;
                    textBoxDrNameCulture.Text = DD.DrName;

                    //------------------------------------------------
                    textBoxPatientName.Text = DD.PName;
                    textBoxPnameBiopsy.Text = DD.PName;
                    // textBoxPnameImmuno.Text = DD.PName;
                    textBoxPNameCyto.Text = DD.PName;
                    textBoxPNameCulture.Text = DD.PName;
                    //------------------------------------------------
                    textBoxMedicalCodeBMASP.Text = DD.PatientID.ToString();
                    textBoxMedicalCodeBMBiopsy.Text = DD.PatientID.ToString();
                    //textBoxMedicalCodeImmuno.Text = DD.PatientID.ToString();

                    //------------------------------------------------

                    textBoxEmail.Text = DD.email;
                    textBoxEmailBiopsy.Text = DD.email;

                    //------------------------------------------------
                    comboBoxGender.Text = DD.Gender;
                    comboBoxGenderBiopsy.Text = DD.Gender;

                    //------------------------------------------------
                    numericUpDownAge.Value = DD.Age.Value;
                    numericUpDownAgeBiopsy.Value = DD.Age.Value;
                    numericUpDownCyto.Value = DD.Age.Value;

                    //------------------------------------------------
                    comboBoxAge.Text = DD.AgeType;
                    comboBoxAgeTypeBiopsy.Text = DD.AgeType;
                    comboBoxAgeCyto.Text = DD.AgeType;

                    //------------------------------------------------
                    dateTimePickerResultDate.Value = DD.ResultDate.Value;
                    dateTimePickerResultBiopsy.Value = DD.ResultDate.Value;

                    //------------------------------------------------
                    dateTimePickerVisitDate.Value = DD.VisitDate.Value;
                    dateTimePickerVisitBiopsy.Value = DD.VisitDate.Value;

                    //------------------------------------------------
                    textBoxAddress.Text = DD.Adress;
                    textBoxAddressBiopsy.Text = DD.Adress;
                    //------------------------------------------------



                }
                foreach (var BMBM in LoopForBMResults)
                {
                    numericUpDownBasophils.Value = BMBM.Basophils.Value;
                    numericUpDownBlasts.Value = BMBM.Blasts.Value;
                    numericUpDownEosinophils.Value = BMBM.Eosinophils.Value;
                    numericUpDownJuvenile.Value = BMBM.Juvenile.Value;
                    numericUpDownLymphocytes.Value = BMBM.Lymphocytes.Value;
                    numericUpDownMonocytes.Value = BMBM.Monocytes.Value;
                    numericUpDownMyelocytes.Value = BMBM.Myelocytes.Value;
                    numericUpDownNormoblasts.Value = BMBM.Normoblasts.Value;
                    numericUpDownPlasmacells.Value = BMBM.PlasmaCells.Value;
                    numericUpDownPromyelocytes.Value = BMBM.Promyelocytes.Value;
                    numericUpDownSegmented.Value = BMBM.Segmented.Value;
                    numericUpDownStaff.Value = BMBM.Staff.Value;
                    comboBoxSiteBMA.Text = BMBM.BMAspSite;
                    comboBoxSiteBMBiopsy.Text = BMBM.BMBsite;
                    richTextBoxBiopsyConclusion.Text = BMBM.BMBconclusion;
                    richTextBoxBMAConclusion.Text = BMBM.BMAconclusion;
                    richTextBoxCommentBMA.Text = BMBM.BMAspComment;
                    richTextBoxHistologicalExamination.Text = BMBM.BMB_HistoExamin;
                    numericUpDownSizeBMBiopsy.Value = BMBM.BoneSize.Value;
                    comboBoxBonehardness.Text = BMBM.BoneHardness;
                    //richTextBoxCommentImmunopheno.Text = BMBM.CommentImmuPhen;
                    //richTextBoxConclusionImmunopheno.Text = BMBM.ConclusionImmuPheno;
                    //richTextBoxPhenotype.Text = BMBM.PhenotypeImmuPhen;
                    //==================================================================
                    textBoxTestNameCytogenetics.Text = BMBM.CytoTestName;
                    textBoxSpecimenCyto.Text = BMBM.CytoSpecimen;
                    textBoxRecommendation.Text = BMBM.CytoRecommendation;
                    textBoxKaryotype.Text = BMBM.CytoKaryotype;
                    textBoxInterpretation.Text = BMBM.CytoInterpretation;

                    numericUpDown45CellsCount.Value = BMBM.CytoCellsCounted45.Value;
                    numericUpDown46CellsCount.Value = BMBM.CytoCellsCounted46.Value;
                    numericUpDown47CellsCount.Value = BMBM.CytoCellsCounted47.Value;
                    numericUpDownTotalCellsCount.Value = BMBM.CytoCellsCounted4Total.Value;

                    numericUpDown45ChroCount.Value = BMBM.CytoChromosomeCount45.Value;
                    numericUpDown46ChroCount.Value = BMBM.CytoChromosomeCount46.Value;
                    numericUpDown47ChroCount.Value = BMBM.CytoChromosomeCount47.Value;
                    numericUpDownTotalChroCount.Value = BMBM.CytoChromosomeCountTotal.Value;

                    numericUpDown45Karyo.Value = BMBM.CytoCellsKayrotyped45.Value;
                    numericUpDown46Karyo.Value = BMBM.CytoCellsKayrotyped46.Value;
                    numericUpDown47Karyo.Value = BMBM.CytoCellsKayrotyped47.Value;
                    numericUpDownTotalKaryo.Value = BMBM.CytoCellsKayrotypedTotal.Value;

                    numericUpDown45Photographed.Value = BMBM.CytoCellsPhotographed45.Value;
                    numericUpDown46Photographed.Value = BMBM.CytoCellsPhotographed46.Value;
                    numericUpDown47Photographed.Value = BMBM.CytoCellsPhotographed47.Value;
                    numericUpDownTotalPhotographed.Value = BMBM.CytoCellsPhotographedTotal.Value;

                }
                LoopForListViewItems();

            }
            catch { ; }




        }
        private void LoopForListViewItems()
        {
            DataClasses1DataContext DC1Context = new DataClasses1DataContext();
            ///==================== ListView loop ======================
            ///=========================================================
            //listView1.Items.Clear();
            DataTable dt = new DataTable();
            DataColumn dc = new DataColumn();
            //DataRow dr;
            var Qy = (from pr in DC1Context.Immunophenotypings
                      where pr.PatientID == int.Parse(listBoxBMASP.SelectedItem.ToString())
                      select pr).ToList();
            ListViewItem lstItem = null;


            foreach (var ImmunoVar in Qy)
            {

                lstItem = new ListViewItem(ImmunoVar.MarkerName.ToString());
                lstItem.SubItems.Add(ImmunoVar.Percentage);
                lstItem.SubItems.Add(ImmunoVar.Result);
                // listView1.Items.Add(lstItem);
            }


            ///================ End List View ==========================
            ///=========================================================

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            buttonDeleteBMASP.PerformClick();
        }

        private void buttonAddImmunophenotyping_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSerchMedicalCode_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxSerchMedicalCode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSerchMedicalCode_TextChanged(object sender, EventArgs e)
        {

            //listBoxBMASP.Items.Clear();

            ////var q = from string search in listBoxBMASP.Items where search.Contains(comboBoxSerchMedicalCode.Text) select search;
            ////listBoxBMASP.Items.Add(q.ToString());
            //for (int i = 0; i < listBoxBMASP.Items.Count; i++)
            //{
            //    if (listBoxBMASP.Items[i].ToString().Contains(comboBoxSerchMedicalCode.Text))
            //    {
            //        listBoxBMASP.Items.Add(i.ToString());
            //    }
            //}

        }

        private void comboBoxSerchMedicalCode_ValueMemberChanged(object sender, EventArgs e)
        {


            //    try
            //    {
            //        var DC1Context = new DataClasses1DataContext();
            //        var PatintDataTable = new PatientDetail();
            //        var BMResultsTable = new BoneMarrowResult();
            //        //=============================================================================

            //        var LoopComboMedicalCode = from DD in DC1Context.PatientDetails
            //                                   where DD.PatientID == Convert.ToInt32(comboBoxSerchMedicalCode.SelectedItem)
            //                                   select DD;
            //        var LoopForBMResults = from BMBM in DC1Context.BoneMarrowResults
            //                               where BMBM.ID == Convert.ToInt32(comboBoxSerchMedicalCode.SelectedItem)
            //                               select BMBM;

            //        foreach (var DD in LoopComboMedicalCode)
            //        {
            //            textBoxDoctorName.Text = DD.DrName;
            //            textBoxDrNameBiopsy.Text = DD.DrName;
            //            textBoxDrNameImmunophenotyping.Text = DD.DrName;
            //            //------------------------------------------------
            //            textBoxPatientName.Text = DD.PName;
            //            textBoxPnameBiopsy.Text = DD.PName;
            //            textBoxPnameImmunophenotyping.Text = DD.PName;
            //            //------------------------------------------------
            //            textBoxMedicalCodeBMASP.Text = DD.PatientID.ToString();

            //            //------------------------------------------------
            //            textBoxEmail.Text = DD.email;
            //            textBoxEmailBiopsy.Text = DD.email;
            //            textBoxEmailImmunophenotyping.Text = DD.email;
            //            //------------------------------------------------
            //            comboBoxGender.Text = DD.Gender;
            //            comboBoxGenderBiopsy.Text = DD.Gender;
            //            comboBoxGenderImmunophenotyping.Text = DD.Gender;
            //            //------------------------------------------------
            //            numericUpDownAge.Value = DD.Age.Value;
            //            numericUpDownAgeBiopsy.Value = DD.Age.Value;
            //            numericUpDownAgeImmunophenotyping.Value = DD.Age.Value;
            //            //------------------------------------------------
            //            comboBoxAge.Text = DD.AgeType;
            //            comboBoxAgeTypeBiopsy.Text = DD.AgeType;
            //            comboBoxAgeTypeImmunophenotyping.Text = DD.AgeType;
            //            //------------------------------------------------
            //            dateTimePickerResultDate.Value = DD.ResultDate.Value;
            //            dateTimePickerResultBiopsy.Value = DD.ResultDate.Value;
            //            dateTimePickerResultImmunophenotyping.Value = DD.ResultDate.Value;
            //            //------------------------------------------------
            //            dateTimePickerVisitDate.Value = DD.VisitDate.Value;
            //            dateTimePickerVisitBiopsy.Value = DD.VisitDate.Value;
            //            dateTimePickerVisitImmunophenotyping.Value = DD.VisitDate.Value;
            //            //------------------------------------------------
            //            textBoxAddress.Text = DD.Adress;
            //            textBoxAddressBiopsy.Text = DD.Adress;
            //            textBoxAddressImmunophenotyping.Text = DD.Adress;
            //        }
            //        foreach (var BMBM in LoopForBMResults)
            //        {

            //        }
            //    }
            //    catch (Exception exx) { MessageBox.Show(exx.ToString()); }
        }

        private void buttonUpdateBMASP_Click(object sender, EventArgs e)
        {
            UpdatePatientInDataBase();
        }
        private void UpdatePatientInDataBase()
        {
            var DC1Context = new DataClasses1DataContext();
            var CultureTable = new CulturesResult();
            var PatintDataTable = new PatientDetail();
            var AntiobioticResultTable = new AntibioticResult();
            //================= Update Patient to database ============================
            var BMResultsTable = new BoneMarrowResult();

            var qu = (from CCC in DC1Context.PatientDetails
                      where CCC.PatientID == int.Parse(textBoxMedicalCodeBMASP.Text)
                      select CCC).Single<PatientDetail>();
            qu.PName = textBoxPatientName.Text;
            //qu.PatientID = int.Parse( textBoxMedicalCodeBMASP.Text);
            qu.Adress = textBoxAddress.Text;
            qu.Age = numericUpDownAge.Value;
            qu.AgeType = comboBoxAge.Text;
            qu.DrName = textBoxDoctorName.Text;
            qu.email = textBoxEmail.Text;
            qu.Gender = comboBoxGender.Text;
            qu.ResultDate = dateTimePickerResultDate.Value;
            qu.VisitDate = dateTimePickerVisitDate.Value;
            //===================================================================
            var qu2 = (from BMRecord in DC1Context.BoneMarrowResults
                       where BMRecord.ID == int.Parse(textBoxMedicalCodeBMASP.Text)
                       select BMRecord).Single<BoneMarrowResult>();
            qu2.Basophils = numericUpDownBasophils.Value;
            qu2.Blasts = numericUpDownBlasts.Value;
            qu2.BMAconclusion = richTextBoxBMAConclusion.Text;
            qu2.BMAspComment = richTextBoxCommentBMA.Text;
            qu2.BMAspSite = comboBoxSiteBMA.Text;
            qu2.BMB_HistoExamin = richTextBoxHistologicalExamination.Text;
            qu2.BMBconclusion = richTextBoxBiopsyConclusion.Text;
            qu2.BMBsite = comboBoxSiteBMBiopsy.Text;
            qu2.BoneHardness = comboBoxBonehardness.Text;
            qu2.BoneSize = numericUpDownSizeBMBiopsy.Value;
            qu2.Eosinophils = numericUpDownEosinophils.Value;
            qu2.Juvenile = numericUpDownJuvenile.Value;
            qu2.Lymphocytes = numericUpDownLymphocytes.Value;
            qu2.Monocytes = numericUpDownMonocytes.Value;
            qu2.Myelocytes = numericUpDownMyelocytes.Value;
            qu2.Normoblasts = numericUpDownNormoblasts.Value;
            qu2.PlasmaCells = numericUpDownPlasmacells.Value;
            qu2.Promyelocytes = numericUpDownPromyelocytes.Value;
            qu2.Segmented = numericUpDownSegmented.Value;
            qu2.Staff = numericUpDownStaff.Value;
            qu2.CytoCellsCounted45 = numericUpDown45CellsCount.Value;
            qu2.CytoCellsCounted46 = numericUpDown46CellsCount.Value;
            qu2.CytoCellsCounted47 = numericUpDown47CellsCount.Value;
            qu2.CytoCellsCounted4Total = numericUpDownTotalCellsCount.Value;
            qu2.CytoCellsKayrotyped45 = numericUpDown45Karyo.Value;
            qu2.CytoCellsKayrotyped46 = numericUpDown46Karyo.Value;
            qu2.CytoCellsKayrotyped47 = numericUpDown47Karyo.Value;
            qu2.CytoCellsKayrotypedTotal = numericUpDownTotalKaryo.Value;
            qu2.CytoCellsPhotographed45 = numericUpDown45Photographed.Value;
            qu2.CytoCellsPhotographed46 = numericUpDown46Photographed.Value;
            qu2.CytoCellsPhotographed47 = numericUpDown47Photographed.Value;
            qu2.CytoCellsPhotographedTotal = numericUpDownTotalPhotographed.Value;
            qu2.CytoChromosomeCount45 = numericUpDown45ChroCount.Value;
            qu2.CytoChromosomeCount46 = numericUpDown46ChroCount.Value;
            qu2.CytoChromosomeCount47 = numericUpDown47ChroCount.Value;
            qu2.CytoChromosomeCountTotal = numericUpDownTotalChroCount.Value;
            qu2.CytoTestName = textBoxTestNameCytogenetics.Text;
            qu2.CytoSpecimen = textBoxSpecimenCyto.Text;
            qu2.CytoInterpretation = textBoxInterpretation.Text;
            qu2.CytoKaryotype = textBoxKaryotype.Text;
            qu2.CytoRecommendation = textBoxRecommendation.Text;
            //=============================Culture======================================


            var qu3 = (from CCC in DC1Context.CulturesResults
                       where CCC.PatientID == int.Parse(textBoxMedicalCodeBMASP.Text)
                       select CCC).Single<CulturesResult>();

            qu3.CultureNameForResult = comboBoxCultureSource.Text;
            qu3.CultureCondition = comboBoxCondition.Text;
            qu3.DirectFilm = textBoxDirectFilm.Text;
            qu3.Epithelial = textBoxEpithelial.Text;
            qu3.OrganismUID =int.Parse( labelOrganismUIDHidden.Text);
            qu3.NotesOrComment = richTextBoxCultureComment.Text;
            qu3.PUS = textBoxPus.Text;
            qu3.RBCs = textBoxRBCs.Text;

            //============== Antibiotics with Status ============================
            var AR = new AntibioticResult();
            var AR2 = from System.Windows.Documents.ListItem li in listBoxResistant.Items
                          
                           select listBoxResistant.Text;
            
            foreach (var item in AR2)
            {
                AR.AntibioticNameForResult = item.ToString();
                AR.AntibioticStatus = "R";
                AR.CulturesResultsUID = int.Parse(labelCultureUIDHidden.Text);
            }
            DC1Context.ExecuteCommand("INSERT INTO dbo.AntibioticResult(CulturesResultsUID,AntibioticNameForResult , AntibioticStatus )VALUES("+int.Parse( labelCultureUIDHidden.Text)+", "+listBoxResistant.Items.ToString() +" , 'R');");
            //===================================================================
            PatintDataTable = qu;
            BMResultsTable = qu2;
            CultureTable = qu3;
            AntiobioticResultTable = AR;
            

            try
            {
                DC1Context.SubmitChanges();
                //MessageBox.Show("Patient Saved Successfully","Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch
            { ; }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }


        public void button2_Click(object sender, EventArgs e)
        {
            if (textBoxMedicalCodeBMASP.Text == "")
            { MessageBox.Show("Select Patient ID to view || فضلا قم باختيار رقم المريض", "Selection missing", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            //string SelectFormulaCR = "{PatientDetails.PatientID}=" + int.Parse(textBoxMedicalCodeBMASP.Text);
            /////////==========frmBMAReport ReBMA = new frmBMAReport(int.Parse(textBoxMedicalCodeBMASP.Text));
            frmBMAReport ReBMA = new frmBMAReport(int.Parse(textBoxMedicalCodeBMASP.Text));
            //ParameterField paramField = new ParameterField();
            //ParameterDiscreteValue discreteVal1 = new ParameterDiscreteValue();
            //paramField.ParameterFieldName = "@PID";

            //discreteVal1.Value = int.Parse(textBoxMedicalCodeBMASP.Text);

            //paramField.CurrentValues.Add(discreteVal1);

            ReBMA.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxMedicalCodeBMASP.Text == "")
            { MessageBox.Show("Select Patient ID to view || فضلا قم باختيار رقم المريض", "Selection missing", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            frmBMBiposyRep BRep = new frmBMBiposyRep(int.Parse(textBoxMedicalCodeBMASP.Text));
            BRep.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            button2.PerformClick();
        }

        private void buttonSaveBMA_Click(object sender, EventArgs e)
        {
            if (textBoxMedicalCodeBMASP.Text == "")
            {
                MessageBox.Show("Enter Medical Code", "Medical Code Missing", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            DataClasses1DataContext DDCCDD = new DataClasses1DataContext();
            int RecordExist = (from TYmmm in DDCCDD.PatientDetails
                               where TYmmm.PatientID == int.Parse(textBoxMedicalCodeBMASP.Text)
                               select TYmmm).Count();
            if (RecordExist > 0)
            {
                UpdatePatientInDataBase();

            }
            else
            {
                AddPatientToDataBase();

            }
            textBoxMedicalCodeBMASP.Enabled = false;
            SavingStatus = false;
        }

        private void ShowImageReport(object sender, EventArgs e)
        {
            if (textBoxMedicalCodeBMASP.Text == "")
            { MessageBox.Show("Select Patient ID to view || فضلا قم باختيار رقم المريض", "Selection missing", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            frmImagesReport frmim = new frmImagesReport(int.Parse(textBoxMedicalCodeBMASP.Text));
            frmim.ShowDialog();
        }
        private void Check100()
        {
            try
            {
                if (numericUpDownBasophils.Value + numericUpDownBlasts.Value + numericUpDownEosinophils.Value + numericUpDownJuvenile.Value + numericUpDownLymphocytes.Value + numericUpDownMonocytes.Value + numericUpDownMyelocytes.Value + numericUpDownNormoblasts.Value + numericUpDownPlasmacells.Value + numericUpDownPromyelocytes.Value + numericUpDownSegmented.Value + numericUpDownStaff.Value > 100)
                {
                    labelTotal.Text = (numericUpDownBasophils.Value + numericUpDownBlasts.Value + numericUpDownEosinophils.Value + numericUpDownJuvenile.Value + numericUpDownLymphocytes.Value + numericUpDownMonocytes.Value + numericUpDownMyelocytes.Value + numericUpDownNormoblasts.Value + numericUpDownPlasmacells.Value + numericUpDownPromyelocytes.Value + numericUpDownSegmented.Value + numericUpDownStaff.Value).ToString();
                    MessageBox.Show("Cells count is greater than 100 || فضلا التاكيد علي عدد الخلايا", "Confirmation || تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    progressBar1.Value = 100;
                }
                if ((numericUpDownBasophils.Value + numericUpDownBlasts.Value + numericUpDownEosinophils.Value + numericUpDownJuvenile.Value + numericUpDownLymphocytes.Value + numericUpDownMonocytes.Value + numericUpDownMyelocytes.Value + numericUpDownNormoblasts.Value + numericUpDownPlasmacells.Value + numericUpDownPromyelocytes.Value + numericUpDownSegmented.Value + numericUpDownStaff.Value < 100))
                {
                    labelTotal.Text = (numericUpDownBasophils.Value + numericUpDownBlasts.Value + numericUpDownEosinophils.Value + numericUpDownJuvenile.Value + numericUpDownLymphocytes.Value + numericUpDownMonocytes.Value + numericUpDownMyelocytes.Value + numericUpDownNormoblasts.Value + numericUpDownPlasmacells.Value + numericUpDownPromyelocytes.Value + numericUpDownSegmented.Value + numericUpDownStaff.Value).ToString();

                    progressBar1.Value = Convert.ToInt32(numericUpDownBasophils.Value + numericUpDownBlasts.Value + numericUpDownEosinophils.Value + numericUpDownJuvenile.Value + numericUpDownLymphocytes.Value + numericUpDownMonocytes.Value + numericUpDownMyelocytes.Value + numericUpDownNormoblasts.Value + numericUpDownPlasmacells.Value + numericUpDownPromyelocytes.Value + numericUpDownSegmented.Value + numericUpDownStaff.Value);
                }
                else { progressBar1.Value = Convert.ToInt32(numericUpDownBasophils.Value + numericUpDownBlasts.Value + numericUpDownEosinophils.Value + numericUpDownJuvenile.Value + numericUpDownLymphocytes.Value + numericUpDownMonocytes.Value + numericUpDownMyelocytes.Value + numericUpDownNormoblasts.Value + numericUpDownPlasmacells.Value + numericUpDownPromyelocytes.Value + numericUpDownSegmented.Value + numericUpDownStaff.Value); }
            }
            catch { }

        }
        private void Check100Last()
        {
            try
            {
                if (numericUpDownBasophils.Value + numericUpDownBlasts.Value + numericUpDownEosinophils.Value + numericUpDownJuvenile.Value + numericUpDownLymphocytes.Value + numericUpDownMonocytes.Value + numericUpDownMyelocytes.Value + numericUpDownNormoblasts.Value + numericUpDownPlasmacells.Value + numericUpDownPromyelocytes.Value + numericUpDownSegmented.Value + numericUpDownStaff.Value > 100)
                {
                    labelTotal.Text = (numericUpDownBasophils.Value + numericUpDownBlasts.Value + numericUpDownEosinophils.Value + numericUpDownJuvenile.Value + numericUpDownLymphocytes.Value + numericUpDownMonocytes.Value + numericUpDownMyelocytes.Value + numericUpDownNormoblasts.Value + numericUpDownPlasmacells.Value + numericUpDownPromyelocytes.Value + numericUpDownSegmented.Value + numericUpDownStaff.Value).ToString();
                    MessageBox.Show("Cells count is greater than 100 || فضلا التاكيد علي عدد الخلايا", "Confirmation || تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                    progressBar1.Value = 100;
                }
                if ((numericUpDownBasophils.Value + numericUpDownBlasts.Value + numericUpDownEosinophils.Value + numericUpDownJuvenile.Value + numericUpDownLymphocytes.Value + numericUpDownMonocytes.Value + numericUpDownMyelocytes.Value + numericUpDownNormoblasts.Value + numericUpDownPlasmacells.Value + numericUpDownPromyelocytes.Value + numericUpDownSegmented.Value + numericUpDownStaff.Value < 100))
                {
                    labelTotal.Text = (numericUpDownBasophils.Value + numericUpDownBlasts.Value + numericUpDownEosinophils.Value + numericUpDownJuvenile.Value + numericUpDownLymphocytes.Value + numericUpDownMonocytes.Value + numericUpDownMyelocytes.Value + numericUpDownNormoblasts.Value + numericUpDownPlasmacells.Value + numericUpDownPromyelocytes.Value + numericUpDownSegmented.Value + numericUpDownStaff.Value).ToString();
                    MessageBox.Show("Cells count is smaller than 100 || فضلا التاكيد علي عدد الخلايا", "Confirmation || تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                    progressBar1.Value = Convert.ToInt32(numericUpDownBasophils.Value + numericUpDownBlasts.Value + numericUpDownEosinophils.Value + numericUpDownJuvenile.Value + numericUpDownLymphocytes.Value + numericUpDownMonocytes.Value + numericUpDownMyelocytes.Value + numericUpDownNormoblasts.Value + numericUpDownPlasmacells.Value + numericUpDownPromyelocytes.Value + numericUpDownSegmented.Value + numericUpDownStaff.Value);
                }
                else { progressBar1.Value = Convert.ToInt32(numericUpDownBasophils.Value + numericUpDownBlasts.Value + numericUpDownEosinophils.Value + numericUpDownJuvenile.Value + numericUpDownLymphocytes.Value + numericUpDownMonocytes.Value + numericUpDownMyelocytes.Value + numericUpDownNormoblasts.Value + numericUpDownPlasmacells.Value + numericUpDownPromyelocytes.Value + numericUpDownSegmented.Value + numericUpDownStaff.Value); }
            }
            catch { }

        }
        private void numericUpDownBlasts_Leave(object sender, EventArgs e)
        {
            Check100();
        }

        private void numericUpDownPlasmacells_Leave(object sender, EventArgs e)
        {
            Check100Last();
        }

        private void button11_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool flag1 = IsNumber(textBoxSearchMedicalCode.Text);

            try
            {


                var DC1Context = new DataClasses1DataContext();
                var InputToMainParamByNameButton = from ff in DC1Context.PatientDetails
                                                   where ff.PName == listBoxBMASP.Text
                                                   select ff;
                //=============================================================================
                if (flag1 == true)
                {
                    MainParam = int.Parse(textBoxSearchMedicalCode.Text);
                }
                else
                {
                    ///GGGGGGGGGG();

                    LoopForListBoxForIDByName();
                    //foreach (var pop in InputToMainParamByNameButton)
                    //{

                    //    LoopForListBoxForIDByName();
                    //}

                }
                var PatintDataTable = new PatientDetail();
                var BMResultsTable = new BoneMarrowResult();
                //=============================================================================
                //MainParam = int.Parse(textBoxSearchMedicalCode.Text);
                var LoopListBox = from DD in DC1Context.PatientDetails
                                  where DD.PatientID == MainParam
                                  select DD;
                var LoopForBMResults = from BMBM in DC1Context.BoneMarrowResults
                                       where BMBM.ID == MainParam
                                       select BMBM;

                foreach (var DD in LoopListBox)
                {
                    textBoxDoctorName.Text = DD.DrName;
                    textBoxDrNameBiopsy.Text = DD.DrName;

                    //------------------------------------------------
                    textBoxPatientName.Text = DD.PName;
                    textBoxPnameBiopsy.Text = DD.PName;

                    //------------------------------------------------
                    textBoxMedicalCodeBMASP.Text = DD.PatientID.ToString();
                    textBoxMedicalCodeBMBiopsy.Text = DD.PatientID.ToString();
                    //------------------------------------------------
                    textBoxEmail.Text = DD.email;
                    textBoxEmailBiopsy.Text = DD.email;

                    //------------------------------------------------
                    comboBoxGender.Text = DD.Gender;
                    comboBoxGenderBiopsy.Text = DD.Gender;

                    //------------------------------------------------
                    numericUpDownAge.Value = DD.Age.Value;
                    numericUpDownAgeBiopsy.Value = DD.Age.Value;

                    //------------------------------------------------
                    comboBoxAge.Text = DD.AgeType;
                    comboBoxAgeTypeBiopsy.Text = DD.AgeType;

                    //------------------------------------------------
                    dateTimePickerResultDate.Value = DD.ResultDate.Value;
                    dateTimePickerResultBiopsy.Value = DD.ResultDate.Value;

                    //------------------------------------------------
                    dateTimePickerVisitDate.Value = DD.VisitDate.Value;
                    dateTimePickerVisitBiopsy.Value = DD.VisitDate.Value;

                    //------------------------------------------------
                    textBoxAddress.Text = DD.Adress;
                    textBoxAddressBiopsy.Text = DD.Adress;


                }
                foreach (var BMBM in LoopForBMResults)
                {
                    numericUpDownBasophils.Value = BMBM.Basophils.Value;
                    numericUpDownBlasts.Value = BMBM.Blasts.Value;
                    numericUpDownEosinophils.Value = BMBM.Eosinophils.Value;
                    numericUpDownJuvenile.Value = BMBM.Juvenile.Value;
                    numericUpDownLymphocytes.Value = BMBM.Lymphocytes.Value;
                    numericUpDownMonocytes.Value = BMBM.Monocytes.Value;
                    numericUpDownMyelocytes.Value = BMBM.Myelocytes.Value;
                    numericUpDownNormoblasts.Value = BMBM.Normoblasts.Value;
                    numericUpDownPlasmacells.Value = BMBM.PlasmaCells.Value;
                    numericUpDownPromyelocytes.Value = BMBM.Promyelocytes.Value;
                    numericUpDownSegmented.Value = BMBM.Segmented.Value;
                    numericUpDownStaff.Value = BMBM.Staff.Value;
                    comboBoxSiteBMA.Text = BMBM.BMAspSite;
                    comboBoxSiteBMBiopsy.Text = BMBM.BMBsite;
                    richTextBoxBiopsyConclusion.Text = BMBM.BMBconclusion;
                    richTextBoxBMAConclusion.Text = BMBM.BMAconclusion;
                    richTextBoxCommentBMA.Text = BMBM.BMAspComment;
                    richTextBoxHistologicalExamination.Text = BMBM.BMB_HistoExamin;
                    numericUpDownSizeBMBiopsy.Value = BMBM.BoneSize.Value;
                    comboBoxBonehardness.Text = BMBM.BoneHardness;

                    //==================================================================
                    textBoxTestNameCytogenetics.Text = BMBM.CytoTestName;
                    textBoxSpecimenCyto.Text = BMBM.CytoSpecimen;
                    textBoxRecommendation.Text = BMBM.CytoRecommendation;
                    textBoxKaryotype.Text = BMBM.CytoKaryotype;
                    textBoxInterpretation.Text = BMBM.CytoInterpretation;

                    numericUpDown45CellsCount.Value = BMBM.CytoCellsCounted45.Value;
                    numericUpDown46CellsCount.Value = BMBM.CytoCellsCounted46.Value;
                    numericUpDown47CellsCount.Value = BMBM.CytoCellsCounted47.Value;
                    numericUpDownTotalCellsCount.Value = BMBM.CytoCellsCounted4Total.Value;

                    numericUpDown45ChroCount.Value = BMBM.CytoChromosomeCount45.Value;
                    numericUpDown46ChroCount.Value = BMBM.CytoChromosomeCount46.Value;
                    numericUpDown47ChroCount.Value = BMBM.CytoChromosomeCount47.Value;
                    numericUpDownTotalChroCount.Value = BMBM.CytoChromosomeCountTotal.Value;

                    numericUpDown45Karyo.Value = BMBM.CytoCellsKayrotyped45.Value;
                    numericUpDown46Karyo.Value = BMBM.CytoCellsKayrotyped46.Value;
                    numericUpDown47Karyo.Value = BMBM.CytoCellsKayrotyped47.Value;
                    numericUpDownTotalKaryo.Value = BMBM.CytoCellsKayrotypedTotal.Value;

                    numericUpDown45Photographed.Value = BMBM.CytoCellsPhotographed45.Value;
                    numericUpDown46Photographed.Value = BMBM.CytoCellsPhotographed46.Value;
                    numericUpDown47Photographed.Value = BMBM.CytoCellsPhotographed47.Value;
                    numericUpDownTotalPhotographed.Value = BMBM.CytoCellsPhotographedTotal.Value;

                }
            }
            catch { ; }

        }

        private void buttonSearchByName_Click(object sender, EventArgs e)
        {
            if (buttonSearchByName.Text == "By Name")
            {
                try
                {
                    var DC1Context = new DataClasses1DataContext();
                    var PatintDataTable = new PatientDetail();
                    var BMResultsTable = new BoneMarrowResult();

                    //=============================================================================

                    var LoopListBox = from DD in DC1Context.PatientDetails
                                      select DD;
                    listBoxBMASP.Items.Clear();
                    foreach (var DD in LoopListBox)
                    {
                        listBoxBMASP.Items.Add(DD.PName);

                    }
                    buttonSearchByName.Text = "By Code";
                }
                catch { ; }
            }
            else
            {
                listBoxBMASP.Items.Clear();
                LoopForListBoxForID();
                buttonSearchByName.Text = "By Name";
            }
        }

        public void LoopForListBoxForIDByName()
        {

            string StringParam = textBoxSearchMedicalCode.Text;
            if (string.IsNullOrEmpty(StringParam) == true)
            {
                listBoxBMASP.Items.Clear();
                LoopForListBoxForID();
            }

            else
            {

                try
                {
                    var DC1Context = new DataClasses1DataContext();
                    var PatintDataTable = new PatientDetail();
                    var BMResultsTable = new BoneMarrowResult();

                    listBoxBMASP.Items.Add(listBoxBMASP.Items.Contains(textBoxSearchMedicalCode.Text));


                    var LoopListBox = (from DD in DC1Context.PatientDetails
                                       join DTR in DC1Context.BoneMarrowResults
                                       on DD.PatientID equals DTR.ID
                                       where DD.PName.Contains(StringParam)
                                       select new { DD, DTR }).ToList();



                    listBoxBMASP.Items.Clear();

                    foreach (var DD in LoopListBox)
                    {


                        listBoxBMASP.Items.Add(DD.DD.PName);



                        textBoxDoctorName.Text = DD.DD.DrName;
                        textBoxDrNameBiopsy.Text = DD.DD.DrName;

                        //------------------------------------------------
                        textBoxPatientName.Text = DD.DD.PName;
                        textBoxPnameBiopsy.Text = DD.DD.PName;

                        //------------------------------------------------
                        textBoxMedicalCodeBMASP.Text = DD.DD.PatientID.ToString();
                        textBoxMedicalCodeBMBiopsy.Text = DD.DD.PatientID.ToString();
                        //------------------------------------------------
                        textBoxEmail.Text = DD.DD.email;
                        textBoxEmailBiopsy.Text = DD.DD.email;

                        //------------------------------------------------
                        comboBoxGender.Text = DD.DD.Gender;
                        comboBoxGenderBiopsy.Text = DD.DD.Gender;

                        //------------------------------------------------
                        numericUpDownAge.Value = DD.DD.Age.Value;
                        numericUpDownAgeBiopsy.Value = DD.DD.Age.Value;

                        //------------------------------------------------
                        comboBoxAge.Text = DD.DD.AgeType;
                        comboBoxAgeTypeBiopsy.Text = DD.DD.AgeType;

                        //------------------------------------------------
                        dateTimePickerResultDate.Value = DD.DD.ResultDate.Value;
                        dateTimePickerResultBiopsy.Value = DD.DD.ResultDate.Value;

                        //------------------------------------------------
                        dateTimePickerVisitDate.Value = DD.DD.VisitDate.Value;
                        dateTimePickerVisitBiopsy.Value = DD.DD.VisitDate.Value;

                        //------------------------------------------------
                        textBoxAddress.Text = DD.DD.Adress;
                        textBoxAddressBiopsy.Text = DD.DD.Adress;


                    }
                    foreach (var BMBM in LoopListBox)
                    {

                        numericUpDownBasophils.Value = BMBM.DTR.Basophils.Value;
                        numericUpDownBlasts.Value = BMBM.DTR.Blasts.Value;
                        numericUpDownEosinophils.Value = BMBM.DTR.Eosinophils.Value;
                        numericUpDownJuvenile.Value = BMBM.DTR.Juvenile.Value;
                        numericUpDownLymphocytes.Value = BMBM.DTR.Lymphocytes.Value;
                        numericUpDownMonocytes.Value = BMBM.DTR.Monocytes.Value;
                        numericUpDownMyelocytes.Value = BMBM.DTR.Myelocytes.Value;
                        numericUpDownNormoblasts.Value = BMBM.DTR.Normoblasts.Value;
                        numericUpDownPlasmacells.Value = BMBM.DTR.PlasmaCells.Value;
                        numericUpDownPromyelocytes.Value = BMBM.DTR.Promyelocytes.Value;
                        numericUpDownSegmented.Value = BMBM.DTR.Segmented.Value;
                        numericUpDownStaff.Value = BMBM.DTR.Staff.Value;
                        comboBoxSiteBMA.Text = BMBM.DTR.BMAspSite;
                        comboBoxSiteBMBiopsy.Text = BMBM.DTR.BMBsite;
                        richTextBoxBiopsyConclusion.Text = BMBM.DTR.BMBconclusion;
                        richTextBoxBMAConclusion.Text = BMBM.DTR.BMAconclusion;
                        richTextBoxCommentBMA.Text = BMBM.DTR.BMAspComment;
                        richTextBoxHistologicalExamination.Text = BMBM.DTR.BMB_HistoExamin;
                        numericUpDownSizeBMBiopsy.Value = BMBM.DTR.BoneSize.Value;
                        comboBoxBonehardness.Text = BMBM.DTR.BoneHardness;

                        //==================================================================
                        textBoxTestNameCytogenetics.Text = BMBM.DTR.CytoTestName;
                        textBoxSpecimenCyto.Text = BMBM.DTR.CytoSpecimen;
                        textBoxRecommendation.Text = BMBM.DTR.CytoRecommendation;
                        textBoxKaryotype.Text = BMBM.DTR.CytoKaryotype;
                        textBoxInterpretation.Text = BMBM.DTR.CytoInterpretation;

                        numericUpDown45CellsCount.Value = BMBM.DTR.CytoCellsCounted45.Value;
                        numericUpDown46CellsCount.Value = BMBM.DTR.CytoCellsCounted46.Value;
                        numericUpDown47CellsCount.Value = BMBM.DTR.CytoCellsCounted47.Value;
                        numericUpDownTotalCellsCount.Value = BMBM.DTR.CytoCellsCounted4Total.Value;

                        numericUpDown45ChroCount.Value = BMBM.DTR.CytoChromosomeCount45.Value;
                        numericUpDown46ChroCount.Value = BMBM.DTR.CytoChromosomeCount46.Value;
                        numericUpDown47ChroCount.Value = BMBM.DTR.CytoChromosomeCount47.Value;
                        numericUpDownTotalChroCount.Value = BMBM.DTR.CytoChromosomeCountTotal.Value;

                        numericUpDown45Karyo.Value = BMBM.DTR.CytoCellsKayrotyped45.Value;
                        numericUpDown46Karyo.Value = BMBM.DTR.CytoCellsKayrotyped46.Value;
                        numericUpDown47Karyo.Value = BMBM.DTR.CytoCellsKayrotyped47.Value;
                        numericUpDownTotalKaryo.Value = BMBM.DTR.CytoCellsKayrotypedTotal.Value;

                        numericUpDown45Photographed.Value = BMBM.DTR.CytoCellsPhotographed45.Value;
                        numericUpDown46Photographed.Value = BMBM.DTR.CytoCellsPhotographed46.Value;
                        numericUpDown47Photographed.Value = BMBM.DTR.CytoCellsPhotographed47.Value;
                        numericUpDownTotalPhotographed.Value = BMBM.DTR.CytoCellsPhotographedTotal.Value;

                    }


                }

                catch { }



            }

            ///======================================================
            ///======================================================
            ///======================================================

            //    try
            //    {
            //        var DC1Context = new DataClasses1DataContext();
            //        var PatintDataTable = new PatientDetail();
            //        var BMResultsTable = new BoneMarrowResult();



            //        var LoopListBox = from DD in DC1Context.PatientDetails
            //                          select DD;
            //        foreach (var DD in LoopListBox)
            //        {
            //            listBoxBMASP.Items.Add(DD.PName);

            //        }
            //    }
            //    catch { ; }
        }

        private void exitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updateCurrentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonSaveBMA.PerformClick();
        }

        private void deleteCurrentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonDeleteBMASP.PerformClick();
        }

        private void printPreviewBMBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void printPreviewBMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2.PerformClick();
        }

        private void printPreviewImmunophenotypingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button4.PerformClick();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            button4.PerformClick();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonSaveBMA.PerformClick();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            buttonDeleteBMASP.PerformClick();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button10.PerformClick();
        }
        public void GGGGGGGGGG()
        {
            listBoxBMASP.Items.Clear();

            string StringParam = textBoxSearchMedicalCode.Text;
            var DC1Context = new DataClasses1DataContext();
            var PatintDataTable = new PatientDetail();
            var BMResultsTable = new BoneMarrowResult();


            var LoopListBox = from DD in DC1Context.PatientDetails

                              where DD.PName.Contains(StringParam)
                              select DD;

            foreach (var uuu in LoopListBox)
            {
                listBoxBMASP.Items.Add(uuu.PName);

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBoxMedicalCodeBMASP.Enabled = true;
            textBoxMedicalCodeBMASP.Text = null;
            richTextBoxBiopsyConclusion.Text = null;
            richTextBoxBMAConclusion.Text = null;
            richTextBoxCommentBMA.Text = null;
            richTextBoxHistologicalExamination.Text = null;
            textBoxAddress.Text = null;
            textBoxAddressBiopsy.Text = null;
            textBoxDoctorName.Text = null;
            textBoxDrNameBiopsy.Text = null;
            textBoxEmail.Text = null;
            textBoxEmailBiopsy.Text = null;
            textBoxMedicalCodeBMBiopsy.Text = null;
            textBoxPatientName.Text = null;
            textBoxPnameBiopsy.Text = null;
            textBoxSearchMedicalCode.Text = null;
            comboBoxAge.Text = null;
            comboBoxAgeTypeBiopsy.Text = null;
            comboBoxBonehardness.Text = null;
            comboBoxGender.Text = null;
            comboBoxGenderBiopsy.Text = null;
            comboBoxSiteBMA.Text = null;
            comboBoxSiteBMBiopsy.Text = null;
            numericUpDownAge.Value = 0;
            numericUpDownAgeBiopsy.Value = 0;
            numericUpDownBasophils.Value = 0;
            numericUpDownBlasts.Value = 0;
            numericUpDownEosinophils.Value = 0;
            numericUpDownJuvenile.Value = 0;
            numericUpDownLymphocytes.Value = 0;
            numericUpDownMonocytes.Value = 0;
            numericUpDownMyelocytes.Value = 0;
            numericUpDownNormoblasts.Value = 0;
            numericUpDownPlasmacells.Value = 0;
            numericUpDownPromyelocytes.Value = 0;
            numericUpDownSegmented.Value = 0;
            numericUpDownSizeBMBiopsy.Value = 0;
            numericUpDownStaff.Value = 0;
            textBoxInterpretation.Text = null;
            textBoxKaryotype.Text = null;
            textBoxRecommendation.Text = null;
            textBoxSpecimenCyto.Text = null;
            textBoxTestNameCytogenetics.Text = null;

            numericUpDown45CellsCount.Value = 0;
            numericUpDown46CellsCount.Value = 0;
            numericUpDown47CellsCount.Value = 0;
            numericUpDownTotalCellsCount.Value = 0;

            numericUpDown45ChroCount.Value = 0;
            numericUpDown46ChroCount.Value = 0;
            numericUpDown47ChroCount.Value = 0;
            numericUpDownTotalChroCount.Value = 0;

            numericUpDown45Karyo.Value = 0;
            numericUpDown46Karyo.Value = 0;
            numericUpDown47Karyo.Value = 0;
            numericUpDownTotalKaryo.Value = 0;

            numericUpDown45Photographed.Value = 0;
            numericUpDown46Photographed.Value = 0;
            numericUpDown47Photographed.Value = 0;
            numericUpDownTotalPhotographed.Value = 0;


        }

        private void textBoxMedicalCodeBMASP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                   && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only numbers allowed here|| فضلا يرجي ادخال ارقام فقط في هذا الحقل", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (e.KeyChar == 13)
            { SendKeys.Send("{tab}"); }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            frmSpellingChecker SPccc = new frmSpellingChecker();
            SPccc.ShowDialog();
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            frmSpellingChecker SPccc = new frmSpellingChecker();
            SPccc.ShowDialog();
        }

        private void BM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SavingStatus == true)
            {
                DialogResult SavingRequest = MessageBox.Show("Do you want to save?", "Saving Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (SavingRequest == DialogResult.Yes)
                {
                    DataClasses1DataContext DDCCDD = new DataClasses1DataContext();
                    int RecordExist = (from TYmmm in DDCCDD.PatientDetails
                                       where TYmmm.PatientID == int.Parse(textBoxMedicalCodeBMASP.Text)
                                       select TYmmm).Count();
                    if (RecordExist > 0)
                    {
                        UpdatePatientInDataBase();

                    }
                    else
                    {
                        AddPatientToDataBase();

                    }
                    textBoxMedicalCodeBMASP.Enabled = false;
                }
                if (SavingRequest == DialogResult.No)
                {

                }

            }
            SavingStatus = false;
        }

        private void SaveingStatusRequestMethod(object sender, EventArgs e)
        {
            SavingStatus = true;
        }

        private void textBoxDoctorName_TextChanged(object sender, EventArgs e)
        {
            SavingStatus = true;
        }

        private void listBoxBMASP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SavingStatus == true)
            {

                DataClasses1DataContext DDCCDD = new DataClasses1DataContext();
                int RecordExist = (from TYmmm in DDCCDD.PatientDetails
                                   where TYmmm.PatientID == int.Parse(textBoxMedicalCodeBMASP.Text)
                                   select TYmmm).Count();
                if (RecordExist > 0)
                {
                    UpdatePatientInDataBase();

                }
                else
                {
                    AddPatientToDataBase();

                }
                textBoxMedicalCodeBMASP.Enabled = false;


            }
            SavingStatus = false;
        }

        private void EnterAsTab(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{tab}");
            }
        }

        //private void AddImmunoPhenoTypingResult(object sender, EventArgs e)
        //{

        //    string[] items = new string[3];
        //    items[0] = comboBoxCDName.Text;
        //    items[1] = numericUpDownPercentage.Value.ToString();
        //    items[2] = comboBoxResultImmuno.Text;
        //    ListViewItem Item = new ListViewItem(items);
        //    listView1.Items.Add(Item);
        //    var DC1Context = new DataClasses1DataContext();


        //}

        private void SaveImmunoBut(object sender, EventArgs e)
        {

            var DCDC2 = new DataClasses1DataContext();

            var ImBMResultTable = new BoneMarrowResult();

            var qu2 = (from BMRecord in DCDC2.BoneMarrowResults
                       where BMRecord.ID == int.Parse(textBoxMedicalCodeBMASP.Text)
                       select BMRecord).Single<BoneMarrowResult>();
            //{
            //    qu2.PhenotypeImmuPhen = richTextBoxPhenotype.Text;
            //    qu2.ConclusionImmuPheno = richTextBoxConclusionImmunopheno.Text;
            //    qu2.CommentImmuPhen = richTextBoxCommentImmunopheno.Text;
            //}

            //===================================================================

            ImBMResultTable = qu2;
            try
            {
                DCDC2.SubmitChanges();
                //MessageBox.Show("Patient Saved Successfully","Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch
            { ; }


            ////==============================================================================

            string[] itemsarray = new string[3];
            //itemsarray[0] = comboBoxCDName.Text;
            //itemsarray[1] = numericUpDownPercentage.Value.ToString();
            //itemsarray[2] = comboBoxResultImmuno.Text;
            ListViewItem LVItem = new ListViewItem(itemsarray);


            var DC1Context = new DataClasses1DataContext();

            //================= Add Patient to database ============================


            //var ImmunophenotyingTable = new Immunophenotyping();
            //{
            //    ImmunophenotyingTable.PatientID = int.Parse(textBoxMedicalCodeImmuno.Text);
            //    ImmunophenotyingTable.MarkerName = itemsarray.GetValue(0).ToString();
            //    ImmunophenotyingTable.Percentage = itemsarray.GetValue(1).ToString();
            //    ImmunophenotyingTable.Result = itemsarray.GetValue(2).ToString();
            //    listView1.Items.Add(LVItem);
            //}
            //string[] MyStringArray = new string[4] { textBoxMedicalCodeImmuno.Text, comboBoxCDName.Text, numericUpDownPercentage.Value.ToString(), comboBoxResultImmuno.Text };


            //DC1Context.Immunophenotypings.InsertOnSubmit(ImmunophenotyingTable);
            //if (comboBoxCDName.Text == "" && comboBoxResultImmuno.Text == "" && numericUpDownPercentage.Value == 0)
            //{

            //}
            //else
            //{
            //    DC1Context.SubmitChanges();
            //}
            LoopForListViewItems();

        }

        private void contextMenuStripListViewImmuno_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {



        }

        private void DeleteFromListView(object sender, EventArgs e)
        {

            try
            {


                DataClasses1DataContext dcd55 = new DataClasses1DataContext();

                ListViewItem eachItem = new ListViewItem();

                //listView1.Items.RemoveAt(listView1.CheckedItems.IndexOf(eachItem));

                var Immm55 = new Immunophenotyping();
                var KKL = from FRF in dcd55.Immunophenotypings
                          where FRF.MarkerName == eachItem.SubItems[0].ToString()
                          select FRF;

                foreach (var SYS in KKL)
                {
                    dcd55.Immunophenotypings.DeleteOnSubmit(SYS);
                    dcd55.SubmitChanges();
                }






            }
            catch { ;}
        }

        private void button8_Click_1(object sender, EventArgs e)
        {


        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //listView1.LabelEdit = true;

        }

        private void RemoveAlltoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dcd = new DataClasses1DataContext();
            var Immunotable = new Immunophenotyping();
            var RTR = (from JUI in dcd.Immunophenotypings
                       where JUI.PatientID == int.Parse(listBoxBMASP.Text)
                       select JUI).ToList();

            foreach (var P in RTR)
            {
                dcd.Immunophenotypings.DeleteOnSubmit(P);
            }
            dcd.SubmitChanges();
            LoopForListViewItems();
        }

        private void button8_Click_2(object sender, EventArgs e)
        {
            if (textBoxMedicalCodeBMASP.Text == "")
            { MessageBox.Show("Select Patient ID to view || فضلا قم باختيار رقم المريض", "Selection missing", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            frmCytogeneticsRep BRep = new frmCytogeneticsRep(int.Parse(textBoxMedicalCodeBMASP.Text));
            BRep.Show();
        }

        

        private void button6_Click_1(object sender, EventArgs e)
        {

            foreach (var item in checkedListBox1.CheckedItems)
            {
                listBoxResistant.Items.Add(item);
            }


            List<string> removals = new List<string>();
            foreach (string s in checkedListBox1.CheckedItems)
            {
               
                removals.Add(s);
            }

            foreach (string s in removals)
            {
                checkedListBox1.Items.Remove(s);
            }
            //checkedListBox1.Items.Remove(checkedListBox1.SelectedItem);

            checkedListBox1.Refresh();
            checkedListBox1.Update();

        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems)
            {
                listBoxModerate.Items.Add(item);
            }


            List<string> removals = new List<string>();
            foreach (string s in checkedListBox1.CheckedItems)
            {

                removals.Add(s);
            }

            foreach (string s in removals)
            {
                checkedListBox1.Items.Remove(s);
            }
            //checkedListBox1.Items.Remove(checkedListBox1.SelectedItem);

            checkedListBox1.Refresh();
            checkedListBox1.Update();
            
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems)
            {
                listBoxSensitive.Items.Add(item);
            }


            List<string> removals = new List<string>();
            foreach (string s in checkedListBox1.CheckedItems)
            {

                removals.Add(s);
            }

            foreach (string s in removals)
            {
                checkedListBox1.Items.Remove(s);
            }
            //checkedListBox1.Items.Remove(checkedListBox1.SelectedItem);

            checkedListBox1.Refresh();
            checkedListBox1.Update();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, true);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, false);
        }

        private void contextMenuStripForAntibiotic_Click(object sender, EventArgs e)
        {
            
            

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            listBoxResistant.Items.Remove(listBoxResistant.SelectedItem);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            listBoxSensitive.Items.Remove(listBoxResistant.SelectedItem);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            listBoxModerate.Items.Remove(listBoxResistant.SelectedItem);
        }

        private void button11_Click_2(object sender, EventArgs e)
        {
            listBoxResistant.Items.Clear();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            listBoxModerate.Items.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            listBoxSensitive.Items.Clear();
        }





    }

        
    }


   

    
