using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aprovacao();
            Console.WriteLine("");
            JogoSecreto();
            Console.ReadLine();

            void Aprovacao()
            {
                //Criar uma variável chamada notaMedia e atribua um valor inteiro a
                //ela. Caso seu valor seja maior ou igual a 5, escreva na tela "Nota
                //suficiente para aprovação".

                Console.Write("Digite a nota do aluno: ");
                string notaMedia = Console.ReadLine();
                int notaMediaNumerica = int.Parse(notaMedia);

                if (notaMediaNumerica >= 5)
                {
                    Console.WriteLine("Nota " + notaMediaNumerica + " suficiente para aprovação. Você foi aprovado.");
                }
                else
                {
                    Console.WriteLine("Nota " + notaMediaNumerica + " insuficiente para aprovação. Você foi reprovado.");
                }

            }

            void JogoSecreto()
            {
                Random aleatorio = new Random();
                int numeroSecreto = aleatorio.Next(1, 101);

                do
                {
                    Console.Write("Digite um número entre 1 e 100: ");
                    int chute = int.Parse(Console.ReadLine());


                    if (chute == numeroSecreto)
                    {
                        Console.WriteLine("Parabéns! Você acertou o número.");
                        break;
                    }
                    else if (chute < numeroSecreto)
                    {
                        Console.WriteLine("O número é maior.");
                    }
                    else
                    {
                        Console.WriteLine("O número é menor.");
                    }

                } while (true);

                Console.WriteLine("O jogo acabou. Você acertou o número secreto!");
            }
        }
    }
}
