/**
*
* 功 能： N/A
* 类 名： AutofacModuleRegister
* 作 者： weili
* 时 间： 2019/5/19 23:12:46
* 版 本： 1.0.0.0
* 版 权： Copyright (c) 2019 Mainki. All rights reserved.
*
*/

using Autofac;
using System.Reflection;

namespace NuoSoon.Config
{
    public class AutofacModuleRegister : Autofac.Module
    {
        //重写Autofac管道Load方法，在这里注册注入
        protected override void Load(ContainerBuilder builder)
        {            
            builder.RegisterAssemblyTypes(GetAssemblyByName("Vli.Repository")).AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(GetAssemblyByName("NuoSoon.Repository.EF")).AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(GetAssemblyByName("NuoSoon.Service")).AsImplementedInterfaces();
        }

        /// <summary>
        /// 根据程序集名称获取程序集
        /// </summary>
        public static Assembly GetAssemblyByName(string AssemblyName)
        {
            return Assembly.Load(AssemblyName);
        }
    }
}
