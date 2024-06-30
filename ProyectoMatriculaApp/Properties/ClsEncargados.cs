using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMatriculaApp.Properties
{
    internal class Cls_encargados
    {
        string[] autor;
        int cedula;
        int telau;
        public void Ind()
        {
            int numasis;
            int maxasis = 3;
            Console.WriteLine("Ingrese la cantidad de personas autorizadas a recoger el estudiante. Maximo 3 ");
            numasis = int.Parse(Console.ReadLine());
            if (numasis > maxasis)
            {
                numasis = maxasis;
                Console.WriteLine($"Solo se pueden ingresar hasta {maxasis} autorizados. Se tomarán los primeros {maxasis}.");
            }
            autor = new string[numasis];

            for (int i = 0; i<autor.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre del autorizado "+(i+1));
                autor[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el numero de cedula");
                cedula= int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Telefono");
                telau= int.Parse(Console.ReadLine());
            }
        }
        public void Imprimir()
        {
            Console.WriteLine("Los nombres de las personas autorizadas a recoger el estudiante son: ");
            for (int i = 0; i < autor.Length; i++)
            {
                Console.WriteLine((i + 1) + " " + autor[i].ToString());
                Console.WriteLine("Cedula "+ cedula);
                Console.WriteLine("Telefono "+ telau);
            }
        }
    }
}
