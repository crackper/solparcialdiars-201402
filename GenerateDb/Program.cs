using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sol.Parcial.BusinessEntities;
using Sol.Parcial.Repository;

namespace GenerateDb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creando Base de datos.....");

            var context = new SolParcialContext();

            var festival = new Festival()
            {
                Nombre = "Festiva de Cannes",
                Ciudad = "Cannes"
            };

            context.Festivales.Add(festival);

            context.SaveChanges();

            Console.WriteLine("Base de datos Creada.....");
            Console.ReadLine();

        }
    }
}
