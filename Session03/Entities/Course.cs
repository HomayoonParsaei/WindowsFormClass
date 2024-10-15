#nullable disable

using Session03.Models;

namespace Session02.Models
{
    public class Course :IBaseEntity
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }

    }
}
 