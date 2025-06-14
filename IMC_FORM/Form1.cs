using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC_FORM
{
    public partial class Form1 : Form
    {
        //Creación del objeto
        private Log_IMC Mi_IMC;
        public Form1()
        {
            //Instanciación del objeto
            Mi_IMC = new Log_IMC();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Setter de propiedad que bloquea el despliegue de un menú al hacer click derecho sobre alguna textbox para impedir pegar cosas con el mouse
            txtPeso.ContextMenuStrip = new ContextMenuStrip();
            txtEstatura.ContextMenuStrip = new ContextMenuStrip();
            txtPasos.ContextMenuStrip = new ContextMenuStrip();
            txtZancada.ContextMenuStrip = new ContextMenuStrip();
        }
        //Método que habilita el uso de ciertas teclas específicas en la textbox que registra el Peso
        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Condición que únicamente permite la escritura de números
            if (!char.IsDigit(e.KeyChar))
            {
                {
                    //Condición que permite hacer uso de la tecla backspace para borrar valores y hacer correcciones o ajustes
                    if (e.KeyChar == (char)Keys.Back)
                    {
                        e.Handled = false;
                    }
                    //Condición que permite ingresar un único punto decimal en caso de querer escribir un decimal
                    else if (e.KeyChar == '.' && !((TextBox)sender).Text.Contains("."))
                    {
                        e.Handled = false;
                    }
                    //Condición que bloquea todo lo demás
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }
        //Método que habilita el uso de ciertas teclas específicas en la textbox que registra la Estatura
        private void txtEstatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Condición que únicamente permite la escritura de números
            if (!char.IsDigit(e.KeyChar))
            {
                {
                    // Condición que permite hacer uso de la tecla backspace para borrar valores y hacer correcciones o ajustes
                    if (e.KeyChar == (char)Keys.Back)
                    {
                        e.Handled = false;
                    }
                    //Condición que permite ingresar un único punto decimal en caso de querer escribir un decimal
                    else if (e.KeyChar == '.' && !((TextBox)sender).Text.Contains("."))
                    {
                        e.Handled = false;
                    }
                    //Condición que bloquea todo lo demás
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }
        //Método que habilita el uso de ciertas teclas específicas en la textbox que registra los Pasos
        private void txtPasos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Condición que únicamente permite la escritura de números
            if (!char.IsDigit(e.KeyChar))
            {
                {
                    // Condición que permite hacer uso de la tecla backspace para borrar valores y hacer correcciones o ajustes
                    if (e.KeyChar == (char)Keys.Back)
                    {
                        e.Handled = false;
                    }
                    //Condición que bloquea todo lo demás
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        //Método que habilita el uso de ciertas teclas específicas en la textbox que registra el tamaño de la Zancada
        private void txtZancada_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Condición que únicamente permite la escritura de números
            if (!char.IsDigit(e.KeyChar))
            {
                {
                    // Condición que permite hacer uso de la tecla backspace para borrar valores y hacer correcciones o ajustes
                    if (e.KeyChar == (char)Keys.Back)
                    {
                        e.Handled = false;
                    }
                    //Condición que permite ingresar un único punto decimal en caso de querer escribir un decimal
                    else if (e.KeyChar == '.' && !((TextBox)sender).Text.Contains("."))
                    {
                        e.Handled = false;
                    }
                    //Condición que bloquea todo lo demás
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        //Método que envía los datos capturados en las textboxes a el objeto para instanciarlo
        private void btbCalc_Click(object sender, EventArgs e)
        {
            //Condición que verifica que no hayan textboxes vacías
            if (txtEstatura.Text != string.Empty && txtPasos.Text != string.Empty && txtPeso.Text!= string.Empty && txtZancada.Text!= string.Empty )
            {
                //Variable que guarda dos valores a la vez provenientes de la tupla de la función que calcula el IMC
                var resultado = Mi_IMC.IMC_Calc(double.Parse(txtPeso.Text), double.Parse(txtEstatura.Text));

                //Registro de la cantidad de pasos dados y del tamaño de la zancada en la función que calcula distancias
                Mi_IMC.Caminata(int.Parse(txtPasos.Text), double.Parse(txtZancada.Text));

                //Mensaje que muestra los resultados si estos son correctos
                MessageBox.Show
                    (
                    $"Tu IMC es: {resultado.valor} kg/m²\n" +
                    $"Categoría: {resultado.categoria}\n" +
                    $"{Mi_IMC.Distancia()}"
                    );

                //Líneas de código que limpian el objeto para su reutilización
                Mi_IMC.IMC=string.Empty;
                Mi_IMC.Recorrido=0;

            }
            else
            {
                //Mensaje de alerta que indica error si se trata de ejecutar el calculo con uno o varios campos vacíos
                MessageBox.Show("Error, datos incompletos");
            }
        }

        //Método que límpia todas las textboxes y el objeto 
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtZancada.Clear();
            txtEstatura.Clear();
            txtPasos.Clear();
            txtPeso.Clear();
            Mi_IMC.IMC = string.Empty;
            Mi_IMC.Recorrido = 0;
        }
    }
}
