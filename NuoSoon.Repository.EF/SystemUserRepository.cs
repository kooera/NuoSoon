/**
*
* 功 能： N/A
* 类 名： SystemUserRepository
* 作 者： weili
* 时 间： 2019/6/15 17:51:23
* 版 本： 1.0.0.0
* 版 权： Copyright (c) 2019 Mainki. All rights reserved.
*
*/

using NuoSoon.DataContext;
using System.Collections.Generic;
using System.Linq;
using Vli.Entity.PO;
using Vli.Repository;

namespace NuoSoon.Repository.EF
{
    public class SystemUserRepository : ISystemUserRepository
    {
        private readonly NsDb db;

        public SystemUserRepository(NsDb db)
        {
            this.db = db;
        }

        public List<SystemUser> ListSystemUser()
        {
            return db.SystemUser == null ? new List<SystemUser>() : db.SystemUser.ToList();
        }
    }
}
