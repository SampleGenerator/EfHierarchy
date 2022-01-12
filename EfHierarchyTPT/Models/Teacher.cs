using System.ComponentModel.DataAnnotations.Schema;

namespace EfHierarchyTPT.Models;

[Table("Teacher")]
public class Teacher : Person
{
    public DateTime HireDate { get; set; }
}
