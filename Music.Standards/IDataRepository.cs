using System.Collections.Generic;

namespace Music.Standards
{
    public interface IDataRepository<T> where T: class
    {
         void Add(T entity);
         void Remove(int id);
         T GetById(int id);
         List<T> GetAll();
         void Update(T entity);
         T GetByName(string name);
    }
}