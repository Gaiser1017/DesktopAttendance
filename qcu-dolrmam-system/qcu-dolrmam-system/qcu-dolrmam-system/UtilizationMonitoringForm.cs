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
        private List<Section> sections = new List<Section>();

        public UtilizationMonitoringForm()
        {
            InitializeComponent();
            this.Load += async (s, e) => await LoadSections();
            yrSecComboBox.SelectedIndexChanged += YrSecComboBox_SelectedIndexChanged;
        }

        // Fetch Sections from API
        private async Task LoadSections()
        {
            string sectionsUrl = "http://localhost:8000/api/sections";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(sectionsUrl);
                    response.EnsureSuccessStatusCode();

                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    sections = JsonConvert.DeserializeObject<List<Section>>(jsonResponse) ?? new List<Section>();

                    if (sections.Count > 0)
                    {
                        yrSecComboBox.DataSource = sections;
                        yrSecComboBox.DisplayMember = "Name";
                        yrSecComboBox.ValueMember = "Id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading sections: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Handle Section Selection Change
        private void YrSecComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (yrSecComboBox.SelectedItem is Section selectedSection)
            {
                roomComboBox.Text = selectedSection.Classroom?.Name ?? "N/A";
                buildingComboBox.Text = selectedSection.Classroom?.Building?.Name ?? "N/A";
            }
        }

        // Store Attendance (API Submission)
        private async Task StoreAttendance(int professorId, int sectionId, int terminalCode,
                                   string studentFullName, string studentEmail,
                                   int studentNumber, string yearSection, string remarks)
        {
            string storeUrl = "http://localhost:8000/api/store/attendance";  // Ensure backend URL

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var attendanceData = new
                    {
                        professor_id = professorId,
                        section_id = sectionId,
                        terminal_code = terminalCode,
                        student_full_name = studentFullName,
                        student_email = studentEmail,
                        student_number = studentNumber,
                        year_section = yearSection,
                        remarks = remarks
                    };

                    string jsonPayload = JsonConvert.SerializeObject(attendanceData);
                    var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                    // ✅ Set the Accept header to expect JSON response
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    // ✅ Debugging message to check the URL
                    MessageBox.Show($"Sending POST to: {storeUrl}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                if (string.IsNullOrWhiteSpace(facultyTextBox.Text))
                {
                    errorProvider1.SetError(facultyTextBox, "Textbox is empty.");
                    isValid = false;
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(facultyTextBox.Text, @"^[a-zA-Z\s]+$"))
                {
                    errorProvider1.SetError(facultyTextBox, "Only letters and spaces are allowed.");
                    isValid = false;
                }

                if (string.IsNullOrWhiteSpace(subjectTextBox.Text))
                {
                    errorProvider1.SetError(subjectTextBox, "Subject name cannot be empty.");
                    isValid = false;
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(subjectTextBox.Text, @"^[a-zA-Z0-9]+$"))
                {
                    errorProvider1.SetError(subjectTextBox, "Only letters and numbers are allowed in subject name (no spaces).");
                    isValid = false;
                }

                if (string.IsNullOrWhiteSpace(StudentNumTextBox.Text))
                {
                    errorProvider1.SetError(StudentNumTextBox, "Student number cannot be empty.");
                    isValid = false;
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(StudentNumTextBox.Text, @"^[0-9-]+$"))
                {
                    errorProvider1.SetError(StudentNumTextBox, "Only numbers and dashes are allowed in student number.");
                    isValid = false;
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(StudentNumTextBox.Text, @"^\d{2}-\d{4}$"))
                {
                    errorProvider1.SetError(StudentNumTextBox, "Student number must be in this format (e.g., 21-2205 )");
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

                if (string.IsNullOrWhiteSpace(emailTextBox.Text))
                {
                    errorProvider1.SetError(emailTextBox, "Email cannot be empty.");
                    isValid = false;
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(emailTextBox.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    errorProvider1.SetError(emailTextBox, "Please enter a valid email address.");
                    isValid = false;
                }

                if (string.IsNullOrWhiteSpace(mobileNumTextBox.Text))
                {
                    errorProvider1.SetError(mobileNumTextBox, "Mobile number cannot be empty.");
                    isValid = false;
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(mobileNumTextBox.Text, @"^\d{11}$"))
                {
                    errorProvider1.SetError(mobileNumTextBox, "Mobile number must be exactly 11 digits.");
                    isValid = false;
                }

                if (StudentNumTextBox == null)
                {
                    MessageBox.Show("❌ Error: StudentNumTextBox is NULL.", "UI Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(StudentNumTextBox.Text, out int studentNumber))
                {
                    MessageBox.Show("Invalid student number! Please enter a valid numeric value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ensure All Fields Are Filled
                if (string.IsNullOrWhiteSpace(fullNameTextBox.Text) ||
                    string.IsNullOrWhiteSpace(emailTextBox.Text) ||
                    string.IsNullOrWhiteSpace(yrSecComboBox.Text) ||
                    string.IsNullOrWhiteSpace(remarksCheckBox.Text))
                {
                    MessageBox.Show("Please fill in all required fields before submitting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Call StoreAttendance
                await StoreAttendance(
                    professorId: 1,
                    sectionId: 1,
                    terminalCode: 1,
                    studentFullName: fullNameTextBox.Text,
                    studentEmail: emailTextBox.Text,
                    studentNumber: studentNumber,
                    yearSection: yrSecComboBox.Text,
                    remarks: remarksCheckBox.Text
                );
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
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTextBox.Text = DateTime.Now.ToString("dd-MM-yy");
            dayTextBox.Text = DateTime.Now.ToString("dddd");
            timeTextBox.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        // Section Class Model
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
    }
}