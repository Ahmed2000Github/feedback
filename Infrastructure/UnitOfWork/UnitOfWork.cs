
using Core.Interfaces;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private DataContext Context { get; }
        private IGenericRepository<T> entity;
        public UnitOfWork(DataContext context)
        {
            Context = context;
        }
        public IGenericRepository<T> Entity
        {
            get
            {
                return entity ?? (entity = new GenericRepository<T>(Context));
            }
        }
        public void Save()
        {
            Context.SaveChanges();
        }
    }
}
