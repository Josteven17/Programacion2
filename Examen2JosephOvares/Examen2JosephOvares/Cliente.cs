using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen2JosephOvares
{
    public class Cliente
    {
        private static String Nombre { get; set; }
        private static String Cedula { get; set; }
        private static String Telefono { get; set; }
        private static String Direccion { get; set; }


        public Cliente(String nombre, String cedula, String telefono, String direccion)
        {
            Nombre = nombre;
            Cedula = cedula;
            Telefono = telefono;
            Direccion = direccion;

        }

        public static String GetNombre() { return Nombre; }
        public static String GetCedula() { return Cedula; }
        public static String GetTelefono() { return Telefono; }
        public static String GetDireccion() { return Direccion; }

        public static void SetNombre(String nombre)
        {
            Nombre = nombre;
        }
        public static void SetCedula(String cedula)
        {
            Cedula = cedula;
        }
        public static void SetTelefono(String telefono)
        {

            Telefono = telefono;
        }
        public static void SetDireccion(String direccion)
        {

            Direccion = direccion;
        }

    }
}