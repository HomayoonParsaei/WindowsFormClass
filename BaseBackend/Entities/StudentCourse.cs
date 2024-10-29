using BaseBackend.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBackend.Entities
{
    public class StudentCourse : IBaseEntity, ICreateableEntity, IDeletableEntity
    {

        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
        public Course Course { get; set; }

        public int Id { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public int DeletedByUserId { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
