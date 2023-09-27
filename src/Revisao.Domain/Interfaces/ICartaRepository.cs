using System.Collections.Generic;
using Revisao.Domain.Entities;

namespace Revisao.Domain.Interfaces
{
    public interface ICartaRepository
    {
        Carta AdicionarCarta(Carta carta);
        List<Carta> ListarCartas();
    }
}
