using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Ĥėļŀō ŵŏŗłđ");

            //Console.OutputEncoding = System.Text.Encoding.Unicode;
            byte[] testUnicode = new byte[] { 240, 159, 145, 186 };
            string unicodeSymbol = Encoding.UTF8.GetString(testUnicode);
            Console.WriteLine(unicodeSymbol);
            
        }
    }
}
