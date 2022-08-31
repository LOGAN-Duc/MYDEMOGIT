using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace demo1.Models
{
    public class Roles
    {
        public int ID { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }

        public ICollection<Usercs> Users{ get; set; }

    }
}
