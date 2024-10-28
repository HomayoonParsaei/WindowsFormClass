using Session03.Entities.Interfaces;
#nullable disable


namespace Session02.Models
{
    public class Course : IBaseEntity, ICreateableEntity, IDeletableEntity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public int CreatedByUserId { get ; set ; }
        public DateTime CreatedAt { get ; set ; }
        public bool IsDeleted { get ; set ; }
        public int DeletedByUserId { get ; set ; }
        public DateTime DeletedAt { get ; set ; }
    }
}
 