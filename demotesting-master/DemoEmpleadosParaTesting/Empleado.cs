﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEmpleadosParaTesting
{
    public class Empleado
    {
        //Propiedades o atributos
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Departamento { get; set; }
        
       
        public double Sueldo { get; set; }
        public int Nota { get; set; }

        //Métodos

        public void Inicializar()
        {
            Console.Write("Ingrese nombre: ");
            Nombre = Console.ReadLine();


            Console.Write("Ingrese apellido: ");
            Apellido = Console.ReadLine();


            Console.Write("Ingrese departamento: ");
            Departamento = Console.ReadLine();

            string linea;

            Console.Write("Ingrese sueldo: ");
            linea = Console.ReadLine();
            Sueldo = int.Parse(linea);
        }

        public string ObtenerFicha()
        {
            string ficha =
            "Nombre completo:" + this.Nombre + " " + this.Apellido + Environment.NewLine +
            "Departamento: " + this.Departamento + Environment.NewLine +
            "Sueldo:" + this.Sueldo + " Pesos" + Environment.NewLine;

            return ficha;

        }

        public void SubirSueldo(double porcentaje, int nota)
        {
            //this.Sueldo += porcentaje * this.Sueldo / 100;
            if(nota >= 6)
            {
                this.Sueldo = this.Sueldo + porcentaje * this.Sueldo / 100;
            }
        }

        /*
        public void BajarSueldo(double porcentaje)
        {
            //this.sueldo += porcentaje * this.sueldo / 100;
            this.Sueldo = this.Sueldo - porcentaje * this.Sueldo / 100;
        }
        */

    }
}
