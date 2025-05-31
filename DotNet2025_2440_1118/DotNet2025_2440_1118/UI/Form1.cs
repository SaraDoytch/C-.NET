namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ManagerBtn_Click_2(object sender, EventArgs e)
        {
            ManagerMenu managerMenu = new ManagerMenu();
            managerMenu.Show();
            this.Hide();

        }
        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            EmployeeMenu employeeMenu = new EmployeeMenu();
            employeeMenu.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
