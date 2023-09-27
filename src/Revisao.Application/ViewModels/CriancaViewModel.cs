using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.ViewModels
{
    public class CriancaViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int NumeroCasa { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Carta { get; set; }
    }
}
