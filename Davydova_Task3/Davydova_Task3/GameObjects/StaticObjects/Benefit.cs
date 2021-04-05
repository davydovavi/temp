using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davydova_Task3.GameObjects.StaticObjects
{
    public class Benefit:StaticObject
    {
        Dictionary<string, bool> PossibleBenefits { get; set; }
        public Benefit(int id, string name, KeyValuePair<int, int> location, Dictionary<string, bool> possibleBenefits) : base(id, name, location)
        {
            PossibleBenefits = possibleBenefits;
        }
        public override void InfluenceAlgorithm()
        {
            //do something
        }
    }
}
