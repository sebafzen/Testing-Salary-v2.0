﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEmpleadosParaTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a Sistema de Empleado.");
            Console.WriteLine("________________________________");

            Console.Clear();

            Empleado empleadouno = new Empleado();

            Console.WriteLine("Sistema de Empleado: Ingreso de datos.");
            Console.WriteLine("______________________________________");

            empleadouno.Inicializar();

            Console.Clear();

            Console.WriteLine("Sistema de Empleado.");
            Console.WriteLine("____________________");

            Console.WriteLine(empleadouno.ObtenerFicha());

            Console.Clear();

            Console.WriteLine("Sistema de Empleado: Aumento 20% del sueldo.");
            Console.WriteLine("____________________________________________");

            empleadouno.SubirSueldo(20, 5);

            Console.WriteLine(empleadouno.ObtenerFicha());

            //empleadouno.bajarSueldo(10);

            //Console.WriteLine(empleadouno.obtenerFicha());

            Console.ReadKey();
        }
    }
}
