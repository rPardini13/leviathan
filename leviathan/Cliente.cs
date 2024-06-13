using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace leviathan
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string RG {  get; set; }
        public string Nome { get; set; }
        public string Celular { get; set; }
        public int FuncionarioId { get; set; }

        public Cliente()
        {
            Id = 0;
            Login = string.Empty;
            Senha = string.Empty;
            RG = string.Empty;
            Nome = string.Empty;
            Celular = string.Empty;
            FuncionarioId = 0;
        }
        //AcessoBD acesso = new AcessoBD();
        DataTable dt = new DataTable();
        List<SqlParameter> parameters = new List<SqlParameter>(); //Lista de Parâmetros
        string sql = string.Empty; //Variável que vai conversar com o SQL

        public void Consultar()
        {
            try
            {
                parameters.Clear();
                sql = "select id, login,senha, rg, nome, \n";
                sql += "celular, ativo, funcionarioId \n";
                sql += "from tblCliente \n";
                sql += "where funcionarioId = @funcionarioId";
                parameters.Add(new SqlParameter("funcinarioId", FuncionarioId));
               


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Gravar()
        {
            try
            {
                parameters.Clear();
                if (Id == 0 )
                {
                    sql = "insert int tblCliente \n";
                    sql += "(login, senha rg, nome, celular, funcionarioId) \n";
                    sql += "values \n";
                    sql += "(@login, @)";
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
