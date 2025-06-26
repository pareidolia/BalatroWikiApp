using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BalatroWikiApp.Models
{
    [Table("hands")]
    public partial class Hand : Entity
    {
        [Required]
        [Column("nameHand")]
        [StringLength(50)]
        public string NameHand { get; set; }

        [Column("baseChips")]
        public int BaseChips { get; set; }

        [Column("baseMult")]
        public int BaseMult { get; set; }

        [Column("imageHand")]
        [StringLength(100)]
        public string? ImageHand { get; set; }

        [DisplayName("nameConsumable")]
        public virtual Consumable? Consumable { get; set; }

        public override string ToString()
        {
            return NameHand;
        }
    }
}
