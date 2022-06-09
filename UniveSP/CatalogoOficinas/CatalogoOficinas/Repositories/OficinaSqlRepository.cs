using CatalogoOficinas.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoOficinas.Repositories
{
    public class OficinaSqlServerRepository : IOficinaRepository
    {
        private const double Star = 0.0;
        private readonly SqlConnection sqlConnection;

        public OficinaSqlServerRepository(IConfiguration configuration)
        {
            sqlConnection = new SqlConnection(configuration.GetConnectionString("Default"));
        }

        public async Task<List<Oficina>> Obter(int pagina, int quantidade)
        {
            var oficinas = new List<Oficina>();

            var comando = $"select * from Catalogo order by id offset {((pagina - 1) * quantidade)} rows fetch next {quantidade} rows only";

            await sqlConnection.OpenAsync();
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            SqlDataReader sqlDataReader = await sqlCommand.ExecuteReaderAsync();

            while (sqlDataReader.Read())
            {
                oficinas.Add(new Oficina
                {
                    Id = (Guid)sqlDataReader["id"],
                    Nome = (string)sqlDataReader["Nome"],
                    Endereco = (string)sqlDataReader["Endereco"],
                    Descricao = (string)sqlDataReader["Descricao"],
                    Cnpj = (string)sqlDataReader["Cnpj"],
                    Estrelas = (Double)sqlDataReader["Estrelas"]
                });
            }

            await sqlConnection.CloseAsync();

            return oficinas;
        }

        public async Task<Oficina> Obter(Guid id)
        {
            Oficina oficina = null;

            var comando = $"select * from Catalogo where Id = '{id}'";

            await sqlConnection.OpenAsync();
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            SqlDataReader sqlDataReader = await sqlCommand.ExecuteReaderAsync();

            while (sqlDataReader.Read())
            {
                oficina = new Oficina
                {
                    Id = (Guid)sqlDataReader["id"],
                    Nome = (string)sqlDataReader["Nome"],
                    Endereco = (string)sqlDataReader["Endereco"],
                    Descricao = (string)sqlDataReader["Descricao"],
                    Cnpj = (string)sqlDataReader["Cnpj"],
                    Estrelas = (Double)sqlDataReader["Estrelas"]
                };
            }
            await sqlConnection.CloseAsync();

            return oficina;
        }

        public async Task<List<Oficina>> Obter(string nome, string cnpj)
        {
            var oficinas = new List<Oficina>();

            var comando = $"select * from Catalogo where Nome = '{nome}' and Cnpj = '{cnpj}'";

            await sqlConnection.OpenAsync();
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            SqlDataReader sqlDataReader = await sqlCommand.ExecuteReaderAsync();

            while (sqlDataReader.Read())
            {
                oficinas.Add(new Oficina
                {
                    Id = (Guid)sqlDataReader["id"],
                    Nome = (string)sqlDataReader["Nome"],
                    Endereco = (string)sqlDataReader["Endereco"],
                    Descricao = (string)sqlDataReader["Descricao"],
                    Cnpj = (string)sqlDataReader["Cnpj"],
                    Estrelas = (Double)sqlDataReader["Estrelas"]
                });
            }

            await sqlConnection.CloseAsync();

            return oficinas;
        }

        public async Task Inserir(Oficina oficina)
        {
            var comando = $"insert Catalogo (Id, Nome, Endereco, Descricao, Cnpj, Estrelas) values ('{oficina.Id}','{oficina.Nome}','{oficina.Endereco}','{oficina.Descricao}','{oficina.Cnpj}','{oficina.Estrelas = Star}')";

            await sqlConnection.OpenAsync();
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            await sqlConnection.CloseAsync();
        }

        public async Task Atualizar(Oficina oficina)
        {
            var comando = $"update Catalogo set Nome = '{oficina.Nome}', Endereco ='{oficina.Endereco}', Descricao ='{oficina.Descricao}' where Id ='{oficina.Id}'";
            
            await sqlConnection.OpenAsync();
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            await sqlConnection.CloseAsync();
        }

        public async Task Remover(Guid id)
        {
            
            var comando = $"delete from Catalogo where Id = '{id}'";

            await sqlConnection.OpenAsync();
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            await sqlConnection.CloseAsync();

            //System.InvalidOperationException: The connection was not closed. The connection's current state is open.
        }

        public void Dispose()
        {
            sqlConnection?.Close();
            sqlConnection?.Dispose();
        }
    }
}
