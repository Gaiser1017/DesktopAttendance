namespace qcu_dolrmam_system
{
	partial class UtilizationMonitoringForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UtilizationMonitoringForm));
            label1 = new Label();
            panel1 = new Panel();
            roomComboBox = new ComboBox();
            label8 = new Label();
            buildingComboBox = new ComboBox();
            label7 = new Label();
            facultyTextBox = new TextBox();
            label6 = new Label();
            subjectTextBox = new TextBox();
            label5 = new Label();
            timeTextBox = new TextBox();
            label4 = new Label();
            dayTextBox = new TextBox();
            label3 = new Label();
            dateTextBox = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            yrSecComboBox = new ComboBox();
            mobileNumTextBox = new TextBox();
            label14 = new Label();
            label13 = new Label();
            StudentNumTextBox = new TextBox();
            label12 = new Label();
            emailTextBox = new TextBox();
            label11 = new Label();
            fullNameTextBox = new TextBox();
            label10 = new Label();
            terminalTextBox = new TextBox();
            label9 = new Label();
            panel3 = new Panel();
            remarksCheckBox = new TextBox();
            label17 = new Label();
            networkConnCheckBox = new CheckBox();
            mouseCheckBox = new CheckBox();
            keyboardCheckBox = new CheckBox();
            monitorCheckBox = new CheckBox();
            systemUnitCheckBox = new CheckBox();
            label16 = new Label();
            label15 = new Label();
            saveButton = new Button();
            cancelButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(0, -2);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1076, 77);
            label1.TabIndex = 0;
            label1.Text = "Utilization Monitoring Form";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(roomComboBox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(buildingComboBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(facultyTextBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(subjectTextBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(timeTextBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dayTextBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dateTextBox);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(44, 80);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(994, 397);
            panel1.TabIndex = 1;
            // 
            // roomComboBox
            // 
            roomComboBox.FormattingEnabled = true;
            roomComboBox.Location = new Point(541, 238);
            roomComboBox.Margin = new Padding(4, 5, 4, 5);
            roomComboBox.Name = "roomComboBox";
            roomComboBox.Size = new Size(394, 33);
            roomComboBox.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(541, 198);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(61, 25);
            label8.TabIndex = 12;
            label8.Text = "Room";
            // 
            // buildingComboBox
            // 
            buildingComboBox.FormattingEnabled = true;
            buildingComboBox.Location = new Point(541, 148);
            buildingComboBox.Margin = new Padding(4, 5, 4, 5);
            buildingComboBox.Name = "buildingComboBox";
            buildingComboBox.Size = new Size(394, 33);
            buildingComboBox.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(541, 108);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(82, 25);
            label7.TabIndex = 10;
            label7.Text = "Building";
            // 
            // facultyTextBox
            // 
            facultyTextBox.Location = new Point(541, 47);
            facultyTextBox.Margin = new Padding(4, 5, 4, 5);
            facultyTextBox.Multiline = true;
            facultyTextBox.Name = "facultyTextBox";
            facultyTextBox.Size = new Size(394, 46);
            facultyTextBox.TabIndex = 9;
            facultyTextBox.TextChanged += facultyTextBox_TextChanged_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(541, 17);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(145, 25);
            label6.TabIndex = 8;
            label6.Text = "Name of Faculty";
            // 
            // subjectTextBox
            // 
            subjectTextBox.Location = new Point(56, 322);
            subjectTextBox.Margin = new Padding(4, 5, 4, 5);
            subjectTextBox.Multiline = true;
            subjectTextBox.Name = "subjectTextBox";
            subjectTextBox.Size = new Size(394, 46);
            subjectTextBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(56, 292);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(124, 25);
            label5.TabIndex = 6;
            label5.Text = "Subject/Code";
            // 
            // timeTextBox
            // 
            timeTextBox.Location = new Point(56, 228);
            timeTextBox.Margin = new Padding(4, 5, 4, 5);
            timeTextBox.Multiline = true;
            timeTextBox.Name = "timeTextBox";
            timeTextBox.Size = new Size(394, 46);
            timeTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(56, 198);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 25);
            label4.TabIndex = 4;
            label4.Text = "Time";
            // 
            // dayTextBox
            // 
            dayTextBox.Location = new Point(56, 138);
            dayTextBox.Margin = new Padding(4, 5, 4, 5);
            dayTextBox.Multiline = true;
            dayTextBox.Name = "dayTextBox";
            dayTextBox.Size = new Size(394, 46);
            dayTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 108);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 25);
            label3.TabIndex = 2;
            label3.Text = "Day";
            // 
            // dateTextBox
            // 
            dateTextBox.Location = new Point(56, 47);
            dateTextBox.Margin = new Padding(4, 5, 4, 5);
            dateTextBox.Multiline = true;
            dateTextBox.Name = "dateTextBox";
            dateTextBox.Size = new Size(394, 46);
            dateTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 17);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 0;
            label2.Text = "Date";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(yrSecComboBox);
            panel2.Controls.Add(mobileNumTextBox);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(StudentNumTextBox);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(emailTextBox);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(fullNameTextBox);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(terminalTextBox);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(44, 495);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(994, 320);
            panel2.TabIndex = 2;
            // 
            // yrSecComboBox
            // 
            yrSecComboBox.FormattingEnabled = true;
            yrSecComboBox.Location = new Point(541, 148);
            yrSecComboBox.Name = "yrSecComboBox";
            yrSecComboBox.Size = new Size(394, 33);
            yrSecComboBox.TabIndex = 26;
            // 
            // mobileNumTextBox
            // 
            mobileNumTextBox.Location = new Point(541, 247);
            mobileNumTextBox.Margin = new Padding(4, 5, 4, 5);
            mobileNumTextBox.Multiline = true;
            mobileNumTextBox.Name = "mobileNumTextBox";
            mobileNumTextBox.Size = new Size(394, 46);
            mobileNumTextBox.TabIndex = 25;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(541, 217);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(145, 25);
            label14.TabIndex = 24;
            label14.Text = "Mobile Number";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(541, 118);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(149, 25);
            label13.TabIndex = 22;
            label13.Text = "Year and Section";
            // 
            // StudentNumTextBox
            // 
            StudentNumTextBox.Location = new Point(541, 52);
            StudentNumTextBox.Margin = new Padding(4, 5, 4, 5);
            StudentNumTextBox.Multiline = true;
            StudentNumTextBox.Name = "StudentNumTextBox";
            StudentNumTextBox.Size = new Size(394, 46);
            StudentNumTextBox.TabIndex = 21;
            StudentNumTextBox.TextChanged += StudentNumTextBox_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(541, 22);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(112, 25);
            label12.TabIndex = 20;
            label12.Text = "Student No.";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(56, 247);
            emailTextBox.Margin = new Padding(4, 5, 4, 5);
            emailTextBox.Multiline = true;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(394, 46);
            emailTextBox.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(56, 217);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(56, 25);
            label11.TabIndex = 18;
            label11.Text = "Email";
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Location = new Point(56, 148);
            fullNameTextBox.Margin = new Padding(4, 5, 4, 5);
            fullNameTextBox.Multiline = true;
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(394, 46);
            fullNameTextBox.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(56, 118);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(88, 25);
            label10.TabIndex = 16;
            label10.Text = "Fullname";
            // 
            // terminalTextBox
            // 
            terminalTextBox.Location = new Point(56, 52);
            terminalTextBox.Margin = new Padding(4, 5, 4, 5);
            terminalTextBox.Multiline = true;
            terminalTextBox.Name = "terminalTextBox";
            terminalTextBox.Size = new Size(394, 46);
            terminalTextBox.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(56, 22);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(117, 25);
            label9.TabIndex = 14;
            label9.Text = "Terminal No.";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(remarksCheckBox);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(networkConnCheckBox);
            panel3.Controls.Add(mouseCheckBox);
            panel3.Controls.Add(keyboardCheckBox);
            panel3.Controls.Add(monitorCheckBox);
            panel3.Controls.Add(systemUnitCheckBox);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label15);
            panel3.Location = new Point(44, 835);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(994, 273);
            panel3.TabIndex = 3;
            // 
            // remarksCheckBox
            // 
            remarksCheckBox.Location = new Point(541, 125);
            remarksCheckBox.Margin = new Padding(4, 5, 4, 5);
            remarksCheckBox.Multiline = true;
            remarksCheckBox.Name = "remarksCheckBox";
            remarksCheckBox.Size = new Size(394, 82);
            remarksCheckBox.TabIndex = 27;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(541, 95);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(82, 25);
            label17.TabIndex = 26;
            label17.Text = "Remarks";
            // 
            // networkConnCheckBox
            // 
            networkConnCheckBox.AutoSize = true;
            networkConnCheckBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            networkConnCheckBox.Location = new Point(260, 137);
            networkConnCheckBox.Margin = new Padding(4, 5, 4, 5);
            networkConnCheckBox.Name = "networkConnCheckBox";
            networkConnCheckBox.Size = new Size(216, 26);
            networkConnCheckBox.TabIndex = 32;
            networkConnCheckBox.Text = "Network Connection";
            networkConnCheckBox.UseVisualStyleBackColor = true;
            // 
            // mouseCheckBox
            // 
            mouseCheckBox.AutoSize = true;
            mouseCheckBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mouseCheckBox.Location = new Point(260, 95);
            mouseCheckBox.Margin = new Padding(4, 5, 4, 5);
            mouseCheckBox.Name = "mouseCheckBox";
            mouseCheckBox.Size = new Size(94, 26);
            mouseCheckBox.TabIndex = 31;
            mouseCheckBox.Text = "Mouse";
            mouseCheckBox.UseVisualStyleBackColor = true;
            // 
            // keyboardCheckBox
            // 
            keyboardCheckBox.AutoSize = true;
            keyboardCheckBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            keyboardCheckBox.Location = new Point(61, 178);
            keyboardCheckBox.Margin = new Padding(4, 5, 4, 5);
            keyboardCheckBox.Name = "keyboardCheckBox";
            keyboardCheckBox.Size = new Size(121, 26);
            keyboardCheckBox.TabIndex = 30;
            keyboardCheckBox.Text = "Keyboard";
            keyboardCheckBox.UseVisualStyleBackColor = true;
            // 
            // monitorCheckBox
            // 
            monitorCheckBox.AutoSize = true;
            monitorCheckBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            monitorCheckBox.Location = new Point(61, 137);
            monitorCheckBox.Margin = new Padding(4, 5, 4, 5);
            monitorCheckBox.Name = "monitorCheckBox";
            monitorCheckBox.Size = new Size(102, 26);
            monitorCheckBox.TabIndex = 29;
            monitorCheckBox.Text = "Monitor";
            monitorCheckBox.UseVisualStyleBackColor = true;
            // 
            // systemUnitCheckBox
            // 
            systemUnitCheckBox.AutoSize = true;
            systemUnitCheckBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            systemUnitCheckBox.Location = new Point(61, 95);
            systemUnitCheckBox.Margin = new Padding(4, 5, 4, 5);
            systemUnitCheckBox.Name = "systemUnitCheckBox";
            systemUnitCheckBox.Size = new Size(143, 26);
            systemUnitCheckBox.TabIndex = 28;
            systemUnitCheckBox.Text = "System Unit";
            systemUnitCheckBox.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(54, 55);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(599, 25);
            label16.TabIndex = 27;
            label16.Text = "Check if working properly, if not then state the reason on the remarks. ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(54, 22);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(111, 25);
            label15.TabIndex = 26;
            label15.Text = "Condition:";
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.LimeGreen;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveButton.ForeColor = Color.WhiteSmoke;
            saveButton.Location = new Point(890, 1128);
            saveButton.Margin = new Padding(4, 5, 4, 5);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(149, 62);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.Red;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(733, 1128);
            cancelButton.Margin = new Padding(4, 5, 4, 5);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(149, 62);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // UtilizationMonitoringForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 1215);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "UtilizationMonitoringForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UtilizationMonitoringForm";
            Load += UtilizationMonitoringForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
		private Panel panel1;
		private TextBox dateTextBox;
		private Label label2;
		private Panel panel2;
		private Panel panel3;
		private ComboBox buildingComboBox;
		private Label label7;
		private TextBox facultyTextBox;
		private Label label6;
		private TextBox subjectTextBox;
		private Label label5;
		private TextBox timeTextBox;
		private Label label4;
		private TextBox dayTextBox;
		private Label label3;
		private ComboBox roomComboBox;
		private Label label8;
		private TextBox mobileNumTextBox;
		private Label label14;
		private Label label13;
		private TextBox StudentNumTextBox;
		private Label label12;
		private TextBox emailTextBox;
		private Label label11;
		private TextBox fullNameTextBox;
		private Label label10;
		private TextBox terminalTextBox;
		private Label label9;
		private Label label16;
		private Label label15;
		private CheckBox systemUnitCheckBox;
		private TextBox remarksCheckBox;
		private Label label17;
		private CheckBox networkConnCheckBox;
		private CheckBox mouseCheckBox;
		private CheckBox keyboardCheckBox;
		private CheckBox monitorCheckBox;
		private Button saveButton;
		private Button cancelButton;
		private System.Windows.Forms.Timer timer1;
        private ErrorProvider errorProvider1;
        private ComboBox yrSecComboBox;
    }
}