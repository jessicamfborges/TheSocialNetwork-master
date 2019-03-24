using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajuine.DomainModel.Interfaces.Repositories
{
    public interface  IRepositoryBase<TEntity> where TEntity : class
    {
        void Create(TEntity profile);
        TEntity Read(Guid id);
        IEnumerable<TEntity> ReadAll();
        void Update(TEntity profile);
        void Delete(Guid id);
    }
}
