using CelilCavus.OgrenciKayitSistemi.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CelilCavus.OgrenciKayitSistemi.Service
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _dbcontext;
        private readonly DbSet<T> _dbset;

        public BaseRepository(DbContext dbcontext)
        {
            _dbcontext = dbcontext;
            _dbset = dbcontext.Set<T>();
        }
        [NonAction]
        public void Add(T entity)
        {
            _dbset.Add(entity);
            _dbcontext.SaveChanges();
        }
        [NonAction]
        public void Delete(T entity)
        {
            _dbset.Remove(entity);
            _dbcontext.SaveChanges();
        }
        [NonAction]
        public IEnumerable<T> GetAll()
        {
            return _dbset.AsNoTracking().ToList();
        }
        [NonAction]
        public T GetById(int id)
        {
            return _dbset.Find(id);
        }

        [NonAction]
        public void Update(T entity)
        {
            _dbset.Update(entity);
            _dbcontext.SaveChanges();
        }
    }
}