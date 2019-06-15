/**
*
* 功 能： N/A
* 类 名： SystemUserService
* 作 者： weili
* 时 间： 2019/6/15 17:56:12
* 版 本： 1.0.0.0
* 版 权： Copyright (c) 2019 Mainki. All rights reserved.
*
*/

using System;
using System.Collections.Generic;
using System.Text;
using Vli.Entity.PO;
using Vli.Repository;

namespace NuoSoon.Service.Impl
{
    public class SystemUserService : BaseService<SystemUser>, ISystemUserService<SystemUser>
    {
        private readonly ISystemUserRepository systemUser; 
        public SystemUserService(IBaseRepository<SystemUser> baseRepository, ISystemUserRepository systemUser) : base(baseRepository)
        {
            this.systemUser = systemUser;
        }

        public List<SystemUser> ListSystemUser()
        {
            return systemUser.ListSystemUser();
        }
    }
}
