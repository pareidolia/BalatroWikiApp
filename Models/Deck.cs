using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BalatroWikiApp.Models;

[Table("decks")]
public partial class Deck : Entity
{
    [Required]
    [Column("nameDeck")]
    [StringLength(50)]
    public string NameDeck { get; set; }

    [Required]
    [Column("descriptionDeck")]
    [StringLength(200)]
    public string DescriptionDeck { get; set; }
}