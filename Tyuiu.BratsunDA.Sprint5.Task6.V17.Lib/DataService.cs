using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BratsunDA.Sprint5.Task6.V17.Lib
{
    public class DataService : ISprint5Task6V17
    {
        public int LoadFromDataFile(string path)
        {

                string input = File.ReadAllText(path);

                int count = 0;
                int spaces = 0;

                foreach (char c in input)
                {
                    if (c == ' ')
                    {
                    spaces++;
                    }
                    else
                    {
                        if (spaces > 1)
                        {
                            count++;
                        }
                    spaces = 0;
                    }
                }
                return count;
            
        }
    }
}

