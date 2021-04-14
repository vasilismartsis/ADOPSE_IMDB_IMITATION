
namespace ADOPSE_IMDB_IMITATION.UserControls.Movies
{
    partial class ShowAllMovies
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
            this.components = new System.ComponentModel.Container();
            this.MoviesGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trailerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isSeriesDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aDOPSE_IMDB_IMITATIONDataSet = new ADOPSE_IMDB_IMITATION.ADOPSE_IMDB_IMITATIONDataSet();
            this.moviesTableAdapter = new ADOPSE_IMDB_IMITATION.ADOPSE_IMDB_IMITATIONDataSetTableAdapters.MoviesTableAdapter();
            this.DoubleClickToEditLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDOPSE_IMDB_IMITATIONDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // MoviesGridView
            // 
            this.MoviesGridView.AllowUserToAddRows = false;
            this.MoviesGridView.AllowUserToDeleteRows = false;
            this.MoviesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoviesGridView.AutoGenerateColumns = false;
            this.MoviesGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MoviesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MoviesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.releaseDateDataGridViewTextBoxColumn,
            this.imageDataGridViewTextBoxColumn,
            this.trailerDataGridViewTextBoxColumn,
            this.directorDataGridViewTextBoxColumn,
            this.isSeriesDataGridViewCheckBoxColumn});
            this.MoviesGridView.DataSource = this.moviesBindingSource;
            this.MoviesGridView.Location = new System.Drawing.Point(0, 47);
            this.MoviesGridView.Name = "MoviesGridView";
            this.MoviesGridView.Size = new System.Drawing.Size(531, 400);
            this.MoviesGridView.TabIndex = 0;
            this.MoviesGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MoviesGridView_CellContentDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // releaseDateDataGridViewTextBoxColumn
            // 
            this.releaseDateDataGridViewTextBoxColumn.DataPropertyName = "releaseDate";
            this.releaseDateDataGridViewTextBoxColumn.HeaderText = "releaseDate";
            this.releaseDateDataGridViewTextBoxColumn.Name = "releaseDateDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "image";
            this.imageDataGridViewTextBoxColumn.HeaderText = "image";
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            // 
            // trailerDataGridViewTextBoxColumn
            // 
            this.trailerDataGridViewTextBoxColumn.DataPropertyName = "trailer";
            this.trailerDataGridViewTextBoxColumn.HeaderText = "trailer";
            this.trailerDataGridViewTextBoxColumn.Name = "trailerDataGridViewTextBoxColumn";
            // 
            // directorDataGridViewTextBoxColumn
            // 
            this.directorDataGridViewTextBoxColumn.DataPropertyName = "director";
            this.directorDataGridViewTextBoxColumn.HeaderText = "director";
            this.directorDataGridViewTextBoxColumn.Name = "directorDataGridViewTextBoxColumn";
            // 
            // isSeriesDataGridViewCheckBoxColumn
            // 
            this.isSeriesDataGridViewCheckBoxColumn.DataPropertyName = "isSeries";
            this.isSeriesDataGridViewCheckBoxColumn.HeaderText = "isSeries";
            this.isSeriesDataGridViewCheckBoxColumn.Name = "isSeriesDataGridViewCheckBoxColumn";
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "Movies";
            this.moviesBindingSource.DataSource = this.aDOPSE_IMDB_IMITATIONDataSet;
            // 
            // aDOPSE_IMDB_IMITATIONDataSet
            // 
            this.aDOPSE_IMDB_IMITATIONDataSet.DataSetName = "ADOPSE_IMDB_IMITATIONDataSet";
            this.aDOPSE_IMDB_IMITATIONDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // DoubleClickToEditLabel
            // 
            this.DoubleClickToEditLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DoubleClickToEditLabel.AutoSize = true;
            this.DoubleClickToEditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.DoubleClickToEditLabel.Location = new System.Drawing.Point(139, 14);
            this.DoubleClickToEditLabel.Name = "DoubleClickToEditLabel";
            this.DoubleClickToEditLabel.Size = new System.Drawing.Size(228, 20);
            this.DoubleClickToEditLabel.TabIndex = 1;
            this.DoubleClickToEditLabel.Text = "Double click a movie to edit";
            // 
            // ShowAllMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DoubleClickToEditLabel);
            this.Controls.Add(this.MoviesGridView);
            this.Name = "ShowAllMovies";
            this.Size = new System.Drawing.Size(531, 447);
            this.Load += new System.EventHandler(this.EditMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MoviesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDOPSE_IMDB_IMITATIONDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MoviesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trailerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSeriesDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private ADOPSE_IMDB_IMITATIONDataSet aDOPSE_IMDB_IMITATIONDataSet;
        private ADOPSE_IMDB_IMITATIONDataSetTableAdapters.MoviesTableAdapter moviesTableAdapter;
        private System.Windows.Forms.Label DoubleClickToEditLabel;
    }
}
