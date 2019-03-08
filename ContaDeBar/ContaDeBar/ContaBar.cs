using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaDeBar
{
    public class ContaBar
    {
        public decimal Total;
        public int QtdPessoas;
        public decimal PorcGarcom;
        public decimal TotalPessoa;
        public decimal ValorUnitario;
        public int Quantidade;


        public ContaBar()
        {
            Total = 0;
            QtdPessoas = 1;
            PorcGarcom = 0.10M;
        }

        public void AdicionaCompra(bool garcom)
        {     
            if(garcom == true)
            {
                Total += (ValorUnitario * Quantidade) / QtdPessoas;
                Math.Round(Total += (Total * PorcGarcom), 2);
            }   
            else
            {
                Math.Round(Total += (ValorUnitario * Quantidade) / QtdPessoas, 2);
            }


        }

        public void CalculoPorPessoa()
        {
            Math.Round(TotalPessoa = Total / QtdPessoas, 2);
        }

    }

}
