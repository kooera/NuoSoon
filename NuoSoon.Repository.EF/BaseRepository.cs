/**
*
* 功 能： N/A
* 类 名： BaseRepositories
* 作 者： weili
* 时 间： 2019/5/19 22:57:30
* 版 本： 1.0.0.0
* 版 权： Copyright (c) 2019 Mainki. All rights reserved.
*
*/

using NuoSoon.DataContext;
using System.Threading.Tasks;
using Vli.Repository;

namespace NuoSoon.Repository.EF
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly NsDb db;
        public BaseRepository(NsDb db)
        {
            this.db = db;
        }

        public virtual bool DeleteById(long id)
        {
            var entity = GetEntityById(id);
            if (entity != null)
            {
                db.Remove(entity);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual T GetEntityById(long id)
        {
            var entity = db.Find<T>(id);
            return entity;
        }

        public virtual T Insert(T entity)
        {
            db.Add(entity);
            db.SaveChanges();
            return entity;
        }

        public virtual T Update(T entity)
        {
            UpdateAsync(entity);
            return entity;
        }

        public virtual async Task<T> UpdateAsync(T entity)
        {
            db.Update(entity);
            await db.SaveChangesAsync();
            return entity;
        }
    }
}
