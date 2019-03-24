using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cajuine.DomainModel.Entities;

namespace Cajuine.RestauranteWebApi.Models
{
    public class RestauranteViewModel 
    {
        public Guid Id  { get; set; }
        public Profile Sender { get; set; }
        public Profile Recipient { get; set; }
        
        public DateTime PublishDateTime { get; set; }
        public string Content { get; set; }
        public PostTypeEnum PostType => PostTypeEnum.Restaurante;
    }
}