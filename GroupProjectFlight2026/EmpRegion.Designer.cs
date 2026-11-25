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
            this.label1 = new System.Windows.Forms.Label();
            this.btnState = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(377, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Display all employees in selected region";
            // 
            // btnState
            // 
            this.btnState.Location = new System.Drawing.Point(625, 180);
            this.btnState.Name = "btnState";
            this.btnState.Size = new System.Drawing.Size(92, 40);
            this.btnState.TabIndex = 4;
            this.btnState.Text = "Employees State";
            this.btnState.UseVisualStyleBackColor = true;
            this.btnState.Click += new System.EventHandler(this.btnState_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(502, 191);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(377, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 45);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter an employee ID to display the state they live in";
            // 
            // EmpRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 356);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnState);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEmpInRegion);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lstDisplay);
            this.Name = "EmpRegion";
            this.Text = "EmpRegion";
            this.Load += new System.EventHandler(this.EmpRegion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnEmpInRegion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnState;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
    }
}