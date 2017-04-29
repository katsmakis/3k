using System;

namespace k3k.Core.Data
{

    public abstract class Repository<T> : IDisposable, IRepository<T> where T : class
    {
        #region IRepository<T> Members
        //test: to be deleted
        //test to be deleted
        public abstract T GetById(long id);
        public abstract T GetById(int id);
        public abstract void Save(T entity);
        public abstract void Update(T entity);
        public abstract void Delete(T entity);

        #endregion

        #region IDisposable Members

        public abstract void Dispose();

        #endregion
    }
}