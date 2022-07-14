using CadastrosProdutos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrosProdutos.Interfaces
{
    public interface ICadastroAppService<TModel>
    {
        bool Add(TModel model);
        bool Remove(int id);
        bool Update(TModel model);
        ProductModel GetById(int id);
        IList<ProductModel> GetAll();
    }
}
