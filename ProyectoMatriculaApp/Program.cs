using ProyectoMatriculaApp;
using ProyectoMatriculaApp.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ProyectoMatriculaApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0;
            //Se declaran las clases que se crearon para poder ser llamadas
            Cls_encargados Ind = new Cls_encargados();
            Cls_Padres Din = new Cls_Padres();
            Cls_Familia Nid = new Cls_Familia();
            List<Alumno> alumnos = new List<Alumno>();
            //Se crea un menu donde se permita: Agregar, Eliminar y Mostrar los alumnos. Tambien una opcion para salir
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("     Ministerio de Educacion Publica");
                Console.WriteLine("  Direccion Regional de Enseñanza San Jose");
                Console.WriteLine("Circuito 06 Escuela Concepcion de Alajuelita");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("           Boleta de Matricula");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("1. Agregar Alumno");
                Console.WriteLine("2. Eliminar Alumno");
                Console.WriteLine("3. Mostrar Alumnos");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Seleccione una opción:");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarAlumno(alumnos, Ind, Din, Nid, cantidad);
                        break;
                    case "2":
                        EliminarAlumno(alumnos);
                        break;
                    case "3":
                        MostrarAlumnos(alumnos, Ind, Din, Nid);
                        break;
                    case "4":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }

            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }
        //Este es el case1 donde se crea una lista donde va a guardar cada alumno y dentro de cada alumno por medio de clases 
        //se va a guardar otras informaciones como lo son los padres, familiares y encargados de recoger al alumno
        static void AgregarAlumno(List<Alumno> alumnos, Cls_encargados Ind, Cls_Padres Din, Cls_Familia Nid, int cantidad)
        {
            Console.WriteLine("1.NIVEL EN QUE SE MATRICULA:");
            string nivel = Console.ReadLine();
            Console.WriteLine("Fecha de ingreso:");
            string ingreso = Convert.ToString(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("DATOS PERSONALES DEL ESTUDIANTE:");
            Console.WriteLine("Nombre completo del estudiante:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Numero de identificacion(cédula, DIMEX, Num pasaporte, Num refugiado)");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Fecha de nacimiento:");
            string nacimiento = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Lugar de nacimiento:");
            string lugar = Console.ReadLine();
            Console.WriteLine("Nacionalidad:");
            string nacionalidad = Console.ReadLine();
            Console.WriteLine("Tiene adecuación: En caso que si especifique");
            string adecua = Console.ReadLine();
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("3.LUGAR DE RESIDENCIA:");
            Console.WriteLine("Barrio:");
            string barrio = Console.ReadLine();
            Console.WriteLine("Distrito:");
            string distrito = Console.ReadLine();
            Console.WriteLine("Cantón:");
            string canton = Console.ReadLine();
            Console.WriteLine("Dirección exacta:");
            string direccion = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Telefonos:");
            int telefono = int.Parse(Console.ReadLine());
            Console.WriteLine("Correo electrónico:");
            string correo = Convert.ToString(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("4.INFORMACION IMPORTANTE");
            Console.WriteLine("En caso de emergencia comunicarse con la persona:    Telefono: ");
            string emerg = Convert.ToString(Console.ReadLine());
            //Por medio de la clase Ind se pide los datos de los autorizados a recoger al alumno con limite de 3 personas
            Ind.Ind();
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("5.DATOS GENERALES DEL PADRE, MADRE O ENCARGADO DEL ESTUDIANTE");
            //Por medio de la clase Din se pide los datos de los padres del alumno con limite de 3 personas
            Din.Din();
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("6.DATOS DE MIEMBROS QUE VIVEN CON EL ESTUDIANTE");
            //Por medio de la clase Nid se pide los datos de los familiares del alumno sin limite de ingresos
            Nid.Nid(cantidad);
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("7.OTROS DATOS DEL ESTUDIANTE");
            Console.WriteLine("La vivienda donde vive es");
            string vivienda = Console.ReadLine();
            Console.WriteLine("El estado de la vivienda donde habita es");
            string estado = Console.ReadLine();
            Console.WriteLine("Presenta alguna enfermedad que requiera tratamiento médico");
            string enfermedad = Console.ReadLine();
            Console.WriteLine("Debe medicarse durante la jornada lectiva: En caso que si. Que medicamento:");
            string medicamento = Console.ReadLine();
            Console.WriteLine("Es alergico a algun medicamento:   Cual:  ");
            string alergico = Console.ReadLine();
            Console.WriteLine("Es alergico a algun alimento:     Cual:    ");
            string alimento = Console.ReadLine();
            Console.WriteLine("A la salida del estudiante, esta autorizado para viajar: Solo o acompañado?");
            string viaje = Console.ReadLine();
            Console.WriteLine("Existe algun impedimento por parte del PANI en cuanto a custodia del menor: En caso que si especifique:");
            string pani = Console.ReadLine();
            Console.WriteLine("Posee internet:   Que empresa brunda el servicio:   Velocidad:");
            string internet = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Cuanto es el promedio mensual de ingresos entre todas las personas que habitan en su hogar:");
            int tot = int.Parse(Console.ReadLine());
            Alumno nuevoAlumno = new Alumno(nivel, ingreso, nombre, id, nacimiento, lugar, nacionalidad, adecua, barrio, distrito, canton, direccion, telefono, correo, emerg,
            vivienda, estado, enfermedad, medicamento, alergico, alimento, viaje, pani, internet);
            alumnos.Add(nuevoAlumno);
        }
        //El case2 permite eliminar un alumno de la lista por medio de su ID
        static void EliminarAlumno(List<Alumno> alumnos)
        {
            Console.WriteLine("Ingrese el ID del alumno a eliminar:");
            int id = int.Parse(Console.ReadLine());
            //Con el siguiente comando permite eliminar un alumno por medio del ID
            Alumno alumnoAEliminar = alumnos.FirstOrDefault(a => a.Id == id);

            if (alumnoAEliminar != null)
            {
                //Si el ID coincide con uno de la lista se elimina correctamente
                alumnos.Remove(alumnoAEliminar);
                Console.WriteLine("Alumno eliminado correctamente.");
            }
            else
            {
                //Pero un numero de ID incorrecto muestra la leyenda que no existe
                Console.WriteLine("Alumno no encontrado.");
            }
        }
        //El case3 permite mostrar la lista de los alumnos que han sido registrados anteriormente
        static void MostrarAlumnos(List<Alumno> alumnos, Cls_encargados Ind, Cls_Padres Din, Cls_Familia Nid)
        {
            Console.WriteLine("Los datos de los alumnos inscritos es:");
            foreach (Alumno alumno in alumnos)
            {
                Console.WriteLine("DATOS PERSONALES DEL ESTUDIANTE");
                Console.WriteLine($"Nivel en que se matricula: {alumno.Nivel}");
                Console.WriteLine($"Fecha de ingreso: {alumno.Ingreso}");
                Console.WriteLine($"Nombre completo del estudiante: {alumno.Nombre}");
                Console.WriteLine($"Identificacion: {alumno.Id}");
                Console.WriteLine($"Fecha de nacimiento: {alumno.Nacimiento}");
                Console.WriteLine($"Lugar de nacimiento: {alumno.Lugar}");
                Console.WriteLine($"Nacionalidad: {alumno.Nacionalidad}");
                Console.WriteLine($"Tiene adecuacion: {alumno.Adecua}");
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("LUGAR DE RESIDENCIA");
                Console.WriteLine($"Barrio: {alumno.Barrio}");
                Console.WriteLine($"Distrito: {alumno.Distrito}");
                Console.WriteLine($"Canton: {alumno.Canton}");
                Console.WriteLine($"Direccion exacta: {alumno.Direccion}");
                Console.WriteLine($"Telefono: {alumno.Telefono}");
                Console.WriteLine($"Correo electronico: {alumno.Correo}");
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("INFORMACION IMPORTANTE");
                Console.WriteLine($"En caso de emergencia llamar a: {alumno.Emergencia}");
                //El Ind.Imprimir muestra los datos de los encargados del alumno
                Ind.Imprimir();
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("DATOS GENERALES DEL PADRE, MADRE O ENCARGADO");
                //El Din.Imp muestra los datos de los padres del alumno
                Din.Imp();
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("DATOS DE MIEMBROS QUE VIVEN CON EL MENOR");
                //El Nid.Impri muestra los datos de los familiares del alumno
                Nid.Impri();
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("7.OTROS DATOS DEL ESTUDIANTE");
                Console.WriteLine($"La vivienda donde vive es:  {alumno.Vivienda}");
                Console.WriteLine($"El estado de la vivienda donde habita es: {alumno.Estado}");
                Console.WriteLine($"Presenta alguna enfermedad que requiera tratamiento médico  {alumno.Enfermedad}");
                Console.WriteLine($"Debe medicarse durante la jornada lectiva: En caso que si. Que medicamento: {alumno.Medicamento}");
                Console.WriteLine($"Es alergico a algun medicamento:   Cual:  {alumno.Alergico}");
                Console.WriteLine($"Es alergico a algun alimento:     Cual:    {alumno.Alimento}");
                Console.WriteLine($"A la salida del estudiante, esta autorizado para viajar: Solo o acompañado? {alumno.Viaje}");
                Console.WriteLine($"Existe algun impedimento por parte del PANI en cuanto a custodia del menor: En caso que si especifique: {alumno.Pani}");
                Console.WriteLine($"Posee internet:   Que empresa brunda el servicio:   Velocidad: {alumno.Internet}");
            }
        }
        class Alumno
        {
            public string Nivel { get; set; }
            public string Ingreso { get; set; }
            public string Nombre { get; set; }
            public int Id { get; set; }
            public string Nacimiento { get; set; }
            public string Lugar { get; set; }
            public string Nacionalidad { get; set; }
            public string Adecua { get; set; }
            public string Barrio { get; set; }
            public string Distrito { get; set; }
            public string Canton { get; set; }
            public string Direccion { get; set; }
            public int Telefono { get; set; }
            public string Correo { get; set; }
            public string Emergencia { get; set; }
            public string Vivienda { get; set; }
            public string Estado { get; set; }
            public string Enfermedad { get; set; }
            public string Medicamento { get; set; }
            public string Alergico { get; set; }
            public string Alimento { get; set; }
            public string Viaje { get; set; }
            public string Pani { get; set; }
            public string Internet { get; set; }
            public Alumno(string nivel, string ingreso, string nombre, int id, string nacimiento, string lugar, string nacionalidad, string adecua, string barrio,
                string distrito, string canton, string direccion, int telefono, string correo, string emerg, string vivienda, string estado,
                string enfermedad, string medicamento, string alergico, string alimento, string viaje, string pani, string internet)
            {
                Nivel = nivel;
                Ingreso = ingreso;
                Nombre = nombre;
                Id = id;
                Nacimiento = nacimiento;
                Lugar = lugar;
                Nacionalidad = nacionalidad;
                Adecua = adecua;
                Barrio = barrio;
                Distrito = distrito;
                Canton = canton;
                Direccion = direccion;
                Telefono = telefono;
                Correo= correo;
                Emergencia=emerg;
                Vivienda = vivienda;
                Estado = estado;
                Enfermedad = enfermedad;
                Medicamento = medicamento;
                Alergico = alergico;
                Alimento = alimento;
                Viaje = viaje;
                Pani = pani;
                Internet= internet;
            }

        }
    }
}


