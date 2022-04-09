using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practiquemos_clases_método_objetos
{
    internal class Empleado
    {
		//Propiedades
		private string Nombre;
		private string Puesto;
		private string Edo_Civil;
		private int Edad;
		private string Fecha_Nac;
		private int Antiguedad_Lab;

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Puesto1 { get => Puesto; set => Puesto = value; }
        public string Edo_Civil1 { get => Edo_Civil; set => Edo_Civil = value; }
        public int Edad1 { get => Edad; set => Edad = value; }
        public string Fecha_Nac1 { get => Fecha_Nac; set => Fecha_Nac = value; }
        public int Antiguedad_Lab1 { get => Antiguedad_Lab; set => Antiguedad_Lab = value; }

        //Metodo
        public void Crear_emp(string _Nombre1, string _Puesto1, string _Edo_Civil1, int _Edad1, string _Fecha_Nac1, int _Antiguedad_Lab1)
		{
			this.Nombre = _Nombre1;
			this.Puesto = _Puesto1;
			this.Edo_Civil = _Edo_Civil1;
			this.Edad = _Edad1;
			this.Fecha_Nac = _Fecha_Nac1;
			this.Antiguedad_Lab = _Antiguedad_Lab1;
		}
		public void Eliminar_emp()
		{

		}
		public void Consultar_emp()
		{

		}
	}
}
