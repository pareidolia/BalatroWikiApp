using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BalatroWikiApp.Models;

[Table("vouchers")]
public partial class Voucher : Entity
{
    [Required]
    [Column("nameVoucher")]
    [StringLength(50)]
    public string NameVoucher { get; set; }

    [Required]
    [Column("descriptionVoucher")]
    [StringLength(200)]
    public string DescriptionVoucher { get; set; }

    [Column("priceVoucher")]
    public int PriceVoucher { get; set; }

    [Column("stateVoucher")]
    public bool StateVoucher { get; set; }

    [Column("imageVoucher")]
    [StringLength(100)]
    public string? ImageVoucher { get; set; }
}