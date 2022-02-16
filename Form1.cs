namespace CarRepairTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addVehicleBtn_Click(object sender, EventArgs e)
        {
            AddVehicle addVehicle = new AddVehicle();
            addVehicle.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void addServiceBtn_Click(object sender, EventArgs e)
        {
            AddService addService = new AddService();
            
            addService.Show();
        }
    }
}