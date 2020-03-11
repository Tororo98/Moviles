using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppPrueba.Services.Database
{
    public interface IVehiculoDataBase<T> : IServiceDataBase<T> where T : class, new()
    {
        Task<int> InsertAllItemAsync(List<T> items);
        Task<int> DeleteAllItemsAsync();
        Task<List<T>> GetAllItemsWithChildrensAsync(List<T> items);
        Task InsertAllItemsWithChildrensAsync(List<T> items);

    }
}
