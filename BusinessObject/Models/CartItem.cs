﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Models
{
    /// <summary>
    /// Mục sản phẩm trong giỏ hàng
    /// </summary>
    public class CartItem
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid CartId { get; set; }

        [ForeignKey(nameof(CartId))]
        public Cart Cart { get; set; }

        [Required]
        public Guid ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
        public int Quantity { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "RentalDays must be at least 1.")]
        public int RentalDays { get; set; }

        [Required(ErrorMessage = "Start Date is required for a cart item.")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End Date is required for a cart item.")]
        public DateTime EndDate { get; set; }

    }
}
