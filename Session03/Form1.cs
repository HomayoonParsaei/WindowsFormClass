using Session02.Enums;
using Session02.Models;
using Session02.Utilities;
using System.Windows.Forms;
using System.Xml.Linq;
#nullable disable


namespace Session02
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        string firstName;
        string lastName;
        string phoneNumber;
        string nationalCode;
        DateOnly dateOfBirth;
        Gender gender;

        public Form1()
        {
            InitializeComponent();
            SetComboBoxesDataSource();
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {


            GetData();
            if (!IsEntryDataValid()) return;
            AddStudent();

            phoneNumber = DataCleaner.CleanPhoneNumber(phoneNumber);


            // C# Trim()
            // is a string method. This method is used to removes all leading and trailing white-space characters from the current String object.
            // This method can be overloaded by passing arguments to it.



        }

        private (string, string, string, string, DateOnly, Gender) GetData()
        {
            firstName = textBoxFirstName.Text;
            lastName = textBoxPhoneNumber.Text;
            phoneNumber = textBoxPhoneNumber.Text;
            nationalCode = textBoxNationalCode.Text;
            dateOfBirth = DateOnly.Parse(dateTimePickerDateOFBirth.Text);
            gender = (Gender)Enum.Parse(typeof(Gender), comboBoxGender.Text);
            return (firstName, lastName, phoneNumber, nationalCode, dateOfBirth, gender);
        }
        private bool IsEntryDataValid()
        {
            if (string.IsNullOrEmpty(firstName) ||
                string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(phoneNumber) ||
                string.IsNullOrEmpty(nationalCode))
            {
                MessageBox.Show("Please enter valid data.");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void AddStudent()
        {
            Student student = new(
                            firstName: firstName,
                            lastName: lastName,
                            phoneNumber: phoneNumber,
                            dateOfBirth: dateOfBirth,
                            nationalCode: nationalCode,
                            gender: gender
                            );

            textBoxFullName.Text = student.FullName;
            students.Add(student);
            MessageBox.Show("Register Successfully.");
            ClearFormFields();
        }

        public void SetComboBoxesDataSource()
        {
            //   comboBoxGender.Items.Add(Gender.Male);
            comboBoxGender.DataSource = GenderFriendlyText.GetGenderFriendlyTextsList();
            comboBoxGender.SelectedIndex = -1;
        }

        private void ClearFormFields()
        {
            Action<Control.ControlCollection> controlCollection = null;

            controlCollection = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                    else if (control is ComboBox)
                    {
                        (control as ComboBox).SelectedIndex = -1; // Reset combo box selection
                    }
                    else if (control is DateTimePicker)
                    {
                        (control as DateTimePicker).Value = DateTime.Today; // Set to today's date
                    }
                    else
                    {
                        controlCollection(control.Controls); // Recursively call for child controls
                    }
                }
            };


            //comboBoxPublisher.DataSource = PublisherService.GetList;
            //comboBoxPublisher.ValueMember = "Id";
            //comboBoxPublisher.DisplayMember = "Title";


        }
    }
}




//Style 3
//  Student student = new()
//  {
//      FirstName = textBoxFirstName.Text,
//      LastName = textBoxLastName.Text,
//      PhoneNumber = textBoxPhoneNumber.Text,
//      DateOfBirth = DateOnly.Parse(dateTimePickerDateOFBirth.Text),
//      NationalCode = textBoxNationalCode.Text
//  };
//  textBoxFullName.Text = student.FullName;

//Style 2
//  Student student = new();
//  student.FirstName=textBoxFirstName.Text;
//  student.LastName=textBoxLastName.Text;
//  textBoxFullName.Text=student.FullName;
//  student.PhoneNumber=textBoxPhoneNumber.Text;
//  student.DateOfBirth= DateOnly.Parse(dateTimePickerDateOFBirth.Text);
//  student.NationalCode=textBoxNationalCode.Text;

//Style 1
//  Student student = new Student();
//  student.FirstName=textBoxFirstName.Text;
//  student.LastName=textBoxLastName.Text;
//  textBoxFullName.Text=student.FullName;
//  student.PhoneNumber=textBoxPhoneNumber.Text;
//  student.DateOfBirth= DateOnly.Parse(dateTimePickerDateOFBirth.Text);
//  student.NationalCode=textBoxNationalCode.Text;
