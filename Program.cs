using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _8__Novo_Curso_de_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> listaDasBandas = new List<string> { "Black mice", "Icy cave", "Dark cave" };

            Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
            bandasRegistradas.Add("The Beatles", new List<int> { 10, 7, 6 });
            bandasRegistradas.Add("U2", new List<int> { 5, 8, 9 });

            ExibirMenuDeOpcoes();
            Console.ReadLine();

            void ExibirLogo()
            {
                string mensagem = (@"
███████╗███╗░░██╗███████╗██████╗░░██████╗░██╗░░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝████╗░██║██╔════╝██╔══██╗██╔════╝░╚██╗░██╔╝  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
█████╗░░██╔██╗██║█████╗░░██████╔╝██║░░██╗░░╚████╔╝░  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
██╔══╝░░██║╚████║██╔══╝░░██╔══██╗██║░░╚██╗░░╚██╔╝░░  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
███████╗██║░╚███║███████╗██║░░██║╚██████╔╝░░░██║░░░  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚══════╝╚═╝░░╚══╝╚══════╝╚═╝░░╚═╝░╚═════╝░░░░╚═╝░░░  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
                ");
                string mensagemDeBoasVindas = ("Boas Vindas ao Energy Sound.");
                Console.WriteLine(mensagem);
                Console.WriteLine(mensagemDeBoasVindas);
            }

            void ExibirMenuDeOpcoes()
            {
                ExibirLogo();
                Console.WriteLine("\nDigite 1 para registrar uma banda.");
                Console.WriteLine("Digite 2 para mostrar uma banda.");
                Console.WriteLine("Digite 3 para avaliar uma banda.");
                Console.WriteLine("Digite 4 para exibir a media de uma banda.");
                Console.WriteLine("Digite 5 para sair.");

                Console.Write("\nDigite uma opção: ");
                string opcaoEscolhida = Console.ReadLine();
                int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

                switch (opcaoEscolhidaNumerica)
                {
                    case 1:
                        RegistrarBanda();
                        break;
                    case 2:
                        MostrarBandasRegistradas();
                        break;
                    case 3:
                        AvaliarUmaBanda();
                        break;
                    case 4:
                        ExibirMedia();
                        break;
                    case 5:
                        Console.WriteLine("Tchau tchau :)");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                void TituloDasOpcoes(string titulo)
                {
                    int quantidadeDeLetras = titulo.Length;
                    string asteristicos = string.Empty.PadLeft(quantidadeDeLetras, '*');
                    Console.WriteLine(asteristicos);
                    Console.WriteLine(titulo);
                    Console.WriteLine(asteristicos + "\n");
                }

                void RegistrarBanda()
                {
                    Console.Clear();
                    TituloDasOpcoes("Registro das bandas");
                    Console.Write("\nDigite o nome da banda que deseja registrar: ");
                    string bandaRegistrada = Console.ReadLine();
                    bandasRegistradas.Add(bandaRegistrada, new List<int>());
                    Console.WriteLine($"Banda {bandaRegistrada} registrada com sucesso!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    ExibirMenuDeOpcoes();
                }
                void MostrarBandasRegistradas()
                {
                    Console.Clear();
                    TituloDasOpcoes("Exibindo as bandas registradas");
                    //for(int i = 0; i < listaDasBandas.Count; i++)
                    //{
                    //Console.WriteLine($"Banda: {listaDasBandas[i]}");
                    //}

                    foreach (string banda in bandasRegistradas.Keys)
                    {
                        Console.WriteLine($"Banda: {banda}");
                    }
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal.");
                    Console.ReadKey();
                    Console.Clear();
                    ExibirMenuDeOpcoes();
                }

                void AvaliarUmaBanda()
                {
                    Console.Clear();
                    TituloDasOpcoes("Avaliar banda");
                    Console.Write("Digite o nome da banda que deseja avaliar: ");
                    string nomeDaBanda = Console.ReadLine();
                    if (bandasRegistradas.ContainsKey(nomeDaBanda))
                    {
                        Console.Write($"Qual nota a banda {nomeDaBanda} merece: ");
                        int nota = int.Parse(Console.ReadLine());
                        bandasRegistradas[nomeDaBanda].Add(nota);
                        Console.WriteLine($"A nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}.");
                        Thread.Sleep(4000);
                        Console.Clear();
                        ExibirMenuDeOpcoes();
                    }
                    else
                    {
                        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
                        Console.WriteLine("Pressione uma tecla para voltar ao menu principal :)");
                        Console.ReadKey();
                        Console.Clear();
                        ExibirMenuDeOpcoes();
                    }
                }

                void ExibirMedia()
                {
                    Console.Clear();
                    TituloDasOpcoes("Exibir media de uma banda");
                    Console.Write("Digite o nome da banda que deseja ver a media: ");
                    string nomeDaBanda = Console.ReadLine();

                    if (bandasRegistradas.ContainsKey(nomeDaBanda))
                    {
                        List<int> notaDaBanda = bandasRegistradas[nomeDaBanda];
                        Console.WriteLine($"A media da banda {nomeDaBanda} e {notaDaBanda.Average()}");
                        Console.WriteLine("Pressione uma tecla para voltar ao menu principal :)");
                        Console.ReadKey();
                        Console.Clear();
                        ExibirMenuDeOpcoes();
                    }
                    else
                    {
                        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
                        Console.WriteLine("Pressione uma tecla para voltar ao menu principal :)");
                        Console.ReadKey();
                        Console.Clear();
                        ExibirMenuDeOpcoes();
                    }
                }
            }
        }
    }
}
