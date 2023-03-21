using System;

class Program
{
    static void Main(string[] args)
    {
        // Cria um array para armazenar os nomes dos convidados
        string[] convidados = new string[10];

        // Adiciona alguns nomes à lista de convidados
        convidados[0] = "Ana";
        convidados[1] = "Bruno";
        convidados[2] = "Carla";

        // Pede ao usuário para inserir um nome na lista de convidados
        Console.WriteLine("Digite um nome para adicionar à lista de convidados:");
        string novoConvidado = Console.ReadLine();

        // Adiciona o nome do novo convidado ao final da lista de convidados
        int posicao = Array.IndexOf(convidados, null);
        if (posicao >= 0 && posicao < convidados.Length)
        {
            convidados[posicao] = novoConvidado;
            Console.WriteLine("O nome {0} foi adicionado à lista de convidados na posição {1}.", novoConvidado, posicao);
        }
        else
        {
            Console.WriteLine("Não há espaço suficiente na lista de convidados para adicionar {0}.", novoConvidado);
        }

        // Exibe a lista de convidados
        Console.WriteLine("Lista de convidados:");
        for (int i = 0; i < convidados.Length; i++)
        {
            if (convidados[i] != null)
            {
                Console.WriteLine(convidados[i]);
            }
        }
    }
}
