using ApiCatalogoOficinas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoOficinas.Repository
{
    public class OficinaRepository : IOficinaRepository
    {
        private static Dictionary<Guid, Oficina> oficinas = new Dictionary<Guid, Oficina>()
        {
            {Guid.Parse("0ca374a-5-9282-45d8-92c3-2985f2a9fd04"), new Oficina{ Id = Guid.Parse("0ca374a-5-9282-45d8-92c3-2985f2a9fd04"), Nome = "Mecânica do Almir", Endereco = "Rua do meio, Parque São Jorge", Descricao = "Focada em funilaria e pequenos reparos", Estrelas = 4.8 } },
            {Guid.Parse("1ba123v-7-6598-gtav-1c25-265s2sdsd45a"), new Oficina{ Id = Guid.Parse("1ba123v-7-6598-gtav-1c25-265s2sdsd45a"), Nome = "Auto Elétrica do Assis", Endereco = "Rua da feira, Centro", Descricao = "Nosso maior foco é a parte elétrica do seu automovel", Estrelas = 4.9 } },
            {Guid.Parse("15sad15-9-2545-sad1-1sda-minecraft154"), new Oficina{ Id = Guid.Parse("15sad15-9-2545-sad1-1sda-minecraft154"), Nome = "Oficina Automatica", Endereco = "Rua da pedra mole, São Judas", Descricao = "Oficina para todo o tipo de reparo, atendemos todos os seguros", Estrelas = 3.1} }
        };

        public Task<List<Oficina>> Obter(int pagina, int quantidade)
        {
            return Task.FromResult(oficinas.Values.Skip((pagina - 1) * quantidade).Take(quantidade).ToList());
        }

        public Task<Oficina> Obter(Guid id)
        {
            if (!oficinas.ContainsKey(id))
                return null;

            return Task.FromResult(oficinas[id]);
        }

        public Task<List<Oficina>> Obter(string nome, string descricao)
        {
            return Task.FromResult
                (oficinas.Values.Where(oficina => oficina.Nome.Equals(nome) && oficina.Descricao.Equals(descricao)).ToList());
        }

        public Task<List<Oficina>> ObterSemLambda(string nome, string descricao)
        {
            var retorno = new List<Oficina>();

            foreach (var oficina in oficinas.Values)
            {
                if (oficina.Nome.Equals(nome) && oficina.Descricao.Equals(descricao))
                    retorno.Add(oficina);
            }

            return Task.FromResult(retorno);
        }

        public Task Inserir(Oficina oficina)
        {
            oficinas.Add(oficina.Id, oficina);
            return Task.CompletedTask;
        }

        public Task Atualizar(Oficina oficina)
        {
            oficinas[oficina.Id] = oficina;
            return Task.CompletedTask;
        }

        public Task Remover(Guid id)
        {
            oficinas.Remove(id);
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            //Fechar conexão com o banco
        }

    }
}
