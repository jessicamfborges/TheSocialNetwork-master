using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cajuine.DomainModel.Entities;

namespace Cajuine.DataAccess.Entities
{
    public class ProfileAzureTableEntity : TableEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string PhotoUrl { get; set; }
        public string Country { get; set; }

        public ProfileAzureTableEntity()
        {
        }

        public ProfileAzureTableEntity(Guid id, string country)
        {
            Id = id;
            Country = country;
            this.RowKey = Id.ToString();
            this.PartitionKey = Country;
        }
    }
}
