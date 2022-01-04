using NominasApi.Abstractions;
using NominasApi.Repository;
using System;
using System.Collections.Generic;

namespace NominasApi.Application
{
    public interface IApplication<E> : IABMBase<E> 
    {
    }

    public class ApplicationBase<E> : IApplication<E> where E : IEntityBase
    {
        IRepository<E> _repository;

        public ApplicationBase(IRepository<E> repository)
        {
            _repository = repository;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IList<E> GetAll()
        {
           return _repository.GetAll();
        }

        public E GetById(int id)
        {
            return _repository.GetById(id);
        }

        public E Save(E entity)
        {
            return _repository.Save(entity);
        }
    }
}
