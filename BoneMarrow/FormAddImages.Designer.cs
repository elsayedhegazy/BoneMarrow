namespace BoneMarrow
{
    partial class FormAddImages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddImages));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button11 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button19 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PNameImageForms = new System.Windows.Forms.TextBox();
            this.PIDImagesForm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(124, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 204);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Save Image ( 1 )";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SaveImage1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 291);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Save Image ( 3 )";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.SaveImage3);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(124, 284);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(294, 214);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(458, 291);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(105, 23);
            this.button8.TabIndex = 16;
            this.button8.Text = "Save Image ( 4 )";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.SaveImage4);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(569, 284);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(316, 214);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(457, 36);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(105, 23);
            this.button11.TabIndex = 12;
            this.button11.Text = "Save Image ( 2 )";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.SaveImage2);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(569, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(316, 204);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(604, 2);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(258, 23);
            this.button19.TabIndex = 26;
            this.button19.Text = "Delete All Images for Current Pateint";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Image 1 Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Image 2 Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Image 3 Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Image 4 Name";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PNameImageForms
            // 
            this.PNameImageForms.Enabled = false;
            this.PNameImageForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNameImageForms.Location = new System.Drawing.Point(393, 5);
            this.PNameImageForms.Name = "PNameImageForms";
            this.PNameImageForms.Size = new System.Drawing.Size(194, 21);
            this.PNameImageForms.TabIndex = 36;
            // 
            // PIDImagesForm
            // 
            this.PIDImagesForm.Enabled = false;
            this.PIDImagesForm.Location = new System.Drawing.Point(182, 5);
            this.PIDImagesForm.Name = "PIDImagesForm";
            this.PIDImagesForm.Size = new System.Drawing.Size(100, 20);
            this.PIDImagesForm.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Patient ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Patient Name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bone marrow aspirate 10 x",
            "Bone marrow aspirate 20 x",
            "Bone marrow aspirate 30 x",
            "Bone marrow aspirate 40 x",
            "Bone marrow Biopsy 10 x",
            "Bone marrow Biopsy 20 x",
            "Bone marrow Biopsy 30 x",
            "Bone marrow Biopsy 40 x"});
            this.comboBox1.Location = new System.Drawing.Point(124, 248);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(294, 21);
            this.comboBox1.TabIndex = 40;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Bone marrow aspirate 10 x",
            "Bone marrow aspirate 20 x",
            "Bone marrow aspirate 30 x",
            "Bone marrow aspirate 40 x",
            "Bone marrow Biopsy 10 x",
            "Bone marrow Biopsy 20 x",
            "Bone marrow Biopsy 30 x",
            "Bone marrow Biopsy 40 x"});
            this.comboBox2.Location = new System.Drawing.Point(569, 241);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(316, 21);
            this.comboBox2.TabIndex = 41;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Bone marrow aspirate 10 x",
            "Bone marrow aspirate 20 x",
            "Bone marrow aspirate 30 x",
            "Bone marrow aspirate 40 x",
            "Bone marrow Biopsy 10 x",
            "Bone marrow Biopsy 20 x",
            "Bone marrow Biopsy 30 x",
            "Bone marrow Biopsy 40 x"});
            this.comboBox3.Location = new System.Drawing.Point(124, 504);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(294, 21);
            this.comboBox3.TabIndex = 42;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Bone marrow aspirate 10 x",
            "Bone marrow aspirate 20 x",
            "Bone marrow aspirate 30 x",
            "Bone marrow aspirate 40 x",
            "Bone marrow Biopsy 10 x",
            "Bone marrow Biopsy 20 x",
            "Bone marrow Biopsy 30 x",
            "Bone marrow Biopsy 40 x"});
            this.comboBox4.Location = new System.Drawing.Point(569, 503);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(316, 21);
            this.comboBox4.TabIndex = 43;
            // 
            // FormAddImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 561);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PIDImagesForm);
            this.Controls.Add(this.PNameImageForms);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddImages";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Images";
            this.Load += new System.EventHandler(this.FormAddImages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox PNameImageForms;
        private System.Windows.Forms.TextBox PIDImagesForm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}