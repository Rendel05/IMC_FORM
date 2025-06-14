using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IMC_FORM
{
    internal class Log_IMC
    {
        //Variable privades que guardan la categoria de IMC obtenida y los km recorridos a partir de parametros dados por el usuario
        private string imc;
        private double recorrido;

        //Encapsulación de las variables declaradas para no manipularlas directamente
        public string IMC
        {
            get { return imc; }
            set { imc=value; }
        }
        public double Recorrido
        {
            get { return recorrido; }
            set { recorrido = value; }
        }

        //Contructor vacio, su única función es impedir que el string imc inicie con valor NULL
        public Log_IMC()
        {
            imc = string.Empty;
            recorrido = 0;
        }

        //Método que calcula dos valores relacionados con el IMC, la categoria en texto(string) y el valor númerico obtenido(double)
        //Los atributos con los que trabaja se obtienen a partir de los datos registrados en las textboxes Peso y Estatura
        public (string categoria, double valor) IMC_Calc(double peso, double altura)
        {
            //Lógica aritmética para calcular el IMC 
            double discriminante = Math.Round(peso / Math.Pow(altura, 2), 2);
            string categoria;
            //Lógica condicional que en función de el IMC númerico(discriminante) obtenido asigna una categoría en texto
            if (discriminante <= 18.5)
                categoria = "Bajo";
            else if (discriminante <= 24.9)
                categoria = "Ideal";
            else if (discriminante <= 29.9)
                categoria = "Sobrepeso";
            else
                categoria = "Obesidad";
            //Registro de la categoria textual en la variable imc declarada al principio
            imc = categoria;
            return (categoria, discriminante);
        }

        //Método que calcula la cantidad de kilometros recorridos
        //Los atributos con los que trabaja se obtienen a partir de los datos registrados en las textboxes Pasos y Zancada
        public void Caminata(int pasos, double zancada)
        {   
            //Lógica aritmética que tranforma los pasos y el tamaño de zancada en una distancia y la registra en la variable recorrido declarada al principio
            recorrido+= (pasos*(zancada/100))/1000;
        }

        //Método que calcula si ya se ha cumplido la cantidad de kilometros recorridos según los parametros registrados por el usuario y dada una meta asignada arbitrariamente
        public string Distancia()
        {
            //si el imc es igual a "bajo" la meta a caminar es igual a 0, por consiguiente el usuario no necesita caminar
            if (imc == "Bajo")
            {
                return "No necesitas caminar";
            }

            //Conversión de las categorías de imc en una meta arbitraria en kilometros, evitando así la anidación de if's
            double meta = 0;
            if (imc == "Ideal"){ meta = 3;}
            else if (imc == "Sobrepeso"){ meta = 5; }
            else{meta = 10;}

            //Condición que se ejecuta si el recorrido previamente calculado ya ha alcanzado la meta asignada
            if (recorrido >= meta)
            {
                return $"Ya has recorrido tu meta diaria, hoy recorriste {recorrido} km";
            }
            //Condición que se ejecuta si el recorrido previamente calculado NO ha alcanzado la meta asignada
            else
            {
                //Variable que almacena la cantidad faltante para cumplir con la meta asignada, si hay decimales estos se redondean a dos dígitos 
                double falta = Math.Round(meta - recorrido, 2);
                return $"No has alcanzado tu meta diaria, necesitas caminar aún {falta} km";
            }
        }
    }
}
