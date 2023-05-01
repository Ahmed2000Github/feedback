using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class

    {
        public DbSet<T> table = null;
        public GenericRepository(DataContext context)
        {
            Context = context;
            table = Context.Set<T>();
        }

        public DataContext Context { get; }

        public void Delete(object Id)
        {
            T existing = GetById(Id);
            table.Remove(existing);
        }

        public IEnumerable<T> GetAll()
        {
            return table;
        }

        public T GetById(object Id)
        {
            return table.Find(Id);
        }
        public void Insert(T entity)
        {
            table.Add(entity);
        }

        public void Update(T entity)
        {
            table.Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
        }
    }
}
