using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IAsyncRepository<T>
    {
        //Universal methods
        Task<T> GetById(int? id);
        Task<List<T>> GetAll();
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);

        //User methods
        Task<T> UpdateUserAsync(T entity);

    }
}
