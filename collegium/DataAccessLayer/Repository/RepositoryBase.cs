using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer.Repository
{
    public class RepositoryBase
    {
        public IEnumerable<T> ExecuteObject<T>(DataTable data)
        {
            List<T> items = new List<T>();
            foreach (var row in data.Rows)
            {
                T item = (T)Activator.CreateInstance(typeof(T), row);
                items.Add(item);
            }
            return items;
        }
    }
}
