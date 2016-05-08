using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroundAnalyser.Data;
using System.Data.OleDb;
using System.IO;

namespace libraryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Distribute dist = new Distribute(@"D:\Project\data\第二次改完程序_正确_280.raw", @"C:\Users\Victor\OneDrive\Code\CSharp\GroundAnalyser\GroundAnalyser\data\db.mdb");
            dist.importData();
            
        }
    }
}
