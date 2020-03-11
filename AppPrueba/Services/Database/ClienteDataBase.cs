using AppPrueba.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppPrueba.Services.Database
{
    public class ClienteDataBase<T> : IClienteDataBase<T> where T : ClienteModel, new()
    {
        public ClienteDataBase()
        {

            App.Database.connection.CreateTableAsync<T>().Wait();
            App.Database.connection.CreateTableAsync<VehiculoModel>().Wait();

        }

        public Task<int> DeleteItemAsync(T item)
        {
            return App.Database.connection.DeleteAsync(item);
        }

        public Task<List<T>> GetItemAsync()
        {
            return App.Database.connection.Table<T>().ToListAsync();
        }

        public Task<T> GetItemAsync(int id)
        {
            return App.Database.connection.FindAsync<T>(id);
        }

        public Task<List<T>> GetItemsAsync()
        {
            return App.Database.connection.Table<T>().ToListAsync();

        }

        public Task<int> InsertItemAsync(T item)
        {
            return App.Database.connection.InsertAsync(item);
        }

        public Task<int> UpdateItemAsync(T item)
        {
            return App.Database.connection.UpdateAsync(item);
        }

        public Task<int> InsertWithChildrensAsync(ClienteModel item)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetClienteByRestIdAsync(long id)
        {
            throw new NotImplementedException();
        }
    }
}
