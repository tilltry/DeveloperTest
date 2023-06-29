namespace Library
{
    public class ZadanieOne
    {
        private static int n;
        private static string result;
        public static void One()
        {
            try
            {
                Console.Write("Введите число N: ");
                n = int.Parse(Console.ReadLine());
                if (n >= 1)
                {
                    result = string.Join(",", Enumerable.Range(1, n)) + '.';
                    Console.WriteLine(result);
                }
                else
                {
                    Console.Write("Неверный ввод");
                }
            }
            catch
            {
                Console.Write("Неверный ввод");
            }
            
        }
    }
    public class ZadanieTwo
    {
        private static int n;
        public static void Two()
        {
            try
            {
                Console.Write("Введите нечетное число N: ");
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0 || n < 3) // If N is an even number, exit the function.
                {
                    Console.Write("Неверный ввод");
                    return;
                }
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (row == n / 2 && col == n / 2)
                        {
                            Console.Write(" ");
                        }
                        else Console.Write("#");
                    }
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.Write("Неверный ввод");
            }
           
            
        }
    }
}
