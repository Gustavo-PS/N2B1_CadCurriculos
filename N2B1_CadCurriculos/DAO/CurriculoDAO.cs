using N2B1_CadCurriculos.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace N2B1_CadCurriculos.DAO
{
    public class CurriculoDAO
    {

        private SqlParameter[] CriaParametros(CurriculoViewModel c)
        {
            SqlParameter[] parametros = new SqlParameter[5];
            parametros[0] = new SqlParameter("cpf", c.cpf);
            parametros[1] = new SqlParameter("nome", c.nome);
            parametros[2] = new SqlParameter("telefone", c.telefone);
            parametros[3] = new SqlParameter("email", c.email);
            parametros[4] = new SqlParameter("cargo", c.cargo);

            parametros[5] = new SqlParameter("cep", c.cep);
            parametros[6] = new SqlParameter("estado", c.estado);
            parametros[7] = new SqlParameter("cidade", c.cidade);
            parametros[8] = new SqlParameter("bairro", c.bairro);
            parametros[9] = new SqlParameter("rua", c.rua);
            parametros[10] = new SqlParameter("numero", c.numero);

            return parametros;
        }
        public void Inserir(CurriculoViewModel c)
        {
            string sql =
            "insert into alunos(id, nome, mensalidade, cidadeId, dataNascimento)" +
            "values ( @id, @nome, @mensalidade, @cidadeId, @dataNascimento)";
            HelperDAO.ExecutaSQL(sql, CriaParametros(c));
        }
    }
}
