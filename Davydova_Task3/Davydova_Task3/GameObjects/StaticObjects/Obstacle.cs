using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davydova_Task3.GameObjects.StaticObjects
{
    public class Obstacle:StaticObject
    {
        Dictionary<string, bool> PossibleObstacles { get; set; }
        public Obstacle(int id, string name, KeyValuePair<int, int> location, Dictionary<string, bool> possibleObstacles) : base(id, name, location)
        {
            PossibleObstacles = possibleObstacles;
        }
        public override void InfluenceAlgorithm()
        {
            //do something
        }
    }
}
