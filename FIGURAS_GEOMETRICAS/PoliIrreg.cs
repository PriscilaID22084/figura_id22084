﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    class PoliIrreg : Figura
    {
        public PoliIrreg(float lado)
        {
            //usando el boton guardar
            Lado1 = lado;
        }
        public override float area()
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXCEPCION DE USO DEFAULT DEL SISTEMA
        }
        public override float perimetro()
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXCEPCION DE USO DEFAULT DEL SISTEMA
        }
        public override float volumen()
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXCEPCION DE USO DEFAULT DEL SISTEMA
        }
    }
    class Rombo : PoliIrreg //clase nieta hereda metodos y lado1 del abuelo figura
    {
        private float diagmay;
        private float diagmen;
        public float Diagmay
        {
            set
            {
                //pregunta si el lado <0
                if (value < 0)
                {
                    diagmay = 0; //manda el valor del textbox
                }   //NO EXISTEN LADOS NEGATIVOS
                else
                {
                    diagmay = value;
                    //value es el valor del textbox
                }
            }
            get //obtener el valor
            {
                return diagmay; //regresa o cacha el valor de la variable lado1
            }
        }
        public float Diagmen
        {
            set
            {
                //pregunta si el lado <0
                if (value < 0)
                {
                    diagmen = 0; //manda el valor del textbox
                }   //NO EXISTEN LADOS NEGATIVOS
                else
                {
                    diagmen = value;
                    //value es el valor del textbox
                }
            }
            get //obtener el valor
            {
                return diagmen; //regresa o cacha el valor de la variable lado1
            }
        }
        public Rombo(float lado1, float diagmay, float diagmen)
        {
            this.Diagmay = diagmay;
            this.Diagmen = diagmen;
            this.Lado1 = lado1;
        }
        public override float area()
        {
            return (Diagmay * Diagmen) / 2;
        }
        public override float perimetro()
        {
            return 4 * Lado1;
        }
        public override float volumen()
        {
            throw new NotImplementedException();
        }
    }
}
