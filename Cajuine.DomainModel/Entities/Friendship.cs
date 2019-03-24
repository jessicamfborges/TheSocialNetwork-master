using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajuine.DomainModel.Entities
{
    public class Friendship : EntityBase
    {
        public Profile FriendRequester { get; set; }
        public Profile FriendRequested { get; set; }
    }
}
