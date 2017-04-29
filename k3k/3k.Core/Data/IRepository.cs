namespace k3k.Core.Data
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Loads the entity with the specified Int64 id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        T GetById(long id);

        /// <summary>
        /// Loads the entity specified Int32 id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        T GetById(int id);

        /// <summary>
        /// Saves the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Save(T entity);

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Update(T entity);

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Delete(T entity);
    }

}