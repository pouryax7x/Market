using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using PostgreSQL;

namespace DAL
{
    abstract public class BaseDA<T> where T : class
    {
        protected DbSet<T> _table;
        EntityContext _db;
        public BaseDA(EntityContext db)
        {
            _db = db;
            this._table = _db.Set<T>();
        }


        protected IQueryable<T> GetAll() => _table.AsQueryable();
        protected T GetOne(Func<T, bool> crit)
        {
            return _table.Where(crit).FirstOrDefault();
        }
        protected IQueryable<T> GetSome(Func<T, bool> crit)
        {
            return _table.Where(crit).AsQueryable();
        }
        protected int Delete(int id)
        {
            var temp = _table.Find(id);
            _db.Remove(temp);
            return id;
        }
        protected T Update(T model, int id)
        {
            var temp = _table.Find(id);
            _db.Entry(temp).CurrentValues.SetValues(model);
            return model;
        }
        protected T Insert(T model){
            _table.Add(model);
            return model;
        }
        protected void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}