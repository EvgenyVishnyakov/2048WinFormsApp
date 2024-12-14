namespace _2048WinFormsApp
{
    partial class ChoiceForm
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
            GetRullesButton = new Button();
            StartGameButton = new Button();
            ExitButton = new Button();
            label1 = new Label();
            ShowResultGamesButton = new Button();
            SuspendLayout();
            // 
            // GetRullesButton
            // 
            GetRullesButton.BackColor = Color.BurlyWood;
            GetRullesButton.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GetRullesButton.ForeColor = SystemColors.ActiveCaptionText;
            GetRullesButton.Location = new Point(179, 81);
            GetRullesButton.Name = "GetRullesButton";
            GetRullesButton.Size = new Size(425, 69);
            GetRullesButton.TabIndex = 0;
            GetRullesButton.Text = "Правила игры";
            GetRullesButton.UseVisualStyleBackColor = false;
            GetRullesButton.Click += GetRullesButton_Click;
            GetRullesButton.MouseLeave += GetRullesButton_MouseLeave;
            GetRullesButton.MouseHover += GetRullesButton_MouseHover;
            // 
            // StartGameButton
            // 
            StartGameButton.BackColor = Color.BurlyWood;
            StartGameButton.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartGameButton.ForeColor = SystemColors.ActiveCaptionText;
            StartGameButton.Location = new Point(179, 166);
            StartGameButton.Name = "StartGameButton";
            StartGameButton.Size = new Size(425, 72);
            StartGameButton.TabIndex = 1;
            StartGameButton.Text = "Запуск игры";
            StartGameButton.UseVisualStyleBackColor = false;
            StartGameButton.Click += StartGameButton_Click;
            StartGameButton.MouseLeave += StartGameButton_MouseLeave;
            StartGameButton.MouseHover += StartGameButton_MouseHover;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.BurlyWood;
            ExitButton.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.ForeColor = SystemColors.ActiveCaptionText;
            ExitButton.Location = new Point(179, 349);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(425, 75);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            ExitButton.MouseLeave += ExitButton_MouseLeave;
            ExitButton.MouseHover += ExitButton_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(159, 32);
            label1.Name = "label1";
            label1.Size = new Size(493, 27);
            label1.TabIndex = 3;
            label1.Text = "Мы рады приветствовать Вас на игре 2048!";
            // 
            // ShowResultGamesButton
            // 
            ShowResultGamesButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ShowResultGamesButton.BackColor = Color.BurlyWood;
            ShowResultGamesButton.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowResultGamesButton.Location = new Point(179, 255);
            ShowResultGamesButton.Name = "ShowResultGamesButton";
            ShowResultGamesButton.Size = new Size(422, 74);
            ShowResultGamesButton.TabIndex = 4;
            ShowResultGamesButton.Text = "Результаты игр";
            ShowResultGamesButton.UseVisualStyleBackColor = false;
            ShowResultGamesButton.Click += ShowResultGamesButton_Click;
            ShowResultGamesButton.MouseLeave += ShowResultGamesButton_MouseLeave;
            ShowResultGamesButton.MouseHover += ShowResultGamesButton_MouseHover;
            // 
            // ChoiceForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(ShowResultGamesButton);
            Controls.Add(label1);
            Controls.Add(ExitButton);
            Controls.Add(StartGameButton);
            Controls.Add(GetRullesButton);
            Name = "ChoiceForm";
            Text = "Меню";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GetRullesButton;
        private Button StartGameButton;
        private Button ExitButton;
        private Label label1;
        private Button ShowResultGamesButton;
    }
}