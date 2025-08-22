namespace Shared;

    public class ConsoleExtensions
    {
        public static int GetInt(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            if (int.TryParse(input, out int result))
            {
                return result;
            }

            throw new Exception("El valor ingresado no es un número entero válido.");
        }
    }