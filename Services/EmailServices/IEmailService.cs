﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.DTOs.Contact;

namespace Services.EmailServices
{
    public interface IEmailService
    {
        Task SendVerificationEmailAsync(string toEmail, string verificationLink);
        Task SendBanNotificationEmailAsync(string toEmail, string reason);
        Task SendContactFormEmailAsync(ContactFormRequestDto formData);
    }
}
