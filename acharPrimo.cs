using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (IsPrime(numero))
        {
            Console.WriteLine(numero + " é um número primo.");
        }
        else
        {
            Console.WriteLine(numero + " não é um número primo.");
        }
    }

    public bool IsPrime(int numero)
    {
        if (numero <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
