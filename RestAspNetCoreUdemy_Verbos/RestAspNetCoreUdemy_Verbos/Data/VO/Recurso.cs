using RestAspNetCoreUdemy_Verbos.HATEOAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAspNetCoreUdemy_Verbos.Data.VO
{
    public class Recurso
    {
        public long? Id { get; set; }
        public List<LinkDTO> Links { get; set; } = new List<LinkDTO>();
    }
}
