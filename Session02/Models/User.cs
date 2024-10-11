namespace Session02.Models
{
    public class User
    {
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public DateOnly DateOfBirth { get; protected set; }
        public string NationalCode { get; protected set; }
        public string PhoneNumber { get; protected set; }
        public short Gender { get; protected set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
