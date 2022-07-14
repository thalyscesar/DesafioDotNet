using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Cadastros.Domain.Interfaces
{
    public interface IAcessoADados
    {
        bool Executar(string NomeProcedure, List<SqlParameter> parametros);
        DataSet Consultar(string NomeProcedure, List<SqlParameter> parametros);
    }
}
