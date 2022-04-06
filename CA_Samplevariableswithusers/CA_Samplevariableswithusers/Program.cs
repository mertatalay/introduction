using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Samplevariableswithusers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan almış olduğumuz bilgileri aşağıda tanımlanan değişkenlere aktarın
            //değişkinler
            string ad = "";
            string soyad = string.Empty;
            string adres = "";
            string boy = "";
            string kilo = "";
            string yas = "";
            string tc = "";
            string telno = "";



            //console

            Console.WriteLine("kullanıcı bilgi platformuna hoşgeldiniz");
            Console.WriteLine("lütfen aşağıdaki bilgileri doldurun");
            Console.WriteLine("adınızı giriniz");
            ad = Console.ReadLine();
            Console.WriteLine("soyadınız giriniz");
            soyad = Console.ReadLine();
            Console.WriteLine("adresinizi giriniz");
            adres = Console.ReadLine();
            Console.WriteLine("boyunuzu giriniz");
            boy = Console.ReadLine();
            Console.WriteLine("kilonuzu giriniz");
            kilo = Console.ReadLine();
            Console.WriteLine("yaşınızı giriniz");
            yas = Console.ReadLine();
            Console.WriteLine("tc giriniz");
            tc = Console.ReadLine();
            Console.WriteLine("telefon giriniz");
            telno = Console.ReadLine();
            Console.WriteLine("adınız:" + ad);
            Console.WriteLine("soyadınız:" + soyad);
            Console.WriteLine("adresiniz:" + adres);
            Console.WriteLine("boyunuz:" + boy);
            Console.WriteLine("kilonuz:" + kilo);
            Console.WriteLine("yaşınız:" + yas);
            Console.WriteLine("tc:" + tc);
            Console.WriteLine("telefon numaranız:" + telno);
            Console.Read();

            //console.writelan("adınız:"+ad+"\n"+"soyadını:"+soyad+"\n");
            //  \n bir alt satıra atar


            //writelan içerisinde bulunan değerleri bir değişkene atayarak da yapabiliriz.
            string ozet = "adınız:" + ad + "\n" + "soyadını:" + soyad + "\n";
            Console.WriteLine(ozet);
            Console.Read();





        }
    }
}
