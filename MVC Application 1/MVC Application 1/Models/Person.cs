using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_Application_1.Models
{
    public class Person
    {   
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }

        [DataType(DataType.Date)]
        public DateTime LastLogin { get; set; }

    }
}
