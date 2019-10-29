using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPPLICATION.Models
{
    //This will represent a table in the DB
    public class User
    {
        //this is the primarykey
        [Key]
        public int UserId { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required]
        public string UserName { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string UserRole { get; set; }
        public int Age{ get; set; }

    }
}
