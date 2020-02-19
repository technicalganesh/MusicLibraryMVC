using System;
using System.Collections.Generic;
using System.Linq;
using Music.Standards;

namespace Music.DataAccess
{
    public class SqliteRepository<T> : IDataRepository<T> where T : class
    {
        SqliteDbContext _dbContext;
    
        public SqliteRepository(SqliteDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public T GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
