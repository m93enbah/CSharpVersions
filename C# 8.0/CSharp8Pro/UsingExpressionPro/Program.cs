using System;
using System.IO;

namespace UsingExpressionPro
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertFiles();
        }
        //with using var , it will kill the instnace once you go out the method , its more simpler than old way
        public static int ConvertFiles()
        {
            int output = 0;
            using var inputFile = new StreamReader(@"D:\InputFile.txt");
            using var outputFile = new StreamWriter(@"D:\OutputFile.txt");
            string line;
            while ((line = inputFile.ReadLine()) != null)
            {
                outputFile.WriteLine(line);
                output += 1;
            }

            //int output = 0;
            //using (var inputFile = new StreamReader(@"D:\InputFile.txt"))
            //{
            //    using (var outputFile = new StreamWriter(@"D:\OutputFile.txt"))
            //    {
            //        string line;
            //        while ((line = inputFile.ReadLine()) != null)
            //        {
            //            outputFile.WriteLine(line);
            //            output += 1;
            //        }
            //    }
            //}
            return output;
        }

    }
}
