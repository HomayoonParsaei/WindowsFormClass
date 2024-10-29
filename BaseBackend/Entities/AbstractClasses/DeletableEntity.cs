namespace BaseBackend.Entities.AbstractClasses
{
    public abstract class DeletableEntity
    {
        public bool IsDeleted { get; set; }
        public int DeletedByUserId { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
