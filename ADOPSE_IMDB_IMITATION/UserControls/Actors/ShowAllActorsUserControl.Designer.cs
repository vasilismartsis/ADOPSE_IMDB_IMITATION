namespace ADOPSE_IMDB_IMITATION.UserControls.Nena
{
    partial class ShowAllActorsUserControl
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
            this.AllActorsDataGridView = new System.Windows.Forms.DataGridView();
            this.UserControlHeader = new System.Windows.Forms.Label();
            this.OpenSelectedActorBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllActorsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AllActorsDataGridView
            // 
            this.AllActorsDataGridView.AllowUserToAddRows = false;
            this.AllActorsDataGridView.AllowUserToDeleteRows = false;
            this.AllActorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllActorsDataGridView.Location = new System.Drawing.Point(45, 87);
            this.AllActorsDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AllActorsDataGridView.Name = "AllActorsDataGridView";
            this.AllActorsDataGridView.ReadOnly = true;
            this.AllActorsDataGridView.RowTemplate.Height = 28;
            this.AllActorsDataGridView.Size = new System.Drawing.Size(562, 185);
            this.AllActorsDataGridView.TabIndex = 0;
            // 
            // UserControlHeader
            // 
            this.UserControlHeader.AutoSize = true;
            this.UserControlHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserControlHeader.Location = new System.Drawing.Point(346, 22);
            this.UserControlHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserControlHeader.Name = "UserControlHeader";
            this.UserControlHeader.Size = new System.Drawing.Size(74, 25);
            this.UserControlHeader.TabIndex = 8;
            this.UserControlHeader.Text = "Actors";
            // 
            // OpenSelectedActorBtn
            // 
            this.OpenSelectedActorBtn.Location = new System.Drawing.Point(263, 321);
            this.OpenSelectedActorBtn.Name = "OpenSelectedActorBtn";
            this.OpenSelectedActorBtn.Size = new System.Drawing.Size(195, 23);
            this.OpenSelectedActorBtn.TabIndex = 9;
            this.OpenSelectedActorBtn.Text = "Open selected Actor";
            this.OpenSelectedActorBtn.UseVisualStyleBackColor = true;
            this.OpenSelectedActorBtn.Click += new System.EventHandler(this.OpenSelectedActorBtn_Click);
            // 
            // ShowAllActorsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OpenSelectedActorBtn);
            this.Controls.Add(this.UserControlHeader);
            this.Controls.Add(this.AllActorsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ShowAllActorsUserControl";
            this.Size = new System.Drawing.Size(1003, 443);
            ((System.ComponentModel.ISupportInitialize)(this.AllActorsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AllActorsDataGridView;
        private System.Windows.Forms.Label UserControlHeader;
        private System.Windows.Forms.Button OpenSelectedActorBtn;
    }
}
