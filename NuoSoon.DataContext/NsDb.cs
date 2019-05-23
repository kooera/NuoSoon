/**
*
* 功 能： N/A
* 类 名： NsDb
* 作 者： weili
* 时 间： 2019/5/23 22:15:21
* 版 本： 1.0.0.0
* 版 权： Copyright (c) 2019 Mainki. All rights reserved.
*
*/

using Microsoft.EntityFrameworkCore;
using Vli.DataContext;

namespace NuoSoon.DataContext
{
    public class NsDb : VliDb
    {
        public NsDb(DbContextOptions<NsDb> options) : base(options)
        {
        }
    }
}
