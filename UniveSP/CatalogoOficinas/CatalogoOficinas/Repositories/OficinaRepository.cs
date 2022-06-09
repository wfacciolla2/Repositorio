using CatalogoOficinas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CatalogoOficinas.Repositories
{

    public class OficinaRepository : IOficinaRepository
    {
        private static Dictionary<Guid, Oficina> oficinas = new Dictionary<Guid, Oficina>()
        {
            {Guid.Parse("8185d868-dd94-4ebb-ab0c-5f3581af329e"), new Oficina{ Id = Guid.Parse("8185d868-dd94-4ebb-ab0c-5f3581af329e"), Nome = "Mecânica do Almir", Endereco = "Rua do meio, Parque São Jorge", Descricao = "Focada em funilaria e pequenos reparos",Cnpj = "40", Estrelas = 4.8 } },
            {Guid.Parse("d606d520-58af-460a-a385-935fa5c5783d"), new Oficina{ Id = Guid.Parse("d606d520-58af-460a-a385-935fa5c5783d"), Nome = "Auto Elétrica do Assis", Endereco = "Rua da feira, Centro", Descricao = "Nosso maior foco é a parte elétrica do seu automovel",Cnpj = "40", Estrelas = 4.9 } },
            {Guid.Parse("9c1b5f2d-2a5d-4656-8d18-d54b196058e9"), new Oficina{ Id = Guid.Parse("9c1b5f2d-2a5d-4656-8d18-d54b196058e9"), Nome = "Oficina Automatica", Endereco = "Rua da pedra mole, São Judas", Descricao = "Oficina para todo o tipo de reparo, atendemos todos os seguros",Cnpj = "40", Estrelas = 3.1} }
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

        public Task<List<Oficina>> Obter(string nome, string cnpj)
        {
            return Task.FromResult(oficinas.Values.Where(oficina => oficina.Nome.Equals(nome) && oficina.Cnpj.Equals(cnpj)).ToList());
        }
        public Task<List<Oficina>> ObterSemLambda(string nome, string cnpj)
        {
            var retorno = new List<Oficina>();

            foreach (var oficina in oficinas.Values)
            {
                if (oficina.Nome.Equals(nome) && oficina.Cnpj.Equals(cnpj))
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

        }
    }
}
