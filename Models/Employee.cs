using System.ComponentModel.DataAnnotations;

namespace crudcore.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string Company { get; set; }

        [Required]
        public string Department { get; set; }
    }
}
