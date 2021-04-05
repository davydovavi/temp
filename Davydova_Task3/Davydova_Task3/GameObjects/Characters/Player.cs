using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Davydova_Task3.GameObjects.StaticObjects;

namespace Davydova_Task3.GameObjects.Characters
{
    public class Player:Character
    {
        Map Map { get; set; }
        public Player(int id, string name, KeyValuePair<int, int> location, int playerLife, int speed, List<Obstacle> obstaclesAvoidable) : base(id, name, location, playerLife, speed, obstaclesAvoidable)
        {

        }

        public void AddMap(Map map)
        {
            Map = map;
        }

        public override void ActionAlgorithm()
        {
            //do something
        }

    }
}
