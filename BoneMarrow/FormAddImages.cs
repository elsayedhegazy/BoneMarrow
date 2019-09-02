using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BoneMarrow
{
    public partial class FormAddImages : Form
    {
        
        public FormAddImages(int PatientIDforImage,string PatientNameforImage)
        {
            InitializeComponent();
            PIDImagesForm.Text = PatientIDforImage.ToString();
            PNameImageForms.Text = PatientNameforImage;
        }

        private void FormAddImages_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext DDCCDD = new DataClasses1DataContext();
            int RecordExist = (from TYmmm in DDCCDD.Images
                               where TYmmm.ID == int.Parse(PIDImagesForm.Text)
                               select TYmmm).Count();
            var Immmmm = new Image();
            if (RecordExist <= 0)
            {
                Immmmm.ID = int.Parse(PIDImagesForm.Text);
            }
            else
            {
                LoopForImagesViewInForm();
                return;
            }
            DDCCDD.Images.InsertOnSubmit(Immmmm);
            DDCCDD.SubmitChanges();
            
        }
        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {

            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {

                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);

                return ms.ToArray();

            }

        }
        public System.Drawing.Image ByteArrayToImage(byte[] byteArrayIn)
        {

            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(byteArrayIn))
            {

                System.Drawing.Image returnImage =  System.Drawing.Image.FromStream(ms);
                return returnImage;

            }

        }
        private void LoopForImagesViewInForm()
        {
            DataClasses1DataContext MyImages = new DataClasses1DataContext();
            var VImage = (from Image in MyImages.Images
                         where Image.ID == int.Parse(PIDImagesForm.Text)
                         select Image).SingleOrDefault();
                        // select System.Drawing.Image.FromStream(new System.IO.MemoryStream(Image.Img1.ToArray()));
            try
            {
                pictureBox1.Image = System.Drawing.Image.FromStream(new System.IO.MemoryStream(VImage.Img1.ToArray()));
                pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                comboBox1.Text = VImage.ImgName1.ToString();
            }
            catch
            {
            }
            try
            {
                comboBox2.Text = VImage.ImgName2.ToString();
                pictureBox2.Image = System.Drawing.Image.FromStream(new System.IO.MemoryStream(VImage.Img2.ToArray()));
                pictureBox2.BorderStyle = BorderStyle.Fixed3D;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch
            {
            }
           try
           {
               pictureBox3.Image = System.Drawing.Image.FromStream(new System.IO.MemoryStream(VImage.Img3.ToArray()));
               pictureBox3.BorderStyle = BorderStyle.Fixed3D;
               pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
               comboBox3.Text = VImage.ImgName3.ToString();
           }
           catch
           {
           }
           try
           {
               pictureBox4.Image = System.Drawing.Image.FromStream(new System.IO.MemoryStream(VImage.Img4.ToArray()));
               pictureBox4.BorderStyle = BorderStyle.Fixed3D;
               pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
               comboBox4.Text = VImage.ImgName4.ToString();
           }
           catch
           {
           }
            //foreach (System.Drawing.Image IMuu in VImage)
            //{
            //    pictureBox1.Image = IMuu;
                
            //    pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            //    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            //}
            

            //var VImage2 = from Image in MyImages.Images
            //             where Image.ID == int.Parse(PIDImagesForm.Text)
            //             select System.Drawing.Image.FromStream(new System.IO.MemoryStream(Image.Img2.ToArray()));
            //foreach (System.Drawing.Image IMuu2 in VImage2)
            //{
            //    pictureBox2.Image = IMuu2;
            //    pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            //    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            //}
            //var VImage3 = from Image in MyImages.Images
            //              where Image.ID == int.Parse(PIDImagesForm.Text)
            //              select System.Drawing.Image.FromStream(new System.IO.MemoryStream(Image.Img3.ToArray()));

            //foreach (System.Drawing.Image IMuu3 in VImage3)
            //{
            //    pictureBox3.Image = IMuu3;
            //    pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            //    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

            //}
            //var VImage4 = from Image in MyImages.Images
            //              where Image.ID == int.Parse(PIDImagesForm.Text)
            //              select System.Drawing.Image.FromStream(new System.IO.MemoryStream(Image.Img4.ToArray()));
            
            
            //foreach (System.Drawing.Image IMuu4 in VImage4)
            //{
            //    pictureBox4.Image = IMuu4;
            //    pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            //    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;

            //}


        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            System.IO.MemoryStream MemStream = new System.IO.MemoryStream();
            imageIn.Save(MemStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            return MemStream.ToArray();
        }
        private byte[] GetFileContent(string imageFilePath)
        {
            System.IO.Stream fileStream = new System.IO.FileStream(imageFilePath, System.IO.FileMode.Open);
            byte[] fileContent = new byte[fileStream.Length];
            fileStream.Read(fileContent, 0, (int)fileStream.Length);
            fileStream.Close();
            return fileContent;
        }
        private void AddImage1(object sender, EventArgs e)
        {
           
       }

        private void AddImage2(object sender, EventArgs e)
        {
            
        }

        private void SaveImage1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            { MessageBox.Show("Choose Image name First", " Image Name missing ", MessageBoxButtons.OK, MessageBoxIcon.Hand); return; }
            else
            {
                var DCforImages = new DataClasses1DataContext();

                try
                {
                    openFileDialog1.ShowDialog();

                    //pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                    //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    string FileNameBM = openFileDialog1.FileName.ToString();
                    string FileNameNoPath = openFileDialog1.SafeFileName.ToString();

                    byte[] ImageReady = GetFileContent(FileNameBM);
                    System.Data.Linq.Binary FilBinary = new System.Data.Linq.Binary(ImageReady);

                    var IImage = new Image();
                    var quImage = (from CCC in DCforImages.Images
                                   where CCC.ID == int.Parse(PIDImagesForm.Text)
                                   select CCC).Single<Image>();

                    quImage.Img1 = FilBinary;
                    quImage.ImgName1 = comboBox1.Text;

                    IImage = quImage;

                    DCforImages.SubmitChanges();
                    LoopForImagesViewInForm();
                    MessageBox.Show("Saving image Done");
                }

                catch
                { ; }
                finally
                {

                }
            }

            //=== Adding Code for Images from OFD to SQL ========
            //var DCforImages = new DataClasses1DataContext();

            //try
            //{
            //    openFileDialog1.ShowDialog();

            //        //pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            //        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //        string FileNameBM = openFileDialog1.FileName.ToString();
            //        string FileNameNoPath = openFileDialog1.SafeFileName.ToString();

            //        byte[] ImageReady = GetFileContent(FileNameBM);
            //        System.Data.Linq.Binary FilBinary = new System.Data.Linq.Binary(ImageReady);

            //        Image IImage = new Image();
            //        {
            //            //===== Insert image 1 =====

            //            IImage.Img1 = FilBinary;
            //            IImage.ImgName1 = textBoxImage1.Text;
            //        }

            //        DCforImages.Images.InsertOnSubmit(IImage);

            //        DCforImages.SubmitChanges();
            //        MessageBox.Show("Submit images Done");
            //    }

            //catch (Exception exx)
            //{ MessageBox.Show(exx.ToString()); }
            //finally
            //{
            //    MessageBox.Show("Done");
            //}

        }

        private void DeleteImage1(object sender, EventArgs e)
        {
            var DC1Context = new DataClasses1DataContext();
            var ImagesTable = new Image();
            //=============================================================================
            //======== Delete Patient from data base ======================================
            var VarDeletePatintImages = from P in DC1Context.Images
                                        where P.ID == int.Parse(PIDImagesForm.Text)
                                        select  P ;
            try
            {
                foreach (var P in VarDeletePatintImages)
                {
                    DC1Context.Images.DeleteOnSubmit(P);
                    DC1Context.SubmitChanges();
                    MessageBox.Show("Image Deleted Successfully", "Delete Image", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoopForImagesViewInForm();
                
            }
            catch 
            {; }
        }

        private void SaveImage2(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            { MessageBox.Show("Choose Image name First", " Image Name missing ", MessageBoxButtons.OK, MessageBoxIcon.Hand); return; }
            else
            {
                var DCforImages = new DataClasses1DataContext();

                try
                {
                    openFileDialog1.ShowDialog();

                    //pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                    //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    string FileNameBM = openFileDialog1.FileName.ToString();
                    string FileNameNoPath = openFileDialog1.SafeFileName.ToString();

                    byte[] ImageReady = GetFileContent(FileNameBM);
                    System.Data.Linq.Binary FilBinary = new System.Data.Linq.Binary(ImageReady);

                    var IImage = new Image();
                    var quImage = (from CCC in DCforImages.Images
                                   where CCC.ID == int.Parse(PIDImagesForm.Text)
                                   select CCC).Single<Image>();

                    quImage.Img2 = FilBinary;
                    quImage.ImgName2 = comboBox2.Text;

                    IImage = quImage;

                    DCforImages.SubmitChanges();
                    LoopForImagesViewInForm();
                    MessageBox.Show("Saving image Done");
                }

                catch
                { ; }
                finally
                {

                }
            }
        }

        private void SaveImage3(object sender, EventArgs e)
        {
            if (comboBox3.Text == "")
            { MessageBox.Show("Choose Image name First", " Image Name missing ", MessageBoxButtons.OK, MessageBoxIcon.Hand); return; }
            else
            {
                var DCforImages = new DataClasses1DataContext();

                try
                {
                    openFileDialog1.ShowDialog();

                    //pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                    //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    string FileNameBM = openFileDialog1.FileName.ToString();
                    string FileNameNoPath = openFileDialog1.SafeFileName.ToString();

                    byte[] ImageReady = GetFileContent(FileNameBM);
                    System.Data.Linq.Binary FilBinary = new System.Data.Linq.Binary(ImageReady);

                    var IImage = new Image();
                    var quImage = (from CCC in DCforImages.Images
                                   where CCC.ID == int.Parse(PIDImagesForm.Text)
                                   select CCC).Single<Image>();

                    quImage.Img3 = FilBinary;
                    quImage.ImgName3 = comboBox3.Text;

                    IImage = quImage;

                    DCforImages.SubmitChanges();
                    LoopForImagesViewInForm();
                    MessageBox.Show("Saving image Done");
                }
                catch { }
            }
        }

        private void SaveImage4(object sender, EventArgs e)
        {
            if (comboBox4.Text == "")
            { MessageBox.Show("Choose Image name First", " Image Name missing ", MessageBoxButtons.OK, MessageBoxIcon.Hand); return; }
            else
            {
                var DCforImages = new DataClasses1DataContext();

                try
                {
                    openFileDialog1.ShowDialog();

                    //pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                    //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    string FileNameBM = openFileDialog1.FileName.ToString();
                    string FileNameNoPath = openFileDialog1.SafeFileName.ToString();

                    byte[] ImageReady = GetFileContent(FileNameBM);
                    System.Data.Linq.Binary FilBinary = new System.Data.Linq.Binary(ImageReady);

                    var IImage = new Image();
                    var quImage = (from CCC in DCforImages.Images
                                   where CCC.ID == int.Parse(PIDImagesForm.Text)
                                   select CCC).Single<Image>();

                    quImage.Img4 = FilBinary;
                    quImage.ImgName4 = comboBox4.Text;

                    IImage = quImage;

                    DCforImages.SubmitChanges();
                    LoopForImagesViewInForm();
                    MessageBox.Show("Saving image Done");
                }
                catch { }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            var DC1Context = new DataClasses1DataContext();
            var ImagesTable = new Image();
            //=============================================================================
            //======== Delete Patient from data base ======================================
            var VarDeletePatintImages = from P in DC1Context.Images
                                        where P.ID == int.Parse(PIDImagesForm.Text)
                                        select P;
            try
            {
                foreach (var P in VarDeletePatintImages)
                {
                    DC1Context.Images.DeleteOnSubmit(P);
                    DC1Context.SubmitChanges();
                    pictureBox1.Image = null;
                    pictureBox2.Image = null;
                    pictureBox3.Image = null;
                    pictureBox4.Image = null;
                    MessageBox.Show("Image Deleted Successfully", "Delete Image", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoopForImagesViewInForm();

            }
            catch
            { ; }
           
            FormAddImages.ActiveForm.Close();

        }
        }
    }

