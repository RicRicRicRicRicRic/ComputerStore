namespace Computer_Store
{
    public partial class HomePage : Form
    {
        private Confirm_button adminForm;
        private UserForm userForm;
        public HomePage()
        {
            InitializeComponent();
            adminForm = new Confirm_button(); 
            userForm = new UserForm();   
        }
        private void HomePage_Load_1(object sender, EventArgs e)
        {

        }


        private void Exit_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Exit Computer Store?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void User_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            userForm.ShowDialog(); 
            this.Show();
        }

        private void Admin_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminForm.ShowDialog(); 
            this.Show();
        }

        
    }
}
