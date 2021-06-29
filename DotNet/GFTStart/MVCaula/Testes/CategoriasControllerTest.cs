using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIaula.Controllers;
using Microsoft.EntityFrameworkCore;
using Moq;
using MVCaula.Models;
using Xunit;

namespace Testes
{
    public class CategoriasControllerTest
    {
        private readonly Mock<DbSet<Categoria>> mockSet;
        private readonly Mock<Context> mockContext;
        private readonly Categoria categoria;
        public CategoriasControllerTest()
        {
            mockSet = new Mock<DbSet<Categoria>>();
            mockContext = new Mock<Context>();
            categoria = new Categoria { Id = 1, Descricao = "Teste de Categoria" };
            mockContext.Setup(m => m.Categorias).Returns(mockSet.Object);
            mockContext.Setup(m => m.Categorias.FindAsync(1)).ReturnsAsync(categoria);
        }

        [Fact]
        public async Task GetCategoria()
        {
            var service = new CategoriasController(mockContext.Object);
            await service.GetCategoria(1);

            mockSet.Verify(m => m.FindAsync(1), Times.Once());
        }
    }
}
