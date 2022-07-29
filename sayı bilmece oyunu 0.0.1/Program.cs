using System;

namespace sayı_bilmece_oyunu_0._0._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); //r a s t g e l e
            int theholynumber = 0;
            string diff = "Null";
            int guess;
            int guesses;
            bool playagain = false;
            int min = 1;
            int max = 100;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("stinkypooprobux'un Sayı Bilmece Oyunu");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("  ");
            Console.WriteLine("stinkypooprobux'un Sayı Bilmece Oyunu'na hoşgeldin!");
            Console.WriteLine("  ");

            do
            {
                try
                {

                    Console.WriteLine("Bir zorluk seç: (E : Kolay, N : Normal, H : Zor, I : Deli, P : Neredeyse İmkansız)");
                    diff = "Null";


                    switch (Console.ReadLine())
                    {
                        case "E":
                            diff = "Kolay";
                            Console.WriteLine("Zorluk Kolay olarak belirlendi.");
                            max = 100;
                            playagain = true;
                            break;

                        case "N":
                            diff = "Normal";
                            Console.WriteLine("Zorluk Normal olarak belirlendi.");
                            max = 1000;
                            playagain = true;
                            break;

                        case "H":
                            diff = "Zor";
                            Console.WriteLine("Zorluk Zor olarak belirlendi.");
                            max = 10000;
                            playagain = true;
                            break;

                        case "I":
                            diff = "Deli";
                            Console.WriteLine("Zorluk Deli olarak belirlendi.");
                            max = 100000;
                            playagain = true;
                            break;

                        case "P":
                            diff = "Neredeyse İmkansız";
                            Console.WriteLine("Zorluk Neredeyse İmkansız olarak belirlendi.");
                            max = 1000000;
                            playagain = true;
                            break;

                        default:
                            Console.WriteLine("[!!!UYARI!!!] Böyle bir şey seçemezsin!");
                            break;
                    }

                    while (playagain)
                    {
                        guess = 0;
                        guesses = 0;
                        theholynumber = random.Next(min, max + 1);

                        while (guess != theholynumber)
                        {
                            Console.WriteLine("");
                            Console.WriteLine($"{min} ile {max} arasında bir sayı tahmin et!");
                            guess = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Tahmin: " + guess);

                            if (guess > theholynumber)
                            {
                                Console.WriteLine(guess + " çok yüksek!");
                            }
                            else if (guess < theholynumber)
                            {
                                Console.WriteLine(guess + " çok düşük!");
                            }
                            guesses++;
                        }
                        Console.WriteLine("----------------------");
                        Console.WriteLine(diff + $" zorlukta {guesses} defa deneyerek kazandın!");
                        Console.WriteLine("Sayı: " + theholynumber);
                        playagain = false;
                    }



                } //çökmeyi önleyen şeyin sonu
                catch (FormatException)
                {
                    Console.WriteLine("[!!!HATA!!!] Böyle bir şey yazamazsın! Yeniden dene!");
                }
                catch (Exception)
                {
                    Console.WriteLine("[!!!HATA!!!] Hata! Yeniden dene!");
                }

                Console.WriteLine("Yeniden denemek ister misin?"); //oyunun sonu :(
                Console.WriteLine("E : Evet");
                Console.WriteLine("H : Hayır");
            } while (Console.ReadLine().ToUpper() == "E");

                Console.WriteLine("");
                Console.WriteLine("Oynadığın için teşekkürler, sanırım.");
                Console.WriteLine("");

            Console.ReadKey();
        }
    }
}