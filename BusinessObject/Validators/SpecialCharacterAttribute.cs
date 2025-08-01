﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessObject.Validators
{
    public class SpecialCharacterAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is string password)
            {
                if (!Regex.IsMatch(password, @"[!@#$%^&*(),.?""{}|<>]"))
                {
                    return new ValidationResult("Password must contain at least one special character.");
                }
            }
            return ValidationResult.Success;
        }
    }
}
