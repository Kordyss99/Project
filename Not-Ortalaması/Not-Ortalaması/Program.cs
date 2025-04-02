using System.Diagnostics;

namespace Not_Ortalaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan 3 tane not alan ve bu notların ortalamasını bul
            // 80 - 100 arasındaysa A+
            // 60 - 80 arasındaysa A
            // 40 - 60 Arasındaysa B+
            // 40 dan küçükse F


            //Kullanıcıdan Not alma
            Console.Write("Notunuzu Girin : ");
            int not1 = Convert.ToInt32(Console.ReadLine());
            int not2 = Convert.ToInt32(Console.ReadLine());
            int not3 = Convert.ToInt32(Console.ReadLine());

            //3 NOTU TOPLAYIP 3'E BÖLEREK ORTALAMA ALMA
            int ort = (not1 + not2 + not3) / 3;
            // 80 - 100 arasındaysa A+
            if (ort >= 80 && ort <= 100)
            {
                Console.Clear();
                Console.WriteLine("A+");
            }
            // 60 - 80 arasındaysa A
            else if (ort >= 60 && ort <= 80)
            {
                Console.Clear();
                Console.WriteLine("A");
            }
            // 40 - 60 Arasındaysa B+
            else if (ort >= 40 && ort <= 60)
            {
                Console.Clear();
                Console.WriteLine("B+");
            }
            // 40 dan küçükse F
            else
            {
                Console.WriteLine("F");
            }

        }
    }
}
