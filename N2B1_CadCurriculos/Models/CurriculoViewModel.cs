using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N2B1_CadCurriculos.Models
{
    public class CurriculoViewModel
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string cargo { get; set; }

        //Endereço
        public int cep { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }
        public string bairo { get; set; }
        public string rua { get; set; }
        public int numero { get; set; }

        //Dados de formação acadêmica e cursos
        public string curso1 { get; set; }
        public string escolaridade1 { get; set; }
        public string instituicao1 { get; set; }
        public string situacao1 { get; set; }
        public DateTime conclusao1 { get; set; }
        public string periodo1 { get; set; }


        public string curso2 { get; set; }
        public string escolaridade2 { get; set; }
        public string instituicao2 { get; set; }
        public string situacao2 { get; set; }
        public DateTime conclusao2 { get; set; }
        public string periodo2 { get; set; }

        public string curso3 { get; set; }
        public string escolaridade3 { get; set; }
        public string instituicao3 { get; set; }
        public string situacao3 { get; set; }
        public DateTime conclusao3 { get; set; }
        public string periodo3 { get; set; }

        public string curso4 { get; set; }
        public string escolaridade4 { get; set; }
        public string instituicao4 { get; set; }
        public string situacao4 { get; set; }
        public DateTime conclusao4 { get; set; }
        public string periodo4 { get; set; }

        public string curso5 { get; set; }
        public string escolaridade5 { get; set; }
        public string instituicao5 { get; set; }
        public string situacao5 { get; set; }
        public DateTime conclusao5 { get; set; }
        public string periodo5 { get; set; }

        //Dados de experiências profissionais anteriores
        public string empresa1 { get; set; }
        public DateTime inicio1 { get; set; }
        public DateTime termino1 { get; set; }
        public int ocupacao1 { get; set; }
        public string atividades1 { get; set; }

        public string empresa2 { get; set; }
        public DateTime inicio2 { get; set; }
        public DateTime termino2 { get; set; }
        public int ocupacao2 { get; set; }
        public string atividades2 { get; set; }

        public string empresa3 { get; set; }
        public DateTime inicio3 { get; set; }
        public DateTime termino3 { get; set; }
        public int ocupacao3 { get; set; }
        public string atividades3 { get; set; }


        //Dados de idiomas
        public int idioma1 { get; set; }
        public int nivelidiota1 { get; set; }

        public int idioma2 { get; set; }
        public int nivelidiota2 { get; set; }

        public int idioma3 { get; set; }
        public int nivelidiota3 { get; set; }
    }
}
