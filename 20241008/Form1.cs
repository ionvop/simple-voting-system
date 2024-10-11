namespace _20241008
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Hide();
            Navigator.Navigate(new Form(), new LoginForm());
        }
    }
}
