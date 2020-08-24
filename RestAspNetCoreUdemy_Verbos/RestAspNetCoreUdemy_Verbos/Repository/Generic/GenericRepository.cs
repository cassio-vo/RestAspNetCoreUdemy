using Microsoft.EntityFrameworkCore;
using RestAspNetCoreUdemy_Verbos.Model.Base;
using RestAspNetCoreUdemy_Verbos.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAspNetCoreUdemy_Verbos.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private MySqlContext _context;
        private DbSet<T> _dataSet;

        public GenericRepository(MySqlContext context)
        {
            _context = context;
            _dataSet = _context.Set<T>();
        }

        public T Create(T item)
        {
            try
            {
                _context.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }

        public void Delete(long id)
        {
            var result = _dataSet.SingleOrDefault(p => p.Id == id);

            try
            {
                if (result != null)
                {
                    _dataSet.Remove(result);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Exist(long? id)
        {
            return _dataSet.Any(p => p.Id == id);
        }

        public List<T> FindAll()
        {
            return _dataSet.ToList<T>();
        }

        public T FindById(long? id)
        {
            return _dataSet.SingleOrDefault(x => x.Id == id);
        }

        public T Update(T item)
        {
            if (!Exist(item.Id)) Create(item);

            var result = FindById(item.Id);

            try
            {
                _context.Entry(result).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }
    }
}
