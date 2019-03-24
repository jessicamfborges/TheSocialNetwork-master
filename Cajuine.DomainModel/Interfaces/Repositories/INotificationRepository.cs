using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cajuine.DomainModel.Entities;

namespace Cajuine.DomainModel.Interfaces.Repositories
{
    public interface INotificationRepository
    {
        void Create(Notification notification);
        IEnumerable<Notification> ReadAll(Profile recipient);
    }
}
