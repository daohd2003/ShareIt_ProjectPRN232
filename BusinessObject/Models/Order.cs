﻿using BusinessObject.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace BusinessObject.Models
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public User Customer { get; set; }

        [Required]
        public Guid ProviderId { get; set; }
        [ForeignKey(nameof(ProviderId))]
        public User Provider { get; set; }

        [Required]
        public OrderStatus Status { get; set; }

        [Required, Column(TypeName = "decimal(10,2)")]
        public decimal TotalAmount { get; set; }

        public DateTime? RentalStart { get; set; }
        public DateTime? RentalEnd { get; set; }

        public DateTime? DeliveredDate { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();
        [JsonIgnore]
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

        public string? CustomerFullName { get; set; }
        public string? CustomerEmail { get; set; } 
        public string? CustomerPhoneNumber { get; set; }
        public string? DeliveryAddress { get; set; }

        public bool HasAgreedToPolicies { get; set; } = false;
    }
}
