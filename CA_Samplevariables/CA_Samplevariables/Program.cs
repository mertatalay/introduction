using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Samplevariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ad
            //soyad
            //adres
            //boy
            //kilo
            //yaş
            //ehliyet var mı?
            //eğitim durumu
            //ayakkabı numarası
            //ev kira mı?
            //aylık kira bedeli
            //tc no
            //tel no
            //en sevdiğini yemek
            //en son ödediğiniz fatura

            string ad = "mert";
            string soyad = "atalay";
            string adres = "istanbul";
            float boy = 1.98f;
            short kilo = 83;
            byte yas = 34;
            bool ehliyet_varmi = true;
            string egitim_durumu = "üniversite";
            byte ayakkabi_no = 43;
            bool ev_kirami = false;
            decimal aylikkira = 0;
            string tc = "24333532562";
            string telno = "783657326835";
            string ensevyemek = "musakka";
            decimal fatura = 110.45m;

            Console.WriteLine("ad:"+ad);
            Console.WriteLine("soyad:"+soyad);
            Console.WriteLine("adres:"+adres);
            Console.WriteLine("boy:"+boy);
            Console.WriteLine("kilo:"+kilo);
            Console.WriteLine("yas:"+yas);
            Console.WriteLine("ehliyet:"+ehliyet_varmi);
            Console.WriteLine("ayakkabi:"+ayakkabi_no);
            Console.WriteLine("ev durumu:"+ev_kirami);
            Console.WriteLine("aylik kira:" + aylikkira);
            Console.WriteLine("tc:" + tc);
            Console.WriteLine("tel no:" + telno);
            Console.WriteLine("en sevdiğim yemek:" + ensevyemek);
            Console.WriteLine("fatura:" + fatura);

            Console.Read();




        }
    }
}
