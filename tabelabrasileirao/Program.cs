using System;

namespace tabelabrasileirao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabela Brasileirão");
            Console.WriteLine("Insira sua opção: ");
            ConsoleKeyInfo a;
            Campeonato campeonato = new Campeonato();
            do
            {   Console.Write("Selecione a sua opção (F2) para add ou (F3) para imprimir: \n");
                a = Console.ReadKey();//.key;

                if (a.Key == ConsoleKey.F2){
                    System.Console.WriteLine("#Adicionando uma nova equipe");
                    System.Console.WriteLine("Digite o nome da equipe: ");

                     string nome = Console.ReadLine();
                    System.Console.WriteLine("Digite a pontuacao: "); 
                    string pontuacao = Console.ReadLine();
                    campeonato.equipe.Add(new Equipe(nome, Int32.Parse(pontuacao)));
                   
                }
            }while (a.Key != ConsoleKey.F3);
                System.Console.WriteLine("Listando o resultado");  
                campeonato.ordenaPontuacao();
                campeonato.resultado();

                System.Console.WriteLine(campeonato.equipe.Count);
        }
    }
}
