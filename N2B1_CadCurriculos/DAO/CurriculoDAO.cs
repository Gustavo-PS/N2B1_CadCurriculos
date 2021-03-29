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

        private CurriculoViewModel MontaCurriculo(DataRow registro)
        {
            CurriculoViewModel cv = new CurriculoViewModel();
            cv.Cpf = registro["cpf"].ToString();
            cv.Nome = registro["nome"].ToString();
            cv.Cep = registro["cep"].ToString();
            cv.Rua = registro["rua"].ToString();
            return cv;
        }

        private SqlParameter[] CriaParametros(CurriculoViewModel c)
        {
            DateTime data = Convert.ToDateTime("01/01/0001");
            SqlParameter[] parametros = new SqlParameter[62];
            //dados pessoais
            parametros[0] = new SqlParameter("cpf", c.Cpf ?? (object)DBNull.Value);
            parametros[1] = new SqlParameter("nome", c.Nome ?? (object)DBNull.Value);
            parametros[2] = new SqlParameter("telefone", c.Telefone ?? (object)DBNull.Value);
            parametros[3] = new SqlParameter("email", c.Email ?? (object)DBNull.Value);
            parametros[4] = new SqlParameter("cargo", c.Cargo ?? (object)DBNull.Value);

            //endereço
            parametros[5] = new SqlParameter("cep", c.Cep ?? (object)DBNull.Value);
            parametros[6] = new SqlParameter("estado", c.Estado ?? (object)DBNull.Value);
            parametros[7] = new SqlParameter("cidade", c.Cidade ?? (object)DBNull.Value);
            parametros[8] = new SqlParameter("bairro", c.Bairro ?? (object)DBNull.Value);
            parametros[9] = new SqlParameter("rua", c.Rua ?? (object)DBNull.Value);
            parametros[10] = new SqlParameter("numero", c.Numero == 0 ? (object)DBNull.Value : c.Numero);

            //Cursos
            parametros[11] = new SqlParameter("curso1", c.Curso1 ?? (object)DBNull.Value);
            parametros[12] = new SqlParameter("escolaridade1", c.Escolaridade1 ?? (object)DBNull.Value);
            parametros[13] = new SqlParameter("instituicao1", c.Instituicao1 ?? (object)DBNull.Value);
            parametros[14] = new SqlParameter("situacao1", c.Situacao1 ?? (object)DBNull.Value);
            parametros[15] = new SqlParameter("conclusao1", c.Conclusao1 == data ? (object)DBNull.Value : c.Conclusao1);
            parametros[16] = new SqlParameter("periodo1", c.Periodo1 ?? (object)DBNull.Value);

            parametros[17] = new SqlParameter("curso2", c.Curso2 ?? (object)DBNull.Value);
            parametros[18] = new SqlParameter("escolaridade2", c.Escolaridade2 ?? (object)DBNull.Value);
            parametros[19] = new SqlParameter("instituicao2", c.Instituicao2 ?? (object)DBNull.Value);
            parametros[20] = new SqlParameter("situacao2", c.Situacao2 ?? (object)DBNull.Value);
            parametros[21] = new SqlParameter("conclusao2", c.Conclusao2 == data ? (object)DBNull.Value : c.Conclusao2);
            parametros[22] = new SqlParameter("periodo2", c.Periodo2 ?? (object)DBNull.Value);

            parametros[23] = new SqlParameter("curso3", c.Curso3 ?? (object)DBNull.Value);
            parametros[24] = new SqlParameter("escolaridade3", c.Escolaridade3 ?? (object)DBNull.Value);
            parametros[25] = new SqlParameter("instituicao3", c.Instituicao3 ?? (object)DBNull.Value);
            parametros[26] = new SqlParameter("situacao3", c.Situacao3 ?? (object)DBNull.Value);
            parametros[27] = new SqlParameter("conclusao3", c.Conclusao3 == data ? (object)DBNull.Value : c.Conclusao3);
            parametros[28] = new SqlParameter("periodo3", c.Periodo3 ?? (object)DBNull.Value);

            parametros[29] = new SqlParameter("curso4", c.Curso4 ?? (object)DBNull.Value);
            parametros[30] = new SqlParameter("escolaridade4", c.Escolaridade4 ?? (object)DBNull.Value);
            parametros[31] = new SqlParameter("instituicao4", c.Instituicao4 ?? (object)DBNull.Value);
            parametros[32] = new SqlParameter("situacao4", c.Situacao4 ?? (object)DBNull.Value);
            parametros[33] = new SqlParameter("conclusao4", c.Conclusao4 == data ? (object)DBNull.Value : c.Conclusao4);
            parametros[34] = new SqlParameter("periodo4", c.Periodo4 ?? (object)DBNull.Value);

            parametros[35] = new SqlParameter("curso5", c.Curso5 ?? (object)DBNull.Value);
            parametros[36] = new SqlParameter("escolaridade5", c.Escolaridade5 ?? (object)DBNull.Value);
            parametros[37] = new SqlParameter("instituicao5", c.Instituicao5 ?? (object)DBNull.Value);
            parametros[38] = new SqlParameter("situacao5", c.Situacao5 ?? (object)DBNull.Value);
            parametros[39] = new SqlParameter("conclusao5", c.Conclusao5 == data ? (object)DBNull.Value : c.Conclusao5);
            parametros[40] = new SqlParameter("periodo5", c.Periodo5 ?? (object)DBNull.Value);

            //Experiências
            parametros[41] = new SqlParameter("empresa1", c.Empresa1 ?? (object)DBNull.Value);
            parametros[42] = new SqlParameter("inicio1", c.Inicio1 == data ? (object)DBNull.Value : c.Inicio1); 
            parametros[43] = new SqlParameter("termino1", c.Termino1 == data ? (object)DBNull.Value : c.Termino1);
            parametros[44] = new SqlParameter("ocupacao1", c.Ocupacao1 ?? (object)DBNull.Value);
            parametros[45] = new SqlParameter("Atividades1", c.Atividades1 ?? (object)DBNull.Value);

            parametros[46] = new SqlParameter("empresa2", c.Empresa2 ?? (object)DBNull.Value);
            parametros[47] = new SqlParameter("inicio2", c.Inicio2 == data ? (object)DBNull.Value : c.Inicio2);
            parametros[48] = new SqlParameter("termino2", c.Termino2 == data ? (object)DBNull.Value : c.Termino2);
            parametros[49] = new SqlParameter("ocupacao2", c.Ocupacao2 ?? (object)DBNull.Value);
            parametros[50] = new SqlParameter("Atividades2", c.Atividades2 ?? (object)DBNull.Value);

            parametros[51] = new SqlParameter("empresa3", c.Empresa3 ?? (object)DBNull.Value);
            parametros[52] = new SqlParameter("inicio3", c.Inicio3 == data ? (object)DBNull.Value : c.Inicio3);
            parametros[53] = new SqlParameter("termino3", c.Termino3 == data ? (object)DBNull.Value : c.Termino3);
            parametros[54] = new SqlParameter("ocupacao3", c.Ocupacao3 ?? (object)DBNull.Value);
            parametros[55] = new SqlParameter("Atividades3", c.Atividades3 ?? (object)DBNull.Value);

            //Idiomas
            parametros[56] = new SqlParameter("idioma1", c.Idioma1 ?? (object)DBNull.Value);
            parametros[57] = new SqlParameter("nivelidioma1", c.Nivelidioma2 ?? (object)DBNull.Value);

            parametros[58] = new SqlParameter("idioma2", c.Idioma2 ?? (object)DBNull.Value);
            parametros[59] = new SqlParameter("nivelidioma2", c.Nivelidioma2 ?? (object)DBNull.Value);

            parametros[60] = new SqlParameter("idioma3", c.Idioma3 ?? (object)DBNull.Value);
            parametros[61] = new SqlParameter("nivelidioma3", c.Nivelidioma3 ?? (object)DBNull.Value);

            return parametros;
        }
        public void Inserir(CurriculoViewModel c)
        {
            string sql =
            "insert into Cadastro (CPF, nome, telefone, email, cargo, CEP, estado, cidade, bairro, rua, numero, curso1, escolaridade1, instituicao1, situacao1, conclusao1, periodo1, curso2, escolaridade2, instituicao2, situacao2, conclusao2, periodo2, curso3, escolaridade3, instituicao3, situacao3, conclusao3, periodo3, curso4, escolaridade4, instituicao4, situacao4, conclusao4, periodo4, curso5, escolaridade5, instituicao5, situacao5, conclusao5, periodo5, empresa1, inicio1, termino1, ocupacao1, Atividades1, empresa2, inicio2, termino2, ocupacao2, Atividades2, empresa3, inicio3, termino3, ocupacao3, Atividades3, idioma1, nivelidioma1, idioma2, nivelidioma2, idioma3, nivelidioma3)" +
            "values (@CPF, @nome, @telefone, @email, @cargo, @CEP, @estado, @cidade, @bairro, @rua, @numero, @curso1, @escolaridade1, @instituicao1, @situacao1, @conclusao1, @periodo1, @curso2, @escolaridade2, @instituicao2, @situacao2, @conclusao2, @periodo2, @curso3, @escolaridade3, @instituicao3, @situacao3, @conclusao3, @periodo3, @curso4, @escolaridade4, @instituicao4, @situacao4, @conclusao4, @periodo4, @curso5, @escolaridade5, @instituicao5, @situacao5, @conclusao5, @periodo5, @empresa1, @inicio1, @termino1, @ocupacao1, @Atividades1, @empresa2, @inicio2, @termino2, @ocupacao2, @Atividades2, @empresa3, @inicio3, @termino3, @ocupacao3, @Atividades3, @idioma1, @nivelidioma1, @idioma2, @nivelidioma2, @idioma3, @nivelidioma3)";
            HelperDAO.ExecutaSQL(sql, CriaParametros(c));
        }

        public void Excluir(string CPF)
        {
            string sql = "delete Cadastro where CPF =" + '\'' + CPF + '\'';
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
            "escolaridade1 = @escolaridade1," +
            "instituicao1 = @instituicao1," +
            "situacao1 = @situacao1," +
            "conclusao1 = @conclusao1," +
            "periodo1 = @periodo1," +
            "curso2 = @curso2," +                               //curso 2
            "escolaridade2 = @escolaridade2," +
            "instituicao2 = @instituicao2," +
            "situacao2 = @situacao2," +
            "conclusao2 = @conclusao2," +
            "periodo2 = @periodo2," +
            "curso3 = @curso3," +                               //curso 3
            "escolaridade3 = @escolaridade3," +
            "instituicao3 = @instituicao3," +
            "situacao3 = @situacao3," +
            "conclusao3 = @conclusao3," +
            "periodo3 = @periodo3," +
            "curso4 = @curso4," +                               //curso 4
            "escolaridade4 = @escolaridade4," +
            "instituicao4 = @instituicao4," +
            "situacao4 = @situacao4," +
            "conclusao4 = @conclusao4," +
            "periodo4 = @periodo4," +
            "curso5 = @curso5," +                               //curso 5
            "escolaridade5 = @escolaridade5," +
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
            string sql = "select * from Cadastro order by Nome";
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaCurriculo(registro));
            return lista;
        }

        public int ProximoCPF()
        {
            string sql = "select isnull(max(CPF) +1, 1) as 'MAIOR' from Cadastro";
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            return Convert.ToInt32(tabela.Rows[0]["MAIOR"]);
        }



        public CurriculoViewModel Consulta(string cpf)
        {
            string sql = "select * from Cadastro where cpf =" + '\'' + cpf + '\'';
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);

            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaCV(tabela.Rows[0]);
        }

        private CurriculoViewModel MontaCV(DataRow registro)
        {
            CurriculoViewModel cv = new CurriculoViewModel();
            //Dados Pessoais
            cv.Nome = registro["Nome"].ToString();
            cv.Cpf = registro["Cpf"].ToString();
            cv.Telefone = registro["Telefone"].ToString();
            cv.Email = registro["Email"].ToString();
            cv.Cargo = registro["Cargo"].ToString();

            //Endereço
            cv.Cep = registro["Cep"].ToString();
            cv.Estado = registro["Estado"].ToString();
            cv.Cidade = registro["Cidade"].ToString();
            cv.Bairro = registro["Bairro"].ToString();
            cv.Rua = registro["Rua"].ToString();
            cv.Numero = Convert.ToInt32(registro["Numero"]);

            // Cursos Acadêmicos 1
            cv.Curso1 = registro["Curso1"].ToString();
            cv.Escolaridade1 = registro["Escolaridade1"].ToString();
            cv.Instituicao1 = registro["Instituicao1"].ToString();
            cv.Situacao1 = registro["Situacao1"].ToString();
            cv.Conclusao1 = Convert.ToDateTime(registro["Conclusao1"]);
            cv.Periodo1 = registro["Periodo1"].ToString();
            // Cursos Acadêmicos 2
            cv.Curso2 = registro["Curso2"].ToString();
            cv.Escolaridade2 = registro["Escolaridade2"].ToString();
            cv.Instituicao2 = registro["Instituicao2"].ToString();
            cv.Situacao2 = registro["Situacao2"].ToString();
            cv.Conclusao2 = Convert.ToDateTime(registro["Conclusao2"]);
            cv.Periodo2 = registro["Periodo2"].ToString();
            // Cursos Acadêmicos 3
            cv.Curso3 = registro["Curso3"].ToString();
            cv.Escolaridade3 = registro["Escolaridade3"].ToString();
            cv.Instituicao3 = registro["Instituicao3"].ToString();
            cv.Situacao3 = registro["Situacao3"].ToString();
            cv.Conclusao3 = Convert.ToDateTime(registro["Conclusao3"]);
            cv.Periodo3 = registro["Periodo3"].ToString();
            // Cursos Acadêmicos 4
            cv.Curso4 = registro["Curso4"].ToString();
            cv.Escolaridade4 = registro["Escolaridade4"].ToString();
            cv.Instituicao4 = registro["Instituicao4"].ToString();
            cv.Situacao4 = registro["Situacao4"].ToString();
            cv.Conclusao4 = Convert.ToDateTime(registro["Conclusao4"]);
            cv.Periodo4 = registro["Periodo4"].ToString();
            // Cursos Acadêmicos 5
            cv.Curso5 = registro["Curso5"].ToString();
            cv.Escolaridade5 = registro["Escolaridade5"].ToString();
            cv.Instituicao5 = registro["Instituicao5"].ToString();
            cv.Situacao5 = registro["Situacao5"].ToString();
            cv.Conclusao5 = Convert.ToDateTime(registro["Conclusao5"]);
            cv.Periodo5 = registro["Periodo5"].ToString();


            //Experiencia 1
            cv.Empresa1 = registro["Empresa1"].ToString();
            cv.Inicio1 = Convert.ToDateTime(registro["Inicio1"]);
            cv.Termino1 = Convert.ToDateTime(registro["Termino1"]);
            cv.Ocupacao1 = registro["Ocupacao1"].ToString();
            cv.Atividades1 = registro["Atividades1"].ToString();
            //Experiencia 2
            cv.Empresa2 = registro["Empresa2"].ToString();
            cv.Inicio2 = Convert.ToDateTime(registro["Inicio2"]);
            cv.Termino2 = Convert.ToDateTime(registro["Termino2"]);
            cv.Ocupacao2 = registro["Ocupacao2"].ToString();
            cv.Atividades2 = registro["Atividades2"].ToString();
            //Experiencia 3
            cv.Empresa3 = registro["Empresa3"].ToString();
            cv.Inicio3 = Convert.ToDateTime(registro["Inicio3"]);
            cv.Termino3 = Convert.ToDateTime(registro["Termino3"]);
            cv.Ocupacao3 = registro["Ocupacao3"].ToString();
            cv.Atividades3 = registro["Atividades3"].ToString();

            //Idioma 1
            cv.Idioma1 = registro["Idioma1"].ToString();
            cv.Nivelidioma1 = registro["Nivelidioma1"].ToString();
            //Idioma 2
            cv.Idioma2 = registro["Idioma2"].ToString();
            cv.Nivelidioma2 = registro["Nivelidioma2"].ToString();
            //Idioma 3
            cv.Idioma3 = registro["Idioma3"].ToString();
            cv.Nivelidioma3 = registro["Nivelidioma3"].ToString();

            return cv;
        }
    }
}
