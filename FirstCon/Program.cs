using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCon
{
    // First comments
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld hw = new HelloWorld();
            hw.Hello = "hello world..";
            Console.WriteLine("Message = {0}", hw.Hello);
            Console.ReadLine();
        }
    }
}
