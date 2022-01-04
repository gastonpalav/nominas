using NominasApi.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominasApi.Repository
{

    public interface IRepository<T> : IABMBase<T>
    {

    }

    public class RepositoryBase<T> : IRepository<T> where T : IEntityBase
    {
        IDBContextBase<T> _dBContextBase;

        public RepositoryBase(IDBContextBase<T> dbContextBase)
        {
            _dBContextBase = dbContextBase;
        }

        public void Delete(int id)
        {
            _dBContextBase.Delete(id);
        }

        public IList<T> GetAll()
        {
            return _dBContextBase.GetAll();
        }

        public T GetById(int id)
        {
            return (_dBContextBase.GetById(id));
        }

        public T Save(T entity)
        {
           return _dBContextBase.Save(entity);
        }
    }
}
