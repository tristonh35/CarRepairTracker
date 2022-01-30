﻿namespace CarRepairTracker
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.BtnSumbit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearLabel.Location = new System.Drawing.Point(364, 33);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(29, 15);
            this.yearLabel.TabIndex = 0;
            this.yearLabel.Text = "Year";
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(89, 33);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(36, 15);
            this.makeLabel.TabIndex = 1;
            this.makeLabel.Text = "Make";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(219, 33);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(41, 15);
            this.modelLabel.TabIndex = 2;
            this.modelLabel.Text = "Model";
            // 
            // vinLabel
            // 
            this.vinLabel.AutoSize = true;
            this.vinLabel.Location = new System.Drawing.Point(364, 135);
            this.vinLabel.Name = "vinLabel";
            this.vinLabel.Size = new System.Drawing.Size(26, 15);
            this.vinLabel.TabIndex = 3;
            this.vinLabel.Text = "VIN";
            // 
            // CBYear
            // 
            this.CBYear.FormattingEnabled = true;
            this.CBYear.Location = new System.Drawing.Point(364, 84);
            this.CBYear.Name = "CBYear";
            this.CBYear.Size = new System.Drawing.Size(121, 23);
            this.CBYear.TabIndex = 4;
            this.CBYear.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RdbHonda
            // 
            this.RdbHonda.AutoSize = true;
            this.RdbHonda.Location = new System.Drawing.Point(89, 84);
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
            this.RdbSubaru.Location = new System.Drawing.Point(89, 220);
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
            this.RdbToyota.Location = new System.Drawing.Point(89, 268);
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
            this.RdbNissan.Location = new System.Drawing.Point(89, 177);
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
            this.RdbMazda.Location = new System.Drawing.Point(89, 131);
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
            this.TxtVin.Location = new System.Drawing.Point(364, 169);
            this.TxtVin.Name = "TxtVin";
            this.TxtVin.Size = new System.Drawing.Size(254, 23);
            this.TxtVin.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(219, 84);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(219, 131);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(219, 178);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(219, 221);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 14;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // BtnSumbit
            // 
            this.BtnSumbit.Location = new System.Drawing.Point(364, 241);
            this.BtnSumbit.Name = "BtnSumbit";
            this.BtnSumbit.Size = new System.Drawing.Size(346, 72);
            this.BtnSumbit.TabIndex = 15;
            this.BtnSumbit.Text = "Submit Data";
            this.BtnSumbit.UseVisualStyleBackColor = true;
            // 
            // AddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(722, 329);
            this.Controls.Add(this.BtnSumbit);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
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
        private ComboBox CBYear;
        private RadioButton RdbHonda;
        private RadioButton RdbSubaru;
        private RadioButton RdbToyota;
        private RadioButton RdbNissan;
        private RadioButton RdbMazda;
        private TextBox TxtVin;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Button BtnSumbit;
    }
}