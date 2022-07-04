using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);
        }

        private static void Exercise1_1(string file)
        {
            var xdoc = XDocument.Load(file);

            var samples = xdoc.Root.Elements().Select(x=> new { 
                                                        Name = (string)x.Element("name"),
                                                        TeamMenber = (string)x.Element("teammembers")});
            foreach (var sample in samples)
            {
                Console.WriteLine("{0} {1}",sample.Name,sample.TeamMenber);
            }
        }

        private static void Exercise1_2(string file)
        {
            var xdoc = XDocument.Load(file);
            var samples = xdoc.Root.Elements().Select(x => new {
                                                        Name = (string)x.Element("name").Attribute("kanji"),
                                                        Firstplayed = (string)x.Element("firstplayed")}
                                                     ).OrderBy(x=>x.Firstplayed);

            foreach (var sample in samples)
            {
                Console.WriteLine("{0}({1})", sample.Name, sample.Firstplayed);
            }
        }

        private static void Exercise1_3(string file)
        {
            var xdoc = XDocument.Load(file);

            
        }

        private static void Exercise1_4(string file, string newfile)
        {
            
        }
    }
}
