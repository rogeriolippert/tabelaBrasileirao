using System;
using Xunit;
using tabelabrasileirao

namespace test
{
    class EquipeTest
    {
        [Fact]
        public void EquipeTest()
        {
            Equipe equipe = new Equipe("Internacional", 10);
            Assert.Equal("Internacional", equipe.nome);
            Assert.Equal(10, equipe.pontuacao);

        }
    }
}