using System;
using System.Threading;
namespace BMDersleriMultitreadProgramlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Başlatıldı");
            // Thread'leri oluşturmak için
            Thread t1 = new Thread(Method1)
            {
                Name = "Thread1"
            };
            Thread t2 = new Thread(Method2)
            {
                Name = "Thread2"
            };
            Thread t3 = new Thread(Method3)
            {
                Name = "Thread3"
            };
            //Thread'leri başlatmak için
            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Main Thread Sonlandı");

        }
        static void Method1()
        {
            Console.WriteLine("Method1 " + Thread.CurrentThread.Name + "'i kullanarak başlatıldı");
            for (int i = 1; i <= 8; i++)
            {
                Console.WriteLine("Method1 :" + i);
            }
            Console.WriteLine("Method1 " + Thread.CurrentThread.Name + "'i kullanarak sonlandı");
        }

        static void Method2()
        {
            Console.WriteLine("Method2 " + Thread.CurrentThread.Name + "'yi kullanarak başlatıldı");
            for (int i = 1; i <= 8; i++)
            {
                Console.WriteLine("Method2 :" + i);
                if (i == 3)
                {
                    Console.WriteLine("20 saniyelik askıya alma operasyonu başlatıldı");
                    //20 saniye boyunca Thread'i askıya almak için
                    Thread.Sleep(20000);
                    Console.WriteLine("20 saniye doldu ve askıya alma operasyonu sonlandı");
                }
            }
            Console.WriteLine("Method2 " + Thread.CurrentThread.Name + "'yi kullanarak sonlandı");
        }
        static void Method3()
        {
            Console.WriteLine("Method3 " + Thread.CurrentThread.Name + "'ü kullanarak başlatıldı");
            for (int i = 1; i <= 8; i++)
            {
                Console.WriteLine("Method3 :" + i);
            }
            Console.WriteLine("Method3 " + Thread.CurrentThread.Name + "'ü kullanarak sonlandı");
        }
    }
}
