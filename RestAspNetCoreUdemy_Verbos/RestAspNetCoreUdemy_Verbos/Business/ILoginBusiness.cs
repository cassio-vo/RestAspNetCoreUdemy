using RestAspNetCoreUdemy_Verbos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAspNetCoreUdemy_Verbos.Business
{
    public interface ILoginBusiness
    {
        object FindByLogin(User user);
    }
}
