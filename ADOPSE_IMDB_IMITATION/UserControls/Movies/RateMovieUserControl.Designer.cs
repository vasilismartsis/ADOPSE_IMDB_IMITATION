﻿
namespace ADOPSE_IMDB_IMITATION.UserControls.Movies
{
    partial class RateMovieUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.RateMovieRadioButtonGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SaveRatingBtn = new System.Windows.Forms.Button();
            this.RateMovieRadioButtonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // RateMovieRadioButtonGroupBox
            // 
            this.RateMovieRadioButtonGroupBox.Controls.Add(this.radioButton5);
            this.RateMovieRadioButtonGroupBox.Controls.Add(this.radioButton4);
            this.RateMovieRadioButtonGroupBox.Controls.Add(this.radioButton3);
            this.RateMovieRadioButtonGroupBox.Controls.Add(this.radioButton2);
            this.RateMovieRadioButtonGroupBox.Controls.Add(this.radioButton1);
            this.RateMovieRadioButtonGroupBox.Location = new System.Drawing.Point(3, 3);
            this.RateMovieRadioButtonGroupBox.Name = "RateMovieRadioButtonGroupBox";
            this.RateMovieRadioButtonGroupBox.Size = new System.Drawing.Size(191, 38);
            this.RateMovieRadioButtonGroupBox.TabIndex = 1;
            this.RateMovieRadioButtonGroupBox.TabStop = false;
            this.RateMovieRadioButtonGroupBox.Text = "Rate the movie";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(154, 17);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(31, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(117, 17);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(31, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(80, 17);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(43, 17);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // SaveRatingBtn
            // 
            this.SaveRatingBtn.Location = new System.Drawing.Point(200, 14);
            this.SaveRatingBtn.Name = "SaveRatingBtn";
            this.SaveRatingBtn.Size = new System.Drawing.Size(40, 23);
            this.SaveRatingBtn.TabIndex = 3;
            this.SaveRatingBtn.Text = "OK";
            this.SaveRatingBtn.UseVisualStyleBackColor = true;
            this.SaveRatingBtn.Click += new System.EventHandler(this.SaveRatingBtn_Click);
            // 
            // RateMovieUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(249, 49);
            this.Controls.Add(this.SaveRatingBtn);
            this.Controls.Add(this.RateMovieRadioButtonGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RateMovieUserControl";
            this.Text = "Rate Movie";
            this.RateMovieRadioButtonGroupBox.ResumeLayout(false);
            this.RateMovieRadioButtonGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox RateMovieRadioButtonGroupBox;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button SaveRatingBtn;
    }
}
