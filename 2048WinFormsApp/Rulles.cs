namespace _2048WinFormsApp
{
    public partial class Rulles : Form
    {
        public Rulles()
        {
            InitializeComponent();            
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private void Rulles_DockChanged(object sender, EventArgs e)
        {
            ClientSize = new Size(1227, 391);
            this.Width = SystemInformation.PrimaryMonitorSize.Width;
            this.Height = SystemInformation.PrimaryMonitorSize.Height;
        }        
        
    }
}
