using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMatriculaApp.Properties
{
    internal class Cls_Familia
    {
        string[] familiares;
        int cedulaf, ingresof;
        string paren, nivelf, civilf, ocupf;
        public void Nid(int cantidadfamiliares)
        {
            Console.WriteLine("Ingrese la cantidad de personas que viven con el estudiante");
            cantidadfamiliares = int.Parse(Console.ReadLine());
            familiares = new string[cantidadfamiliares];
            for (int i = 0; i<familiares.Length; i++)
            {
                Console.WriteLine("Nombre de la persona"+(i+1));
                familiares[i] = Console.ReadLine();
                Console.WriteLine("Numero de identificacion");
                cedulaf = int.Parse(Console.ReadLine());
                Console.WriteLine("Parentesco");
                paren= Console.ReadLine();
                Console.WriteLine("Nivel academico");
                nivelf = Console.ReadLine();
                Console.WriteLine("Estado civil");
                civilf= Console.ReadLine();
                Console.WriteLine("Ocupacion");
                ocupf= Console.ReadLine();
                Console.WriteLine("Ingreso mensual");
                ingresof= int.Parse(Console.ReadLine());
            }
        }
        public void Impri()
        {
            Console.WriteLine("Los nombres de las personas que viven con el estudiante son: ");
            for (int i = 0; i < familiares.Length; i++)
            {
                Console.WriteLine((i + 1) + " " + familiares[i].ToString());
                Console.WriteLine("Numero de identificacion "+ cedulaf);
                Console.WriteLine("Parentesco "+ paren);
                Console.WriteLine("Nivel academico "+ nivelf);
                Console.WriteLine("Estado civil "+ civilf);
                Console.WriteLine("Ocupacion "+ ocupf);
                Console.WriteLine("Ingreso mensual "+ ingresof);
            }
        }
    }
}
