using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02.Models
{
    public class StudentCourse
    {

        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
        public Course Course { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}
