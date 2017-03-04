using _3k.Core.Data;
using _3k.Domain;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace _3k.Infrastructure.Repositories
{


    public abstract class Ef3kRepository : IDisposable
    {
        protected Ef3kRepository(DbContext context)
        {
            Context = (CustomerEntities)context;
        }

        /// <summary>
        ///     Gets the context.
        /// </summary>
        /// <value>The context.</value>
        protected CustomerEntities Context { get; private set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this instance is disposed.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance is disposed; otherwise, <c>false</c>.
        /// </value>
        protected bool IsDisposed { get; set; }

        #region IDisposable Members

        /// <summary>
        ///     Performs application-defined tasks associated with freeing, releasing, or resetting
        ///     unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            IsDisposed = true;
            GC.SuppressFinalize(this);
        }

        /// <summary>
        ///     Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing">
        ///     <c>true</c> to release both managed and unmanaged resources;
        ///     <c>false</c> to release only unmanaged resources.
        /// </param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                Context?.Dispose();

                Context = null;
            }

            Context?.Dispose();

            Context = null;
        }

        #endregion
    }

    public abstract class Ef3kRepository<T> : Ef3kRepository, IRepository<T> where T : class
    {
        protected Ef3kRepository(DbContext context) : base(context)
        {
        }

        public T GetById(long id)
        {
            return Context.Set<T>().Find(id);
        }

        public T GetById(int id)
        {
            return Context.Set<T>().Find(id);
        }

        public void Save(T entity)
        {
            Context.Set<T>().Add(entity);
            Context.SaveChanges();
        }

        public void Update(T entity)
        {
            Context.Set<T>().AddOrUpdate(entity);
            Context.SaveChanges();
        }
        public void Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
            Context.SaveChanges();
        }

    }
}