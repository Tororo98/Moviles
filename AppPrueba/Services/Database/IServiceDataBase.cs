using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrueba.Services.Database
{
    public interface IServiceDataBase<T> where T : class, new()
    {
        Task<List<T>>GetItemAsync();

        Task<T> GetItemAsync(int id);

        Task<int> InsertItemAsync(T item);

        Task<int> UpdateItemAsync(T item);

        Task<int> DeleteItemAsync(T item);
    }

}
