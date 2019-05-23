
/**
*
* 功 能： N/A
* 类 名： BaseServices
* 作 者： weili
* 时 间： 2019/5/19 23:02:24
* 版 本： 1.0.0.0
* 版 权： Copyright (c) 2019 Mainki. All rights reserved.
*
*/
using Vli.Repository;
namespace NuoSoon.Service.Impl
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        private readonly IBaseRepository<T> baseRepository;

        public BaseService(IBaseRepository<T> baseRepository)
        {
            this.baseRepository = baseRepository;
        }

        public virtual bool DeleteById(long id)
        {
            return baseRepository.DeleteById(1);
        }

        public virtual T GetEntityById(long id)
        {
            return baseRepository.GetEntityById(1);
        }

        public virtual T Insert(T entity)
        {
            return baseRepository.Insert(entity);
        }

        public virtual T Update(T entity)
        {
            return baseRepository.Update(entity);
        }
    }
}
