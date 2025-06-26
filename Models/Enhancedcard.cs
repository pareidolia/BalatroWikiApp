using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BalatroWikiApp.Models;

[Table("enhancedcards")]
public partial class Enhancedcard : Entity
{

    [Required]
    [Column("nameEnhanced")]
    [StringLength(50)]
    public string NameEnhanced { get; set; }

    [Required]
    [Column("effectEnhanced")]
    [StringLength(50)]
    public string EffectEnhanced { get; set; }

    [Required]
    [Column("typeEnhanced")]
    [StringLength(20)]
    public string TypeEnhanced { get; set; }

    [Column("imageEnhancedcard")]
    [StringLength(100)]
    public string? ImageEnhancedcard { get; set; }

    [DisplayName("nameConsumable")]
    public virtual Consumable? Consumable { get; set; }

    public virtual ICollection<Card> Cards { get; set; } = new List<Card>();

    public override string ToString()
    {
        return NameEnhanced;
    }
}