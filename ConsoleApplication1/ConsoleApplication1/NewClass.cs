using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class NewClass
    {
        private string name;

        public int age { get; set; }

        private bool isGood;
        public string Name {
            get { return name; }
            set { name = value; }
        }

        public string GetName()
        {
            return name;
        }
    }
}
