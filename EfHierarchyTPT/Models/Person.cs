﻿using System.ComponentModel.DataAnnotations.Schema;

namespace EfHierarchyTPT.Models;

[Table("People")]
public class Person
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
}