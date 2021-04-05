using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Davydova_Task3.GameObjects;
using Davydova_Task3.GameObjects.Characters;
using Davydova_Task3.GameObjects.StaticObjects;

namespace Davydova_Task3
{
    public class Map
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public List<Monster> Monsters { get; set; }
        public List<Benefit> Benefits { get; set; }
        public List<Obstacle> Obstacles { get; set; }

        public Map(int height, int width, List<Monster> monsters, List<Benefit> benefits, List<Obstacle> obstacles)
        {
            Height = height;
            Width = width;
            Monsters = monsters;
            Benefits = benefits;
            Obstacles = obstacles;
        }

    }
}
