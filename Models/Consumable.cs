using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using BalatroWikiApp.Enums;

namespace BalatroWikiApp.Models
{
    [Table("consumables")]
    public partial class Consumable : Entity
    {
        [Required]
        [Column("imageConsumable")]
        [StringLength(100)]
        public string ImageConsumable { get; set; }

        [Required]
        [Column("typeConsumable")]
        public TypeConsumable TypeConsumable {  get; set; }
    }
}
