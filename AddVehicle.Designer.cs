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
            this.CBYear = new System.Windows.Forms.ComboBox();
            this.RdbHonda = new System.Windows.Forms.RadioButton();
            this.RdbSubaru = new System.Windows.Forms.RadioButton();
            this.RdbToyota = new System.Windows.Forms.RadioButton();
            this.RdbNissan = new System.Windows.Forms.RadioButton();
            this.RdbMazda = new System.Windows.Forms.RadioButton();
            this.TxtVin = new System.Windows.Forms.TextBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearLabel.Location = new System.Drawing.Point(210, 33);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(29, 15);
            this.yearLabel.TabIndex = 0;
            this.yearLabel.Text = "Year";
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(27, 33);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(36, 15);
            this.makeLabel.TabIndex = 1;
            this.makeLabel.Text = "Make";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(108, 33);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(41, 15);
            this.modelLabel.TabIndex = 2;
            this.modelLabel.Text = "Model";
            // 
            // vinLabel
            // 
            this.vinLabel.AutoSize = true;
            this.vinLabel.Location = new System.Drawing.Point(213, 109);
            this.vinLabel.Name = "vinLabel";
            this.vinLabel.Size = new System.Drawing.Size(26, 15);
            this.vinLabel.TabIndex = 3;
            this.vinLabel.Text = "VIN";
            // 
            // CBYear
            // 
            this.CBYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBYear.FormattingEnabled = true;
            this.CBYear.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.CBYear.Location = new System.Drawing.Point(210, 79);
            this.CBYear.MaxDropDownItems = 22;
            this.CBYear.MaxLength = 4;
            this.CBYear.Name = "CBYear";
            this.CBYear.Size = new System.Drawing.Size(121, 23);
            this.CBYear.TabIndex = 4;
            this.CBYear.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RdbHonda
            // 
            this.RdbHonda.AutoSize = true;
            this.RdbHonda.Location = new System.Drawing.Point(27, 79);
            this.RdbHonda.Name = "RdbHonda";
            this.RdbHonda.Size = new System.Drawing.Size(61, 19);
            this.RdbHonda.TabIndex = 5;
            this.RdbHonda.TabStop = true;
            this.RdbHonda.Text = "Honda";
            this.RdbHonda.UseVisualStyleBackColor = true;
            this.RdbHonda.CheckedChanged += new System.EventHandler(this.RdbHonda_CheckedChanged);
            // 
            // RdbSubaru
            // 
            this.RdbSubaru.AutoSize = true;
            this.RdbSubaru.Location = new System.Drawing.Point(28, 154);
            this.RdbSubaru.Name = "RdbSubaru";
            this.RdbSubaru.Size = new System.Drawing.Size(62, 19);
            this.RdbSubaru.TabIndex = 6;
            this.RdbSubaru.TabStop = true;
            this.RdbSubaru.Text = "Subaru";
            this.RdbSubaru.UseVisualStyleBackColor = true;
            this.RdbSubaru.CheckedChanged += new System.EventHandler(this.RdbSubaru_CheckedChanged);
            // 
            // RdbToyota
            // 
            this.RdbToyota.AutoSize = true;
            this.RdbToyota.Location = new System.Drawing.Point(28, 179);
            this.RdbToyota.Name = "RdbToyota";
            this.RdbToyota.Size = new System.Drawing.Size(60, 19);
            this.RdbToyota.TabIndex = 7;
            this.RdbToyota.TabStop = true;
            this.RdbToyota.Text = "Toyota";
            this.RdbToyota.UseVisualStyleBackColor = true;
            this.RdbToyota.CheckedChanged += new System.EventHandler(this.RdbToyota_CheckedChanged);
            // 
            // RdbNissan
            // 
            this.RdbNissan.AutoSize = true;
            this.RdbNissan.Location = new System.Drawing.Point(28, 129);
            this.RdbNissan.Name = "RdbNissan";
            this.RdbNissan.Size = new System.Drawing.Size(60, 19);
            this.RdbNissan.TabIndex = 8;
            this.RdbNissan.TabStop = true;
            this.RdbNissan.Text = "Nissan";
            this.RdbNissan.UseVisualStyleBackColor = true;
            this.RdbNissan.CheckedChanged += new System.EventHandler(this.RdbNissan_CheckedChanged);
            // 
            // RdbMazda
            // 
            this.RdbMazda.AutoSize = true;
            this.RdbMazda.Location = new System.Drawing.Point(28, 104);
            this.RdbMazda.Name = "RdbMazda";
            this.RdbMazda.Size = new System.Drawing.Size(60, 19);
            this.RdbMazda.TabIndex = 9;
            this.RdbMazda.TabStop = true;
            this.RdbMazda.Text = "Mazda";
            this.RdbMazda.UseVisualStyleBackColor = true;
            this.RdbMazda.CheckedChanged += new System.EventHandler(this.RdbMazda_CheckedChanged);
            // 
            // TxtVin
            // 
            this.TxtVin.Location = new System.Drawing.Point(213, 134);
            this.TxtVin.Name = "TxtVin";
            this.TxtVin.Size = new System.Drawing.Size(254, 23);
            this.TxtVin.TabIndex = 10;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(213, 179);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(254, 72);
            this.BtnSubmit.TabIndex = 15;
            this.BtnSubmit.Text = "Submit Data";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(108, 79);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(108, 104);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(108, 129);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 18;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(108, 154);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 19;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // AddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(486, 263);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.TxtVin);
            this.Controls.Add(this.RdbMazda);
            this.Controls.Add(this.RdbNissan);
            this.Controls.Add(this.RdbToyota);
            this.Controls.Add(this.RdbSubaru);
            this.Controls.Add(this.RdbHonda);
            this.Controls.Add(this.CBYear);
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
        private RadioButton RdbHonda;
        private RadioButton RdbSubaru;
        private RadioButton RdbToyota;
        private RadioButton RdbNissan;
        private RadioButton RdbMazda;
        private TextBox TxtVin;
        private Button BtnSubmit;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private ComboBox CBYear;
    }
}