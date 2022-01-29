namespace CarRepairTracker
{
    partial class AddVehicle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.yearLabel = new System.Windows.Forms.Label();
            this.makeLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.vinLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(157, 77);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(29, 15);
            this.yearLabel.TabIndex = 0;
            this.yearLabel.Text = "Year";
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(150, 126);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(36, 15);
            this.makeLabel.TabIndex = 1;
            this.makeLabel.Text = "Make";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(145, 175);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(41, 15);
            this.modelLabel.TabIndex = 2;
            this.modelLabel.Text = "Model";
            // 
            // vinLabel
            // 
            this.vinLabel.AutoSize = true;
            this.vinLabel.Location = new System.Drawing.Point(160, 229);
            this.vinLabel.Name = "vinLabel";
            this.vinLabel.Size = new System.Drawing.Size(26, 15);
            this.vinLabel.TabIndex = 3;
            this.vinLabel.Text = "VIN";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(242, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(242, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(242, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(242, 221);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 7;
            // 
            // AddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.vinLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.makeLabel);
            this.Controls.Add(this.yearLabel);
            this.Name = "AddVehicle";
            this.Text = "Add Vehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label yearLabel;
        private Label makeLabel;
        private Label modelLabel;
        private Label vinLabel;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}