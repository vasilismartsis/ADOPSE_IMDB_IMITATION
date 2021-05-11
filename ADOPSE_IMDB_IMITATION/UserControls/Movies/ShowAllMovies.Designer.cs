
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
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aDOPSE_IMDB_IMITATIONDataSet = new ADOPSE_IMDB_IMITATION.ADOPSE_IMDB_IMITATIONDataSet();
            this.DoubleClickToEditLabel = new System.Windows.Forms.Label();
            this.moviesTableAdapter = new ADOPSE_IMDB_IMITATION.ADOPSE_IMDB_IMITATIONDataSetTableAdapters.MoviesTableAdapter();
            this.tableAdapterManager = new ADOPSE_IMDB_IMITATION.ADOPSE_IMDB_IMITATIONDataSetTableAdapters.TableAdapterManager();
            this.MoviesGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchMovieLabel = new System.Windows.Forms.Label();
            this.SearchMovieTextBox = new PlaceholderTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDOPSE_IMDB_IMITATIONDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesGridView)).BeginInit();
            this.SuspendLayout();
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
            // DoubleClickToEditLabel
            // 
            this.DoubleClickToEditLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DoubleClickToEditLabel.AutoSize = true;
            this.DoubleClickToEditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.DoubleClickToEditLabel.Location = new System.Drawing.Point(121, 0);
            this.DoubleClickToEditLabel.Name = "DoubleClickToEditLabel";
            this.DoubleClickToEditLabel.Size = new System.Drawing.Size(329, 20);
            this.DoubleClickToEditLabel.TabIndex = 1;
            this.DoubleClickToEditLabel.Text = "*Double click any movie you want to edit";
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MoviesTableAdapter = this.moviesTableAdapter;
            this.tableAdapterManager.UpdateOrder = ADOPSE_IMDB_IMITATION.ADOPSE_IMDB_IMITATIONDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // MoviesGridView
            // 
            this.MoviesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoviesGridView.AutoGenerateColumns = false;
            this.MoviesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MoviesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MoviesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MoviesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn7});
            this.MoviesGridView.DataSource = this.moviesBindingSource;
            this.MoviesGridView.Location = new System.Drawing.Point(0, 91);
            this.MoviesGridView.Name = "MoviesGridView";
            this.MoviesGridView.Size = new System.Drawing.Size(560, 356);
            this.MoviesGridView.TabIndex = 1;
            this.MoviesGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MoviesGridView_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 41;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 58;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "releaseDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "releaseDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 89;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "image";
            this.dataGridViewTextBoxColumn4.HeaderText = "image";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "trailer";
            this.dataGridViewTextBoxColumn5.HeaderText = "trailer";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 57;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "director";
            this.dataGridViewTextBoxColumn6.HeaderText = "director";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 67;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "isSeries";
            this.dataGridViewCheckBoxColumn1.HeaderText = "isSeries";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 49;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn7.HeaderText = "description";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 83;
            // 
            // SearchMovieLabel
            // 
            this.SearchMovieLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchMovieLabel.AutoSize = true;
            this.SearchMovieLabel.Location = new System.Drawing.Point(236, 34);
            this.SearchMovieLabel.Name = "SearchMovieLabel";
            this.SearchMovieLabel.Size = new System.Drawing.Size(76, 13);
            this.SearchMovieLabel.TabIndex = 4;
            this.SearchMovieLabel.Text = "Search Movie:";
            // 
            // SearchMovieTextBox
            // 
            this.SearchMovieTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchMovieTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.SearchMovieTextBox.Location = new System.Drawing.Point(208, 50);
            this.SearchMovieTextBox.Name = "SearchMovieTextBox";
            this.SearchMovieTextBox.Placeholder = "Search Movie";
            this.SearchMovieTextBox.Size = new System.Drawing.Size(135, 20);
            this.SearchMovieTextBox.TabIndex = 3;
            this.SearchMovieTextBox.Text = "Search Movie";
            this.SearchMovieTextBox.TextChanged += new System.EventHandler(this.SearchMovieTextBox_TextChanged);
            // 
            // ShowAllMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SearchMovieLabel);
            this.Controls.Add(this.SearchMovieTextBox);
            this.Controls.Add(this.MoviesGridView);
            this.Controls.Add(this.DoubleClickToEditLabel);
            this.Name = "ShowAllMovies";
            this.Size = new System.Drawing.Size(560, 447);
            this.Load += new System.EventHandler(this.EditMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDOPSE_IMDB_IMITATIONDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private ADOPSE_IMDB_IMITATIONDataSet aDOPSE_IMDB_IMITATIONDataSet;
        private System.Windows.Forms.Label DoubleClickToEditLabel;
        private ADOPSE_IMDB_IMITATIONDataSetTableAdapters.MoviesTableAdapter moviesTableAdapter;
        private ADOPSE_IMDB_IMITATIONDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView MoviesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private PlaceholderTextBox SearchMovieTextBox;
        private System.Windows.Forms.Label SearchMovieLabel;
    }
}
