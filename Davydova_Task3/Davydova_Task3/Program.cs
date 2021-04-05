using System;
using Davydova_Task3.IO;

namespace Davydova_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter fileName: ");
            string fileName = Console.ReadLine();
            FileIO fileIO = new FileIO();
            Map map = fileIO.GetMap(fileName);

            foreach (var obstacle in map.Obstacles)
            {
                obstacle.InfluenceAlgorithm();
            }
            
        }
    }
}
