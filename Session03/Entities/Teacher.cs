
using Session03.Entities.Interfaces;

namespace Session02.Models
{
    public class Teacher : IBaseEntity, ICreateableEntity, IDeletableEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string NationalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string CurrentDegree { get; set; }
        public string FullName
        {
            get 
            {
                return FirstName+" "+LastName;
            }
        }

        public bool IsDeleted { get ; set ; }
        public int DeletedByUserId { get ; set ; }
        public DateTime DeletedAt { get ; set ; }
        public int CreatedByUserId { get ; set ; }
        public DateTime CreatedAt { get ; set ; }
    }
}
