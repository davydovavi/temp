using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davydova_Task3.GameObjects
{
    public class GameObject
    {
        private int Id { get; set; }
        private string Name { get; set; }

        private KeyValuePair<int, int> location;

        public KeyValuePair<int, int> Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }

        public GameObject(int id, string name, KeyValuePair<int, int> location)
        {
            Id = id;
            Name = name;
            Location = location;
        }

    }
}
