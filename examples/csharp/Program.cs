using System;
using Infomap;
namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var map = new Infomap.Infomap("--two-level");
            map.addLink(0, 1);
            map.addLink(0, 2);
            map.addLink(0, 3);
            map.addLink(1, 0);
            map.addLink(1, 2);
            map.addLink(2, 1);
            map.addLink(2, 0);
            map.addLink(3, 0);
            map.addLink(3, 4);
            map.addLink(3, 5);
            map.addLink(4, 3);
            map.addLink(4, 5);
            map.addLink(5, 4);
            map.addLink(5, 3);
            Console.WriteLine("Hello World!");
        }
    }
}
