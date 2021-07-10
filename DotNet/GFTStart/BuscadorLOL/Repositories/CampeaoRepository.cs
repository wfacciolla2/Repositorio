using BuscadorLOL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuscadorLOL.Repositories
{
    public class CampeaoRepository : ICampeaoRepository
    {
        private static Dictionary<Guid, Campeao> campeoes = new Dictionary<Guid, Campeao>()
        {
            {Guid.Parse("0ca314a5-9282-45d8-92c3-2985f2a9fd04"), new Campeao{ Id = Guid.Parse("0ca314a5-9282-45d8-92c3-2985f2a9fd04"), Nome = "AATROX", Funcao = "LUTADOR", Preco = 999} },
            {Guid.Parse("eb909ced-1862-4789-8641-1bba36c23db3"), new Campeao{ Id = Guid.Parse("eb909ced-1862-4789-8641-1bba36c23db3"), Nome = "AHRI", Funcao = "MAGO", Preco = 500} },
            {Guid.Parse("5e99c84a-108b-4dfa-ab7e-d8c55957a7ec"), new Campeao{ Id = Guid.Parse("5e99c84a-108b-4dfa-ab7e-d8c55957a7ec"), Nome = "GAREN", Funcao = "TANQUE", Preco = 700} },
            {Guid.Parse("da033439-f352-4539-879f-515759312d53"), new Campeao{ Id = Guid.Parse("da033439-f352-4539-879f-515759312d53"), Nome = "ASHE", Funcao = "ATIRADOR", Preco = 150} },
            {Guid.Parse("92576bd2-388e-4f5d-96c1-8bfda6c5a268"), new Campeao{ Id = Guid.Parse("92576bd2-388e-4f5d-96c1-8bfda6c5a268"), Nome = "BARDO", Funcao = "SUPORTE", Preco = 480} },
            {Guid.Parse("c3c9b5da-6a45-4de1-b28b-491cbf83b589"), new Campeao{ Id = Guid.Parse("c3c9b5da-6a45-4de1-b28b-491cbf83b589"), Nome = "NIDALE", Funcao = "SELVA", Preco = 970} }
        };

        public Task<List<Campeao>> Obter(int pagina, int quantidade)
        {
            return Task.FromResult(campeoes.Values.Skip((pagina - 1) * quantidade).Take(quantidade).ToList());
        }

        public Task<Campeao> Obter(Guid id)
        {
            if (!campeoes.ContainsKey(id))
                return null;

            return Task.FromResult(campeoes[id]);
        }

        public Task<List<Campeao>> Obter(string nome, string funcao)
        {
            return Task.FromResult(campeoes.Values.Where(campeao => campeao.Nome.Equals(nome) && campeao.Funcao.Equals(funcao)).ToList());
        }

        public Task<List<Campeao>> ObterSemLambda(string nome, string funcao)
        {
            var retorno = new List<Campeao>();

            foreach (var campeao in campeoes.Values)
            {
                if (campeao.Nome.Equals(nome) && campeao.Funcao.Equals(funcao))
                    retorno.Add(campeao);
            }

            return Task.FromResult(retorno);
        }

        public Task Inserir(Campeao campeao)
        {
            campeoes.Add(campeao.Id, campeao);
            return Task.CompletedTask;
        }

        public Task Atualizar(Campeao campeao)
        {
            campeoes[campeao.Id] = campeao;
            return Task.CompletedTask;
        }
        public Task Remover(Guid id)
        {
            campeoes.Remove(id);
            return Task.CompletedTask;
        }

        public void Dispose()
        {

        }
    }
}
