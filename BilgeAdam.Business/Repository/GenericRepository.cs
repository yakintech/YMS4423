using BilgeAdam.Data.ORM.Context;
using BilgeAdam.Data.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Business.Repository
{
    public class GenericRepository<TEntity> where TEntity : Base
    {
         BilgeAdamContext db;
         DbSet<TEntity> dbSet;
        //db.Products = dbSet
        //db = context

        public GenericRepository()
        {
            db = new BilgeAdamContext();
            this.dbSet = db.Set<TEntity>();
        }

       
        public void Add(TEntity entity)
        {
            entity.IsDeleted = false;
            entity.AddDate = DateTime.Now;
            entity.UpdateDate = DateTime.Now;

            dbSet.Add(entity);
            db.SaveChanges();
        }

        public List<TEntity> GetAll()
        {
            return dbSet.Where(q => q.IsDeleted == false).ToList();
        }

        public void Delete(int id)
        {
            var entity = dbSet.FirstOrDefault(q => q.ID == id);
            entity.IsDeleted = true;
            entity.DeleteDate = DateTime.Now;

            db.SaveChanges();

        }

        public List<TEntity> GetAllWithQueryable(Expression<Func<TEntity, bool>> lambda)
        {
            return dbSet.Where(q => q.IsDeleted == false).Where(lambda).ToList();
        }

        //tablo içerisindeki satır adetini dönen metot
        public int GetCount()
        {
            return dbSet.Where(q => q.IsDeleted == false).Count();
        }

    }
}
