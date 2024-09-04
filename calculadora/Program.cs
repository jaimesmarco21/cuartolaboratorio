using System;

class Program
{
    static void Main()
    {
        double num1, num2, resultado = 0;
        char operador;

        Console.WriteLine("Calculadora Simple en C#");

        // Ingreso del primer número
        Console.Write("Ingresa el primer número: ");
        num1 = double.Parse(Console.ReadLine());

        // Ingreso del operador
        Console.Write("Ingresa un operador (+, -, *, /): ");
        operador = Console.ReadKey().KeyChar;
        Console.WriteLine();  // Para mover a la siguiente línea después del operador

        // Ingreso del segundo número
        Console.Write("Ingresa el segundo número: ");
        num2 = double.Parse(Console.ReadLine());

        // Selección de la operación
        switch (operador)
        {
            case '+':
                resultado = num1 + num2;
                break;
            case '-':
                resultado = num1 - num2;
                break;
            case '*':
                resultado = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: No se puede dividir entre cero.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Operador no válido.");
                return;
        }

        // Mostrar el resultado
        Console.WriteLine($"Resultado: {num1} {operador} {num2} = {resultado}");
    }
}
