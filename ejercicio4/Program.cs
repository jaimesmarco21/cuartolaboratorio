using System;
class program
{
    static void Main()
    {
        int numero;
        int contador = 0;

        do
        {
            Console.WriteLine("Ingresa un número(Negativo para cerrar el programa)");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                contador++;
            }
        } while (numero>=0);

        Console.WriteLine("Total de numeros positivos ingresados" + contador);
    }
}
