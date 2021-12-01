using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_ClassEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Kisi ft = new Kisi();
                ft.Adi = "faik";
                ft.DenemeTelNo = "8562549652xzcxfg++++";
                ft.DogumTarihi = new DateTime(1978, 07, 20);
                ft.Soyadi = "turan";
                ft.Yas = 43;
                ft.TelefonNumarasi = "1234567890";

                Console.WriteLine(ft.Adi);
                Console.WriteLine(ft.Soyadi);
                Console.WriteLine(ft.DogumTarihi);
                Console.WriteLine(ft.DenemeTelNo);
                Console.WriteLine(ft.TelefonNumarasi);
                Console.WriteLine(ft.Yas);
            }
            catch (Exception ex)
            {
                Console.WriteLine("HATA oluştu.");
                Console.WriteLine(ex.Message);
                
            }

            Console.ReadKey();
        }
    }
}
