namespace _2048WinFormsApp
{
    public partial class ResultsForm : Form
    {        
        public ResultsForm()
        {
            InitializeComponent();
        }
        private void ShowResultsForm_Load(object sender, EventArgs e)
        {
            var users = UserStorage.GetUserResults();
            foreach (var user in users)
            {
                resultsDataGridView.Rows.Add(user.Name, user.Score);
            }
        }
    }
}
