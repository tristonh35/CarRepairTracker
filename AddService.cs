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
    public partial class AddService : Form
    {
        public AddService()
        {
            InitializeComponent();
        }

        

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void clearBtn_Click(object sender, EventArgs e)
        {
            descriptionBox.Clear();
            serviceTitleBox.Clear();
        }
    }
}
