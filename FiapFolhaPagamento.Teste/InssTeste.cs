using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapFolhaPagamento.Teste
{
    public class InssTeste
    {
        [Fact]
        public void Deveria_Aplicar_Faixa_1()
        {
            // Arrange: configurar para o teste
            var inss = new Inss();
            //1412.00 - 7.5% = 105.9
            var desconto = inss.CalcularDesconto(1412);

            //Assert: verifica se a asserção 
            Assert.Equal(105.9m, desconto);
        }
    }
}
