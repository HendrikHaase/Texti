using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texti
{
    class Texti
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();

            Console.WriteLine("Enter Text:");
            var text = Console.ReadLine();

            Console.WriteLine("Iterations:");
            var numbr = Console.ReadLine();

            if (numbr != null)
            {
                var i = int.Parse(numbr);

                for (var j = 1; j <= i; j++)
                {
                    sb.AppendLine(text + " " + j);
                }

                var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                var fullFilePath = path + @"Texti.txt";


                if (File.Exists(fullFilePath))
                    File.Delete(fullFilePath);

                using (var outfile = new StreamWriter(fullFilePath))
                {
                    outfile.Write(sb.ToString());
                }
            }

            Console.WriteLine("done!");
            Console.ReadKey();
        }
    }
}
