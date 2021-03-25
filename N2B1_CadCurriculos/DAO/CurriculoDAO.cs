using N2B1_CadCurriculos.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
            //dados pessoais
            parametros[0] = new SqlParameter("cpf", c.Cpf);
            parametros[1] = new SqlParameter("nome", c.Nome);
            parametros[2] = new SqlParameter("telefone", c.Telefone);
            parametros[3] = new SqlParameter("email", c.Email);
            parametros[4] = new SqlParameter("cargo", c.Cargo);

            //endereço
            parametros[5] = new SqlParameter("cep", c.Cep);
            parametros[6] = new SqlParameter("estado", c.Estado);
            parametros[7] = new SqlParameter("cidade", c.Cidade);
            parametros[8] = new SqlParameter("bairro", c.Bairro);
            parametros[9] = new SqlParameter("rua", c.Rua);
            parametros[10] = new SqlParameter("numero", c.Numero);

            //Cursos
            parametros[11] = new SqlParameter("curso1", c.Curso1);
            parametros[12] = new SqlParameter("nivelescolaridade1", c.Escolaridade1);
            parametros[13] = new SqlParameter("instituicao1", c.Instituicao1);
            parametros[14] = new SqlParameter("situacao1", c.Situacao1);
            parametros[15] = new SqlParameter("periodo1", c.Periodo1);

            parametros[16] = new SqlParameter("curso2", c.Curso2);
            parametros[17] = new SqlParameter("nivelescolaridade2", c.Escolaridade2);
            parametros[18] = new SqlParameter("instituicao2", c.Instituicao2);
            parametros[19] = new SqlParameter("situacao2", c.Situacao2);
            parametros[20] = new SqlParameter("periodo2", c.Periodo2);

            parametros[21] = new SqlParameter("curso3", c.Curso3);
            parametros[22] = new SqlParameter("nivelescolaridade3", c.Escolaridade3);
            parametros[23] = new SqlParameter("instituicao3", c.Instituicao3);
            parametros[24] = new SqlParameter("situacao3", c.Situacao3);
            parametros[25] = new SqlParameter("periodo3", c.Periodo3);

            parametros[26] = new SqlParameter("curso4", c.Curso4);
            parametros[27] = new SqlParameter("nivelescolaridade4", c.Escolaridade4);
            parametros[28] = new SqlParameter("instituicao4", c.Instituicao4);
            parametros[29] = new SqlParameter("situacao4", c.Situacao4);
            parametros[30] = new SqlParameter("periodo4", c.Periodo4);

            parametros[31] = new SqlParameter("curso5", c.Curso5);
            parametros[32] = new SqlParameter("nivelescolaridade5", c.Escolaridade5);
            parametros[33] = new SqlParameter("instituicao5", c.Instituicao5);
            parametros[34] = new SqlParameter("situacao5", c.Situacao5);
            parametros[35] = new SqlParameter("periodo5", c.Periodo5);

            //Experiências
            parametros[36] = new SqlParameter("empresa1", c.Empresa1);
            parametros[37] = new SqlParameter("inicio1", c.Inicio1);
            parametros[38] = new SqlParameter("termino1", c.Termino1);
            parametros[39] = new SqlParameter("ocupacao1", c.Ocupacao1);
            parametros[40] = new SqlParameter("Atividades1", c.Atividades1);

            parametros[41] = new SqlParameter("empresa2", c.Empresa2);
            parametros[42] = new SqlParameter("inicio2", c.Inicio2);
            parametros[43] = new SqlParameter("termino2", c.Termino2);
            parametros[44] = new SqlParameter("ocupacao2", c.Ocupacao2);
            parametros[45] = new SqlParameter("Atividades2", c.Atividades2);

            parametros[46] = new SqlParameter("empresa3", c.Empresa3);
            parametros[47] = new SqlParameter("inicio3", c.Inicio3);
            parametros[48] = new SqlParameter("termino3", c.Termino3);
            parametros[49] = new SqlParameter("ocupacao3", c.Ocupacao3);
            parametros[50] = new SqlParameter("Atividades3", c.Atividades3);

            //Idiomas
            parametros[51] = new SqlParameter("idioma1", c.Idioma1);
            parametros[52] = new SqlParameter("nivelidioma1", c.Nivelidioma2);

            parametros[53] = new SqlParameter("empresa2", c.Idioma2);
            parametros[54] = new SqlParameter("empresa2", c.Empresa2);

            parametros[55] = new SqlParameter("empresa3", c.Idioma3);
            parametros[56] = new SqlParameter("empresa3", c.Empresa3);

            return parametros;
        }
        public void Inserir(CurriculoViewModel c)
        {
            string sql =
            "insert into Cadastro (CPF, nome, telefone, email, cargo, CEP, estado, cidade, bairro, rua, numero, curso1, nivelescolaridade1, instituicao1, situacao1, conclusao1, periodo1, curso2, nivelescolaridade2, instituicao2, situacao2, conclusao2, periodo2, curso3, nivelescolaridade3, instituicao3, situacao3, conclusao3, periodo3, curso4, nivelescolaridade4, instituicao4, situacao4, conclusao4, periodo4, curso5, nivelescolaridade5, instituicao5, situacao5, conclusao5, periodo5, empresa1, inicio1, termino1, ocupacao1, Atividades1, empresa2, inicio2, termino2, ocupacao2, Atividades2, empresa3, inicio3, termino3, ocupacao3, Atividades3, idioma1, nivelidioma1, idioma2, nivelidioma2, idioma3, nivelidioma3)" +
            "values (@CPF, @nome, @telefone, @email, @cargo, @CEP, @estado, @cidade, @bairro, @rua, @numero, @curso1, @nivelescolaridade1, @instituicao1, @situacao1, @conclusao1, @periodo1, @curso2, @nivelescolaridade2, @instituicao2, @situacao2, @conclusao2, @periodo2, @curso3, @nivelescolaridade3, @instituicao3, @situacao3, @conclusao3, @periodo3, @curso4, @nivelescolaridade4, @instituicao4, @situacao4, @conclusao4, @periodo4, @curso5, @nivelescolaridade5, @instituicao5, @situacao5, @conclusao5, @periodo5, @empresa1, @inicio1, @termino1, @ocupacao1, @Atividades1, @empresa2, @inicio2, @termino2, @ocupacao2, @Atividades2, @empresa3, @inicio3, @termino3, @ocupacao3, @Atividades3, @idioma1, @nivelidioma1, @idioma2, @nivelidioma2, @idioma3, @nivelidioma3)";
            HelperDAO.ExecutaSQL(sql, CriaParametros(c));
        }

        public void Excluir(int CPF)
        {
            string sql = "delete Cadastro where CPF =" + CPF;
            HelperDAO.ExecutaSQL(sql, null);
        }

        public void Alterar(CurriculoViewModel cadastro)
        {
            string sql =
            "update Cadastro set nome = @nome, " +
            "telefone = @telefone, " +
            "email = @email," +
            "cargo = @cargo," +
            "CEP = @CEP," +                                     //Endereço
            "estado = @estado," +
            "cidade = @cidade," +
            "bairro = @bairro," +
            "rua = @rua," +
            "numero = @numero," +
            "curso1 = @curso1," +                               //curso 1
            "nivelescolaridade1 = @nivelescolaridade1," +
            "instituicao1 = @instituicao1," +
            "situacao1 = @situacao1," +
            "conclusao1 = @conclusao1," +
            "periodo1 = @periodo1," +
            "curso2 = @curso2," +                               //curso 2
            "nivelescolaridade2 = @nivelescolaridade2," +
            "instituicao2 = @instituicao2," +
            "situacao2 = @situacao2," +
            "conclusao2 = @conclusao2," +
            "periodo2 = @periodo2," +
            "curso3 = @curso3," +                               //curso 3
            "nivelescolaridade3 = @nivelescolaridade3," +
            "instituicao3 = @instituicao3," +
            "situacao3 = @situacao3," +
            "conclusao3 = @conclusao3," +
            "periodo3 = @periodo3," +
            "curso4 = @curso4," +                               //curso 4
            "nivelescolaridade4 = @nivelescolaridade4," +
            "instituicao4 = @instituicao4," +
            "situacao4 = @situacao4," +
            "conclusao4 = @conclusao4," +
            "periodo4 = @periodo4," +
            "curso5 = @curso5," +                               //curso 5
            "nivelescolaridade5 = @nivelescolaridade5," +
            "instituicao5 = @instituicao5," +
            "situacao5 = @situacao5," +
            "conclusao5 = @conclusao5," +
            "periodo5 = @periodo5," +
            "empresa1 = @empresa1," +                           //empresa 1
            "inicio1 = @inicio1," +
            "termino1 = @termino1," +
            "ocupacao1 = @ocupacao1," +
            "Atividades1 = @Atividades1," +
            "empresa2 = @empresa2," +                           //empresa 2
            "inicio2 = @inicio2," +
            "termino2 = @termino2," +
            "ocupacao2 = @ocupacao2," +
            "Atividades2 = @Atividades2," +
            "empresa3 = @empresa3," +                           //empresa 3
            "inicio3 = @inicio3," +
            "termino3 = @termino3," +
            "ocupacao3 = @ocupacao3," +
            "Atividades3 = @Atividades3," +
            "idioma1 = @idioma1," +                             //idioma 1
            "nivelidioma1 = @nivelidioma1," +
            "idioma2 = @idioma2," +                             //idioma 2
            "nivelidioma2 = @nivelidioma2," +
            "idioma3 = @idioma3," +                             //idioma 3
            "nivelidioma3 = @nivelidioma3 where CPF = @CPF";

            HelperDAO.ExecutaSQL(sql, CriaParametros(cadastro));
        }

        public List<CurriculoViewModel> Listagem()
        {
            List<CurriculoViewModel> lista = new List<CurriculoViewModel>();
            string sql = "select * from Cadastro order by nome";
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaCurriculo(registro));
            return lista;
        }
    }
}
