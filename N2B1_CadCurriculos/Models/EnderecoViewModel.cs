using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N2B1_CadCurriculos.Models
{
    public class EnderecoViewModel
    {
        public string pais { get; set; }
        public int cep { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }
        public string bairo { get; set; }
        public string rua { get; set; }
        public int numero { get; set; }
    }
}
