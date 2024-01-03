using System.ComponentModel.DataAnnotations;

namespace PracticeProject4.Models
{
    public class Users
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }
        public string Marks { get; set; }


    }

}