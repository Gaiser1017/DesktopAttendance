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
            ProfTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            SubComboBox = new ComboBox();
            remarksCheckBox = new TextBox();
            roomComboBox = new ComboBox();
            label17 = new Label();
            label13 = new Label();
            networkConnCheckBox = new CheckBox();
            label8 = new Label();
            mouseCheckBox = new CheckBox();
            buildingComboBox = new ComboBox();
            keyboardCheckBox = new CheckBox();
            yrSecComboBox = new ComboBox();
            monitorCheckBox = new CheckBox();
            label7 = new Label();
            systemUnitCheckBox = new CheckBox();
            terminalTextBox = new TextBox();
            label16 = new Label();
            StudentNumTextBox = new TextBox();
            label15 = new Label();
            label11 = new Label();
            emailTextBox = new TextBox();
            label9 = new Label();
            fullNameTextBox = new TextBox();
            label12 = new Label();
            label10 = new Label();
            dateTextBox = new TextBox();
            label2 = new Label();
            saveButton = new Button();
            cancelButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            errorProvider1 = new ErrorProvider(components);
            label5 = new Label();
            SelectAllCheckBox = new CheckBox();
            panel1.SuspendLayout();
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
            panel1.Controls.Add(SelectAllCheckBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(ProfTextBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(SubComboBox);
            panel1.Controls.Add(remarksCheckBox);
            panel1.Controls.Add(roomComboBox);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(networkConnCheckBox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(mouseCheckBox);
            panel1.Controls.Add(buildingComboBox);
            panel1.Controls.Add(keyboardCheckBox);
            panel1.Controls.Add(yrSecComboBox);
            panel1.Controls.Add(monitorCheckBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(systemUnitCheckBox);
            panel1.Controls.Add(terminalTextBox);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(StudentNumTextBox);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(emailTextBox);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(fullNameTextBox);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(dateTextBox);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(44, 80);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(994, 997);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // ProfTextBox
            // 
            ProfTextBox.Location = new Point(61, 141);
            ProfTextBox.Multiline = true;
            ProfTextBox.Name = "ProfTextBox";
            ProfTextBox.Size = new Size(394, 49);
            ProfTextBox.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(61, 113);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 35;
            label4.Text = "Professor";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 422);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 34;
            label3.Text = "Subject";
            label3.Click += label3_Click;
            // 
            // SubComboBox
            // 
            SubComboBox.FormattingEnabled = true;
            SubComboBox.Location = new Point(61, 450);
            SubComboBox.Name = "SubComboBox";
            SubComboBox.Size = new Size(394, 33);
            SubComboBox.TabIndex = 33;
            // 
            // remarksCheckBox
            // 
            remarksCheckBox.Location = new Point(61, 819);
            remarksCheckBox.Margin = new Padding(4, 5, 4, 5);
            remarksCheckBox.Multiline = true;
            remarksCheckBox.Name = "remarksCheckBox";
            remarksCheckBox.Size = new Size(874, 155);
            remarksCheckBox.TabIndex = 27;
            remarksCheckBox.TextChanged += remarksCheckBox_TextChanged;
            // 
            // roomComboBox
            // 
            roomComboBox.FormattingEnabled = true;
            roomComboBox.Location = new Point(541, 551);
            roomComboBox.Margin = new Padding(4, 5, 4, 5);
            roomComboBox.Name = "roomComboBox";
            roomComboBox.Size = new Size(394, 33);
            roomComboBox.TabIndex = 13;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(61, 789);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(82, 25);
            label17.TabIndex = 26;
            label17.Text = "Remarks";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(541, 427);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(74, 25);
            label13.TabIndex = 22;
            label13.Text = "Section";
            // 
            // networkConnCheckBox
            // 
            networkConnCheckBox.AutoSize = true;
            networkConnCheckBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            networkConnCheckBox.Location = new Point(722, 745);
            networkConnCheckBox.Margin = new Padding(4, 5, 4, 5);
            networkConnCheckBox.Name = "networkConnCheckBox";
            networkConnCheckBox.Size = new Size(216, 26);
            networkConnCheckBox.TabIndex = 32;
            networkConnCheckBox.Text = "Network Connection";
            networkConnCheckBox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(541, 521);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(98, 25);
            label8.TabIndex = 12;
            label8.Text = "Classroom";
            // 
            // mouseCheckBox
            // 
            mouseCheckBox.AutoSize = true;
            mouseCheckBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mouseCheckBox.Location = new Point(578, 745);
            mouseCheckBox.Margin = new Padding(4, 5, 4, 5);
            mouseCheckBox.Name = "mouseCheckBox";
            mouseCheckBox.Size = new Size(94, 26);
            mouseCheckBox.TabIndex = 31;
            mouseCheckBox.Text = "Mouse";
            mouseCheckBox.UseVisualStyleBackColor = true;
            // 
            // buildingComboBox
            // 
            buildingComboBox.FormattingEnabled = true;
            buildingComboBox.Location = new Point(61, 551);
            buildingComboBox.Margin = new Padding(4, 5, 4, 5);
            buildingComboBox.Name = "buildingComboBox";
            buildingComboBox.Size = new Size(394, 33);
            buildingComboBox.TabIndex = 11;
            // 
            // keyboardCheckBox
            // 
            keyboardCheckBox.AutoSize = true;
            keyboardCheckBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            keyboardCheckBox.Location = new Point(405, 745);
            keyboardCheckBox.Margin = new Padding(4, 5, 4, 5);
            keyboardCheckBox.Name = "keyboardCheckBox";
            keyboardCheckBox.Size = new Size(121, 26);
            keyboardCheckBox.TabIndex = 30;
            keyboardCheckBox.Text = "Keyboard";
            keyboardCheckBox.UseVisualStyleBackColor = true;
            // 
            // yrSecComboBox
            // 
            yrSecComboBox.FormattingEnabled = true;
            yrSecComboBox.Location = new Point(541, 455);
            yrSecComboBox.Name = "yrSecComboBox";
            yrSecComboBox.Size = new Size(394, 33);
            yrSecComboBox.TabIndex = 26;
            // 
            // monitorCheckBox
            // 
            monitorCheckBox.AutoSize = true;
            monitorCheckBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            monitorCheckBox.Location = new Point(255, 745);
            monitorCheckBox.Margin = new Padding(4, 5, 4, 5);
            monitorCheckBox.Name = "monitorCheckBox";
            monitorCheckBox.Size = new Size(102, 26);
            monitorCheckBox.TabIndex = 29;
            monitorCheckBox.Text = "Monitor";
            monitorCheckBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(61, 521);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(82, 25);
            label7.TabIndex = 10;
            label7.Text = "Building";
            label7.Click += label7_Click;
            // 
            // systemUnitCheckBox
            // 
            systemUnitCheckBox.AutoSize = true;
            systemUnitCheckBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            systemUnitCheckBox.Location = new Point(64, 745);
            systemUnitCheckBox.Margin = new Padding(4, 5, 4, 5);
            systemUnitCheckBox.Name = "systemUnitCheckBox";
            systemUnitCheckBox.Size = new Size(143, 26);
            systemUnitCheckBox.TabIndex = 28;
            systemUnitCheckBox.Text = "System Unit";
            systemUnitCheckBox.UseVisualStyleBackColor = true;
            // 
            // terminalTextBox
            // 
            terminalTextBox.Location = new Point(61, 346);
            terminalTextBox.Margin = new Padding(4, 5, 4, 5);
            terminalTextBox.Multiline = true;
            terminalTextBox.Name = "terminalTextBox";
            terminalTextBox.Size = new Size(394, 46);
            terminalTextBox.TabIndex = 15;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(61, 652);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(599, 25);
            label16.TabIndex = 27;
            label16.Text = "Check if working properly, if not then state the reason on the remarks. ";
            // 
            // StudentNumTextBox
            // 
            StudentNumTextBox.Location = new Point(61, 242);
            StudentNumTextBox.Margin = new Padding(4, 5, 4, 5);
            StudentNumTextBox.Multiline = true;
            StudentNumTextBox.Name = "StudentNumTextBox";
            StudentNumTextBox.Size = new Size(394, 46);
            StudentNumTextBox.TabIndex = 21;
            StudentNumTextBox.TextChanged += StudentNumTextBox_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(61, 617);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(111, 25);
            label15.TabIndex = 26;
            label15.Text = "Condition:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(541, 316);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(56, 25);
            label11.TabIndex = 18;
            label11.Text = "Email";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(541, 346);
            emailTextBox.Margin = new Padding(4, 5, 4, 5);
            emailTextBox.Multiline = true;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(394, 46);
            emailTextBox.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(61, 316);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(117, 25);
            label9.TabIndex = 14;
            label9.Text = "Terminal No.";
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Location = new Point(541, 242);
            fullNameTextBox.Margin = new Padding(4, 5, 4, 5);
            fullNameTextBox.Multiline = true;
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(394, 46);
            fullNameTextBox.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(56, 212);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(112, 25);
            label12.TabIndex = 20;
            label12.Text = "Student No.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(541, 212);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(96, 25);
            label10.TabIndex = 16;
            label10.Text = "Full Name";
            // 
            // dateTextBox
            // 
            dateTextBox.Location = new Point(61, 47);
            dateTextBox.Margin = new Padding(4, 5, 4, 5);
            dateTextBox.Multiline = true;
            dateTextBox.Name = "dateTextBox";
            dateTextBox.Size = new Size(874, 46);
            dateTextBox.TabIndex = 1;
            dateTextBox.TextChanged += dateTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 17);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 0;
            label2.Text = "Date";
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.LimeGreen;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveButton.ForeColor = Color.WhiteSmoke;
            saveButton.Location = new Point(889, 1087);
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
            cancelButton.Location = new Point(732, 1087);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(64, 697);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 37;
            label5.Text = "Select All";
            // 
            // SelectAllCheckBox
            // 
            SelectAllCheckBox.AutoSize = true;
            SelectAllCheckBox.Location = new Point(156, 700);
            SelectAllCheckBox.Name = "SelectAllCheckBox";
            SelectAllCheckBox.Size = new Size(22, 21);
            SelectAllCheckBox.TabIndex = 38;
            SelectAllCheckBox.UseVisualStyleBackColor = true;
            SelectAllCheckBox.CheckedChanged += SelectAllCheckBox_CheckedChanged;
            // 
            // UtilizationMonitoringForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 1175);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
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
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
		private Panel panel1;
		private TextBox dateTextBox;
		private Label label2;
		private ComboBox buildingComboBox;
		private Label label7;
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
        private ComboBox roomComboBox;
        private Label label13;
        private Label label8;
        private ComboBox yrSecComboBox;
        private ComboBox SubComboBox;
        private Label label3;
        private Label label4;
        private TextBox ProfTextBox;
        private CheckBox SelectAllCheckBox;
        private Label label5;
    }
}