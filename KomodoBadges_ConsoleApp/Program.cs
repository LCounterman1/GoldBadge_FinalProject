using KomodoBadges_ClassLibrary;
using KomodoBadges_ConsoleApp.DoorNames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoBadges_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDoors> _doors = new List<IDoors>();

            A1 a1 = new A1() { Name = "A1" };
            A2 a2 = new A2() { Name = "A2" };
            B1 b1 = new B1() { Name = "B1" };
            B2 b2 = new B2() { Name = "B2" };
            C1 c1 = new C1() { Name = "C1" };
            C2 c2 = new C2() { Name = "C2" };

            _doors.Add(a1);
            _doors.Add(a2);
            _doors.Add(b1);
            _doors.Add(b2);
            _doors.Add(c1);
            _doors.Add(c2);





            ProgramUI ui = new ProgramUI();
            ui.Run();
            Console.ReadKey();
        }
    }
}
