using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BalatroWikiApp.Models;


[Table("boosterpack")]
public partial class Boosterpack : Entity
{

    [Column("idJoker")]
    public int? IdJoker { get; set; }


    [Column("idTarot")]
    public int? IdTarot { get; set; }

    [Column("idSpectral")]
    public int? IdSpectral { get; set; }

    [Column("idCard")]
    public int? IdCard { get; set; }

    [Required]
    [Column("namePack")]
    [StringLength(50)]
    public string NamePack { get; set; }

    [Column("numberPack")]
    public int NumberPack { get; set; }

    [Column("numberChoices")]
    public int NumberChoices { get; set; }

    [Column("numberProposition")]
    public int NumberProposition { get; set; }

    [Required]
    [Column("descriptionPack")]
    [StringLength(200)]
    public string DescriptionPack { get; set; }

    [Column("pricePack")]
    public int PricePack { get; set; }

    public virtual Joker? Joker { get; set; }

    public virtual Spectralcard? Spectral { get; set; }

    public virtual Tarotcard? Tarot { get; set; }

    public virtual Card? Card { get; set; }
}