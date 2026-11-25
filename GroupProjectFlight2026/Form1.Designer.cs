namespace GroupProjectFlight2026
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataSet1 = new GroupProjectFlight2026.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddCust = new System.Windows.Forms.Button();
            this.btnAddZip = new System.Windows.Forms.Button();
            this.btnAddAirplane = new System.Windows.Forms.Button();
            this.btnAddAirport = new System.Windows.Forms.Button();
            this.btnEmpRegion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 0;
            this.button1.Text = "exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 6);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 26);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show all employees";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(216, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 26);
            this.button3.TabIndex = 2;
            this.button3.Text = "list jobs";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // btnAddCust
            // 
            this.btnAddCust.Location = new System.Drawing.Point(278, 6);
            this.btnAddCust.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(109, 26);
            this.btnAddCust.TabIndex = 3;
            this.btnAddCust.Text = "Update Customer";
            this.btnAddCust.UseVisualStyleBackColor = true;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // btnAddZip
            // 
            this.btnAddZip.Location = new System.Drawing.Point(405, 6);
            this.btnAddZip.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddZip.Name = "btnAddZip";
            this.btnAddZip.Size = new System.Drawing.Size(104, 26);
            this.btnAddZip.TabIndex = 4;
            this.btnAddZip.Text = "Update Zip Code";
            this.btnAddZip.UseVisualStyleBackColor = true;
            this.btnAddZip.Click += new System.EventHandler(this.btnAddZip_Click);
            // 
            // btnAddAirplane
            // 
            this.btnAddAirplane.Location = new System.Drawing.Point(278, 72);
            this.btnAddAirplane.Name = "btnAddAirplane";
            this.btnAddAirplane.Size = new System.Drawing.Size(137, 23);
            this.btnAddAirplane.TabIndex = 5;
            this.btnAddAirplane.Text = "Add/Update Airplane";
            this.btnAddAirplane.UseVisualStyleBackColor = true;
            this.btnAddAirplane.Click += new System.EventHandler(this.btnAddAirplane_Click);
            // 
            // btnAddAirport
            // 
            this.btnAddAirport.AutoSize = true;
            this.btnAddAirport.Location = new System.Drawing.Point(431, 72);
            this.btnAddAirport.Name = "btnAddAirport";
            this.btnAddAirport.Size = new System.Drawing.Size(146, 23);
            this.btnAddAirport.TabIndex = 6;
            this.btnAddAirport.Text = "Add/Update Airport";
            this.btnAddAirport.UseVisualStyleBackColor = true;
            this.btnAddAirport.Click += new System.EventHandler(this.btnAddAirport_Click);
            // 
            // btnEmpRegion
            // 
            this.btnEmpRegion.Location = new System.Drawing.Point(97, 64);
            this.btnEmpRegion.Name = "btnEmpRegion";
            this.btnEmpRegion.Size = new System.Drawing.Size(105, 39);
            this.btnEmpRegion.TabIndex = 7;
            this.btnEmpRegion.Text = "Display Employees in Region";
            this.btnEmpRegion.UseVisualStyleBackColor = true;
            this.btnEmpRegion.Click += new System.EventHandler(this.btnEmpRegion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 365);
            this.Controls.Add(this.btnEmpRegion);
            this.Controls.Add(this.btnAddAirport);
            this.Controls.Add(this.btnAddAirplane);
            this.Controls.Add(this.btnAddZip);
            this.Controls.Add(this.btnAddCust);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.Button btnAddZip;
        private System.Windows.Forms.Button btnAddAirplane;
        private System.Windows.Forms.Button btnAddAirport;
        private System.Windows.Forms.Button btnEmpRegion;
    }
}

