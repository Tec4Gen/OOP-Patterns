using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class StartPoint
    {
        static void Main(string[] args)
        {
            var Ui = new UI();

            Ui.Run();
            Console.ReadLine();
        }
    }
}
