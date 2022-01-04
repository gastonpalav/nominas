using Microsoft.EntityFrameworkCore;
using NominasApi.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NominasApi.DataAccess
{
    public class DbContextBase<T> : IDBContextBase<T> where T : class,IEntityBase
    {
        NominasDbContext _nominasDbContext;

        DbSet<T> _context;

        public DbContextBase(NominasDbContext nominasDbContext)
        {
            _nominasDbContext = nominasDbContext;
            _context = nominasDbContext.Set<T>();
        }

        public void Delete(int id)
        {
          
        }

        public IList<T> GetAll()
        {
            return _context.ToList();
        }

        public T GetById(int id)
        {
            return _context.Where(i => id == i.Id).FirstOrDefault();
        }

        public T Save(T entity)
        {
            _context.Add(entity);
            _nominasDbContext.SaveChanges();
            return entity;
        }
    }
}
