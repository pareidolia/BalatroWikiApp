using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BalatroWikiApp.Models;

[Table("tags")]
public partial class Tag : Entity
{
    [Required]
    [Column("nameTag")]
    [StringLength(50)]
    public string NameTag { get; set; }

    [Required]
    [Column("effectTag")]
    [StringLength(200)]
    public string EffectTag { get; set; }

    [Column("imageTag")]
    [StringLength(100)]
    public string ImageTag { get; set; }
}