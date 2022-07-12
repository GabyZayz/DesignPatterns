using System;
namespace DesignPatterns.RepositoryPattern
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> Get();

        void Add(TEntity data);

        void Get(int id);

        void Delete(int id);

        void Update(TEntity data);

        void Save();
    }
}

