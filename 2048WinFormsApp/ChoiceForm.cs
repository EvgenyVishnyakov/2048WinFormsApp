namespace _2048WinFormsApp
{
    public partial class ChoiceForm : Form
    {
        public ChoiceForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void GetRullesButton_MouseHover(object sender, EventArgs e)
        {
            GetRullesButton.BackColor = Color.Peru;
        }
        private void GetRullesButton_MouseLeave(object sender, EventArgs e)
        {
            GetRullesButton.BackColor = Color.BurlyWood;
        }
        private void GetRullesButton_Click(object sender, EventArgs e)
        {
            Rulles rulles = new Rulles();
            rulles.ShowDialog();
        }

        private void StartGameButton_MouseHover(object sender, EventArgs e)
        {
            StartGameButton.BackColor = Color.Peru;
        }
        private void StartGameButton_MouseLeave(object sender, EventArgs e)
        {
            StartGameButton.BackColor = Color.BurlyWood;
        }
        private void StartGameButton_Click(object sender, EventArgs e)
        {
            UserNameForm userName = new UserNameForm();
            userName.ShowDialog();
            this.Close();
        }

        private void ShowResultGamesButton_MouseHover(object sender, EventArgs e)
        {
            ShowResultGamesButton.BackColor = Color.Peru;
        }
        private void ShowResultGamesButton_MouseLeave(object sender, EventArgs e)
        {
            ShowResultGamesButton.BackColor = Color.BurlyWood;
        }
        private void ShowResultGamesButton_Click(object sender, EventArgs e)
        {
            ResultsForm results = new ResultsForm();
            results.ShowDialog();
        }

        private void ExitButton_MouseHover(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.Peru;
        }
        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.BurlyWood;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }       
    }
}
