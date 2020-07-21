using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace SistemaVendas
{
    class ClVariaveisGlobais
    {
        public static String vesãoSistema = "Vendas - 0.1";
        public static OleDbConnection conexao = new OleDbConnection();
        public static String endereco_banco = @"db_vendas.accdb";
        public static String conecta = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + endereco_banco;
    }
}
