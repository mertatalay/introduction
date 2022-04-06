using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write() consol da herhamgi bir metinsel ifadeyi yazdırmamıza ve imleci bağlı bulunan satırda kalmasını sağlayan metottur.
            //writelan() consol da herhamgi bir metinsel ifadeyi yazdırmamıza ve imleci bir satır aşağıya kayırır.
            //syntax kuralları
            /* 1-c# büyük küçük harf duyarlı bir dildir.
             * 2-c# metotların parametre parantezleri bulunur.parametre parantezi içerisindeyken ctrl+shift+space kombinasyonu 
             * ile tool tip penceresine ulaşılabilir
             * 3-c# da ifadeler "" içerisinde kullanılır.
             * 4-c# da satırlar istisnasız olarak ; ile sonlandırılmalıdır
             * 5- ctrl+shift+b tuş kombinasyonu ile projeyi derleyebilirsiniz
             * 6- readline() bağlı bulunduğu satırın değerini okur
            
         
             */
            Console.WriteLine("C#introduction dersi");
            Console.WriteLine("bu bizim ilk dersimiz");
            Console.WriteLine("devem etmek için enter a basın");
            Console.ReadLine();
            Console.WriteLine("devam edelim");
            Console.ReadLine();
            Console.WriteLine("Bitti");
            Console.ReadLine();
            Console.Read();
        }
    }
}
