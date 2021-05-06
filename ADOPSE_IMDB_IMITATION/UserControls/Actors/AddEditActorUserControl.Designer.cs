namespace ADOPSE_IMDB_IMITATION.UserControls.Nena
{
    partial class AddEditActorUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditActorUserControl));
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BirthDateDatePicker = new System.Windows.Forms.DateTimePicker();
            this.UserControlHeader = new System.Windows.Forms.Label();
            this.SaveActorBtn = new System.Windows.Forms.Button();
            this.AddNewActorBtn = new System.Windows.Forms.Button();
            this.ShowAllActorsBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FirstName:";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(259, 79);
            this.FirstNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(145, 20);
            this.FirstNameTextBox.TabIndex = 1;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(259, 99);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(145, 20);
            this.LastNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "LastName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "BirthDate:";
            // 
            // BirthDateDatePicker
            // 
            this.BirthDateDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDateDatePicker.Location = new System.Drawing.Point(259, 119);
            this.BirthDateDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.BirthDateDatePicker.Name = "BirthDateDatePicker";
            this.BirthDateDatePicker.Size = new System.Drawing.Size(145, 20);
            this.BirthDateDatePicker.TabIndex = 6;
            // 
            // UserControlHeader
            // 
            this.UserControlHeader.AutoSize = true;
            this.UserControlHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserControlHeader.Location = new System.Drawing.Point(229, 21);
            this.UserControlHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserControlHeader.Name = "UserControlHeader";
            this.UserControlHeader.Size = new System.Drawing.Size(197, 25);
            this.UserControlHeader.TabIndex = 7;
            this.UserControlHeader.Text = "UserControlHeader";
            // 
            // SaveActorBtn
            // 
            this.SaveActorBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveActorBtn.Image")));
            this.SaveActorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveActorBtn.Location = new System.Drawing.Point(173, 168);
            this.SaveActorBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SaveActorBtn.Name = "SaveActorBtn";
            this.SaveActorBtn.Size = new System.Drawing.Size(128, 32);
            this.SaveActorBtn.TabIndex = 8;
            this.SaveActorBtn.Text = "Save Actor";
            this.SaveActorBtn.UseVisualStyleBackColor = true;
            this.SaveActorBtn.Click += new System.EventHandler(this.SaveActorBtn_Click);
            // 
            // AddNewActorBtn
            // 
            this.AddNewActorBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddNewActorBtn.Image")));
            this.AddNewActorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddNewActorBtn.Location = new System.Drawing.Point(305, 168);
            this.AddNewActorBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddNewActorBtn.Name = "AddNewActorBtn";
            this.AddNewActorBtn.Size = new System.Drawing.Size(139, 32);
            this.AddNewActorBtn.TabIndex = 10;
            this.AddNewActorBtn.Text = "Add new Actor";
            this.AddNewActorBtn.UseVisualStyleBackColor = true;
            this.AddNewActorBtn.Click += new System.EventHandler(this.AddNewActorBtn_Click);
            // 
            // ShowAllActorsBtn
            // 
            this.ShowAllActorsBtn.Image = ((System.Drawing.Image)(resources.GetObject("ShowAllActorsBtn.Image")));
            this.ShowAllActorsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowAllActorsBtn.Location = new System.Drawing.Point(448, 168);
            this.ShowAllActorsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ShowAllActorsBtn.Name = "ShowAllActorsBtn";
            this.ShowAllActorsBtn.Size = new System.Drawing.Size(144, 32);
            this.ShowAllActorsBtn.TabIndex = 11;
            this.ShowAllActorsBtn.Text = "Show all Actors";
            this.ShowAllActorsBtn.UseVisualStyleBackColor = true;
            this.ShowAllActorsBtn.Click += new System.EventHandler(this.ShowAllActorsBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // AddEditActorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ShowAllActorsBtn);
            this.Controls.Add(this.AddNewActorBtn);
            this.Controls.Add(this.SaveActorBtn);
            this.Controls.Add(this.UserControlHeader);
            this.Controls.Add(this.BirthDateDatePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddEditActorUserControl";
            this.Size = new System.Drawing.Size(658, 291);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker BirthDateDatePicker;
        private System.Windows.Forms.Label UserControlHeader;
        private System.Windows.Forms.Button SaveActorBtn;
        private System.Windows.Forms.Button AddNewActorBtn;
        private System.Windows.Forms.Button ShowAllActorsBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
