using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliquota.Domain    
{
    class Program
    {     
        static void Main(string[] args)
        {

            double rendimentoCDI = 0.0275f;
            double valorAplicacao = 1000;
            double valorResgate;
            double valorLucro;
            double IR;
            double IRumAno = 0,225;
            double IRumadoisAnos = 0,185;
            double IRAcimadoisAnos = 0,15;
            DateTime dataAplicacao, dataAtual;
            TimeSpan resultado;
           
            dataAplicacao = new DateTime(2020, 08, 30);
            dataAtual = new DateTime(2021,08,30);
            resultado = dataAtual.Subtract(dataAplicacao);
            //não consegui converter em número de dias para calcular os periodos: 1 ano, 2 anos....


            if (dataAtual < dataAplicacao)
            {
                Console.WriteLine("Desculpe, periodo inválido para fazer resgate");
                Console.ReadLine();

            }
                 else if (valorAplicacao <= 0) {
               
                     Console.WriteLine("Desculpe, você não possui valor aplicado");
                     Console.ReadLine();

                 }else{
                     Console.WriteLine("Informe o valor a ser resgatado?");
                     valorResgate = double.Parse(Console.ReadLine());
                        if (resultado <= 365)
                        {
                            valorLucro = valorAplicacao * rendimentoCDI;
                            IR = valorLucro * IRumAno;
                            Console.WriteLine("Esse é o valor de recolhimento do IR: " + IR);
                            Console.ReadLine();
                        }
                            else if ((resultado > 365) && (resultado < 730){
                                valorLucro = valorAplicacao * rendimentoCDI;
                                IR = valorLucro * IRumadoisAnos;
                                Console.WriteLine("Esse é o valor de recolhimento do IR: " + IR);
                                Console.ReadLine();
                            }
                                    else
                                    {
                                        valorLucro = valorAplicacao * rendimentoCDI;
                                        valorLucro = valorAplicacao * rendimentoCDI;
                                        IR = valorLucro * IRAcimadoisAnos;
                                        Console.WriteLine("Esse é o valor de recolhimento do IR: " + IR);
                                        Console.ReadLine();
                                    }
            }
        }

          
    }
}
