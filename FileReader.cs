using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CS_august02
{
    class FileReader
    {
        public void OpenDirectiory()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(".");
            Console.WriteLine(directoryInfo.FullName);
            var files = directoryInfo.GetFiles();
            foreach (var file in files)
            {
                Console.WriteLine(file.Name);
            }
        }

        public void OpenDirectioryInC()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Lab");
            if (!directoryInfo.Exists) directoryInfo.Create();
            FileInfo fileInfo = new FileInfo($"{directoryInfo.FullName}\\CSLab.txt");
            if (!fileInfo.Exists) fileInfo.Create();

            using (FileStream fs = new FileStream($"{fileInfo.FullName}", FileMode.Append, FileAccess.Write))
            {
                int a = 0;
                try
                {
                    a = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Неверный формат!");
                }

                using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                {
                    sw.WriteLine(a);
                }
            }

            Console.WriteLine(directoryInfo.FullName);
            var files = directoryInfo.GetFiles();
            foreach (var file in files)
            {
                Console.WriteLine(file.Name);
            }
        }

        public void OpenFile()
        {
            using (FileStream fs = new FileStream("test.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string a = sr.ReadLine();
                    Console.WriteLine(a);
                }
                /*byte[] readBytes = new byte[(int)fs.Length];
                fs.Read(readBytes, 0, readBytes.Length);
                string a = Encoding.Default.GetString(readBytes);
                Console.WriteLine(a);*/
            }
        }

        public void OpenFileInC()
        {
            using (FileStream fs = new FileStream(@"C:\Lab\CSLab.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string a = sr.ReadToEnd();
                    Console.WriteLine(a);
                }
            }
        }

        public void CreateFile()
        {
            using (FileStream fs = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                string a = "Морковка";
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                {
                    sw.WriteLine(a);
                }
                
                /*string a = "New Line";
                byte[] writeBytes = Encoding.Default.GetBytes(a);
                fs.Write(writeBytes, 0, writeBytes.Length);*/
            }
        }
    }
}
