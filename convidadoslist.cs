using System;

class Program
{
    static void Main(string[] args)
    {
        // Isso cria uma lista para armazenar os nomes dos convidados
        List<string> convidados = new List<string>();

        // Adiciona alguns nomes à lista de convidados
        convidados.Add("Ana");
        convidados.Add("Bruno");
        convidados.Add("Carla");

        // Pede ao usuário para inserir um nome na lista de convidados
        Console.WriteLine("Digite um nome para adicionar à lista de convidados:");
        string novoConvidado = Console.ReadLine();

        // Adiciona o nome do novo convidado ao final da lista de convidados
        convidados.Add(novoConvidado);
        Console.WriteLine("O nome {0} foi adicionado à lista de convidados.", novoConvidado);

        // Exibe a lista de convidados
        Console.WriteLine("Lista de convidados:");
        foreach (string convidado in convidados)
        {
            Console.WriteLine(convidado);
        }
    }
}
