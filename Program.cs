using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Objects> list = new List<Objects>();

            for (int i = 0; i < 3; i++)
            {
                list.Add(new Objects(i, i.ToString()));
            }
            foreach (Objects l in list)
            {
                Console.WriteLine(l.ToString());
            }
        }
    }
}
