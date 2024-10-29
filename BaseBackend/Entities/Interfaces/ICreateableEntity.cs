
namespace BaseBackend.Entities.Interfaces
{
    internal interface ICreateableEntity
    {
        public int CreatedByUserId { get; set; }
        public DateTime CreatedAt { get; set; }
    }

}
