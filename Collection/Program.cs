using System;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Collection----");
            
            Demo.doListDemo();
            Demo.doStackDemo();
             Demo.doDictionaryDemo();
            Demo.doQueueDemo();
            Demo.doSetDemo();
            Console.ReadKey();
        }
    }
}
