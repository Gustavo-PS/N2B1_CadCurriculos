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
        public EnderecoViewModel endereco { get; set; }

        public string curso1 { get; set; }
        public int nivelEscolar1 { get; set; }
        public string instituicao1 { get; set; }
        public int situacao1 { get; set; }
        public DateTime conclusao1 { get; set; }
        public string periodoEscolar1 { get; set; }

        public string empresa1 { get; set; }
        public DateTime inicio1 { get; set; }
        public DateTime termino1 { get; set; }
        public int ocupacao1 { get; set; }
        public string atividades1 { get; set; }

        public int idioma1 { get; set; }
        public int c_idiota1 { get; set; }

        public string conhecimento1 { get; set; }
        public int nivel1 { get; set; }
    }
}
