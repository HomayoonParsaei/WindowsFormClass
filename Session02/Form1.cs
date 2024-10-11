using Session02.Models;
using Session02.Utilities;


namespace Session02
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxPhoneNumber.Text;
            string phoneNumber = textBoxPhoneNumber.Text;
            string nationalCode = textBoxNationalCode.Text;
            DateOnly dateOfBirth = DateOnly.Parse(dateTimePickerDateOFBirth.Text);

            if (string.IsNullOrEmpty(firstName)
                || string.IsNullOrEmpty(lastName)
                || string.IsNullOrEmpty(phoneNumber)
                || string.IsNullOrEmpty(nationalCode))
            {
                MessageBox.Show("Please enter valid data.");
                return;
            }
            else
            {
                phoneNumber = DataCleaner.CleanPhoneNumber(phoneNumber);
            }

            // C# Trim()
            // is a string method. This method is used to removes all leading and trailing white-space characters from the current String object.
            // This method can be overloaded by passing arguments to it.


            Student student = new(
                firstName: firstName,
                lastName: lastName,
                phoneNumber: phoneNumber,
                dateOfBirth: dateOfBirth,
                nationalCode: nationalCode
                );

            textBoxFullName.Text = student.FullName;
            students.Add(student);
            MessageBox.Show("Register Successfully.");
            ClearTextBoxes();

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
