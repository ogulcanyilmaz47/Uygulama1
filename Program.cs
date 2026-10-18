using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_1
{
namespace OduncSuresiKontrol
    {
        class Program
        {
            static void Main(string[] args)
            {

                bool ekipmanOduncte = false;

                Console.WriteLine("--- Ekipman Ödünç Sistemi ---");


                if (ekipmanOduncte)
                {
                    Console.WriteLine("HATA: Bu ekipman şu an başkasında. Talebiniz reddedildi!");
                    return;
                }

                Console.Write("Kaç günlüğüne alacaksın?");
                string kullaniciGirisi = Console.ReadLine();


                if (int.TryParse(kullaniciGirisi, out int gunSayisi))
                {

                    if (gunSayisi >= 1 && gunSayisi <= 7)
                    {
                        Console.WriteLine($"İşlem tamam! Ekipmanı {gunSayisi} günlüğüne aldın.");
                    }
                    else
                    {
                        Console.WriteLine("HATA: Sadece 1 ile 7 gün arasında alabilirsin. Talebiniz reddedildi.");
                    }
                }
                else
                {
                    Console.WriteLine("HATA: Talebiniz reddedildi.");
                }

                Console.ReadKey();
            }
        }
    }
}
    

