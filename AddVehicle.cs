using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRepairTracker
{
    public partial class AddVehicle : Form
    {
        public AddVehicle()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CBMake_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RdbHonda_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Text = "Civic";
            checkBox2.Text = "Accord";
            checkBox3.Text = "S-2000";
            checkBox4.Text = "CR-V";

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void RdbMazda_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Text = "Mazda 3";
            checkBox2.Text = "Mx-5 Miata";
            checkBox3.Text = "Cx-5";
            checkBox4.Text = "Rx-8";

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void RdbNissan_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Text = "Altima";
            checkBox2.Text = "Maxima";
            checkBox3.Text = "Rogue";
            checkBox4.Text = "Nissan Z";

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void RdbSubaru_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Text = "Crosstrek";
            checkBox2.Text = "Impreza";
            checkBox3.Text = "Forester";
            checkBox4.Text = "BRZ";

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void RdbToyota_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Text = "Corolla";
            checkBox2.Text = "Camry";
            checkBox3.Text = "Rav-4";
            checkBox4.Text = "Supra";

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }
    }
}
