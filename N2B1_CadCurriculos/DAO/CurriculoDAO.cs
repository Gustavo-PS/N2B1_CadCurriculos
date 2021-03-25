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
            "insert into Cadastro (CPF, nome, telefone, email, cargo, CEP, estado, cidade, bairro, rua, numero, curso1, nivelescolaridade1, instituicao1, situacao1, conclusao1, periodo1, curso2, nivelescolaridade2, instituicao2, situacao2, conclusao2, periodo2, curso3, nivelescolaridade3, instituicao3, situacao3, conclusao3, periodo3, curso4, nivelescolaridade4, instituicao4, situacao4, conclusao4, periodo4, curso5, nivelescolaridade5, instituicao5, situacao5, conclusao5, periodo5, empresa1, inicio1, termino1, ocupacao1, Atividades1, empresa2, inicio2, termino2, ocupacao2, Atividades2, empresa3, inicio3, termino3, ocupacao3, Atividades3, idioma1, nivelidioma1, idioma2, nivelidioma2, idioma3, nivelidioma3)" +
            "values (@CPF, @nome, @telefone, @email, @cargo, @CEP, @estado, @cidade, @bairro, @rua, @numero, @curso1, @nivelescolaridade1, @instituicao1, @situacao1, @conclusao1, @periodo1, @curso2, @nivelescolaridade2, @instituicao2, @situacao2, @conclusao2, @periodo2, @curso3, @nivelescolaridade3, @instituicao3, @situacao3, @conclusao3, @periodo3, @curso4, @nivelescolaridade4, @instituicao4, @situacao4, @conclusao4, @periodo4, @curso5, @nivelescolaridade5, @instituicao5, @situacao5, @conclusao5, @periodo5, @empresa1, @inicio1, @termino1, @ocupacao1, @Atividades1, @empresa2, @inicio2, @termino2, @ocupacao2, @Atividades2, @empresa3, @inicio3, @termino3, @ocupacao3, @Atividades3, @idioma1, @nivelidioma1, @idioma2, @nivelidioma2, @idioma3, @nivelidioma3)";
            HelperDAO.ExecutaSQL(sql, CriaParametros(c));
        }
    }
}
