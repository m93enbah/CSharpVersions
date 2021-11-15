using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LocalFuncPro
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-basic usage of local functions
            GetCylinderVolume(22, 13);

            //2-using local function with LINQ operations customize
            var lst = new List<string>() { "Lst1", "Lst2", "Lst3" };
            var res = lst.Where(x => x.Equals("Lst1"));


            var input1 =Path.Combine(Environment.CurrentDirectory,"Input1.txt");
            var input2 = Path.Combine(Environment.CurrentDirectory, "Input2.txt");
            var output = Path.Combine(Environment.CurrentDirectory, "Output.txt");
            WriteEmailsAsync(input1, input2, output).GetAwaiter().GetResult();


            Console.ReadLine();
        }

        //we see that we define multiple inner local functions as below
        static double GetCylinderVolume(double radius, double height)
        {
            return getVolume();

            double getVolume()
            {
                // You can declare inner-local functions in a local function 
                double GetCircleArea(double r) => Math.PI * r * r;

                // ALL parents' variables are accessible even though parent doesn't have any input. 
                return GetCircleArea(radius) * height;
            }
        }

        async static Task WriteEmailsAsync(string file1,string file2,string outputFile)
        {
            var emailRegex = new Regex(@"(?i)[a-z0-9_.+-]+@[a-z0-9-]+\.[a-z0-9-.]+");
            IEnumerable<string> emails1 = await getEmailsFromFileAsync(file1);
            IEnumerable<string> emails2 = await getEmailsFromFileAsync(file2);
            await writeLinesToFileAsync(emails1.Concat(emails2), outputFile);

            //local function to read from file
            async Task<IEnumerable<string>> getEmailsFromFileAsync(string fileName)
            {
                string text;

                using (StreamReader reader = File.OpenText(fileName))
                {
                    text = await reader.ReadToEndAsync();
                }

                return from Match emailMatch in emailRegex.Matches(text) select emailMatch.Value;
            }

            //local function to write to target file
            async Task writeLinesToFileAsync(IEnumerable<string> lines, string fileName)
            {
                using (StreamWriter writer = File.CreateText(fileName))
                {
                    foreach (string line in lines)
                    {
                        await writer.WriteLineAsync(line);
                    }
                }
            }
        }
    }
}
