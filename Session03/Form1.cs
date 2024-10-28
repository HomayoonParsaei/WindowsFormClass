using Session02.Enums;
using Session02.Models;
using Session02.Utilities;
#nullable disable


namespace Session02
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
            SetComboBoxesDataSource();
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxPhoneNumber.Text;
            string phoneNumber = textBoxPhoneNumber.Text;
            string nationalCode = textBoxNationalCode.Text;
            DateOnly dateOfBirth = DateOnly.Parse(dateTimePickerDateOFBirth.Text);

            Enum.TryParse(comboBoxGender.Text, out Gender gender);

            IsEnterdDataValid(firstName, lastName, ref phoneNumber, nationalCode);

            // C# Trim()
            // is a string method. This method is used to removes all leading and trailing white-space characters from the current String object.
            // This method can be overloaded by passing arguments to it.


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
            ClearTextBoxes();

        }

        private static bool IsEnterdDataValid(string firstName, string lastName, ref string phoneNumber, string nationalCode)
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

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }


        public void SetComboBoxesDataSource()
        {
            //   comboBoxGender.Items.Add(Gender.Male);
            comboBoxGender.DataSource = GenderFriendlyText.GetGenderFriendlyTextsList();
            comboBoxGender.SelectedIndex = -1;
        }
       
            //comboBoxPublisher.DataSource = PublisherService.GetList;
            //comboBoxPublisher.ValueMember = "Id";
            //comboBoxPublisher.DisplayMember = "Title";


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
