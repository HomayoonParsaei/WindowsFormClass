
namespace Session03.Entities.Interfaces
{
    internal interface ICreateableEntity
    {
        public int CreatedByUserId { get; set; }
        public DateTime CreatedAt { get; set; }
    }

}
