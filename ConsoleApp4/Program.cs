using System;
using System.Linq;

namespace ConsoleApp4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Agenda[] contatos = new Agenda[5];
            int opcao = 0, indice = 0;

            while (opcao != 4)
            {
                Console.WriteLine("---- Menu ----");
                Console.WriteLine("1 - Inserir Contato");
                Console.WriteLine("2 - Imprimir os Contatos");
                Console.WriteLine("3 - Buscar Contato");
                Console.WriteLine("4 - Sair");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    if (indice < 5)
                    {
                        Console.Write("nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("telefone: ");
                        string telefone = Console.ReadLine();
                        Console.Write("idade: ");
                        int idade = int.Parse(Console.ReadLine());
                        Console.Write("sexo: ");
                        string sexo = Console.ReadLine();

                        Agenda contato = new Agenda(nome, telefone, idade, sexo);
                        contatos[indice] = contato;
                        indice++;
                    }
                    else
                    {
                        Console.WriteLine("Agenda cheia!");
                    }
                }
                else if (opcao == 2)
                {
                    for (int x = 0; x < indice; x++)
                    {
                        Console.WriteLine($"\nnome: {contatos[x].Nome}\ntelefone: {contatos[x].Telefone}\nidade: {contatos[x].Idade}\nsexo: {contatos[x].Sexo}\n");
                    }
                }
                else if (opcao == 3)
                {
                    Console.Write("Buscar nome: ");
                    string nome = Console.ReadLine();

                    for (int x = 0; x < indice; x++)
                    {
                        if (contatos[x].Nome == nome)
                        {
                            Console.WriteLine($"nome: {contatos[x].Nome}\ntelefone: {contatos[x].Telefone}\nidade: {contatos[x].Idade}\nsexo: {contatos[x].Sexo}\n");
                        }
                    }
                }
                else if (opcao == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção não encontrada!");
                }
            }
        }
    }
}
