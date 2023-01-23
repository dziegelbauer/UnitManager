using System;
using System.ComponentModel.DataAnnotations;

namespace UnitManager.Models;

public class Unit
{
    [Key]
    public string PAS { get; set; } = String.Empty;
    public string NameLong { get; set; } = String.Empty;
    public string NameShort { get; set; } = String.Empty;
}