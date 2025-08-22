﻿using Shared;

var response = string.Empty;
do
{
    try
    {
        var number1 = ConsoleExtensions.GetInt("Ingrese primer número: ");
        var number2 = ConsoleExtensions.GetInt("Ingrese segundo número: ");
        var number3 = ConsoleExtensions.GetInt("Ingrese tercer número: ");

        if (number1 > number2 && number1 > number3)
        {
            Console.WriteLine($"El número mayor es: {number1}");
        }
        else if (number2 > number1 && number2 > number3)
        {
            Console.WriteLine($"El número mayor es: {number2}");
        }
        else if (number3 > number1 && number3 > number2)
        {
            Console.WriteLine($"El número mayor es: {number3}");
        }
        else
        {
            Console.WriteLine("Los números son iguales o no se pudo determinar un único mayor.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.Write("Desea continuar [S/N]? ");
    response = Console.ReadLine()!.ToUpper();
} while (response == "S");