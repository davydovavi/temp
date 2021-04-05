using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Davydova_Task3.GameObjects.StaticObjects;

namespace Davydova_Task3.GameObjects.Characters
{
    public abstract class Character:GameObject
    {
        int PlayerLife { get; set; }
        int Speed { get; set; } //count of cells per step

        List<Obstacle> ObstaclesAvoidable { get; set; }

        public Character(int id, string name, KeyValuePair<int, int> location, int playerLife, int speed, List<Obstacle> obstaclesAvoidable): base(id, name, location)
        {
            PlayerLife = playerLife;
            Speed = speed;
            ObstaclesAvoidable = obstaclesAvoidable;
        }

        virtual public void ActionAlgorithm()
        {
            //do something
        }
    }
}
