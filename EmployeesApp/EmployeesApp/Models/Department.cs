using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesApp.Models
{
    [Table("Department", Schema = "dbp")]
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Department ID")]

        public int DepartmentId { get; set; }

        [Required]
        [Column(TypeName = "varchar(150)")]
        [Display(Name = "Department Name")]
        public string DepartmentName { get; set; }
    }
}
