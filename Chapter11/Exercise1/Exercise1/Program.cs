using System;
using System.Collections.Generic;
using System.IO;
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

            // これは確認用
            var text = File.ReadAllText(newfile);
            Console.WriteLine(text);
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

            var sample = xdoc.Root.Elements().Select(x => new {
                                                        Name = x.Element("name").Value,
                                                        TeamMenber = x.Element("teammembers").Value}
                                                     ).OrderByDescending(x=>int.Parse(x.TeamMenber)).First();
            
            Console.WriteLine("{0}({1}人)",sample.Name,sample.TeamMenber);
        }

        private static void Exercise1_4(string file, string newfile)
        {
            var xdoc = XDocument.Load(file);
            var soccer = new XElement("ballsport",
                                        new XElement("name", "サッカー", new XAttribute("kanji", "蹴球")),
                                        new XElement("teammembers", 11),
                                        new XElement("firstplayed", 1863)
                                     );
            xdoc.Root.Add(soccer);
            xdoc.Save(newfile);
        }
    }
}
