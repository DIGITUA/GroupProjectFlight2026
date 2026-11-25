namespace GroupProjectFlight2026
{
    partial class EmpRegion
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
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnEmpInRegion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.Location = new System.Drawing.Point(66, 52);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(275, 225);
            this.lstDisplay.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(491, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // btnEmpInRegion
            // 
            this.btnEmpInRegion.Location = new System.Drawing.Point(638, 75);
            this.btnEmpInRegion.Name = "btnEmpInRegion";
            this.btnEmpInRegion.Size = new System.Drawing.Size(90, 36);
            this.btnEmpInRegion.TabIndex = 2;
            this.btnEmpInRegion.Text = "Employees in region";
            this.btnEmpInRegion.UseVisualStyleBackColor = true;
            this.btnEmpInRegion.Click += new System.EventHandler(this.btnEmpInRegion_Click);
            // 
            // EmpRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEmpInRegion);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lstDisplay);
            this.Name = "EmpRegion";
            this.Text = "EmpRegion";
            this.Load += new System.EventHandler(this.EmpRegion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnEmpInRegion;
    }
}