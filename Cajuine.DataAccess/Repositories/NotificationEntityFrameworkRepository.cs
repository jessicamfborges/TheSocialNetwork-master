using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cajuine.DataAccess.Contexts;
using Cajuine.DomainModel.Entities;
using Cajuine.DomainModel.Interfaces.Repositories;

namespace Cajuine.DataAccess.Repositories
{
    public class NotificationEntityFrameworkRepository : INotificationRepository
    {
        public void Create(Notification notification)
        {
            var notificationContext = new SocialNetworkContext();
            notificationContext.Notifications.Add(notification);
            notificationContext.SaveChanges();
        }

        public IEnumerable<Notification> ReadAll(Profile recipient)
        {
            var notificationContext = new SocialNetworkContext();
            return notificationContext.Notifications;
        }
    }
}
