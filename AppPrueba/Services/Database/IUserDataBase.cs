using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrueba.Services.Database
{
    public interface IUserDataBase<T> : IServiceDataBase<T> where T: class, new()
    {
        Task<int> InsertAllItemsAsync(IList<T> items);

        Task<int> DeleteAllItemsAsync();

        Task<int> GetAllItemsAsync();
        
        Task InsertAllItemsWithChildrenAsync(IList<T> items);

    }
}
