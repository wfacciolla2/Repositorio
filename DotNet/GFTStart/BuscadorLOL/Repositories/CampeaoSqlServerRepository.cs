using BuscadorLOL.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BuscadorLOL.Repositories
{
    public class CampeaoSqlServerRepository : ICampeaoRepository
    {
        private readonly SqlConnection sqlConnection;

        public CampeaoSqlServerRepository(IConfiguration configuration)
        {
            sqlConnection = new SqlConnection(configuration.GetConnectionString("Default"));
        }

        public async Task<List<Campeao>> Obter(int pagina, int quantidade)
        {
            var campeoes = new List<Campeao>();

            var comando = $"select * from leagueOfLegends order by id offset {((pagina - 1) * quantidade)} rows fetch next {quantidade} rows only";

            await sqlConnection.OpenAsync();
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            SqlDataReader sqlDataReader = await sqlCommand.ExecuteReaderAsync();

            while (sqlDataReader.Read())
            {
                campeoes.Add(new Campeao
                {
                    Id = (Guid)sqlDataReader["Id"],
                    Nome = (string)sqlDataReader["Nome"],
                    Funcao = (string)sqlDataReader["Funcao"],
                    Preco = (float)sqlDataReader["Preco"]
                });
            }

            await sqlConnection.CloseAsync();

            return campeoes;
        }

        public async Task<Campeao> Obter(Guid id)
        {

            Campeao campeao = null;

            var comando = $"select * from leagueOfLegends where Id = '{id}'";

            await sqlConnection.OpenAsync();
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            SqlDataReader sqlDataReader = await sqlCommand.ExecuteReaderAsync();

            while (sqlDataReader.Read())
            {
                campeao = new Campeao
                {
                    Id = (Guid)sqlDataReader["Id"],
                    Nome = (string)sqlDataReader["Nome"],
                    Funcao = (string)sqlDataReader["Funcao"],
                    Preco = (float)sqlDataReader["Preco"]
                };
            }

            await sqlConnection.CloseAsync();

            return campeao;
        }

        public async Task<List<Campeao>> Obter(string nome, string funcao)
        {
            var campeoes = new List<Campeao>();

            var comando = $"select * from leagueOfLegends where Nome = '{nome}' and Funcao = '{funcao}'";
            await sqlConnection.OpenAsync();
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            SqlDataReader sqlDataReader = await sqlCommand.ExecuteReaderAsync();

            while (sqlDataReader.Read())
            {
                campeoes.Add(new Campeao
                {
                    Id = (Guid)sqlDataReader["Id"],
                    Nome = (string)sqlDataReader["Nome"],
                    Funcao = (string)sqlDataReader["Funcao"],
                    Preco = (float)sqlDataReader["Preco"]
                });
            }

            await sqlConnection.CloseAsync();

            return campeoes;
        }

        public async Task Inserir(Campeao campeao)
        {
            var comando = $"insert leagueOfLegends (Id, Nome, Funcao, Preco) values ('{campeao.Id}', '{campeao.Nome}', '{campeao.Funcao}', {campeao.Preco.ToString().Replace(",", ".")})";

            await sqlConnection.OpenAsync();
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            await sqlConnection.CloseAsync();
        }

        public async Task Atualizar(Campeao campeao)
        {
            var comando = $"update leagueOfLegends set Nome = '{campeao.Nome}', Funcao = '{campeao.Funcao}', Preco = {campeao.Preco.ToString().Replace(",", ".")} where Id = '{campeao.Id}'";

            await sqlConnection.OpenAsync();
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            await sqlConnection.CloseAsync();
        }
        public async Task Remover(Guid id)
        {
            var comando = $"delete from leagueOfLegends where Id = '{id}'";

            await sqlConnection.OpenAsync();
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            await sqlConnection.CloseAsync();
        }
        public void Dispose()
        {
            sqlConnection?.Close();
            sqlConnection?.Dispose();
        }

    }
}
