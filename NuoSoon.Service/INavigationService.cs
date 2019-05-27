using System.Collections.Generic;
using Vli.Entity.PO;

namespace NuoSoon.Service
{
    public interface INavigationService<T> : IBaseService<T> where T : class
    {
        List<Navigation> Navigations();
    }
}
