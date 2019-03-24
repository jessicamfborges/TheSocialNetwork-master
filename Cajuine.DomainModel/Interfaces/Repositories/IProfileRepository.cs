using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cajuine.DomainModel.Entities;

namespace Cajuine.DomainModel.Interfaces.Repositories
{
    public interface IProfileRepository
    {
        void Create(Profile profile);
        Profile Read(Guid post);
        IEnumerable<Profile> ReadAll();
        void Update(Profile profile);
        void Delete(Guid post);
    }
}
