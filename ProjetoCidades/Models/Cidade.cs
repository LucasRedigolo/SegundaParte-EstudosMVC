using System.Collections.Generic;

namespace ProjetoCidades.Models {
    public class Cidade {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Estado { get; set; }
        public int Habitantes { get; set; }
        public List<Cidade> ListarCidades () {
            
            List<Cidade> cid = new List<Cidade> () {
                new Cidade { ID = 10, Nome = "Curitiba", Estado = "PR", Habitantes = 2331 },
                new Cidade { ID = 21, Nome = "Leme", Estado = "SP", Habitantes = 3123 },
                new Cidade { ID = 231, Nome = "Porto Alegre", Estado = "RS", Habitantes = 48734 },
                new Cidade { ID = 42, Nome = "Campinas", Estado = "SP", Habitantes = 94 },
                new Cidade { ID = 32, Nome = "Vitória", Estado = "ES", Habitantes = 6262 },
                new Cidade { ID = 69, Nome = "Florianópolis", Estado = "SC", Habitantes = 94218 }
            };
            return cid;
        }
    }
}