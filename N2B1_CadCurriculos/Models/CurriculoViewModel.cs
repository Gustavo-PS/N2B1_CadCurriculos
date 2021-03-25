using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N2B1_CadCurriculos.Models
{
    public class CurriculoViewModel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }

        //Endereço
        public int Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }

        //Dados de formação acadêmica e cursos
        public string Curso1 { get; set; }
        public string Escolaridade1 { get; set; }
        public string Instituicao1 { get; set; }
        public string Situacao1 { get; set; }
        public DateTime Conclusao1 { get; set; }
        public string Periodo1 { get; set; }

        public string Curso2 { get; set; }
        public string Escolaridade2 { get; set; }
        public string Instituicao2 { get; set; }
        public string Situacao2 { get; set; }
        public DateTime Conclusao2 { get; set; }
        public string Periodo2 { get; set; }

        public string Curso3 { get; set; }
        public string Escolaridade3 { get; set; }
        public string Instituicao3 { get; set; }
        public string Situacao3 { get; set; }
        public DateTime Conclusao3 { get; set; }
        public string Periodo3 { get; set; }

        public string Curso4 { get; set; }
        public string Escolaridade4 { get; set; }
        public string Instituicao4 { get; set; }
        public string Situacao4 { get; set; }
        public DateTime Conclusao4 { get; set; }
        public string Periodo4 { get; set; }

        public string Curso5 { get; set; }
        public string Escolaridade5 { get; set; }
        public string Instituicao5 { get; set; }
        public string Situacao5 { get; set; }
        public DateTime Conclusao5 { get; set; }
        public string Periodo5 { get; set; }

        //Dados de experiências profissionais anteriores
        public string Empresa1 { get; set; }
        public DateTime Inicio1 { get; set; }
        public DateTime Termino1 { get; set; }
        public string Ocupacao1 { get; set; }
        public string Atividades1 { get; set; }

        public string Empresa2 { get; set; }
        public DateTime Inicio2 { get; set; }
        public DateTime Termino2 { get; set; }
        public string Ocupacao2 { get; set; }
        public string Atividades2 { get; set; }

        public string Empresa3 { get; set; }
        public DateTime Inicio3 { get; set; }
        public DateTime Termino3 { get; set; }
        public string Ocupacao3 { get; set; }
        public string Atividades3 { get; set; }


        //Dados de idiomas
        public int Idioma1 { get; set; }
        public int Nivelidioma1 { get; set; }
        public int Idioma2 { get; set; }
        public int Nivelidioma2 { get; set; }
        public int Idioma3 { get; set; }
        public int Nivelidioma3 { get; set; }
    }
}
