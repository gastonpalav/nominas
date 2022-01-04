using System;
using System.Collections.Generic;

namespace NominasApi.Abstractions
{
    public interface IABMBase<E>
    {
        E Save(E entity);

        IList<E> GetAll();

        E GetById(int id); 

        void Delete(int id);
    }
}
