namespace sayilarin_ortalamasini_bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            double bolme = 0;
            for (int i = 1; i <= 30; i++)
            {
                toplam += i;
            }
            bolme = toplam / 30;
            Console.WriteLine(bolme);
            Console.ReadLine();
        }
    }
}
