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
            ShowReport showReport = new ShowReport();
            showReport.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Upon clicking the add vehicle button, the add vehicle button will show up and allow users to add
        // a vehicle of their choice to a database
        private void addVehicleBtn_Click(object sender, EventArgs e)
        {
            AddVehicle addVehicle = new AddVehicle();
            addVehicle.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        //Upon clicking the add service button, the Add Service view will show up and allow users to add
        //a history of services to a specific vehicle
        private void addServiceBtn_Click(object sender, EventArgs e)
        {
            AddService addService = new AddService();
            
            addService.Show();
        }
    }
}