namespace yas_hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Doğum Yılınızı Giriniz: ");
            int yas = Convert.ToInt32(Console.ReadLine());

            int yashesap = 2025 - yas;

            Console.WriteLine($"Yaşınız : {yashesap}");
            Console.ReadLine();
        }
    }
}
