namespace beden_kitle_indeksi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Beden kitle indeksi = kilo / boy*boy
            //beden kitle indeksi 18e eşit veya düşükse zayıf
            //18 ile 25 arasındaysa normal
            //25'ten büyükse obez

            // Kilo giriş
            Console.Write("Kilonuzu girin (kg): ");
            double kilo = Convert.ToDouble(Console.ReadLine());

            // Boy giriş
            Console.Write("Boyunuzu girin (metre cinsinden, örn: 1.75): ");
            double boy = Convert.ToDouble(Console.ReadLine());

            // Vücut Kitle İndeksi (BMI) hesaplama
            double bmi = kilo / (boy * boy);

            Console.WriteLine($"Vücut Kitle İndeksiniz: {bmi:F2}");

            // BMI'ye göre durum belirleme
            if (bmi < 18.5)
            {
                Console.WriteLine("Durum: Zayıf");
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                Console.WriteLine("Durum: Normal");
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                Console.WriteLine("Durum: Kilolu");
            }
            else
            {
                Console.WriteLine("Durum: Obez");
            }

            Console.ReadLine();
        }
    }
}
    }
}
