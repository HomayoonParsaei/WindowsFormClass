using Session03.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03.Models
{
    public class Category : IBaseEntity
    {
        public string Name { get; set; }
    }
}
