using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BalatroWikiApp.Models;

[Table("tarotcard")]
public partial class Tarotcard : Entity
{
    [Required]
    [Column("nameTarot")]
    [StringLength(50)]
    public string NameTarot { get; set; }

    [Required]
    [Column("effectTarot")]
    [StringLength(50)]
    public string EffectTarot { get; set; }

    public virtual ICollection<Boosterpack> Boosterpacks { get; set; } = new List<Boosterpack>();
}