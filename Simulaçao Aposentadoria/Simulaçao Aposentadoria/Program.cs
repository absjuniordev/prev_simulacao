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

            int idade, contri;
            string sexo, resp = ""; // usar aspas duplas para, mas em outro tipo de programação pode mudar


            do
            {
                Console.WriteLine("|=====PREVIDENCIAL SOCIAL=======|");
                Console.Write("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.Write("Digite tempo de contribuição: ");
                contri = int.Parse(Console.ReadLine());
                Console.Write("Digite o sexo [m/f]: ");
                sexo = Console.ReadLine();


                if (idade >= 62 && contri >= 15 && sexo == "f")
                {
                    Console.WriteLine("A senhora podera dar entrada na Aponsetadoria por idade");
                    Console.WriteLine("|==============================|");
                }
                else if (idade >= 65 && contri >= 20 && sexo == "m")
                {

                    Console.WriteLine("O senhor podera dar entrada na Aponsetadoria por idade");
                    Console.WriteLine("|----------------------------------------------------|");
                }
                else if (idade <= 65 && contri < 15 && sexo == "f" || sexo == "m")
                {
                    Console.WriteLine("Sem direito para aposntadoria po idade.");
                }
                else
                {
                    Console.WriteLine("|---------------------------|");
                    Console.WriteLine("Reveja os dados digitados");
                    Console.WriteLine("|---------------------------|");
                }
                Console.WriteLine("|==============================|");
                Console.Write("Deseja continuar? [s/]n]");
                resp = Console.ReadLine();
                Console.Clear();
            }
            while (resp != "n");


        }
    }
}
