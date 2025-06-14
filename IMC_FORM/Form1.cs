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
        private Log_IMC Mi_IMC;
        public Form1()
        {
            Mi_IMC = new Log_IMC();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPeso.ContextMenuStrip = new ContextMenuStrip();
            txtEstatura.ContextMenuStrip = new ContextMenuStrip();
            txtPasos.ContextMenuStrip = new ContextMenuStrip();
            txtZancada.ContextMenuStrip = new ContextMenuStrip();
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                {
                    if (e.KeyChar == (char)Keys.Back)
                    {
                        e.Handled = false;
                    }
                    else if (e.KeyChar == '.' && !((TextBox)sender).Text.Contains("."))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }
        private void txtEstatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                {
                    if (e.KeyChar == (char)Keys.Back)
                    {
                        e.Handled = false;
                    }
                    else if (e.KeyChar == '.' && !((TextBox)sender).Text.Contains("."))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtPasos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                {
                    if (e.KeyChar == (char)Keys.Back)
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }


        private void txtZancada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                {
                    if (e.KeyChar == (char)Keys.Back)
                    {
                        e.Handled = false;
                    }
                    else if (e.KeyChar == '.' && !((TextBox)sender).Text.Contains("."))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void btbCalc_Click(object sender, EventArgs e)
        {
            if (txtEstatura.Text != string.Empty && txtPasos.Text != string.Empty && txtPeso.Text!= string.Empty && txtZancada.Text!= string.Empty )
            {
                var resultado = Mi_IMC.IMC_Calc(double.Parse(txtPeso.Text), double.Parse(txtEstatura.Text));
                Mi_IMC.Caminata(int.Parse(txtPasos.Text), double.Parse(txtZancada.Text));

                MessageBox.Show
                    (
                    $"Tu IMC es: {resultado.valor} kg/m²\n" +
                    $"Categoría: {resultado.categoria}\n" +
                    $"{Mi_IMC.Distancia()}"
                    );
                //txtZancada.Text = string.Empty;
                //txtEstatura.Text = string.Empty;
                //txtPasos.Text = string.Empty;
                //txtPeso.Text = string.Empty;
                Mi_IMC.IMC=string.Empty;
                Mi_IMC.Recorrido=0;

            }
            else
            {
                MessageBox.Show("Error, datos incompletos");
            }
        }
    }
}
