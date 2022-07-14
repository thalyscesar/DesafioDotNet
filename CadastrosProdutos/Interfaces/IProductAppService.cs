using CadastrosProdutos.Models;
using System.Collections.Generic;

namespace CadastrosProdutos.Interfaces
{
    public interface IProductAppService  : ICadastroAppService<ProductModel>
    {
        bool UpdateName(int id, string name);
        bool UpdatePrice(int id, decimal price);
    }
}
