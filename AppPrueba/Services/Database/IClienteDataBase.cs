using AppPrueba.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppPrueba.Services.Database
{
    public interface IClienteDataBase<T> : IServiceDataBase<T> where T: class, new()
    {
        Task<T> GetClienteByRestIdAsync(long id);
        Task<int> InsertWithChildrensAsync(ClienteModel item);
    }
}
