using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practiquemos_clases_método_objetos
{
    internal class Animal
	{ 
	//Propiedades
	private string Nombre;
	private string Tipo;
	private string Total_patas;
	private string Color;
	private string Forma_comunicar;
	private string Tipo_Alimento;

	//Metodo
		public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Tipo1 { get => Tipo; set => Tipo = value; }
        public string Total_patas1 { get => Total_patas; set => Total_patas = value; }
        public string Color1 { get => Color; set => Color = value; }
        public string Forma_comunicar1 { get => Forma_comunicar; set => Forma_comunicar = value; }
        public string Tipo_Alimento1 { get => Tipo_Alimento; set => Tipo_Alimento = value; }

        public void Crear_Animal(string _Nombre1, string _Tipo1, string _Total_patas1, string _Color1, string _Forma_comunicar1, string _Tipo_Alimento1)
		{
			this.Nombre = _Nombre1;
			this.Tipo = _Tipo1;
			this.Total_patas = _Total_patas1;
			this.Color = _Color1;
			this.Forma_comunicar = _Forma_comunicar1;
			this.Tipo_Alimento = _Tipo_Alimento1;
		}
	public void Buscar_Animal()
	{

	}
	public void Alimentar_Animal()
	{

	}
    
    }
}
