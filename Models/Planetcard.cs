using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BalatroWikiApp.Models;

[Table("planetcard")]
public partial class Planetcard : Entity
{
    [Required]
    [Column("namePlanet")]
    [StringLength(50)]
    public string NamePlanet { get; set; }

    [Required]
    [Column("handPlanet")]
    [StringLength(50)]
    public string HandPlanet { get; set; }
}