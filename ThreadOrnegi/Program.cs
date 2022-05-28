using System;
using System.Threading;

namespace ThreadOrnegi
{

    class Program
    {
        public class ThreadIslemi
        {
            public void ThreadOrnegi()
            {
                Thread.Sleep(5000);  
                Console.WriteLine(" 5 saniye Bekleme Sonrası Thread Örneği");
            }
        }
        static void Main(string[] args)
        {
            ThreadIslemi threadIslemi = new ThreadIslemi();
            Console.WriteLine("Ramazan KÜÇÜKKOÇ ");
            Console.WriteLine("NO : 21807052 "); 
            Console.WriteLine("----------------------");
            threadIslemi.ThreadOrnegi();
          
            Console.ReadLine();
        }
    }
}
