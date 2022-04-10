using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Labwork3
{
    class Factory
    {
        public int IdOfWorker { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
    }

    class Premium
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int SumOfPremium { get; set; }
    }

    class DataProvide
    {
        public static List<Factory> Workers;
        public static List<Premium> Premiums;
        //Replace by the real DataDir
        public const string DataDir = @"d:\lab\";

        public static void ReadData()
        {
            Workers = new List<Factory>();
            using (var reader = new StreamReader(DataDir + "Factory.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var words = Regex.Split(reader.ReadLine(), @"\s+");
                    Workers.Add(new Factory { IdOfWorker = int.Parse(words[0]), Surname = words[1], Sex = words[2], Position = words[3], Salary = int.Parse(words[4]) });
                }
            }
            Premiums = new List<Premium>();
            foreach (var line in File.ReadAllLines(DataDir + "Premium.txt", Encoding.GetEncoding(1251)))
            {
                var words = Regex.Split(line, @"\s+");
                Premiums.Add(new Premium { Id = int.Parse(words[0]), Date = Convert.ToDateTime(words[1]).Date, SumOfPremium = int.Parse(words[2]) });
            }

        }
    }
}