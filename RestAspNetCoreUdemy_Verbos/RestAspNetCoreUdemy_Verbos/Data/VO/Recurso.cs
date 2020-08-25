using RestAspNetCoreUdemy_Verbos.HATEOAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAspNetCoreUdemy_Verbos.Data.VO
{
    public class Recurso
    {
        public List<LinkDTO> Links { get; set; } = new List<LinkDTO>();

    }
}
