using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NuoSoon.Service
{
   public interface IBaseService<T> where T :class
    {
        T Insert(T entity);

        /// <summary>
        /// 更新单条数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        T Update(T entity);

        /// <summary>
        /// 通过ID删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteById(long id);

        /// <summary>
        /// 获取单条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetEntityById(long id);

        Task<T> UpdateAsync(T entity);
    }
}
