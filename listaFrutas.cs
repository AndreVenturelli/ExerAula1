using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaFrutas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pede uma lista de frutas para o usuario
            Console.Write("Digite uma lista de frutas separadas por vírgula: ");
            string entrada = Console.ReadLine();

            // Divide a entrada em frutas separadas por vírgula
            string[] frutas = entrada.Split(',');

            // Cria uma lista vazia para armazenar frutas 
            List<string> frutasLista = new List<string>();

            foreach (string fruta in frutas)
            {
                // Converte a fruta para minúsculo e remove possíveis espaços "errados"
                string frutaF = fruta.Trim().ToLower();

                // Verifica se a fruta já existe na lista
                if (!frutasLista.Contains(frutaF))
                {
                    // Adiciona a fruta na lista
                    frutasUnicas.Add(frutaF);
                }
            }

            // Cria uma lista para armazenar as frutas
            List<string> frutasF = new List<string>();

            foreach (string frutasLista in frutasLista)
            {
                // Deixa a lista mais bonita, corrigindo a escrita
                string frutasF = char.ToUpper(frutasLista[0]) + frutasLista.Substring(1);

                // Adiciona a fruta na lista "FrutaF"
                frutasF.Add(frutasF);
            }

            // Mostra as frutas
            Console.WriteLine("Frutas:");
            foreach (string frutasF in frutassF)
            {
                Console.WriteLine(frutaFormatada);
            }
        }
    }
}
