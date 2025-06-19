using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BalatroWikiApp.Models;

[Table("spectralcard")]
public partial class Spectralcard : Entity
{
    [Required]
    [Column("nameSpectral")]
    [StringLength(50)]
    public string NameSpectral { get; set; }

    [Required]
    [Column("effectSpectral")]
    [StringLength(200)]
    public string EffectSpectral { get; set; }

    public virtual ICollection<Boosterpack> Boosterpacks { get; set; } = new List<Boosterpack>();
}