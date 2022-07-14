using Cadastros.Domain.Entities;
using System.Collections.Generic;

namespace Cadastros.Domain.Interfaces
{
    public interface IProductService
    {
        bool Add(Product product);
        bool Update(Product product);
        bool Delete(int id);
        Product GetById(int id);
        List<Product> GetAll();
        bool UpdateName(int id, string name);
        bool UpdatePrice(int id, decimal price);
    }
}
