namespace cift_sayilarin_toplami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam=0;
            for (int i = 0; i <= 30; i += 2)
            {
                toplam += i;

            }
            Console.WriteLine($"Toplam {toplam}");
        }
    }
}
