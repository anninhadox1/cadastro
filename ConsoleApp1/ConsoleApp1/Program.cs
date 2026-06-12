using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            while (opcao != 4)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"
░██████╗██╗░██████╗████████╗███████╗███╗░░░███╗░█████╗░  ██████╗░███████╗
██╔════╝██║██╔════╝╚══██╔══╝██╔════╝████╗░████║██╔══██╗  ██╔══██╗██╔════╝
╚█████╗░██║╚█████╗░░░░██║░░░█████╗░░██╔████╔██║███████║  ██║░░██║█████╗░░
░╚═══██╗██║░╚═══██╗░░░██║░░░██╔══╝░░██║╚██╔╝██║██╔══██║  ██║░░██║██╔══╝░░
██████╔╝██║██████╔╝░░░██║░░░███████╗██║░╚═╝░██║██║░░██║  ██████╔╝███████╗
╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚══════╝╚═╝░░░░░╚═╝╚═╝░░╚═╝  ╚═════╝░╚══════╝

░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░");
                Console.ResetColor();
                Console.WriteLine(""\n Seja muito bem vindo!\n"");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n 1 - Cadastro de Animes");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n 2 - Cadastro de Supers");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n 3 - Cadastro de séries");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n 4 - Cadastro de locadora de VHS");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n 5 - Cadastro de oficina mecânica");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n 6 - Cadastro de livros");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n 7 - Cadastro de restaurante cardapio");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n 8 - Cadastro de jogos");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n 9 - Cadastro de músicas");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n 10 - SAIR");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n Digite a opção escolhida: ");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:   cadastroanimes();
                        break;

                    case 2: cadastrosupers();
                        break;

                    case 3:// cadastroseries();
                        break;

                    case 4: //cadastrolocadoravhs();
                        break;

                    case 5: //cadastrooficinamecanica();
                        break;

                    case 6:// cadastrolivros();
                        break;

                    case 7://cadastrorestaurantecardapio();
                        break;

                    case 8:// cadastrojogos();                          
                        break;

                    case 9://cadastromusicas();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n opcao escolhida: ");
                        Console.ResetColor();
                        Thread.Sleep(1000);
                        break;

                }

            }
        }
        static void cadastroanimes()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

░█████╗░███╗░░██╗██╗███╗░░░███╗███████╗░██████╗
██╔══██╗████╗░██║██║████╗░████║██╔════╝██╔════╝
███████║██╔██╗██║██║██╔████╔██║█████╗░░╚█████╗░
██╔══██║██║╚████║██║██║╚██╔╝██║██╔══╝░░░╚═══██╗
██║░░██║██║░╚███║██║██║░╚═╝░██║███████╗██████╔╝
╚═╝░░╚═╝╚═╝░░╚══╝╚═╝╚═╝░░░░░╚═╝╚══════╝╚═════╝░");
            Console.WriteLine("\n Digite o título do anime: ");
            string tituloAnimes = Console.ReadLine();

            Console.WriteLine("\n Digite a qnt de episodios: ");
            double qntAnimes = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Digite o ano do anime: ");
            string anoAnime = Console.ReadLine();

            Console.WriteLine("\n Digite o personagem principal: ");
            string personagemAnime = Console.ReadLine();

            Console.WriteLine("\n Digite a clasificacao do anime: ");
            string classificacaoAnime = Console.ReadLine();

            Console.WriteLine("\n Digite a categoria: ");
            string categoriaAnime = Console.ReadLine();

            Console.WriteLine("\n Digite a avaliacao do anime: ");
            string avaliacaoAnime = Console.ReadLine();


        }
    


static void cadastrosupers()
{

    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ░██████╗██╗░░░██╗██████╗░███████╗██████╗░░██████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔════╝██║░░░██║██╔══██╗██╔════╝██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ╚█████╗░██║░░░██║██████╔╝█████╗░░██████╔╝╚█████╗░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ░╚═══██╗██║░░░██║██╔═══╝░██╔══╝░░██╔══██╗░╚═══██╗
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝╚██████╔╝██║░░░░░███████╗██║░░██║██████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░░╚═════╝░╚═╝░░░░░╚══════╝╚═╝░░╚═╝╚═════╝░");

            Console.WriteLine("\n Digite o nome poder : ");
            string nomesupers = Console.ReadLine();

            Console.WriteLine("\n Digite o apelido do poder : ");
            double apelidosupers = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Digite: ");
            string anoAnime = Console.ReadLine();

            Console.WriteLine("\n Digite o personagem principal: ");
            string personagemAnime = Console.ReadLine();

            Console.WriteLine("\n Digite a clasificacao do anime: ");
            string classificacaoAnime = Console.ReadLine();

            Console.WriteLine("\n Digite a categoria: ");
            string categoriaAnime = Console.ReadLine();

            Console.WriteLine("\n Digite a avaliacao do anime: ");
            string avaliacaoAnime = Console.ReadLine();

        }








    }
}





