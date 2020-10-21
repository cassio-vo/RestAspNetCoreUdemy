using RestAspNetCoreUdemy_Verbos.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAspNetCoreUdemy_Verbos.Model
{
    public class User
    {
        public long? Id { get; set; }

        public string Login { get; set; }

        public string AccessKey { get; set; }
    }
}
