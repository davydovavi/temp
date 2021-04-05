using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davydova_Task3.GameObjects.StaticObjects
{
    public abstract class StaticObject:GameObject
    {
        public StaticObject(int id, string name, KeyValuePair<int, int> location) :base(id, name, location)
        {

        }

        virtual public void InfluenceAlgorithm()
        {

        }
    }
}
