using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cajuine.DomainModel.Interfaces.Repositories;

namespace Cajuine.DomainModel.Entities
{
    public class Post : EntityBase
    {
        public Profile Sender { get; set; }
        public Profile Recipient { get; set; }

        public DateTime PublishDateTime { get; set; }
        public string Content { get; set; }
        public PostTypeEnum PostType { get; set; }
    }
}
