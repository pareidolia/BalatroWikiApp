using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BalatroWikiApp.Models;

[Table("cards")]
public partial class Card : Entity
{
    [Column("idEnhancedcard")]
    public int? IdEnhancedcard { get; set; }

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

    [DisplayName("nameEnhanced")]
    public virtual Enhancedcard? NameEnhanced { get; set; }

    [Column("imageCard")]
    [StringLength(100)]
    public string? ImageCard { get; set; }

}