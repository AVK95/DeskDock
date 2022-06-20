namespace DeskDock_Form
{
    public partial class DeskDock : Form
    {
        public DeskDock()
        {
            InitializeComponent();
        }

        private void DeskDock_Load(object sender, EventArgs e)
        {
            int width = Screen.PrimaryScreen.WorkingArea.Width;
            int height = Screen.PrimaryScreen.WorkingArea.Height;
            
            //Todo: Add proper start location based on number of controls in the dock
            int startX = width / 3;
            int startY = 4 * height / 5;

            this.Location = new Point(startX, startY);
        }
    }
}