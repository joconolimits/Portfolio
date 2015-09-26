using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Core.Interfaces
{
    public interface IBaseRepository<TEntity>
    {
        void Create(TEntity entity);
        void Edit(TEntity entity);
        void Delete(TEntity entity);
        IEnumerable<TEntity> GetPortfolioItems();
        TEntity FindById(string entityID);
    }
}
