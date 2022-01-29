namespace CarRepairTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addVehicleBtn = new System.Windows.Forms.Button();
            this.addServiceBtn = new System.Windows.Forms.Button();
            this.currReportBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addVehicleBtn
            // 
            this.addVehicleBtn.Location = new System.Drawing.Point(245, 43);
            this.addVehicleBtn.Name = "addVehicleBtn";
            this.addVehicleBtn.Size = new System.Drawing.Size(268, 102);
            this.addVehicleBtn.TabIndex = 0;
            this.addVehicleBtn.Text = "Add Vehicle";
            this.addVehicleBtn.UseVisualStyleBackColor = true;
            // 
            // addServiceBtn
            // 
            this.addServiceBtn.Location = new System.Drawing.Point(245, 185);
            this.addServiceBtn.Name = "addServiceBtn";
            this.addServiceBtn.Size = new System.Drawing.Size(268, 96);
            this.addServiceBtn.TabIndex = 1;
            this.addServiceBtn.Text = "Add Service Report";
            this.addServiceBtn.UseVisualStyleBackColor = true;
            // 
            // currReportBtn
            // 
            this.currReportBtn.Location = new System.Drawing.Point(245, 322);
            this.currReportBtn.Name = "currReportBtn";
            this.currReportBtn.Size = new System.Drawing.Size(268, 96);
            this.currReportBtn.TabIndex = 2;
            this.currReportBtn.Text = "View Current Vehicles/Service History";
            this.currReportBtn.UseVisualStyleBackColor = true;
            this.currReportBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(605, 383);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(102, 35);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.currReportBtn);
            this.Controls.Add(this.addServiceBtn);
            this.Controls.Add(this.addVehicleBtn);
            this.Name = "Form1";
            this.Text = "Vehicle Repair Tracker";
            this.ResumeLayout(false);

        }

        #endregion

        private Button addVehicleBtn;
        private Button addServiceBtn;
        private Button currReportBtn;
        private Button exitBtn;
    }
}