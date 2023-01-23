using System;
using System.ComponentModel.DataAnnotations;

namespace UnitManager.Models;

public class Rank
{
    public enum PayPlan
    {
        Enlisted,
        Officer,
        Warrant,
        CivilianGS,
        CivilianWG,
    }

    [Key]
    public int Id { get; set; }

    public PayPlan Plan { get; set; }
    [Range(1,15)]
    public int PayGrade { get; set; }

    public new string ToString(string? format = null)
    {
        if (format is not null 
            && format.Equals("r")
            && Plan != PayPlan.CivilianGS
            && Plan != PayPlan.CivilianWG)
        {
            var rank = Plan switch
            {
                PayPlan.Enlisted => PayGrade switch
                {
                    1 => "AB",
                    2 => "AMN",
                    3 => "A1C",
                    4 => "SRA",
                    5 => "SSG",
                    6 => "TSG",
                    7 => "MSG",
                    8 => "SMS",
                    9 => "CMS",
                    _ => throw new ArgumentOutOfRangeException(),
                },
                PayPlan.Officer => PayGrade switch
                {
                    1 => "2LT",
                    2 => "1LT",
                    3 => "CPT",
                    4 => "MAJ",
                    5 => "LTC",
                    6 => "COL",
                    7 => "BG",
                    8 => "MG",
                    9 => "LTG",
                    10 => "GEN",
                    _ => throw new ArgumentOutOfRangeException(),
                },
                PayPlan.Warrant => $"CW{PayGrade}",
                _ => throw new ArgumentOutOfRangeException(),
            };
            return $"{rank}";
        }
        else
        {
            var prefix = Plan switch
            {
                PayPlan.Enlisted => "E",
                PayPlan.Officer => "O",
                PayPlan.Warrant => "WO",
                PayPlan.CivilianGS => "GS",
                PayPlan.CivilianWG => "WG",
                _ => throw new ArgumentOutOfRangeException(),
            };
            return $"{prefix}{PayGrade.ToString()}";
        }
    }
}