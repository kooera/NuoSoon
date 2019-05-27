/**
*
* 功 能： N/A
* 类 名： NavigationRepository
* 作 者： weili
* 时 间： 2019/5/27 22:10:25
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
    public class NavigationRepository : INavigationRepository
    {
        private readonly NsDb db;
        public NavigationRepository(NsDb db)
        {
            this.db = db;
        }

        public List<Navigation> Navigations()
        {
            return db.Navigation == null ? new List<Navigation>() : db.Navigation.ToList();
        }
    }
}
