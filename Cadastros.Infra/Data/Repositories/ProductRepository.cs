using Cadastros.Domain.Entities;
using Cadastros.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Cadastros.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IAcessoADados _acessoADados;
        public ProductRepository(IAcessoADados acessoADados)
        {
            _acessoADados = acessoADados;
        }

        public bool Add(Product product)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@CREATEDAT", product.CreatedAt));
            parametros.Add(new SqlParameter("@NAME", product.Name));
            parametros.Add(new SqlParameter("@PRICE", product.Price));
            parametros.Add(new SqlParameter("@BRAND", product.Brand));
            parametros.Add(new SqlParameter("@UPDATEAT", product.UpdateAt));

            var inserido = _acessoADados.Executar("add_product", parametros);

            return inserido;
        }

        public bool Delete(int id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@ID", id));

            var deletado = _acessoADados.Executar("delete_product", parametros);

            return deletado;
        }

        public List<Product> GetAll()
        {
            DataSet ds = _acessoADados.Consultar("select_all_product", new List<SqlParameter>());

            return Converter(ds);
        }

        public Product GetById(int id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@ID", id));

            DataSet ds = _acessoADados.Consultar("select_by_id_product", parametros);

            return Converter(ds).FirstOrDefault();
        }

        public bool Update(Product product)
        {

            var dateAdd = this.GetById(product.Id);

            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@CREATEDAT", dateAdd.CreatedAt));
            parametros.Add(new SqlParameter("@NAME", product.Name));
            parametros.Add(new SqlParameter("@PRICE", product.Price));
            parametros.Add(new SqlParameter("@BRAND", product.Brand));
            parametros.Add(new SqlParameter("@UPDATEAT", product.UpdateAt));
            parametros.Add(new SqlParameter("@ID", product.Id));

            var atualizado = _acessoADados.Executar("update_product", parametros);

            return atualizado;
        }

        private List<Product> Converter(DataSet ds)
        {
            List<Product> list = new List<Product>();

            foreach (DataRow row in ds?.Tables[0]?.Rows)
            {
                list.Add(ConverterDataRowParaProduct(row));
            }

            return list;
        }

        private Product ConverterDataRowParaProduct(DataRow row)
        {
            return new Product(
                               row.Field<DateTime>("created_at"),
                               row.Field<string>("name_product"),
                               row.Field<decimal>("price"),
                               row.Field<string>("brand"),
                               row.Field<DateTime>("update_at"),
                               row.Field<int>("id")
                               );
        }
    }
}
