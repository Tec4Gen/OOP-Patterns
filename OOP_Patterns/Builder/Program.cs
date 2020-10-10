using Builder.Builder;
using Builder.Entitiyes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new Baker();

            builder.TypeBread = new BuilderBread();

            var bread = builder.CreateBread();

            builder.TypeBread = new BuilderBreadCake();

            var bread1 = builder.CreateCakeBread();

            Console.WriteLine(bread.Flour.Type + Environment.NewLine);
            Console.WriteLine(bread1.Flour.Type);
            Console.WriteLine(bread1.Cream.Type);

            Console.ReadLine();
        }
    }
}
