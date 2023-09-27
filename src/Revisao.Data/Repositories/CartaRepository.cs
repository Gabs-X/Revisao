using System.Collections.Generic;
using System.IO;
using System.Linq;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using Newtonsoft.Json;

namespace Revisao.Data.Repositories
{
        public class CartaRepository : ICartaRepository
        {
            private readonly string _filePath = "cartas.json";

            public Carta AdicionarCarta(Carta carta)
            {
                var cartas = ListarCartas();
                carta.Id = cartas.Any() ? cartas.Max(c => c.Id) + 1 : 1;
                cartas.Add(carta);
                File.WriteAllText(_filePath, JsonConvert.SerializeObject(cartas));
                return carta;
            }

            public List<Carta> ListarCartas()
            {
                if (File.Exists(_filePath))
                {
                    var json = File.ReadAllText(_filePath);
                    return JsonConvert.DeserializeObject<List<Carta>>(json) ?? new List<Carta>();
                }
                return new List<Carta>();
            }
        }
}


