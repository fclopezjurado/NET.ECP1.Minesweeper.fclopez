namespace Minesweeper.Views
{
    partial class ShowScores
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.minesweeperDataSet = new Minesweeper.minesweeperDataSet();
            this.scoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scoreTableAdapter = new Minesweeper.minesweeperDataSetTableAdapters.ScoreTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bombspercentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clicksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minesweeperDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.playerDataGridViewTextBoxColumn,
            this.rowsDataGridViewTextBoxColumn,
            this.columnsDataGridViewTextBoxColumn,
            this.bombspercentageDataGridViewTextBoxColumn,
            this.secondsDataGridViewTextBoxColumn,
            this.clicksDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.scoreBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // minesweeperDataSet
            // 
            this.minesweeperDataSet.DataSetName = "minesweeperDataSet";
            this.minesweeperDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scoreBindingSource
            // 
            this.scoreBindingSource.DataMember = "Score";
            this.scoreBindingSource.DataSource = this.minesweeperDataSet;
            // 
            // scoreTableAdapter
            // 
            this.scoreTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // playerDataGridViewTextBoxColumn
            // 
            this.playerDataGridViewTextBoxColumn.DataPropertyName = "player";
            this.playerDataGridViewTextBoxColumn.HeaderText = "player";
            this.playerDataGridViewTextBoxColumn.Name = "playerDataGridViewTextBoxColumn";
            // 
            // rowsDataGridViewTextBoxColumn
            // 
            this.rowsDataGridViewTextBoxColumn.DataPropertyName = "rows";
            this.rowsDataGridViewTextBoxColumn.HeaderText = "rows";
            this.rowsDataGridViewTextBoxColumn.Name = "rowsDataGridViewTextBoxColumn";
            // 
            // columnsDataGridViewTextBoxColumn
            // 
            this.columnsDataGridViewTextBoxColumn.DataPropertyName = "columns";
            this.columnsDataGridViewTextBoxColumn.HeaderText = "columns";
            this.columnsDataGridViewTextBoxColumn.Name = "columnsDataGridViewTextBoxColumn";
            // 
            // bombspercentageDataGridViewTextBoxColumn
            // 
            this.bombspercentageDataGridViewTextBoxColumn.DataPropertyName = "bombs_percentage";
            this.bombspercentageDataGridViewTextBoxColumn.HeaderText = "bombs_percentage";
            this.bombspercentageDataGridViewTextBoxColumn.Name = "bombspercentageDataGridViewTextBoxColumn";
            // 
            // secondsDataGridViewTextBoxColumn
            // 
            this.secondsDataGridViewTextBoxColumn.DataPropertyName = "seconds";
            this.secondsDataGridViewTextBoxColumn.HeaderText = "seconds";
            this.secondsDataGridViewTextBoxColumn.Name = "secondsDataGridViewTextBoxColumn";
            // 
            // clicksDataGridViewTextBoxColumn
            // 
            this.clicksDataGridViewTextBoxColumn.DataPropertyName = "clicks";
            this.clicksDataGridViewTextBoxColumn.HeaderText = "clicks";
            this.clicksDataGridViewTextBoxColumn.Name = "clicksDataGridViewTextBoxColumn";
            // 
            // ShowScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 318);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowScores";
            this.Text = "Scores";
            this.Load += new System.EventHandler(this.ShowScores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minesweeperDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private minesweeperDataSet minesweeperDataSet;
        private System.Windows.Forms.BindingSource scoreBindingSource;
        private minesweeperDataSetTableAdapters.ScoreTableAdapter scoreTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bombspercentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clicksDataGridViewTextBoxColumn;
    }
}