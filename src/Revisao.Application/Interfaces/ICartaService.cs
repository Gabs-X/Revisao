using System.Collections.Generic;
using Revisao.Application.ViewModels;

namespace Revisao.Application.Interfaces
{
        public interface ICartaService
        {
            CartaModel EnviarCartinha(NovaCartaModel novaCarta);
            List<CartaModel> ListarCartinhas();
        }
    

}
