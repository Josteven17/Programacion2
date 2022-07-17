using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasEstudiantes
{
    internal class Program
    {
        
        static float sumaNotas;
        static int aprobados, reprobados;
        static float [] notas = new float [5];
        static String[] estudiantes = new string [5];
        static void Main(string[] args)
        {
           MenuPrincipal();

        }
        public static void MenuPrincipal() {
            int opcion;
            do
            {
                Console.WriteLine("1.Ingresar estudiantes y notas");
                Console.WriteLine("2.Calcular el promedio");
                Console.WriteLine("3.Notas mas altas");
                Console.WriteLine("4.Aprobados y reprobados");
                Console.WriteLine("5.Salir");
                Console.WriteLine("Digite una opcion.");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        IngresarDatos();
                        break;
                    case 2:
                        Console.WriteLine("El promedio de las notas es: " + (sumaNotas/notas.Length));
                        break;
                    case 3:
                        notasAltas();
                        break;
                    case 4:
                        CantidadAprobadosReprobados();
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta");
                        break;
                }
            } while (opcion!=5);
        
        }

        public static void IngresarDatos()
        {
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Digite el nombre de un estudiante");
                estudiantes[i] = Console.ReadLine();
                Console.WriteLine("Digite su nota");
                notas[i]= float.Parse(Console.ReadLine());
                sumaNotas += notas[i];
            }

        }

        public static void notasAltas()
        {
            Console.WriteLine("Las notas mas altas son:");
            for (int i = 0;  i < notas.Length; i++)
            {
                for (int  j = i+1; j < notas.Length;  j++)
                {
                    if (notas[i] < notas[j])
                    {
                        float aux = notas[i];
                        notas[i] = notas[j];
                        notas[j] = aux;
                    }
                }
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(notas[i]);
            }
           
        }

        public static void CantidadAprobadosReprobados()
        {
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] >= 70)
                {
                    aprobados++;
                }
                else
                {
                    reprobados++;
                }
            }
            Console.WriteLine("La cantidad de aprobados es: " + aprobados + 
                "\nLa cantidad de reprobados es: " + reprobados);
            aprobados = 0;
            reprobados = 0; 
        }
    
    }
}
