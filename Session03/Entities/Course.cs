using Session03.Entities.Interfaces;
#nullable disable

<<<<<<< HEAD
=======
using Session03.Entities.Interfaces;
using Session03.Models;
>>>>>>> b9ca5ce6224ef868b26f04ae624dcd54eb89ee92

namespace Session02.Models
{
    public class Course : IBaseEntity, ICreateableEntity, IDeletableEntity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
<<<<<<< HEAD
        public int CreatedByUserId { get ; set ; }
        public DateTime CreatedAt { get ; set ; }
        public bool IsDeleted { get ; set ; }
        public int DeletedByUserId { get ; set ; }
        public DateTime DeletedAt { get ; set ; }
=======

        public int Id { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public int DeletedByUserId { get; set; }
        public DateTime DeletedAt { get; set; }
>>>>>>> b9ca5ce6224ef868b26f04ae624dcd54eb89ee92
    }
}
 