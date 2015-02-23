using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharTest
{
    class UnicodeTest
    {
        static void Main(string[] args)
        {


            Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("Ĥėļŀō ŵŏŗłđ");

            //Console.OutputEncoding = System.Text.Encoding.Unicode;
            byte[] testUnicode = new byte[] { 196, 160 };
            string unicodeSymbol = Encoding.UTF8.GetString(testUnicode);
            Console.WriteLine(unicodeSymbol);
            string anotherTest = "U+0120";

        }

        
    }
}
