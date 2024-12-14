namespace _2048WinFormsApp
{
    partial class GameForm
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
            label1 = new Label();
            scoreLabel = new Label();
            BestResultLabel = new Label();
            bestScoreLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 0;
            label1.Text = "Ваш счет :";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreLabel.Location = new Point(104, 9);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(22, 23);
            scoreLabel.TabIndex = 1;
            scoreLabel.Text = "0";
            // 
            // BestResultLabel
            // 
            BestResultLabel.AutoSize = true;
            BestResultLabel.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BestResultLabel.ForeColor = Color.Red;
            BestResultLabel.Location = new Point(6, 32);
            BestResultLabel.Name = "BestResultLabel";
            BestResultLabel.Size = new Size(133, 21);
            BestResultLabel.TabIndex = 2;
            BestResultLabel.Text = "Лучший счет :";
            // 
            // bestScoreLabel
            // 
            bestScoreLabel.AutoSize = true;
            bestScoreLabel.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bestScoreLabel.ForeColor = Color.Red;
            bestScoreLabel.Location = new Point(145, 32);
            bestScoreLabel.Name = "bestScoreLabel";
            bestScoreLabel.Size = new Size(22, 23);
            bestScoreLabel.TabIndex = 3;
            bestScoreLabel.Text = "0";
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 368);
            Controls.Add(bestScoreLabel);
            Controls.Add(BestResultLabel);
            Controls.Add(scoreLabel);
            Controls.Add(label1);
            Name = "GameForm";
            Text = "2048";
            Load += GameForm_Load;
            KeyDown += GameForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label scoreLabel;
        private Label BestResultLabel;
        private Label bestScoreLabel;
    }
}