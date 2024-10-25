namespace Session03.Entities.Interfaces
{
        public interface  ICreateableEntity
        {
            public int CreatedByUserId { get; set; }
            public DateTime CreatedAt { get; set; }
        }
}
