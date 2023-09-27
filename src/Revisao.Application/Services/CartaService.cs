using AutoMapper;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
//using Revisao.Domain.Entities;
//using Revisao.Domain.Interfaces;

namespace Revisao.Application.Services
{
    public class CartaService : ICartaService
        {
            private readonly ICartaRepository _cartaRepository;
            private readonly IMapper _mapper;

            public CartaService(ICartaRepository cartaRepository, IMapper mapper)
            {
                _cartaRepository = cartaRepository;
                _mapper = mapper;
            }

            public CartaModel EnviarCartinha(NovaCartaModel novaCarta)
            {
                var carta = _mapper.Map<NovaCartaModel, Carta>(novaCarta);
                var cartaAdicionada = _cartaRepository.AdicionarCarta(carta);
                return _mapper.Map<Carta, CartaModel>(cartaAdicionada);
            }

            public List<CartaModel> ListarCartinhas()
            {
                var cartas = _cartaRepository.ListarCartas();
                return _mapper.Map<List<Carta>, List<CartaModel>>(cartas);
            }
        }
    

}
