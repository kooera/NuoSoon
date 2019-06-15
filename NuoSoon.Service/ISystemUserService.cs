using System.Collections.Generic;
using Vli.Entity.PO;

namespace NuoSoon.Service
{
    public interface ISystemUserService<T> : IBaseService<T> where T : class
    {
        List<SystemUser> ListSystemUser();
    }
}
