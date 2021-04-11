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
            this.button1 = new System.Windows.Forms.Button();
            this.AddNewActorTestBtn = new System.Windows.Forms.Button();
            this.ShowAllActorsTestBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "FirstName:";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(389, 121);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(216, 26);
            this.FirstNameTextBox.TabIndex = 1;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(389, 153);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(216, 26);
            this.LastNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "LastName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "BirthDate:";
            // 
            // BirthDateDatePicker
            // 
            this.BirthDateDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDateDatePicker.Location = new System.Drawing.Point(389, 183);
            this.BirthDateDatePicker.Name = "BirthDateDatePicker";
            this.BirthDateDatePicker.Size = new System.Drawing.Size(216, 26);
            this.BirthDateDatePicker.TabIndex = 6;
            // 
            // UserControlHeader
            // 
            this.UserControlHeader.AutoSize = true;
            this.UserControlHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserControlHeader.Location = new System.Drawing.Point(343, 33);
            this.UserControlHeader.Name = "UserControlHeader";
            this.UserControlHeader.Size = new System.Drawing.Size(288, 36);
            this.UserControlHeader.TabIndex = 7;
            this.UserControlHeader.Text = "UserControlHeader";
            // 
            // SaveActorBtn
            // 
            this.SaveActorBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveActorBtn.Image")));
            this.SaveActorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveActorBtn.Location = new System.Drawing.Point(277, 266);
            this.SaveActorBtn.Name = "SaveActorBtn";
            this.SaveActorBtn.Size = new System.Drawing.Size(160, 34);
            this.SaveActorBtn.TabIndex = 8;
            this.SaveActorBtn.Text = "Save Actor";
            this.SaveActorBtn.UseVisualStyleBackColor = true;
            this.SaveActorBtn.Click += new System.EventHandler(this.SaveActorBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Load Actor test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewActorTestBtn
            // 
            this.AddNewActorTestBtn.Location = new System.Drawing.Point(613, 266);
            this.AddNewActorTestBtn.Name = "AddNewActorTestBtn";
            this.AddNewActorTestBtn.Size = new System.Drawing.Size(131, 34);
            this.AddNewActorTestBtn.TabIndex = 10;
            this.AddNewActorTestBtn.Text = "Add new Actor test";
            this.AddNewActorTestBtn.UseVisualStyleBackColor = true;
            this.AddNewActorTestBtn.Click += new System.EventHandler(this.AddNewActorTestBtn_Click);
            // 
            // ShowAllActorsTestBtn
            // 
            this.ShowAllActorsTestBtn.Location = new System.Drawing.Point(764, 266);
            this.ShowAllActorsTestBtn.Name = "ShowAllActorsTestBtn";
            this.ShowAllActorsTestBtn.Size = new System.Drawing.Size(131, 34);
            this.ShowAllActorsTestBtn.TabIndex = 11;
            this.ShowAllActorsTestBtn.Text = "Show all Actors test";
            this.ShowAllActorsTestBtn.UseVisualStyleBackColor = true;
            this.ShowAllActorsTestBtn.Click += new System.EventHandler(this.ShowAllActorsTestBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // AddEditActorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ShowAllActorsTestBtn);
            this.Controls.Add(this.AddNewActorTestBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveActorBtn);
            this.Controls.Add(this.UserControlHeader);
            this.Controls.Add(this.BirthDateDatePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddEditActorUserControl";
            this.Size = new System.Drawing.Size(987, 448);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddNewActorTestBtn;
        private System.Windows.Forms.Button ShowAllActorsTestBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
