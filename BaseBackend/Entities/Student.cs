using BaseBackend.Enums;
namespace BaseBackend.Entities
{
    public class Student : User
    {

        public Student(string firstName)
        {
            
        }
        public Student(string firstName, string lastName, DateOnly dateOfBirth, string nationalCode, string phoneNumber, Gender gender) : base()
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            NationalCode = nationalCode;
            PhoneNumber = phoneNumber;
            Gender = gender;
            
        }
        public void ChangeFirstName (string firstName) => FirstName = firstName;

    }
}

        //  ++++++++++++++++++++++++++++++++++++++++      Snippet     ++++++++++++++++++++++++++++++++++++++++

        //  Name(or shortcut)                           Description                           Valid locations to insert snippet
        //        ctor                 Creates a constructor for the containing class.                 Inside a class.