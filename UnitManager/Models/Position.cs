using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnitManager.Models;

public class Position
{
    [Key]
    public int Id { get; set; }

    public string PAS { get; set; } = String.Empty;
    [ForeignKey("PAS")] 
    public Unit Unit { get; set; } = null!;

    public int RankId { get; set; }
    [ForeignKey("RankId")] 
    public Rank MaxGrade { get; set; } = null!;

    public string DAFSC { get; set; } = String.Empty;
    
}