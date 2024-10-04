//Importar bibliotecas de banco
using System;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoPOOA.Services
{
    public class DataBaseSqlServerService
    {
        //Método para conectar com o banco de dados
        private SqlConnection CriarConexao()
        {
            SqlConnection conexao = 
                new SqlConnection();

            //Os dados para conectar no banco
            conexao.ConnectionString =
                "Data Source=.\\SQLExpress;" + //Servidor
                "Initial Catalog=ProjetoPOOA;" + //Nome do Banco
                "Integrated Security=SSPI;" + //Autenticação do Windows (usuario logado)
                "User Instance=false;"; //Usar o usuario da maquina

            conexao.Open(); //Abrir a conexão com o banco
            return conexao;
        }

    }
}
