namespace doviz_hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dolar = 37.89;
            double euro = 41.97;
            double sterlin = 49.74;


            double d;
            //Ekrana Birimleri yazdırdık
            Console.WriteLine("Dolar");
            Console.WriteLine("Euro");
            Console.WriteLine("Sterlin");

            Console.Write("Para Biriminiz Nedir ?: ");
            string? para = Console.ReadLine();

            switch(para)
            {
                //Kullanıcı Dolar Seçerse
                case "Dolar":
                case "dolar":
                    Console.Write("Ne kadar paranız var?: ");
                    d = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Dolar Kurunda Paranızın Karşılığı: {d*dolar}");
                    break;
                //Kullanıcı Euro Seçerse
                case "Euro":
                case "euro":
                    Console.Write("Ne kadar paranız var?: ");
                    d = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Dolar Kurunda Paranızın Karşılığı: {d * euro}");
                    break;
                //Kullanıcı Sterlin Seçerse
                case "Sterlin":
                case "sterlin":
                    Console.Write("Ne kadar paranız var?: ");
                    d = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Dolar Kurunda Paranızın Karşılığı: {d * sterlin}");
                    break;
                    
            }
            


        }
    }
}
