

using NuoSoon.DataContext;
using Vli.Repository;
/**
*
* 功 能： N/A
* 类 名： AccessRecordRepository
* 作 者： weili
* 时 间： 2019/5/19 22:54:28
* 版 本： 1.0.0.0
* 版 权： Copyright (c) 2019 Mainki. All rights reserved.
*
*/
namespace NuoSoon.Repository.EF
{
    public class AccessRecordRepository : IAccessRecordRepository
    {
        private readonly NsDb db;
        public AccessRecordRepository(NsDb db)
        {
            this.db = db;
        }

        public void GetList()
        {

        }
    }
}
