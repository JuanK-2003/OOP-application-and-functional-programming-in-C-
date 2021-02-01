using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class Person
    {
        string name;
        string direction;
        DateTime dateNaci;

        public string Name { get => name; set => name = value; }
        public string Direction { get => direction; set => direction = value; }
        public DateTime DateNaci { get => dateNaci; set => dateNaci = value; }

        public int calcAge()
        {
            int age = DateTime.Today.AddTicks(-DateNaci.Ticks).Year - 1;
            return age;
        }

        public String normName()
        {
            List<String> normalized = Name.Split(' ').ToList();
            normalized.ForEach(word => word.ToLower());
            Name = "";
            foreach(var word in normalized)
            {
                var n = char.ToUpper(word[0]) + word.Substring(1);
                name += " " + n;
            }
            return Name;
        }

    }
}
