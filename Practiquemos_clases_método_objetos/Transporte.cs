using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practiquemos_clases_método_objetos
{
    internal class Transporte
    {
        //Propiedades
        private string Nombre;
        private string Color;
        private string Tipo;

        //Metodo
        public global::System.String Nombre1 { get => Nombre; set => Nombre = value; }
        public global::System.String Color1 { get => Color; set => Color = value; }
        public global::System.String Tipo1 { get => Tipo; set => Tipo = value; }

        public void Crear_Tran(string _Nombre1, string _Color1, string _Tipo1)
        {
            this.Nombre = _Nombre1;
            this.Color = _Color1;
            this.Tipo = _Tipo1;

        }
        public void Avanzar()
        {

        }
        public void Retroceder()
        {

        }
        public void Frenar()
        {
          
        }

    }
}
