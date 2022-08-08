using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_august02
{
    class Program
    {
        static void Main(string[] args)
        {
            FileReader reader = new FileReader();
            reader.OpenDirectioryInC();
            //reader.CreateFileInC();
            reader.OpenFileInC();

            Console.ReadLine();
        }
    }
}
