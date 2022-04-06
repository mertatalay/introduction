using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operatörler

            //Atama Operatörü =
            string degiskenbir = "değer bir";
            string degiskeniki = degiskenbir;

            //Mantıksal Operatörler
            // & -- ve
            //  | -- veya
            // && -- mutalk ve
            // || -- mutlak veya
            // ! -- değil


            //ilişkisel operatörler

            //  >     büyüktür
            //  <     küçüktür
            //  >=    büyük eşit
            //  <=    küçük eşit
            // ==   -- eşit eşittri
            // !=   -- eşit değil

            // Birleşik Operatörler

            //int sayibir = 5;
            //sayibir = sayibir + 5;

            // +=  -- Topla ve aktar
            // -=   -- çıkar ve aktar
            // *=   -- çarp ve aktar
            // /=  -- böl ve aktar

            // int sayiiki = 5;
            // sayibir += 5;

            //Arttırma Operatörleri
            //int toplam = 10;
            //toplam = 10 + 1;
            //toplam = toplam + 1;

            //toplam++
            //toplam--

            //vize notunun %30 final notunun %70 ini alıp öğrencinin not ortalamasını veren konsol uygılamasını yazın
            //vize 45
            //final 80


            /*float vize = 45;
            float final = 80;
            float ortalama = (vize * 30) / 100 + (final * 70) / 100;
            Console.WriteLine(ortalama);
            Console.ReadLine();
            */

            //consol a yazılan değer admin ise bize true değerini versin değilse false değerini versin

            Console.WriteLine("bir değer girin");
            string gelendeger=Console.ReadLine();
            bool result = gelendeger == "admin";
            Console.WriteLine(result);
            Console.ReadKey();























        }
    }
}
