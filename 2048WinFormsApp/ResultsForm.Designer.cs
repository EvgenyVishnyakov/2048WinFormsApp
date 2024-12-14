namespace _2048WinFormsApp
{
    partial class ResultsForm
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
            components = new System.ComponentModel.Container();
            resultsDataGridView = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Score = new DataGridViewTextBoxColumn();
            usersBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).BeginInit();
            SuspendLayout();
            // 
            // resultsDataGridView
            // 
            resultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsDataGridView.Columns.AddRange(new DataGridViewColumn[] { Name, Score });
            resultsDataGridView.Location = new Point(2, 0);
            resultsDataGridView.Name = "resultsDataGridView";
            resultsDataGridView.RowHeadersWidth = 51;
            resultsDataGridView.Size = new Size(502, 188);
            resultsDataGridView.TabIndex = 0;
            // 
            // Name
            // 
            Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Name.HeaderText = "Участник";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            // 
            // Score
            // 
            Score.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Score.HeaderText = "Очки";
            Score.MinimumWidth = 6;
            Score.Name = "Score";
            // 
            // usersBindingSource
            // 
            usersBindingSource.DataSource = typeof(Users);
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(505, 190);
            Controls.Add(resultsDataGridView);
            //Name = "ResultsForm";
            Text = "Результаты игр";
            Load += ShowResultsForm_Load;
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView resultsDataGridView;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Score;
        private BindingSource usersBindingSource;
    }
}