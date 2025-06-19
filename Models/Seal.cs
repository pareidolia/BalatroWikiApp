using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

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
    [StringLength(20)]
    public string EffectSeal { get; set; }

    [Required]
    [Column("typeSeal")]
    [StringLength(20)]
    public string TypeSeal { get; set; }
}