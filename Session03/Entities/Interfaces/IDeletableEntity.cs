
namespace Session03.Entities.Interfaces
{
    public interface IDeletableEntity
    {
        public bool IsDeleted { get; set; }
        public int DeletedByUserId { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
