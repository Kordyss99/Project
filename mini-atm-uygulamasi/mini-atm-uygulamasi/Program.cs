namespace mini_atm_uygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıya Soracağız nasıl bir işlem yapmalı
            //1- Bakiye Görüntüleme
            //2- Para Çekme
            //3- Para Yatırma
            //4- q ya basarsa çıkış yaptıracağız
            //---------------------------------------------------------------------

            //Bakiye
            int bakiye = 5254;

            long tc = 12345678911;
            int sifre = 1;
            //Güvenlik TC ve Sifre
            Console.Write("TC Kimlik Numaranızı giriniz: ");
            long musteri = Convert.ToInt64(Console.ReadLine());
            Console.Write("Şifrenizi Giriniz: ");
            int musterisifre = Convert.ToInt32(Console.ReadLine());
            //Doğrulama
            if (musteri == tc && musterisifre == sifre)
            {
               //Karşılama Ekranı
                Console.Clear();
                Console.WriteLine("Hoşgeldiniz - Kordyss99 / Bakiyeniz - 5254");
                Console.WriteLine("* bakiye Görüntülemek için 1 Tuşuna Basınız");
                Console.WriteLine("* Para Çekmek İçin 2 Tuşuna Basınız");
                Console.WriteLine("* Para Yatırmak için 3 Tuşuna Basınız");
                Console.WriteLine("* Çıkış Yapmak için 4 Tuşuna Basınız");
                Console.WriteLine("");
                Console.Write("Lütfen Seçim Yapmak için bir sayı giriniz: ");
                int say = Convert.ToInt32(Console.ReadLine());
                //Eğer 1 dersek
                if (say == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Bakiyeniz: " + bakiye);
                }
                //Eğer 2 Dersek
                else if (say == 2)
                {
                    Console.Clear();
                    Console.Write("Çekmek istediğniz tutarı giriniz :");
                    int cek = Convert.ToInt32(Console.ReadLine());
                    if (cek >= bakiye)
                    {
                        Console.WriteLine($"Güncel Bakiyeniz : {bakiye - cek}");
                    }
                    else
                    {
                        Console.WriteLine("Ögrencimisiniz ?");
                    }
                }
                //Eğer 3 dersek
                else if (say == 3)
                {
                    Console.Clear();
                    Console.Write("Yatırmak istediğniz tutarı giriniz :");
                    int yatır = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Güncel Bakiyeniz : {bakiye + yatır}");
                }
                //Eğer 4 Dersek
                else if (say == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Güvenli Çıkış Yapıldı");
                }
                else
                {
                    Console.WriteLine("Yanlış Değer");
                }
            }
            else
            {
                Console.WriteLine("YANLIŞ DEĞER GİRDİNİZ");
            }

            Console.ReadLine();
        }
    }
}
