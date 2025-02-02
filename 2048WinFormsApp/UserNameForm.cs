﻿namespace _2048WinFormsApp;
public partial class UserNameForm : Form
{
    public List<RadioButton> radioButtons;
    public int MapSize { get; set; } = 4;

    public UserNameForm()
    {
        InitializeComponent();
        StartPosition = FormStartPosition.CenterScreen;
        radioButtons = new List<RadioButton>
        {
            radioButton1, radioButton2, radioButton3,radioButton4
        };
        radioButton1.Checked = true;
    }

    private void StartGameButton_MouseHover(object sender, EventArgs e)
    {
        StartGameButton.BackColor = Color.Yellow;
    }

    private void StartGameButton_MouseLeave(object sender, EventArgs e)
    {
        StartGameButton.BackColor = Color.DarkKhaki;
    }

    private void StartGameButton_Click(object sender, EventArgs e)
    {
        var name = Convert.ToString(UserNameTextBox.Text);
        if (name == string.Empty)
        {
            MessageBox.Show("Пожалуйста, обязательно введите свое имя! Попробуйте еще раз.");
        }
        else
        {
            GameForm gameForm = new GameForm();
            gameForm.user = new Users(name);
            gameForm.CalculateMapSize(MapSize);
            gameForm.ShowDialog();
            Close();
        }
    }

    private void UserNameForm_Load(object sender, EventArgs e)
    {
        ChoiceForm choiceForm = new ChoiceForm();
        choiceForm.Show();
    }

    private void radioButton_CheckedChanged(object sender, EventArgs e)
    {
        RadioButton radioButton = (RadioButton)sender;
        if (radioButton.Checked)
        {
            MapSize = Convert.ToInt32(radioButton.Text[0].ToString());
        }
    }
}
