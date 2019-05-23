/**
*
* 功 能： N/A
* 类 名： AutofacService
* 作 者： weili
* 时 间： 2019/5/19 23:11:40
* 版 本： 1.0.0.0
* 版 权： Copyright (c) 2019 Mainki. All rights reserved.
*
*/

using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using NuoSoon.DataContext;
using NuoSoon.Repository.EF;
using NuoSoon.Service;
using NuoSoon.Service.Impl;
using System;
using Vli.Repository;

namespace NuoSoon.Config
{
    public class AutofacService
    {
        public IServiceProvider RegisterAutofac(IServiceCollection services)
        {
            //实例化Autofac容器
            var builder = new ContainerBuilder();

            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));

            //将Services中的服务填充到Autofac中
            builder.Populate(services);

            //新模块组件注册    
            builder.RegisterModule<AutofacModuleRegister>();

            builder.RegisterType<NsDb>().AsSelf().InstancePerDependency();

            //创建容器
            var Container = builder.Build();

            //第三方IOC接管 core内置DI容器 
            return new AutofacServiceProvider(Container);
        }
    }
}
