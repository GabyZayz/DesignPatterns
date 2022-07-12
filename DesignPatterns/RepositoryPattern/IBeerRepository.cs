using System;
namespace DesignPatterns.RepositoryPattern
{
    public interface IBeerRepository
    {
        IEnumerable<Beer> Get();

        void Add(Beer data);

        void Get(int id);

        void Delete(int id);

        void Update(Beer data);

        void Save();

    }
}

