using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using CarRepairTracker.Migrations;

namespace CarRepairTracker
{
    public partial class AddVehicle : Form
    {
        public AddVehicle()
        {
            InitializeComponent();

        }
        /// <summary>
        /// This is a helper method to reduce the amount of code, and sets all of the model checkboxes false by default.
        /// </summary>
        public void checkBoxFalse()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }
        //If the Honda button is selected, all of the models will then appear for this specific make.
        private void RdbHonda_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Text = "Civic";
            checkBox2.Text = "Accord";
            checkBox3.Text = "Odyssey";
            checkBox4.Text = "CR-V";
            checkBoxFalse();
       
        }
        //If the Mazda button is selected, all of the models will then appear for this specific make.
        private void RdbMazda_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Text = "Mazda 3";
            checkBox2.Text = "Mx-5 Miata";
            checkBox3.Text = "Cx-5";
            checkBox4.Text = "Cx-9";
            checkBoxFalse();
        }
        //If the Nissan button is selected, all of the models will then appear for this specific make.
        private void RdbNissan_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Text = "Altima";
            checkBox2.Text = "Maxima";
            checkBox3.Text = "Rogue";
            checkBox4.Text = "Nissan Z";

            checkBoxFalse();
        }
        //If the Subaru button is selected, all of the models will then appear for this specific make.
        private void RdbSubaru_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Text = "Crosstrek";
            checkBox2.Text = "Impreza";
            checkBox3.Text = "Forester";
            checkBox4.Text = "BRZ";

            checkBoxFalse();
        }
        //If the Toyota button is selected, all of the models will then appear for this specific make.
        private void RdbToyota_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Text = "Corolla";
            checkBox2.Text = "Camry";
            checkBox3.Text = "Rav-4";
            checkBox4.Text = "Supra";

            checkBoxFalse();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox4.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }



        public void noMakeChecked()
        {

        }

        /// <summary>
        /// On the click of the submit button, validation for each field will occur before a vehicle
        /// gets sent to the database. 
        /// If there is anything that is invalid, then a corresponding error message will pop up for the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            //Set the dbContext and the Vehicle object
            VehicleContext dbContext = new VehicleContext();
            Vehicle vehicle = new Vehicle();
            int length = TxtVin.Text.Length;
            //If no vehicle make is selected, then an error message will appear for the user telling
            // them that it is required
            if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked ||
                !RdbHonda.Checked && !RdbMazda.Checked && !RdbNissan.Checked && !RdbSubaru.Checked && !RdbToyota.Checked) 
            {
                MessageBox.Show("Please select a Make and Model");
            }
            //If a year is not selected then the user will be prompted that it is required
            if (CBYear.Text == "")
            {
                MessageBox.Show("Please select a year");
            }
            //This ensures that the VIN is 17 characters long 
            if(length < 17 || length > 17)
            {
                MessageBox.Show("Vin must be 17 characters");
            }
            //If everything is correct, the vehicle will now be added to the database. 
            else
            {
                if (checkBox1.Checked == true)
                {
                    vehicle.Model = checkBox1.Text;
                }
                if (checkBox2.Checked == true)
                {
                    vehicle.Model = checkBox2.Text;
                }
                if (checkBox3.Checked == true)
                {
                    vehicle.Model = checkBox3.Text;
                }
                if (checkBox4.Checked == true)
                {
                    vehicle.Model = checkBox4.Text;
                }

                if (RdbHonda.Checked == true)
                {
                    vehicle.Make = RdbHonda.Text;
                }
                if (RdbToyota.Checked == true)
                {
                    vehicle.Make = RdbToyota.Text;
                }
                if (RdbSubaru.Checked == true)
                {
                    vehicle.Make = RdbSubaru.Text;
                }
                if (RdbMazda.Checked == true)
                {
                    vehicle.Make = RdbMazda.Text;
                }
                if (RdbNissan.Checked == true)
                {
                    vehicle.Make = RdbNissan.Text;
                }

                if (CBYear.Text == "")
                {
                    BtnSubmit.Enabled = false;

                }
                if (CBYear.Text != "")
                {
                    vehicle.Year = Convert.ToInt32(CBYear.Text);
                }
                vehicle.VIN = TxtVin.Text;
                //This initializes the addition to the database
                dbContext.Vehicles.Add(vehicle);
                //This saves changes after a vehicle is selected
                dbContext.SaveChanges();
                //A success message for a vehicle being added
                MessageBox.Show("Vehicle successfully added!");
                
            }
            
            
        }

        private void AddVehicle_Load(object sender, EventArgs e)
        {

        }
    }
}
