using System;

namespace arrays
{
    public class Objects
    {
        public int id { get; set; }

        public string name { get; set; }

        public Objects(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return "Show: Id: '" + id +
            "', Name: '" + name +
            "'";
        }
    }
}
