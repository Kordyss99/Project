namespace fibonaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = 0, s2 = 1, fib;
            for (int s3 = 0; s3 < 20; s3++)
            {
                Console.WriteLine(s1 + " ");
                fib = s1 + s2;
                s1 = s2;
                s2 = fib;
            }
            
        }
    }
}
