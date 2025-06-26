using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BalatroWikiApp.Models;

[Table("blinds")]
public partial class Blind : Entity
{
    [Required]
    [Column("nameBlind")]
    [StringLength(50)]
    public string NameBlind { get; set; }

    [Column("anteBlind")]
    public int AnteBlind { get; set; }

    [Required]
    [Column("descriptionBlind")]
    [StringLength(200)]
    public string DescriptionBlind { get; set; }

    [Required]
    [Column("effectBlind")]
    [StringLength(50)]
    public string EffectBlind { get; set; }

    [Column("rewardBlind")]
    public int RewardBlind { get; set; }

    [Column("imageBlind")]
    [StringLength(100)]
    public string? ImageBlind { get; set; }
}