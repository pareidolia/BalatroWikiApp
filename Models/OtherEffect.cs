using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BalatroWikiApp.Models
{
    [Table("otherEffects")]
    public partial class OtherEffect : Entity
    {
        [Column("money")]
        public int Money { get; set; }

        [Required]
        [Column("creation")]
        [StringLength(50)]
        public string Creation { get; set; }

        [Required]
        [Column("copy")]
        [StringLength(50)]
        public string Copy { get; set; }

        [Required]
        [Column("imageOtherEffect")]
        [StringLength(100)]
        public string imageOtherEffect { get; set; }
    }
}
