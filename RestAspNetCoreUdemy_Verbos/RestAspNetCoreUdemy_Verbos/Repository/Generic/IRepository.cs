using RestAspNetCoreUdemy_Verbos.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAspNetCoreUdemy_Verbos.Repository.Generic
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);

        T FindById(long? Id);

        List<T> FindAll();

        T Update(T item);

        void Delete(long Id);

        bool Exist(long? id);
    }
}
