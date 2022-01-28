using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulaçao_Aposentadoria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int idade, tempoContribuicao, anoNascimento;
            string nomeUsuario, sexo, resp = ""; 


            do
            {
            
                Console.WriteLine("|======== INSS Simulação de Aposentadoria Por idade ========|");
                Console.Write("| Informe seu nome: ");
                nomeUsuario = Console.ReadLine();
                Console.Write("| Digite o ano de nacimento com quatro digitos: ");               
                anoNascimento = int.Parse(Console.ReadLine());
                Console.Write("| Digite tempo de contribuição: ");
                tempoContribuicao = int.Parse(Console.ReadLine());
                Console.Write("| Qual o seu sexo [m/f]: ");
                sexo = Console.ReadLine();
                Console.WriteLine("|===========================================================|");
                idade = 2022 - anoNascimento;

                if (idade >= 62 && tempoContribuicao >= 15 && sexo == "f")
                {
                    Console.WriteLine("|-----------------------------------------------------------------|");
                    Console.WriteLine($"| {nomeUsuario} a sra podera dar entrada na Aponsetadoria por idade |");
                    Console.WriteLine("|-----------------------------------------------------------------|");
                }
                else if (idade >= 65 && tempoContribuicao >= 20 && sexo == "m")
                {
                    Console.WriteLine("|-----------------------------------------------------------------|");
                    Console.WriteLine($"| {nomeUsuario} o sr podera dar entrada na Aponsetadoria por idade  |");
                    Console.WriteLine("|-----------------------------------------------------------------|");
                }
                else if (idade <= 65 && tempoContribuicao < 15 && sexo == "f" || sexo == "m")
                {
                    Console.WriteLine("|--------------------------------------------------------------------|");
                    Console.WriteLine("| Sem direito para aposntadoria por idade.                           |");
                    Console.WriteLine("|--------------------------------------------------------------------|");
                }
                else
                {
                    Console.WriteLine("|---------------------------|");
                    Console.WriteLine("| Reveja os dados digitados");
                    Console.WriteLine("|---------------------------|");
                }
                
                Console.Write("|\t\tDeseja continuar? [s/]n:");
                
                resp = Console.ReadLine();
                Console.Clear();
            }
            while (resp != "n");


        }
    }
}
