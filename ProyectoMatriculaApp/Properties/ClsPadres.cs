using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMatriculaApp.Properties
{
    internal class Cls_Padres
    {
        string[] padres;
        int cedu, telp, mensual;
        string civil, esco, trab, ocup, corr, vive;
        public void Din()
        {
            int numasis;
            int maxasis = 3;
            Console.WriteLine("Ingrese la cantidad de personas encargadas del estudiante. Maximo 3 ");
            numasis = int.Parse(Console.ReadLine());
            if (numasis > maxasis)
            {
                numasis = maxasis;
                Console.WriteLine($"Solo se pueden ingresar hasta {maxasis} encargados. Se tomarán los primeros {maxasis}.");
            }
            padres = new string[numasis];

            for (int i = 0; i<padres.Length; i++)
            { 
                Console.WriteLine("Ingrese el nombre del encargado "+(i+1));
                padres[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el numero de identificacion");
                cedu= int.Parse(Console.ReadLine());
                Console.WriteLine("Estado civil");
                civil = Console.ReadLine();
                Console.WriteLine("Nivel de escolaridad");
                esco = Console.ReadLine();
                Console.WriteLine("Lugar de trabajo");
                trab = Console.ReadLine();
                Console.WriteLine("Ocupacion");
                ocup = Console.ReadLine();
                Console.WriteLine("Telefono");
                telp = int.Parse(Console.ReadLine());
                Console.WriteLine("Correo electronico");
                corr = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Ingreso mensual");
                mensual = int.Parse(Console.ReadLine());
                Console.WriteLine("Vive con el o la estudiante?");
                vive = Console.ReadLine();
            }
        }
        public void Imp()
        {
            Console.WriteLine("Los nombres de las personas encargadas del estudiante son: ");
            for (int i = 0; i < padres.Length; i++)
            {
                Console.WriteLine((i + 1) + " " + padres[i].ToString());
                Console.WriteLine("Numero de identificacion "+ cedu);
                Console.WriteLine("Estado civil "+ civil);
                Console.WriteLine("Nivel de escolaridad "+ esco);
                Console.WriteLine("Lugar de trabajo "+ trab);
                Console.WriteLine("Ocupacion "+ ocup);
                Console.WriteLine("Telefono "+ telp);
                Console.WriteLine("Correo electronico "+ corr);
                Console.WriteLine("Ingreso mensual "+ mensual);
                Console.WriteLine("Vive con el o la estudiante? "+ vive);
            }
        }
    }
}
