using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BalatroWikiApp.Models;

[Table("editions")]
public partial class Edition : Entity
{
    [Required]
    [Column("nameEdition")]
    [StringLength(50)]
    public string NameEdition { get; set; }

    [Required]
    [Column("effectEdition")]
    [StringLength(100)]
    public string EffectEdition { get; set; }

    [Column("imageEdition")]
    [StringLength(100)]
    public string? ImageEdition { get; set; }
}