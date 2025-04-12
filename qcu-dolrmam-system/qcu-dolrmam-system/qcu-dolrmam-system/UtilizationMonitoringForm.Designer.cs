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
            errorProvider1 = new ErrorProvider(components);
            timer1 = new System.Windows.Forms.Timer(components);
            cancelButton = new Button();
            saveButton = new Button();
            label2 = new Label();
            dateTextBox = new TextBox();
            label10 = new Label();
            label12 = new Label();
            fullNameTextBox = new TextBox();
            label9 = new Label();
            emailTextBox = new TextBox();
            label11 = new Label();
            label15 = new Label();
            StudentNumTextBox = new TextBox();
            label16 = new Label();
            terminalTextBox = new TextBox();
            systemUnitCheckBox = new CheckBox();
            label7 = new Label();
            monitorCheckBox = new CheckBox();
            yrSecComboBox = new ComboBox();
            keyboardCheckBox = new CheckBox();
            buildingComboBox = new ComboBox();
            mouseCheckBox = new CheckBox();
            label8 = new Label();
            networkConnCheckBox = new CheckBox();
            label13 = new Label();
            label17 = new Label();
            roomComboBox = new ComboBox();
            remarksCheckBox = new TextBox();
            SubComboBox = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            ProfTextBox = new TextBox();
            label5 = new Label();
            SelectAllCheckBox = new CheckBox();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.None;
            cancelButton.BackColor = Color.Red;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(734, 1113);
            cancelButton.Margin = new Padding(4, 5, 4, 5);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(149, 62);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "Clear";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.None;
            saveButton.BackColor = Color.LimeGreen;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveButton.ForeColor = Color.WhiteSmoke;
            saveButton.Location = new Point(891, 1113);
            saveButton.Margin = new Padding(4, 5, 4, 5);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(149, 62);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(105, 100);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 0;
            label2.Text = "Date";
            // 
            // dateTextBox
            // 
            dateTextBox.Location = new Point(105, 139);
            dateTextBox.Margin = new Padding(4, 5, 4, 5);
            dateTextBox.Multiline = true;
            dateTextBox.Name = "dateTextBox";
            dateTextBox.Size = new Size(874, 46);
            dateTextBox.TabIndex = 1;
            dateTextBox.TextChanged += dateTextBox_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(585, 304);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(96, 25);
            label10.TabIndex = 16;
            label10.Text = "Full Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(100, 304);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(112, 25);
            label12.TabIndex = 20;
            label12.Text = "Student No.";
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Location = new Point(585, 334);
            fullNameTextBox.Margin = new Padding(4, 5, 4, 5);
            fullNameTextBox.Multiline = true;
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(394, 46);
            fullNameTextBox.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(105, 408);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(117, 25);
            label9.TabIndex = 14;
            label9.Text = "Terminal No.";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(585, 438);
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
            label11.Location = new Point(585, 408);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(56, 25);
            label11.TabIndex = 18;
            label11.Text = "Email";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(105, 709);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(111, 25);
            label15.TabIndex = 26;
            label15.Text = "Condition:";
            // 
            // StudentNumTextBox
            // 
            StudentNumTextBox.Location = new Point(105, 334);
            StudentNumTextBox.Margin = new Padding(4, 5, 4, 5);
            StudentNumTextBox.Multiline = true;
            StudentNumTextBox.Name = "StudentNumTextBox";
            StudentNumTextBox.Size = new Size(394, 46);
            StudentNumTextBox.TabIndex = 21;
            StudentNumTextBox.TextChanged += StudentNumTextBox_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(105, 744);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(599, 25);
            label16.TabIndex = 27;
            label16.Text = "Check if working properly, if not then state the reason on the remarks. ";
            // 
            // terminalTextBox
            // 
            terminalTextBox.Location = new Point(105, 438);
            terminalTextBox.Margin = new Padding(4, 5, 4, 5);
            terminalTextBox.Multiline = true;
            terminalTextBox.Name = "terminalTextBox";
            terminalTextBox.Size = new Size(394, 46);
            terminalTextBox.TabIndex = 15;
            // 
            // systemUnitCheckBox
            // 
            systemUnitCheckBox.AutoSize = true;
            systemUnitCheckBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            systemUnitCheckBox.Location = new Point(108, 837);
            systemUnitCheckBox.Margin = new Padding(4, 5, 4, 5);
            systemUnitCheckBox.Name = "systemUnitCheckBox";
            systemUnitCheckBox.Size = new Size(143, 26);
            systemUnitCheckBox.TabIndex = 28;
            systemUnitCheckBox.Text = "System Unit";
            systemUnitCheckBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(105, 613);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(82, 25);
            label7.TabIndex = 10;
            label7.Text = "Building";
            label7.Click += label7_Click;
            // 
            // monitorCheckBox
            // 
            monitorCheckBox.AutoSize = true;
            monitorCheckBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            monitorCheckBox.Location = new Point(299, 837);
            monitorCheckBox.Margin = new Padding(4, 5, 4, 5);
            monitorCheckBox.Name = "monitorCheckBox";
            monitorCheckBox.Size = new Size(102, 26);
            monitorCheckBox.TabIndex = 29;
            monitorCheckBox.Text = "Monitor";
            monitorCheckBox.UseVisualStyleBackColor = true;
            // 
            // yrSecComboBox
            // 
            yrSecComboBox.FormattingEnabled = true;
            yrSecComboBox.Location = new Point(585, 547);
            yrSecComboBox.Name = "yrSecComboBox";
            yrSecComboBox.Size = new Size(394, 33);
            yrSecComboBox.TabIndex = 26;
            // 
            // keyboardCheckBox
            // 
            keyboardCheckBox.AutoSize = true;
            keyboardCheckBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            keyboardCheckBox.Location = new Point(449, 837);
            keyboardCheckBox.Margin = new Padding(4, 5, 4, 5);
            keyboardCheckBox.Name = "keyboardCheckBox";
            keyboardCheckBox.Size = new Size(121, 26);
            keyboardCheckBox.TabIndex = 30;
            keyboardCheckBox.Text = "Keyboard";
            keyboardCheckBox.UseVisualStyleBackColor = true;
            // 
            // buildingComboBox
            // 
            buildingComboBox.FormattingEnabled = true;
            buildingComboBox.Location = new Point(105, 643);
            buildingComboBox.Margin = new Padding(4, 5, 4, 5);
            buildingComboBox.Name = "buildingComboBox";
            buildingComboBox.Size = new Size(394, 33);
            buildingComboBox.TabIndex = 11;
            // 
            // mouseCheckBox
            // 
            mouseCheckBox.AutoSize = true;
            mouseCheckBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mouseCheckBox.Location = new Point(622, 837);
            mouseCheckBox.Margin = new Padding(4, 5, 4, 5);
            mouseCheckBox.Name = "mouseCheckBox";
            mouseCheckBox.Size = new Size(94, 26);
            mouseCheckBox.TabIndex = 31;
            mouseCheckBox.Text = "Mouse";
            mouseCheckBox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(585, 613);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(98, 25);
            label8.TabIndex = 12;
            label8.Text = "Classroom";
            // 
            // networkConnCheckBox
            // 
            networkConnCheckBox.AutoSize = true;
            networkConnCheckBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            networkConnCheckBox.Location = new Point(766, 837);
            networkConnCheckBox.Margin = new Padding(4, 5, 4, 5);
            networkConnCheckBox.Name = "networkConnCheckBox";
            networkConnCheckBox.Size = new Size(216, 26);
            networkConnCheckBox.TabIndex = 32;
            networkConnCheckBox.Text = "Network Connection";
            networkConnCheckBox.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(585, 519);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(74, 25);
            label13.TabIndex = 22;
            label13.Text = "Section";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(105, 881);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(82, 25);
            label17.TabIndex = 26;
            label17.Text = "Remarks";
            // 
            // roomComboBox
            // 
            roomComboBox.FormattingEnabled = true;
            roomComboBox.Location = new Point(585, 643);
            roomComboBox.Margin = new Padding(4, 5, 4, 5);
            roomComboBox.Name = "roomComboBox";
            roomComboBox.Size = new Size(394, 33);
            roomComboBox.TabIndex = 13;
            // 
            // remarksCheckBox
            // 
            remarksCheckBox.Location = new Point(105, 911);
            remarksCheckBox.Margin = new Padding(4, 5, 4, 5);
            remarksCheckBox.Multiline = true;
            remarksCheckBox.Name = "remarksCheckBox";
            remarksCheckBox.Size = new Size(874, 155);
            remarksCheckBox.TabIndex = 27;
            remarksCheckBox.TextChanged += remarksCheckBox_TextChanged;
            // 
            // SubComboBox
            // 
            SubComboBox.FormattingEnabled = true;
            SubComboBox.Location = new Point(105, 542);
            SubComboBox.Name = "SubComboBox";
            SubComboBox.Size = new Size(394, 33);
            SubComboBox.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(105, 514);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 34;
            label3.Text = "Subject";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(105, 205);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 35;
            label4.Text = "Professor";
            label4.Click += label4_Click;
            // 
            // ProfTextBox
            // 
            ProfTextBox.Location = new Point(105, 233);
            ProfTextBox.Multiline = true;
            ProfTextBox.Name = "ProfTextBox";
            ProfTextBox.Size = new Size(394, 49);
            ProfTextBox.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(108, 789);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 37;
            label5.Text = "Select All";
            // 
            // SelectAllCheckBox
            // 
            SelectAllCheckBox.AutoSize = true;
            SelectAllCheckBox.Location = new Point(200, 792);
            SelectAllCheckBox.Name = "SelectAllCheckBox";
            SelectAllCheckBox.Size = new Size(22, 21);
            SelectAllCheckBox.TabIndex = 38;
            SelectAllCheckBox.UseVisualStyleBackColor = true;
            SelectAllCheckBox.CheckedChanged += SelectAllCheckBox_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.AutoScroll = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
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
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1074, 1228);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(200, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(724, 82);
            label1.TabIndex = 1;
            label1.Text = "Utilization Monitoring Form";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UtilizationMonitoringForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 1228);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "UtilizationMonitoringForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UtilizationMonitoringForm";
            Load += UtilizationMonitoringForm_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ErrorProvider errorProvider1;
        private Button cancelButton;
        private Button saveButton;
        private Panel panel1;
        private CheckBox SelectAllCheckBox;
        private Label label5;
        private TextBox ProfTextBox;
        private Label label4;
        private Label label3;
        private ComboBox SubComboBox;
        private TextBox remarksCheckBox;
        private ComboBox roomComboBox;
        private Label label17;
        private Label label13;
        private CheckBox networkConnCheckBox;
        private Label label8;
        private CheckBox mouseCheckBox;
        private ComboBox buildingComboBox;
        private CheckBox keyboardCheckBox;
        private ComboBox yrSecComboBox;
        private CheckBox monitorCheckBox;
        private Label label7;
        private CheckBox systemUnitCheckBox;
        private TextBox terminalTextBox;
        private Label label16;
        private TextBox StudentNumTextBox;
        private Label label15;
        private Label label11;
        private TextBox emailTextBox;
        private Label label9;
        private TextBox fullNameTextBox;
        private Label label12;
        private Label label10;
        private TextBox dateTextBox;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}