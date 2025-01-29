namespace _2048WinFormsApp
{
    partial class UserNameForm
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
            StartGameButton = new Button();
            UserNameLabel = new Label();
            UserNameTextBox = new TextBox();
            sizeFieldLabel = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            SuspendLayout();
            // 
            // StartGameButton
            // 
            StartGameButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StartGameButton.BackColor = Color.DarkKhaki;
            StartGameButton.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartGameButton.Location = new Point(137, 260);
            StartGameButton.Margin = new Padding(2, 2, 2, 2);
            StartGameButton.Name = "StartGameButton";
            StartGameButton.Size = new Size(366, 46);
            StartGameButton.TabIndex = 0;
            StartGameButton.Text = "Вперед!";
            StartGameButton.UseVisualStyleBackColor = false;
            StartGameButton.Click += StartGameButton_Click;
            StartGameButton.MouseLeave += StartGameButton_MouseLeave;
            StartGameButton.MouseHover += StartGameButton_MouseHover;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.BackColor = SystemColors.Info;
            UserNameLabel.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserNameLabel.ForeColor = SystemColors.ActiveCaptionText;
            UserNameLabel.Location = new Point(137, 188);
            UserNameLabel.Margin = new Padding(2, 0, 2, 0);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(370, 26);
            UserNameLabel.TabIndex = 1;
            UserNameLabel.Text = "Пожалуйста, напишите Ваше имя";
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UserNameTextBox.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserNameTextBox.Location = new Point(137, 223);
            UserNameTextBox.Margin = new Padding(2, 2, 2, 2);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(366, 33);
            UserNameTextBox.TabIndex = 2;
            UserNameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // sizeFieldLabel
            // 
            sizeFieldLabel.AutoSize = true;
            sizeFieldLabel.BackColor = Color.DarkKhaki;
            sizeFieldLabel.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sizeFieldLabel.Location = new Point(137, 22);
            sizeFieldLabel.Margin = new Padding(2, 0, 2, 0);
            sizeFieldLabel.Name = "sizeFieldLabel";
            sizeFieldLabel.Size = new Size(359, 26);
            sizeFieldLabel.TabIndex = 3;
            sizeFieldLabel.Text = "Выберите размер игрового поля";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(177, 65);
            radioButton1.Margin = new Padding(2, 2, 2, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(60, 26);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "4x4";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(367, 135);
            radioButton2.Margin = new Padding(2, 2, 2, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(68, 26);
            radioButton2.TabIndex = 5;
            radioButton2.Text = "7 x 7";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton3.Location = new Point(177, 135);
            radioButton3.Margin = new Padding(2, 2, 2, 2);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(68, 26);
            radioButton3.TabIndex = 6;
            radioButton3.Text = "5 x 5";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton4.Location = new Point(367, 65);
            radioButton4.Margin = new Padding(2, 2, 2, 2);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(68, 26);
            radioButton4.TabIndex = 7;
            radioButton4.Text = "6 x 6";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton_CheckedChanged;
            // 
            // UserNameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(622, 321);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(sizeFieldLabel);
            Controls.Add(UserNameTextBox);
            Controls.Add(UserNameLabel);
            Controls.Add(StartGameButton);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UserNameForm";
            Text = "Форма для Вашего представления";
            Load += UserNameForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartGameButton;
        private Label UserNameLabel;
        public TextBox UserNameTextBox;
        private Label sizeFieldLabel;
        public RadioButton radioButton1;
        public RadioButton radioButton2;
        public RadioButton radioButton3;
        public RadioButton radioButton4;
    }
}