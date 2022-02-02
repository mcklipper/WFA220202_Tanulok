using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Students.Models
{
    public class Student
    {
        [Key]
        [StringLength(11)]
        [Column(TypeName = "char")]
        public string OM { get; set; }

        [StringLength(128)]
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        [StringLength(5)]
        public string Class { get; set; }

        [StringLength(4)]
        [Column(TypeName = "char")]
        public string Zip { get; set; }

        [StringLength(128)]
        public string Settlement { get; set; }

        [StringLength(128)]
        public string Address { get; set; }

    }
}
