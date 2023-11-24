using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BratsunDA.Sprint5.Task5.V19.Lib
{
    public class DataService : ISprint5Task5V19
    {
        public double LoadFromDataFile(string path)
        {
            double[] numbers = File.ReadAllLines(path)
            .Select(double.Parse)
            .Where(n => Math.Abs(n) < 10 && Math.Abs(n) % 1 == 0)
            .ToArray();

            double max = numbers.Max();
            double min = numbers.Min();
            

            double diff = Math.Round(max - min, 3);
            return diff;
        }
    }
}
