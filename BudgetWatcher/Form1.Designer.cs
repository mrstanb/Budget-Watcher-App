namespace BudgetWatcher
{
    partial class Bw
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.budgetTextBox = new System.Windows.Forms.TextBox();
            this.GetReportBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.setBudgetBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.foodTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.transportTextBox = new System.Windows.Forms.TextBox();
            this.homeTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.billsTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.leasureTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ReportLabel = new System.Windows.Forms.Label();
            this.RepLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Image = global::BudgetWatcher.Properties.Resources.Loli;
            this.label1.Location = new System.Drawing.Point(387, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Budget\r\nWatcher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Humnst777 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monthly budget\r\n";
            // 
            // budgetTextBox
            // 
            this.budgetTextBox.Location = new System.Drawing.Point(10, 53);
            this.budgetTextBox.Name = "budgetTextBox";
            this.budgetTextBox.Size = new System.Drawing.Size(100, 20);
            this.budgetTextBox.TabIndex = 3;
            this.budgetTextBox.TextChanged += new System.EventHandler(this.budgetTextBox_TextChanged);
            // 
            // GetReportBtn
            // 
            this.GetReportBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GetReportBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.GetReportBtn.Location = new System.Drawing.Point(393, 142);
            this.GetReportBtn.Name = "GetReportBtn";
            this.GetReportBtn.Size = new System.Drawing.Size(75, 23);
            this.GetReportBtn.TabIndex = 10;
            this.GetReportBtn.Text = "Get Report";
            this.GetReportBtn.UseVisualStyleBackColor = false;
            this.GetReportBtn.Click += new System.EventHandler(this.GetReportBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Controls.Add(this.budgetTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.setBudgetBtn);
            this.groupBox1.Location = new System.Drawing.Point(73, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 129);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "$$$$$";
            // 
            // setBudgetBtn
            // 
            this.setBudgetBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.setBudgetBtn.Image = global::BudgetWatcher.Properties.Resources.coin;
            this.setBudgetBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setBudgetBtn.Location = new System.Drawing.Point(10, 91);
            this.setBudgetBtn.Name = "setBudgetBtn";
            this.setBudgetBtn.Size = new System.Drawing.Size(100, 23);
            this.setBudgetBtn.TabIndex = 9;
            this.setBudgetBtn.Text = "Set budget";
            this.setBudgetBtn.UseVisualStyleBackColor = false;
            this.setBudgetBtn.Click += new System.EventHandler(this.setBudgetBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::BudgetWatcher.Properties.Resources.wallet;
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Controls.Add(this.foodTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.transportTextBox);
            this.groupBox2.Controls.Add(this.homeTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.billsTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.leasureTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(28, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 283);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.addButton.Location = new System.Drawing.Point(109, 248);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // foodTextBox
            // 
            this.foodTextBox.Location = new System.Drawing.Point(84, 57);
            this.foodTextBox.Name = "foodTextBox";
            this.foodTextBox.Size = new System.Drawing.Size(100, 20);
            this.foodTextBox.TabIndex = 4;
            this.foodTextBox.TextChanged += new System.EventHandler(this.foodTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Humnst777 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Spendings";
            // 
            // transportTextBox
            // 
            this.transportTextBox.Location = new System.Drawing.Point(84, 98);
            this.transportTextBox.Name = "transportTextBox";
            this.transportTextBox.Size = new System.Drawing.Size(100, 20);
            this.transportTextBox.TabIndex = 5;
            this.transportTextBox.TextChanged += new System.EventHandler(this.transportTextBox_TextChanged);
            // 
            // homeTextBox
            // 
            this.homeTextBox.Location = new System.Drawing.Point(84, 136);
            this.homeTextBox.Name = "homeTextBox";
            this.homeTextBox.Size = new System.Drawing.Size(100, 20);
            this.homeTextBox.TabIndex = 6;
            this.homeTextBox.TextChanged += new System.EventHandler(this.homeTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Humnst777 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Leisure";
            // 
            // billsTextBox
            // 
            this.billsTextBox.Location = new System.Drawing.Point(84, 174);
            this.billsTextBox.Name = "billsTextBox";
            this.billsTextBox.Size = new System.Drawing.Size(100, 20);
            this.billsTextBox.TabIndex = 7;
            this.billsTextBox.TextChanged += new System.EventHandler(this.billsTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Humnst777 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Bills";
            // 
            // leasureTextBox
            // 
            this.leasureTextBox.Location = new System.Drawing.Point(84, 206);
            this.leasureTextBox.Name = "leasureTextBox";
            this.leasureTextBox.Size = new System.Drawing.Size(100, 20);
            this.leasureTextBox.TabIndex = 17;
            this.leasureTextBox.TextChanged += new System.EventHandler(this.leasureTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Humnst777 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "House\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Humnst777 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Food";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Humnst777 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Transport";
            // 
            // ReportLabel
            // 
            this.ReportLabel.AutoSize = true;
            this.ReportLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportLabel.Location = new System.Drawing.Point(390, 199);
            this.ReportLabel.Name = "ReportLabel";
            this.ReportLabel.Size = new System.Drawing.Size(0, 16);
            this.ReportLabel.TabIndex = 20;
            // 
            // RepLabel
            // 
            this.RepLabel.AutoSize = true;
            this.RepLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RepLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RepLabel.Location = new System.Drawing.Point(360, 190);
            this.RepLabel.Name = "RepLabel";
            this.RepLabel.Size = new System.Drawing.Size(17, 18);
            this.RepLabel.TabIndex = 21;
            this.RepLabel.Text = "$";
            this.RepLabel.Click += new System.EventHandler(this.RepLabel_Click);
            // 
            // Bw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(590, 425);
            this.Controls.Add(this.RepLabel);
            this.Controls.Add(this.ReportLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GetReportBtn);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Bw";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox budgetTextBox;
        private System.Windows.Forms.TextBox foodTextBox;
        private System.Windows.Forms.TextBox transportTextBox;
        private System.Windows.Forms.TextBox homeTextBox;
        private System.Windows.Forms.TextBox billsTextBox;
        private System.Windows.Forms.TextBox leasureTextBox;
        private System.Windows.Forms.Button setBudgetBtn;
        private System.Windows.Forms.Button GetReportBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label ReportLabel;
        private System.Windows.Forms.Label RepLabel;
    }
}

