namespace CarRepairTracker
{
    partial class AddService
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
            this.addServiceBtn = new System.Windows.Forms.Button();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.vehicleBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serviceTitle = new System.Windows.Forms.Label();
            this.serviceTitleBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addServiceBtn
            // 
            this.addServiceBtn.Location = new System.Drawing.Point(277, 355);
            this.addServiceBtn.Name = "addServiceBtn";
            this.addServiceBtn.Size = new System.Drawing.Size(284, 74);
            this.addServiceBtn.TabIndex = 0;
            this.addServiceBtn.Text = "Add Service To Vehicle";
            this.addServiceBtn.UseVisualStyleBackColor = true;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(277, 226);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(284, 96);
            this.descriptionBox.TabIndex = 1;
            this.descriptionBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(288, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Service Description";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(22, 367);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(147, 62);
            this.clearBtn.TabIndex = 3;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(607, 367);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(148, 62);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // vehicleBox
            // 
            this.vehicleBox.FormattingEnabled = true;
            this.vehicleBox.Location = new System.Drawing.Point(288, 69);
            this.vehicleBox.Name = "vehicleBox";
            this.vehicleBox.Size = new System.Drawing.Size(198, 23);
            this.vehicleBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(288, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select the vehicle";
            // 
            // serviceTitle
            // 
            this.serviceTitle.AutoSize = true;
            this.serviceTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.serviceTitle.Location = new System.Drawing.Point(288, 113);
            this.serviceTitle.Name = "serviceTitle";
            this.serviceTitle.Size = new System.Drawing.Size(89, 20);
            this.serviceTitle.TabIndex = 7;
            this.serviceTitle.Text = "Service Title";
            // 
            // serviceTitleBox
            // 
            this.serviceTitleBox.Location = new System.Drawing.Point(288, 152);
            this.serviceTitleBox.Name = "serviceTitleBox";
            this.serviceTitleBox.Size = new System.Drawing.Size(198, 23);
            this.serviceTitleBox.TabIndex = 8;
            // 
            // AddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.serviceTitleBox);
            this.Controls.Add(this.serviceTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vehicleBox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.addServiceBtn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AddService";
            this.Text = "Add Service";
            this.Load += new System.EventHandler(this.AddService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addServiceBtn;
        private RichTextBox descriptionBox;
        private Label label1;
        private Button clearBtn;
        private Button exitBtn;
        private ComboBox vehicleBox;
        private Label label2;
        private Label serviceTitle;
        private TextBox serviceTitleBox;
    }
}