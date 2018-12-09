using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProyectoXamarin.Models;
using SQLite;

namespace ProyectoXamarin.Datos
{
    public class BaseCoches
    {
        readonly SQLiteAsyncConnection database;

        public BaseCoches(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<coches>().Wait();
        }

        public Task<List<coches>> GetItemsAsync()
        {
            return database.Table<coches>().ToListAsync();
        }

        public Task<List<coches>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<coches>("SELECT * FROM [coches]");
        }

        public Task<coches> GetItemAsync(int id)
        {
            return database.Table<coches>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(coches item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(coches item)
        {
            return database.DeleteAsync(item);
        }
    }
}
