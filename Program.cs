using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atama ve işlemli atama
            Console.WriteLine("****** Atama ve işlemli atama *****");
            int x = 3;
            int y = 3;

            y = y +2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            //Mantıksal Operatorler
            // || && !
            Console.WriteLine("***** Mantıksal Operatorler *****");
            bool isSuccess = true;
            bool İsCompleted = false;

            if(isSuccess==İsCompleted)
                Console.WriteLine("Perfect!!");

            
            if(isSuccess||İsCompleted)
                Console.WriteLine("Great!!");

            
            if(isSuccess&& !İsCompleted)
                Console.WriteLine("Fine!!"); 

            //İlişkisel Operatorler
            // < > >= <= == !=
            Console.WriteLine("****** ilişkisel operatorler*****");
            int a = 3;
            int b = 4;
            bool sonuc = a<b;
            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;
            Console.WriteLine(sonuc);    

        //Aritmetik Operatorler
        // + - * / 

        Console.WriteLine("***** Aritmetik Operatorler ****");

        int sayi1 = 10;
        int sayi2 = 5;
        int sonuc1 = sayi1/sayi2;
        Console.WriteLine(sonuc1);
        sonuc1=sayi1*sayi2;
        Console.WriteLine(sonuc1);
        sonuc1=sayi1+sayi2;
        Console.WriteLine(sonuc1);
        sonuc1=sayi1++;
        Console.WriteLine(sonuc1);
        sonuc1=sayi1-sayi2;
        Console.WriteLine(sonuc1);

        // % mod almak için kullanılır
        int sonuc2 = 20%3;
        Console.WriteLine(sonuc2);






        }
    }
}
