using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesApp.Models
{
    [Table("Student",Schema ="dbp")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name ="Student ID")]

        public int StudentId { get; set; }

        [Required]
        [Column(TypeName ="varchar(150)")]
        [MaxLength(5)]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name ="Date of Birth")]
        [DisplayFormat(DataFormatString ="{0: dd-MMM-yyyy}")]
        public DateTime StudentAge { get; set; } 


        [Required]
        [Display(Name ="Student Gender")]
        public string StudentGender { get; set; }


        [Required]
        [Display(Name ="Student Email")]
        public string StudentEmail { get; set; }

        [ForeignKey("Department")]
        [Required]
        public int Departmentid { get; set; }
        

        [Display(Name ="Department")]
        [NotMapped]
        public string DepartmentName { get; set; }


        public virtual Department Department { get; set; }
    }
}
