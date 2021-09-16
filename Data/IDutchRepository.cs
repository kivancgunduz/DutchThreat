using DutchTreat.Data.Entities;
using System.Collections.Generic;

namespace DutchThreat.Data
{
    public interface IDutchRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByCategory(string category);
        IEnumerable<Order> GetAllOrders(bool includeItems);
        IEnumerable<Order> GetAllOrdersByUser(string username, bool includeItems);
        Order GetOrderByID(string username,int id);
        void AddEntity(object model);
        bool SaveAll();
        
    }
}