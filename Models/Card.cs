using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BalatroWikiApp.Models;

[Table("cards")]
public partial class Card : Entity
{
    [Required]
    [Column("nameCard")]
    [StringLength(50)]
    public string NameCard { get; set; }

    [Required]
    [Column("familyCard")]
    [StringLength(50)]
    public string FamilyCard { get; set; }

    [Column("isEnhanced")]
    public bool IsEnhanced { get; set; }

    public virtual ICollection<Boosterpack> Boosterpacks { get; set; } = new List<Boosterpack>();
}