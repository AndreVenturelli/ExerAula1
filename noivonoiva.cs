using System;

namespace ComparacaoDeConvidados
{
    class Program
    {
        static void Main(string[] args)
        {
            int convidadosNoivo = 100;
            int convidadosNoiva = 120;
            int convidados = convidadosNoiva + convidadosNoivo;

            int presentesNoivo = 80;
            int presentesNoiva = 110;
            int presentes = presentesNoivo + presentesNoiva;

            // use o operador condicional "==" para comparar o número de convidados do noivo e da noiva
            if (convidadosNoivo == convidadosNoiva)
            {
                Console.WriteLine("O número de convidados do noivo e da noiva é o mesmo.");
            }
            else
            {
                Console.WriteLine("O número de convidados do noivo e da noiva é diferente.");
            }

            // use o operador condicional ">" para comparar o número de convidados presentes do noivo e da noiva
            if (presentesNoivo > presentesNoiva)
            {
                Console.WriteLine("O noivo teve mais convidados presentes do que a noiva.");
            }
            else if (presentesNoiva > presentesNoivo)
            {
                Console.WriteLine("A noiva teve mais convidados presentes do que o noivo.");
            }
            else
            {
                Console.WriteLine("O número de convidados presentes do noivo e da noiva é o mesmo.");
            }

            if (presentes == convidados){
                Console.WriteLine("Nenhum convidado faltou.");
            }
            else if (presentes > convidados){
                Console.WriteLine("Houve penetras")
            }

            else (presentes < convidado){
                Console.WriteLine("Houve ausência de convidados.")
            }
        }
    }
}