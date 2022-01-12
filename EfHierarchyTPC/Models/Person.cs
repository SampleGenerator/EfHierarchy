using System.ComponentModel.DataAnnotations.Schema;

namespace Models.EfHierarchyTPC;

public abstract class Person
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
}
