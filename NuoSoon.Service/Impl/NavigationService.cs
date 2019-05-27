/**
*
* 功 能： N/A
* 类 名： NavigationService
* 作 者： weili
* 时 间： 2019/5/27 22:14:05
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
    public class NavigationService : BaseService<Navigation>, INavigationService<Navigation>
    {
        private readonly INavigationRepository repository;
        public NavigationService(IBaseRepository<Navigation> baseRepository, INavigationRepository repository) : base(baseRepository)
        {
            this.repository = repository;
        }

        public List<Navigation> Navigations()
        {
            return repository.Navigations();
        }
    }
}
