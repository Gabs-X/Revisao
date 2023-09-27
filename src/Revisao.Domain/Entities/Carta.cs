using Revisao.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Entities
{
    public class Carta
    {
            public int Id { get; set; }
            public string NomeCrianca { get; set; }
            public EnderecoModel Endereco { get; set; }
            public int IdadeCrianca { get; set; }
            public string TextoCarta { get; set; }
           
       }
}
