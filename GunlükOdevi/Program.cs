namespace GunlükOdevi
{
    internal class Program
    {
        static string Soru (string soru)
        {
            Console.Write(soru);
            return Console.ReadLine();
        }
        class Gunluk
        {
            public string Baslik { get; set; }
            public DateOnly Tarih {  get; set; }
            public string Yazi {  get; set; }

        }
        static List<Gunluk> yazılanGunluk = new List<Gunluk>();
        static void Main(string[] args)
        {
            anaMenü:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Merhaba Günlük kayıt uygulamasına hoş geldiniz.");
            Console.WriteLine("=================================================");
            Console.Write("Lütfen Kullanıcı adı giriniz: ");
            string kullaniciAdi = Console.ReadLine();
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine($"Hoş Geldin {kullaniciAdi}");
                Console.WriteLine("===============================");
                Console.WriteLine("1- Yeni kayıt oluşturma");
                Console.WriteLine("2- Kayıtları görme");
                Console.WriteLine("3- Ana Menü");
                int secim = int.Parse(Soru("Seçimini: "));
                Console.ResetColor();
            if (secim == 1)
            {
                Console.Clear();
                Console.ForegroundColor= ConsoleColor.Magenta;
                Console.WriteLine($"Merhaba {kullaniciAdi} Yeni kayıt'a hoş geldin");
                Console.WriteLine("=============================================");
                Gunluk gunluk = new Gunluk();
                gunluk.Baslik = Soru("Başlık Giriniz: ");
                gunluk.Tarih = DateOnly.Parse(Soru("Tarih giriniz(30.12.2024): "));
                gunluk.Yazi = Soru("Yazınız: ");
                yazılanGunluk.Add(gunluk);
            }
            else if (secim == 2)
            {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine($"Merhaba {kullaniciAdi} geçmiş kayıt kısmı");
                    Console.WriteLine("=============================================");
                    Console.ResetColor();
                    foreach (Gunluk gunluk in yazılanGunluk)
                    {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($" BAŞLIK: {gunluk.Baslik}                                       TARİH: {gunluk.Tarih}");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("===========================================================================");
                    Console.WriteLine(gunluk.Yazi);
                    Console.WriteLine("===========================================================================");
                    }
                    Console.WriteLine("Ana menüye dönmek için bir tuşa basınız");
                    Console.ResetColor();
                    Console.ReadKey();
            }
            else
            {
                    goto anaMenü;
            }
            }



        }
    }
}
