using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using RestAspNetCoreUdemy_Verbos.Data.VO;

namespace RestAspNetCoreUdemy_Verbos.HATEOAS
{
    public static class GetUrl
    {
        public static Recurso GerarLinks(Recurso recurso, string nomeMetodo, HttpContext httpContext, LinkGenerator linkGenerator)
        {
            recurso.Links.Add(new LinkDTO(
                linkGenerator.GetUriByAction(httpContext, nomeMetodo, values: new { recurso.Id }),
                rel: "self", metodo: "GET"));
            return recurso;
        }
    }
}
