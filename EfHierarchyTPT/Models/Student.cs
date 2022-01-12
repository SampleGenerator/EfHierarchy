using System.ComponentModel.DataAnnotations.Schema;

namespace EfHierarchyTPT.Models;

[Table("Student")]
public class Student : Person
{
    public DateTime EnrollmentDate { get; set; }
}