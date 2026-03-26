using System.Xml;

namespace DiamanteDeX.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            int diamondSize = GetValidInt();
            Console.WriteLine();
            for (int i = 0; i < diamondSize; i++)
            {
                int space = Math.Abs(diamondSize / 2 - i);
                Console.WriteLine(new string(' ', space + 3) + new string('X', diamondSize - 2 * space));
            }
            if (!Continue()) break;
            Console.Clear();
        }
    }
    public static bool Continue()
    {
        Console.WriteLine("\nPressione ENTER para fazer novamente ou ESC para sair…\n");
        while (true)
        {
            ConsoleKey key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.Enter: return true;
                case ConsoleKey.Escape: return false;
                default: break;
            }
        }
    }
    public static int GetValidInt()
    {
        while (true)
        {
            Console.Write("Digite um número ímpar > ");
            if (int.TryParse(Console.ReadLine(), out int number) && number % 2 != 0) return number;
            else Console.WriteLine("Entrada inválida, tente novamente.");
        }
    }
}
