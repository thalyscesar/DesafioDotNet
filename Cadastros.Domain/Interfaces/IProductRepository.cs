using Cadastros.Domain.Entities;
using System.Collections.Generic;

namespace Cadastros.Domain.Interfaces
{
    public interface IProductRepository
    {
        bool Add(Product product);
        bool Update(Product product);
        bool Delete(int id);
        Product GetById(int id);
        List<Product> GetAll();
    }
}
