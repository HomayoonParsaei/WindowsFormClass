using Session03.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03.Models
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
