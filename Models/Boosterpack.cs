using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using BalatroWikiApp.Enums;

namespace BalatroWikiApp.Models;


[Table("boosterpack")]
public partial class Boosterpack : Entity
{
    [Required]
    [Column("namePack")]
    [StringLength(50)]
    public string NamePack { get; set; }

    [Required]
    [Column("typePack")]
    [StringLength(50)]
    public TypeBoosterpack Type { get; set; } // enum

    [Column("numberPack")]
    public int NumberPack { get; set; }

    [Column("numberChoices")]
    public int NumberChoices { get; set; }

    [Column("numberProposition")]
    public int NumberProposition { get; set; }

    [Required]
    [Column("descriptionPack")]
    [StringLength(200)]
    public string DescriptionPack { get; set; }

    [Column("pricePack")]
    public int PricePack { get; set; }

    [Column("imageBoosterpack")]
    [StringLength(100)]
    public string ImageBoosterpack { get; set; }

    public TypeBoosterpack TypeBoosterpack { get; set; }
}