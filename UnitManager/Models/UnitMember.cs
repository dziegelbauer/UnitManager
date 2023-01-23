using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnitManager.Models;

public class UnitMember
{
    [Key]
    public int Id { get; set; }

    public string FirstName { get; set; } = String.Empty;
    public string? MiddleName { get; set; } = null;
    public string LastName { get; set; } = String.Empty;

    public int RankId { get; set; }
    [ForeignKey("RankId")] 
    public Rank Grade { get; set; } = null!;

    public DateTime EnlistmentDate { get; set; }
    public DateTime IADDate { get; set; }
    public DateTime ETSDate { get; set; }
    public DateTime DOR { get; set; }
    public DateTime RRDate { get; set; }
    public DateTime TAFSMD { get; set; }
    public TimeSpan TAFMS => DateTime.Today - TAFSMD;

    public string FullName => $"{LastName}, {FirstName}";
}