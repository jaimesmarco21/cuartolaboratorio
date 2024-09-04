using System;
class Program
{
    static void Main()
    {
        int n = 5; // Número de niveles de la pirámide
        for (int i = 1; i <= n; i++)
        {
            // Imprimir espacios
            for (int j = n; j > i; j--)
            {
                Console.Write(" ");
            }
            // Imprimir asteriscos
            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }
            // Nueva línea
            Console.WriteLine();
        }

    }
}