using Session02.Enums;
using Session03.Models;
namespace Session02.Models
{
    public class User : IBaseEntity
    {
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public DateOnly DateOfBirth { get; protected set; }
        public string NationalCode { get; protected set; }
        public string PhoneNumber { get; protected set; }
        public Gender Gender { get; protected set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
