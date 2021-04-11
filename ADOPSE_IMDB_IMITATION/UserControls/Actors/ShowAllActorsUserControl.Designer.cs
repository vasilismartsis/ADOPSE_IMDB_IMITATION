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
            ((System.ComponentModel.ISupportInitialize)(this.AllActorsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AllActorsDataGridView
            // 
            this.AllActorsDataGridView.AllowUserToAddRows = false;
            this.AllActorsDataGridView.AllowUserToDeleteRows = false;
            this.AllActorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllActorsDataGridView.Location = new System.Drawing.Point(67, 134);
            this.AllActorsDataGridView.Name = "AllActorsDataGridView";
            this.AllActorsDataGridView.ReadOnly = true;
            this.AllActorsDataGridView.RowTemplate.Height = 28;
            this.AllActorsDataGridView.Size = new System.Drawing.Size(843, 285);
            this.AllActorsDataGridView.TabIndex = 0;
            // 
            // UserControlHeader
            // 
            this.UserControlHeader.AutoSize = true;
            this.UserControlHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserControlHeader.Location = new System.Drawing.Point(519, 34);
            this.UserControlHeader.Name = "UserControlHeader";
            this.UserControlHeader.Size = new System.Drawing.Size(107, 36);
            this.UserControlHeader.TabIndex = 8;
            this.UserControlHeader.Text = "Actors";
            // 
            // ShowAllActorsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UserControlHeader);
            this.Controls.Add(this.AllActorsDataGridView);
            this.Name = "ShowAllActorsUserControl";
            this.Size = new System.Drawing.Size(1504, 682);
            ((System.ComponentModel.ISupportInitialize)(this.AllActorsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AllActorsDataGridView;
        private System.Windows.Forms.Label UserControlHeader;
    }
}
