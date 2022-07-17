using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeajeAutopista
{
    internal class Program
    {
        static int[] NumeroFactura = new int[15];
        static String[] NumeroPlaca = new string[15];
        static String[] Fecha = new string[15];
        static String[] Hora = new string[15];
        static int[] TipoVehiculo = new int[15];
        static int[] Caseta = new int[15];
        static float[] monto = new float[15];
        static float[] pago = new float[15];
        static float[] vuelto = new float[15];
        private static byte Indice = 0;
        public static Boolean verificador = false;
        public static float total = 0;
        static void Main(string[] args)
        {
            Menu();
        }



        public static void Menu()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("*****Menu Principal Peajes***");
                Console.WriteLine("1. Inicializar Vectores");
                Console.WriteLine("2. Ingresar Paso Verhicular");
                Console.WriteLine("3. Consulta de vehiculos por numero de placa");
                Console.WriteLine("4. Modificar datos por numero de placa");
                Console.WriteLine("5. Reporte toda la informacion");
                Console.WriteLine("6. Salir");
                Console.WriteLine("Ingrese una opcion");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Iniciar();
                        break;
                    case 2:
                        IngresarDatos();
                        break;
                    case 3:
                        Consultar(SolicitarPlaca());
                        break;
                    case 4:
                        Modificar(SolicitarPlaca());    
                        break;
                    case 5:
                        Reporte();
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta");
                        break;
                }
            } while (opcion != 6);

        }

        public static void Iniciar()
        {
            for (int i = 0; i < NumeroFactura.Length; i++)
            {
                NumeroFactura[i] = 0;
                NumeroPlaca[i] = " ";
                Fecha[i] = " ";
                Hora[i] = " ";
                TipoVehiculo[i] = 0;
                Caseta[i] = 0;
                monto[i] = 0;
                pago[i] = 0;
                vuelto[i] = 0;
            }
            Console.WriteLine("Vectores Inicializados");
        }

        public static void IngresarDatos()
        {
            int opcion = 0;
            char dato = ' ';
            do
            {
                Console.WriteLine("Ingrese el numero de placa");
                String placa = Console.ReadLine();
                verificador = false;
                for (int i = 0; i < Indice; i++)
                {
                    if (placa == NumeroPlaca[i])
                    {
                        verificador = true;
                    }
                }
                if (verificador == true)
                {
                    Console.WriteLine("El vehiculo ya esta registrado");
                }
                else
                {
                    NumeroPlaca[Indice] = placa;
                    Console.WriteLine("Ingrese el numero de factura");
                    NumeroFactura[Indice] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la fecha");
                    Fecha[Indice] = Console.ReadLine();
                    Console.WriteLine("Ingrese la hora");
                    Hora[Indice] = Console.ReadLine();
                    TipoDeVehiculo(Indice);
                    TipoCaseta(Indice);
                    Console.WriteLine("Digite con cuanto paga el cliente");
                    pago[Indice] = float.Parse(Console.ReadLine());
                    vuelto[Indice] = pago[Indice] - monto[Indice];
                    total += monto[Indice];
                    Indice++;
                }
                Console.WriteLine("Desea continuar? S/N");
                dato = char.Parse(Console.ReadLine().ToUpper());
            } while (!dato.Equals('N'));

        }
        public static void TipoCaseta( int i)
        {
            int opcion;
            verificador = false;
            do
            {
                Console.WriteLine("Ingrese el numero de caseta");
                opcion = int.Parse(Console.ReadLine());
                if (opcion > 0 && opcion < 4)
                {
                    Caseta[i] = opcion;
                    verificador = true;
                }
                else
                {
                    Console.WriteLine("Opcion Incorrecta");
                }
            } while (verificador != true);
        }
        public static void TipoDeVehiculo(int i)
        {
            int opcion;
            verificador = false;
            do
            {
                Console.WriteLine("Tipos de vehiculo\n" + "1. Moto\n" + "2. Vehiculo Liviano\n" + "3. Camion o peasdo\n" + "4. Autobus");
                opcion = int.Parse(Console.ReadLine());
                if (opcion > 0 && opcion < 5)
                {
                    TipoVehiculo[i] = opcion;

                    switch (opcion)
                    {
                        case 1:
                            monto[i] = 500;
                            break;
                        case 2:
                            monto[i] = 700;
                            break;
                        case 3:
                            monto[i] = 2700;
                            break;
                        case 4:
                            monto[i] = 3700;
                            break;

                    }
                    verificador = true;
                }
                else
                {
                    Console.WriteLine("Opcion Incorrecta");
                }
            } while (verificador != true);

        }
        private static String SolicitarPlaca()
        {
            Console.WriteLine("Ingrese el numero de placa");
            String placa = Console.ReadLine();
            return placa;
        }
        public static void Modificar(String placa)
        {
            int opcion = 0;
            int i = 0;
            while ((i <= Indice) && (!placa.Equals(NumeroPlaca[i])))
            {
                i++;
            }
            if (i > Indice)
            {
                Console.WriteLine("El vehiculo no esta registrado");
            }
            else
            {
                do
                {
                    Console.WriteLine("Opciones de modificacion");
                    Console.WriteLine("1. Modificar fecha");
                    Console.WriteLine("2. Modifcar Hora");
                    Console.WriteLine("3. Modificar tipo de vehiculo");
                    Console.WriteLine("4. Modificar numero de caseta");
                    Console.WriteLine("5. Modificar monto de pago");
                    Console.WriteLine("6. Salir");
                    Console.WriteLine("Digite una opcion");
                    opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese la nueva fecha");
                            Fecha[i] = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Ingrese la hora correcta");
                            Hora[i] = Console.ReadLine();
                            break;
                        case 3:
                            TipoDeVehiculo(i);
                            break;
                        case 4:
                            TipoCaseta(i);
                            break;
                        case 5:
                            Console.WriteLine("Ingrese con cuanto paga el cliente");
                            pago[i] = float.Parse(Console.ReadLine());
                            break;
                        default:
                            Console.WriteLine("Opcion Invalida");
                            break;
                    }

                } while (opcion != 6);
                vuelto[i] = pago[i] - monto[i];
            }
        }

        public static void Consultar(String placa)
        {
            int i = 0;
            while ((i <= Indice) && (!placa.Equals(NumeroPlaca[i])))
            {
                i++;
            }
            if (i > Indice)
            {
                Console.WriteLine("El vehiculo no esta registrado");
            }
            else
            {
                Console.WriteLine("\nEl numero de factura es: " + NumeroFactura[i] + 
                    "\nFecha: " + Fecha[i] +
                    "\nHora: " + Hora[i] +
                    "\nEl numero de placa es: " + NumeroPlaca[i] + 
                    "\nEl tipoe de vechiculo es: " + TipoVehiculo[i] + 
                    "\nEl numero de caseta es: " + Caseta[i] + 
                    "\nEl monto a pagar es: " + monto[i] + 
                    "\nEl cliente paga con: " + pago[i] + 
                    "\n El vuelto es de: " + vuelto[i]);
            }
        }

        public static void Reporte()
        {
            Console.WriteLine("***************Reporte De Vehiculos*************");
            Console.WriteLine("N Factura         Placa      Tipo Vehiculo      Caseta      Monto a pagar     Paga con      Vuelto");
            for (int i = 0; i < Indice; i++)
            {
                Console.WriteLine(NumeroFactura[i] + "           " + NumeroPlaca[i] + "                " +  TipoVehiculo[i] + "           " + Caseta[i] + "            " + monto[i] + "               " + pago[i] + "       " + vuelto[i]);
             }
            Console.WriteLine("La cantidad de autos es: " + Indice + " el total de dinero recaudado es: " + total);
        }

        

    }
}
