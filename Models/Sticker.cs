using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BalatroWikiApp.Models;

[Table("sticker")]
public partial class Sticker : Entity
{
    [Required]
    [Column("nameSticker")]
    [StringLength(50)]
    public string NameSticker { get; set; }

    [Required]
    [Column("descriptionSticker")]
    [StringLength(200)]
    public string DescriptionSticker { get; set; }

    [Required]
    [Column("effectSticker")]
    [StringLength(50)]
    public string EffectSticker { get; set; }

    [Column("imageSticker")]
    [StringLength(100)]
    public string? ImageSticker { get; set; }
}