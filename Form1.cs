using System;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        // Initialize custom components for the form
        private void InitializeCustomComponents()
        {
            // Set the window title
            this.Text = "Zumba Club Client-Concession System";

            // Create and add ID label and input to the form
            Label idLabel = new Label
            {
                Text = "ID:",
                Location = new System.Drawing.Point(15, 20),
                AutoSize = true
            };
            this.Controls.Add(idLabel);

            TextBox idInput = new TextBox
            {
                Name = "idInput",
                Location = new System.Drawing.Point(100, 15),
                Width = 200
            };
            this.Controls.Add(idInput);

            // Create and add Name label and input to the form
            Label nameLabel = new Label
            {
                Text = "Name:",
                Location = new System.Drawing.Point(15, 60),
                AutoSize = true
            };
            this.Controls.Add(nameLabel);

            TextBox nameInput = new TextBox
            {
                Name = "nameInput",
                Location = new System.Drawing.Point(100, 55),
                Width = 200
            };
            this.Controls.Add(nameInput);

            // Create and add Birthday label and input to the form
            Label birthdayLabel = new Label
            {
                Text = "Birthday:",
                Location = new System.Drawing.Point(15, 100),
                AutoSize = true
            };
            this.Controls.Add(birthdayLabel);

            DateTimePicker birthdayInput = new DateTimePicker
            {
                Name = "birthdayInput",
                Location = new System.Drawing.Point(100, 95),
                Format = DateTimePickerFormat.Short,
                Width = 200
            };
            this.Controls.Add(birthdayInput);

            // Create and add Concession label and input to the form
            Label concessionLabel = new Label
            {
                Text = "Concession:",
                Location = new System.Drawing.Point(15, 140),
                AutoSize = true
            };
            this.Controls.Add(concessionLabel);

            ComboBox concessionInput = new ComboBox
            {
                Name = "concessionInput",
                Location = new System.Drawing.Point(100, 135),
                Width = 200,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            concessionInput.Items.AddRange(new string[] { "None", "Student", "Senior" });
            concessionInput.SelectedIndex = 0;
            this.Controls.Add(concessionInput);

            // Create and add Submit button to the form
            Button submitButton = new Button
            {
                Text = "Submit",
                Location = new System.Drawing.Point(100, 180),
                AutoSize = true
            };
            submitButton.Click += button5_Click;
            this.Controls.Add(submitButton);

            // Create and add result label to the form
            Label resultLabel = new Label
            {
                Name = "resultLabel",
                Location = new System.Drawing.Point(15, 220),
                AutoSize = true
            };
            this.Controls.Add(resultLabel);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // This method is called when the form is loaded
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // This method is called when the text is changed in textBox4
        }

        // Handle the Submit button click event
        private void button5_Click(object sender, EventArgs e)
        {
            // Find and store the form controls for ID, Name, Birthday, and Concession input
            TextBox idInput = (TextBox)this.Controls.Find("idInput", true)[0];
            TextBox nameInput = (TextBox)this.Controls.Find("nameInput", true)[0];
            DateTimePicker birthdayInput = (DateTimePicker)this.Controls.Find("birthdayInput", true)[0];
            ComboBox concessionInput = (ComboBox)this.Controls.Find("concessionInput", true)[0];
            Label resultLabel = (Label)this.Controls.Find("resultLabel", true)[0];

            // Get the input values from the form controls
            string id = idInput.Text;
            string name = nameInput.Text;
            DateTime birthday = birthdayInput.Value;
            string concession = concessionInput.SelectedItem.ToString();

            // Update the result label with the client's information
            resultLabel.Text = $"Client Information:\nID: {id}\nName: {name}\nBirthday: {birthday.ToShortDateString()}\nConcession: {concession}";
        }
    }
}