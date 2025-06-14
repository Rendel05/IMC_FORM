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
        private string imc;
        private double recorrido;
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
        public Log_IMC()
        {
            imc=string.Empty;
            recorrido=0;
        }

        public (string categoria, double valor) IMC_Calc(double peso, double altura)
        {
            double discriminante = Math.Round(peso / Math.Pow(altura, 2), 2);
            string categoria;

            if (discriminante <= 18.5)
                categoria = "Bajo";
            else if (discriminante <= 24.9)
                categoria = "Ideal";
            else if (discriminante <= 29.9)
                categoria = "Sobrepeso";
            else
                categoria = "Obesidad";

            imc = categoria;
            return (categoria, discriminante);
        }
        public void Caminata(int pasos, double zancada)
        {   
            recorrido+= (pasos*(zancada/100))/1000;
        }
        public string Distancia()
        {
            if (imc == "Bajo")
            {
                return "No necesitas caminar";
            }
            double meta = 0;
            if (imc == "Ideal"){ meta = 3;}
            else if (imc == "Sobrepeso"){ meta = 5; }
            else{meta = 10;}

            if (recorrido >= meta)
            {
                return $"Ya has recorrido tu meta diaria, hoy recorriste {recorrido} km";
            }
            else
            {
                double falta = Math.Round(meta - recorrido, 2);
                return $"No has alcanzado tu meta diaria, necesitas caminar aún {falta} km";
            }
        }
    }
}
