using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BalatroWikiApp.Enums;
using Microsoft.EntityFrameworkCore;

namespace BalatroWikiApp.Models
{
    [Table("consumables")]
    public partial class Consumable : Entity
    {
        [Column("idHand")]
        public int? IdHand { get; set; }

        [Column("idSeal")]
        public int? IdSeal { get; set; }

        [Column("idEnhancedcard")]
        public int? IdEnhancedcard{ get; set; }


        [Required]
        [Column("nameConsumable")]
        [StringLength(50)]
        public string NameConsumable { get; set; }

        [Required]
        [Column("typeConsumable")]
        public TypeConsumable TypeConsumable {  get; set; }

        [Required]
        [Column("effectConsumable")]
        [StringLength(200)]
        public string EffectConsumable { get; set; }

        [Required]
        [Column("imageConsumable")]
        [StringLength(100)]
        public string? ImageConsumable { get; set; }

        [DisplayName("nameHand")]
        public virtual Hand? Hand { get; set; }

        [DisplayName("nameSeal")]
        public virtual Seal? Seal { get; set; }

        [DisplayName("nameEnhancedcard")]
        public virtual Enhancedcard? Enhancedcard { get; set; }

    }
}
