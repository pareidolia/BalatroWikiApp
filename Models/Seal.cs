using BalatroWikiApp.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BalatroWikiApp.Models;

[Table("seals")]
public partial class Seal : Entity
{
    [Required]
    [Column("nameSeal")]
    [StringLength(20)]
    public string NameSeal { get; set; }

    [Required]
    [Column("effectSeal")]
    [StringLength(50)]
    public string EffectSeal { get; set; }

    [Required]
    [Column("typeSeal")]
    public TypeSeal TypeSeal { get; set; }

    [Column("imageSeal")]
    [StringLength(100)]
    public string? ImageSeal { get; set; }

    [DisplayName("nameConsumable")]
    public virtual Consumable? Consumable { get; set; }

    public override string ToString()
    {
        return NameSeal;
    }
}