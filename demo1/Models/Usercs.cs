using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace demo1.Models
{
    public class Usercs
    {
        public int ID { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Username { get; set; }


   
        [Column(TypeName = "nvarchar(50)")]
        public string Passwwork { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string Fullname { get; set; }

        [Required]
        [Column(TypeName = "ntext")]
        public string Desciption { get; set; }



        public Roles Roles { get; set; }
    }
}
