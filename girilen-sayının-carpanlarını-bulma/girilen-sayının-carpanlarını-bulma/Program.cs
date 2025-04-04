namespace girilen_sayının_carpanlarını_bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz: ");
            int say = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Bu sayının çarpanları: ");

            for (int i = 1; i<=say; i++)
            {
                if (say % i == 0) 
                {
                    Console.Write(i + " - ");
                }
            }
            Console.ReadLine();
        }
    }
}
