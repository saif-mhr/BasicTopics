using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTopics.classes
{
    class Simple
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Simple(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetAge() => Age;
    }
}
