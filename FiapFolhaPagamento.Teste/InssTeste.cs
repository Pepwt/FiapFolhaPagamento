﻿using System;
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

        [Fact]
        public void Deveria_Aplicar_Faixa_2()
        {
            const decimal salario = 2100.00m;
            const decimal descontoEsperado = 167.82m;
            var inss = new Inss();
            //1412.00 * 7.5% = 105.9
            //(2100.00 - 1412)  * 0,09 = 688,00 * 00,09 = 61,92
            // 105,9 + 61,92 = 167,82
            var desconto = inss.CalcularDesconto(salario);
            Assert.Equal(descontoEsperado, desconto);
        }
    }
}
