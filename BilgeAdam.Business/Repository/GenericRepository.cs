﻿using BilgeAdam.Data.ORM.Context;
using BilgeAdam.Data.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Business.Repository
{
    public class GenericRepository<TEntity> where TEntity : Base
    {
        internal BilgeAdamContext context;
        internal DbSet<TEntity> dbSet;

        public GenericRepository()
        {
            context = new BilgeAdamContext();
            this.dbSet = context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            entity.IsDeleted = false;
            entity.AddDate = DateTime.Now;
            entity.UpdateDate = DateTime.Now;

            dbSet.Add(entity);

            context.SaveChanges();
        }

        public List<TEntity> GetAll()
        {
            return dbSet.Where(q => q.IsDeleted == false).ToList();
        }

    }
}
