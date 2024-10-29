using BaseBackend.Entities.Interfaces;


namespace BaseBackend.Entities
{
    public class Category : IBaseEntity, ICreateableEntity, IDeletableEntity
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public int DeletedByUserId { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
