namespace Session03.Entities.AbstractClasses
{
    public abstract class CreateableEntity
    {
        public int CreatedByUserId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
