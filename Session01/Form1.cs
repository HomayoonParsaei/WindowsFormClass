using Session01.Class;
using System.Globalization;

namespace Session01
{
    public partial class FormSignin : Form
    {
        public FormSignin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            

            //Student student1 = new Student();
            //student1.FirstName = "Homayoon";
            //student1.LastName = "Parsaei";
            //student1.NationalIdNumber = "0123456789";
            //student1.DateOfBirth = new DateOnly(2000,12,24);
            //student1.PhoneNumber = "09360001111";


            string username = textBoxUserName.Text;
            string password = textBoxPassword.Text;

            /*-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-

                   condition? consequent : alternative
                   is this condition true ? yes : no

                -_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-*/

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter valid input.");
                return;
            }

     
            if (username.ToLower() == "admin" && password == "admin")
            {
                MessageBox.Show("Login successfuly.");
            }
            else
            {
                MessageBox.Show("Username or Password is invalid !");
            }


            //if (username == "admin" && password == "admin")
            //    MessageBox.Show("Login successfuly.");
            //else
            //    MessageBox.Show("Username or Password is invalid !");
        }
    }
}
