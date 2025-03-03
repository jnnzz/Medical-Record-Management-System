using medical_records_management_system_server;

namespace medical_records_management_system_winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World from Frontend!");
            MessageBox.Show(Server.displayMessage());
        }
    }
}
