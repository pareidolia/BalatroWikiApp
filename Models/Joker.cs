using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BalatroWikiApp.Models;

[Table("jokers")]
public partial class Joker : Entity
{
    [Required]
    [Column("nameJoker")]
    [StringLength(30)]
    public string NameJoker { get; set; }

    [Required]
    [Column("numberJoker")]
    public int NumberJoker { get; set; }

    [Required]
    [Column("rarityJoker")]
    [StringLength(30)]
    public string RarityJoker { get; set; }

    [Column("priceJoker")]
    public int PriceJoker { get; set; }

    [Required]
    [Column("typeJoker")]
    [StringLength(20)]
    public string TypeJoker { get; set; }

    [Required]
    [Column("descriptionJoker")]
    [StringLength(200)]
    public string DescriptionJoker { get; set; }

    [Column("sizeJoker")]
    [Precision(3, 2)]
    public decimal? SizeJoker { get; set; }

    [Column("hasFaceJoker")]
    public bool HasFaceJoker { get; set; }

    [Column("imageJoker")]
    [StringLength(100)]
    public string? ImageJoker { get; set; }
}