using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CS_august02
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileReader reader = new FileReader();
            //reader.OpenDirectioryInC();
            //reader.CreateFileInC();
            //reader.OpenFileInC();

            /*string a = "Mob is stinky";
            string pattern = "Mob";
            var find = Regex.Match(a, pattern);
            Console.WriteLine(find.Success);
            a = Regex.Replace(a, pattern, "Fab");*/

            string input = Console.ReadLine();
            input = Regex.Replace(input, "a", "3");
            input = Regex.Replace(input, "\\.", ":");
            Console.WriteLine(input);

            Console.ReadLine();
        }
    }
}
