using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace qcu_dolrmam_system
{
    public partial class UtilizationMonitoringForm : Form
    {
        private List<Subject> subjects = new List<Subject>();
        private static readonly HttpClient client = new HttpClient();

        public UtilizationMonitoringForm()
        {
            InitializeComponent();
            this.Load += async (s, e) => await LoadSubjects();
            SubComboBox.SelectedIndexChanged += SubComboBox_SelectedIndexChanged;
        }


        // Fetch Subjects from API
        private async Task LoadSubjects()
        {
            string subjectsUrl = "http://localhost:8000/api/subjects";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = await client.GetAsync(subjectsUrl);

                    if (!response.IsSuccessStatusCode)
                    {
                        string errorResponse = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"❌ API Error {response.StatusCode}:\n{errorResponse}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    subjects = JsonConvert.DeserializeObject<List<Subject>>(jsonResponse) ?? new List<Subject>();

                    if (subjects.Count > 0)
                    {
                        SubComboBox.DataSource = subjects;
                        SubComboBox.DisplayMember = "Name";
                        SubComboBox.ValueMember = "Id";
                    }
                    else
                    {
                        MessageBox.Show("⚠ No subjects found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (HttpRequestException httpEx)
                {
                    MessageBox.Show($"⚠ Network Error: {httpEx.Message}", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"❌ Unexpected Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Handle Section Selection Change
        private void SubComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SubComboBox.SelectedItem is Subject selectedSubject)
            {
                ProfTextBox.Text = selectedSubject.Professor?.Name ?? "N/A";
                yrSecComboBox.Text = selectedSubject.Section?.Name ?? "N/A";
                roomComboBox.Text = selectedSubject.Section?.Classroom?.Name ?? "N/A";
                buildingComboBox.Text = selectedSubject.Section?.Classroom?.Building?.Name ?? "N/A";
            }
        }

        // Store Attendance (API Submission)
        private async Task StoreAttendance(int subjectId, string terminalNumber,
                                           string studentFullName, string studentEmail,
                                           string studentNumber, string remarks)
        {
            string storeUrl = "http://localhost:8000/api/store/attendance";  // Ensure backend URL
            {
                try
                {
                    // Convert terminalNumber to a string first
                    string terminalNumberStr = terminalNumber.ToString();

                    var attendanceData = new
                    {
                        subject_id = subjectId,
                        terminal_number = terminalNumberStr,
                        student_full_name = studentFullName,
                        student_email = studentEmail,
                        student_number = studentNumber.Trim(), // Ensure no extra spaces
                        remarks = remarks
                    };



                    string jsonPayload;
                    try
                    {
                        jsonPayload = JsonConvert.SerializeObject(attendanceData);
                    }
                    catch (JsonException jsonEx)
                    {
                        MessageBox.Show($"⚠ JSON Serialization Error: {jsonEx.Message}", "Serialization Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(storeUrl, content);
                    string responseContent = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("✅ Attendance stored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"❌ API Error {response.StatusCode}:\n{responseContent}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (HttpRequestException httpEx)
                {
                    MessageBox.Show($"⚠ Network Error: {httpEx.Message}", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"❌ Unexpected Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        // Save Attendance Button Click
        private async void saveButton_Click(object sender, EventArgs e)
        {
            {
                errorProvider1.Clear();

                bool isValid = true;

                if (string.IsNullOrWhiteSpace(StudentNumTextBox.Text))
                {
                    errorProvider1.SetError(StudentNumTextBox, "Student number cannot be empty.");
                    isValid = false;
                }

                if (string.IsNullOrWhiteSpace(fullNameTextBox.Text))
                {
                    errorProvider1.SetError(fullNameTextBox, "Textbox is empty.");
                    isValid = false;
                }
                // Check if the input contains only letters
                else if (!System.Text.RegularExpressions.Regex.IsMatch(fullNameTextBox.Text, @"^[a-zA-Z\s]+$"))
                {
                    errorProvider1.SetError(fullNameTextBox, "Only letters and spaces are allowed.");
                    isValid = false;
                }

                if (StudentNumTextBox == null)
                {
                    MessageBox.Show("❌ Error: StudentNumTextBox is NULL.", "UI Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate Student Number as a String (Ensure it's numeric)
                string studentNumber = StudentNumTextBox.Text.Trim();
                if (string.IsNullOrWhiteSpace(studentNumber) || !System.Text.RegularExpressions.Regex.IsMatch(studentNumber, @"^\d{2}-\d{4}$"))
                {
                    MessageBox.Show("Invalid student number! Please enter a valid format (e.g., xx-xxxx).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (SubComboBox.SelectedItem is Subject selectedSubject)
                {
                    string terminalNumberStr = "1"; // Convert integer to string

                    string formattedStudentNumber = studentNumber.Replace("-", "");

                    await StoreAttendance(
                        subjectId: selectedSubject.Id,
                        terminalNumber: terminalNumberStr,
                        studentFullName: fullNameTextBox.Text,
                        studentEmail: emailTextBox.Text,
                        studentNumber: formattedStudentNumber,
                        remarks: remarksCheckBox.Text
                                    );
                }
                else
                {
                    MessageBox.Show("Please select a subject.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void facultyTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UtilizationMonitoringForm_Load(object sender, EventArgs e)
        {
            terminalTextBox.Text = Environment.MachineName;
            terminalTextBox.ReadOnly = true;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTextBox.Text = DateTime.Now.ToString("dddd, dd-MM-yy hh:mm:ss tt");
        }


        // Section Class Model

        public class Subject
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public Professor? Professor { get; set; }
            public Section? Section { get; set; }
        }

        public class Professor
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
        }

        public class Section
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public Classroom? Classroom { get; set; }
        }

        public class Classroom
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public Building? Building { get; set; }
        }

        public class Building
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
        }

        private void StudentNumTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void dateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void timeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void remarksCheckBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SelectAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = SelectAllCheckBox.Checked;

            // Set all checkboxes to the same checked state
            systemUnitCheckBox.Checked = isChecked;
            monitorCheckBox.Checked = isChecked;
            keyboardCheckBox.Checked = isChecked;
            mouseCheckBox.Checked = isChecked;
            networkConnCheckBox.Checked = isChecked;
        }
    }
}