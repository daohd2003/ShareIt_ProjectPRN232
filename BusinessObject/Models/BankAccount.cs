﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Models
{
    public class BankAccount
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid ProviderId { get; set; }

        [ForeignKey(nameof(ProviderId))]
        public User Provider { get; set; }

        [Required]
        [MaxLength(255)]
        public string BankName { get; set; }

        [Required]
        [MaxLength(50)]
        public string AccountNumber { get; set; }

        [MaxLength(50)]
        public string RoutingNumber { get; set; }

        public bool IsPrimary { get; set; } = false;
    }
}
