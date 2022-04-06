using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Convert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Convert(tip dönüşümleri)
            /* veri tipleri arasında tip dönüşümü gerçekleştirmek için kullanmış olduğumuz sınıftır.örnek vermek gerekirse c# dilinde string ifadeler "" içerisine yazılır."125" strimg bir ifadeyken aynı zamanda sayıdır.125 ifadesini çift tırnak içerisine almadığımızda rakam olarak tanınır.
             
             //Kapalı dönüşüm (implicit convert)
                //Döüştürme işlemini c# kendisi gerçekleştirir.

            //açık dönüşüm (explicit convert)
               //tipler arasındaki dönüştürme işlemini biz gerçekleştiririz.
             
             //Aşağıdaki örnekler kapalı dönüşüme örnektir.
            
             */

            //char karakter = 'a';//97
            //int karakterdeger = karakter; //ASCII
            //karakterdeger++;
            //karakter=karakterdeger;
            //console.writeline(karakterdeger);


            //Açık dönüşüm işlemeleri


            //stirng metinseldeger="125";
            //int sayisaldeger = metinseldeger;
            //int sayisaldeger = convert.toint32(metinseldeger);
            //console.writeline(sayisaldeger.GetType());
            //console.read();

            //string cevrilecekdeger = "15";
            //short shortdeger = Convert.ToInt16(cevrilecekdeger);

            //Console.WriteLine("Lütfen 1.sayıyı girin...");
            //Console.WriteLine("Lütfen 2. sayıyı girin..");

            // girilen değerlerin tiplerini toint32 olarak console da gösterin
            /*
            string sayibir = "";
            string sayiiki = "";
            Console.Write("1.sayıyı girin:  ");
            sayibir=Console.ReadLine();
            Console.Write("2.saıyı girin:  ");
            sayiiki=Console.ReadLine();

            int sayitip1=Convert.ToInt32(sayibir);
            Console.WriteLine(sayibir.GetType());
            Console.WriteLine(sayiiki.GetType());
            Console.Read();
            */

            string vize;
            string final;
            double ortalama;
            Console.WriteLine("vize değerini giriniz: ");
            vize=Console.ReadLine();
            Console.WriteLine("final değerini girini:  ");
            final=Console.ReadLine();
            
            int vizey = Convert.ToInt32(vize);
            int finaly = Convert.ToInt32(final);
            ortalama = vizey * 0.3+finaly * 0.7;
            Console.WriteLine("ortalama: "+ortalama);
            Console.Read();

            






        }
    }
}
