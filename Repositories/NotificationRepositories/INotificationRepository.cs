﻿using BusinessObject.Enums;
using BusinessObject.Models;
using Repositories.RepositoryBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.NotificationRepositories
{
    public interface INotificationRepository : IRepository<Notification>
    {
        Task<IEnumerable<Notification>> GetByUserIdAsync(Guid userId);
        Task<IEnumerable<Notification>> GetUnreadByUserIdAsync(Guid userId);
        Task<int> GetUnreadCountByUserIdAsync(Guid userId);
        Task MarkAllAsReadByUserIdAsync(Guid userId);
        Task<IEnumerable<Notification>> GetByTypeAndUserIdAsync(Guid userId, NotificationType type);
        Task<IEnumerable<Notification>> GetRecentNotificationsAsync(Guid userId, int count);
    }
}
