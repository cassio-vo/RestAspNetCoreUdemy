using RestAspNetCoreUdemy_Verbos.Model;

namespace RestAspNetCoreUdemy_Verbos.Repository
{
    public interface IUserRepository
    {
        User FindByLogin(string login);
    }
}
