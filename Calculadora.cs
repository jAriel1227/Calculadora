using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * 
 * Johanly Baez; 2020-9409
 * 
 */

namespace Calculadora
{
    public enum Operacion
    {
        sindefinir = 0,
        suma = 1,
        resta = 2,
        multipicacion = 3,
        division = 4,
        modulo = 5,
        raiz = 6,
        potencia = 7,
        Vabsoluto = 8,
        cubo = 9,

    }
    public partial class Calculadora : Form
    {

        //Declaracion de variables...
        double valor1 = 0;
        double valor2 = 0;
        bool permitirNumero = false;

        Operacion operar = Operacion.sindefinir;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void LeerNumero(string numero) //Permite leer el numero ingresado
        {
            permitirNumero = true;
            if (CajaResultado.Text == "0" && CajaResultado != null)
            {
                CajaResultado.Text = numero;
            }
            else
            {
                CajaResultado.Text += numero;
            }
        }
        
        private void Calculadora_Load(object sender, EventArgs e)
        {
            Size = new Size(290,425);
        }
        private double OpeRealizando()
        {
            double resultado=0;
            double num = -1;
            switch (operar)
            {
                case Operacion.sindefinir:
                    break;
                case Operacion.suma:
                    resultado = valor1 + valor2;
                    break;
                case Operacion.resta:
                    resultado = valor1 - valor2;
                    break;
                case Operacion.multipicacion:
                    resultado = valor1 * valor2;
                    break;
                case Operacion.division:
                    if (valor2 == 0)
                    {   
                        labHistorial.Text = "No se puede dividir entre '0'";
                        resultado = 0;
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                    }
                    break;
                case Operacion.modulo:
                    resultado = valor1 % valor2;
                    break;
                case Operacion.raiz:
                    resultado = Math.Sqrt(valor1);
                    break;
                case Operacion.potencia:
                    int po = 2;
                    resultado = Math.Pow(valor1, po);
                    break;
                case Operacion.Vabsoluto:
                    resultado = valor1 * num;
                    break;
                case Operacion.cubo:
                    int cu = 3;
                    resultado = Math.Pow(valor1, cu);
                    break;

                default:
                    break;
            }
            return resultado;
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            if(CajaResultado.Text == "0")
            {
                return;
            }
            else
            {
                CajaResultado.Text += "0";
            }
            
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            LeerNumero("1");
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            LeerNumero("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            LeerNumero("3");
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            LeerNumero("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            LeerNumero("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            LeerNumero("6");
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            LeerNumero("7");
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            LeerNumero("8");
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            LeerNumero("9");
        }
        private void btnResultado_Click(object sender, EventArgs e)
        {
            

            if (valor2 == 0 && permitirNumero ==true)
            {
                valor2 = Convert.ToDouble(CajaResultado.Text);
                labHistorial.Text += valor2 + "=";
                double resultado = OpeRealizando();
                valor1 = 0;
                valor2 = 0;
                if (valor2 == 0)
                {
                    permitirNumero = false;
                }
                CajaResultado.Text = Convert.ToString(resultado);
            }
          
            
        }
        private void ValorVista(string operar)
        {
            //Me obtiene el valor para hacer las operaciones
            valor1 = Convert.ToDouble(CajaResultado.Text);
            labHistorial.Text = CajaResultado.Text + operar;
            CajaResultado.Text = "0"; //Me limpia el TextBox...


        }
        private void btnSumar_Click(object sender, EventArgs e)
        {
            operar = Operacion.suma;
            ValorVista("+");
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            operar = Operacion.resta;
            ValorVista("-");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operar = Operacion.multipicacion;
            ValorVista("x");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            operar = Operacion.division;
            ValorVista("÷");
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            operar = Operacion.raiz;
            ValorVista("√");
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            operar = Operacion.potencia;
            ValorVista("^2");
        }

        private void btnAproximacion_Click(object sender, EventArgs e)
        {
            operar = Operacion.Vabsoluto;
            ValorVista("±");
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            operar = Operacion.modulo;
            ValorVista("%");
        }

        private void btnCubo_Click(object sender, EventArgs e)
        {
            operar = Operacion.cubo;
            ValorVista("x³");
        }

        private void btnLimpiarT_Click(object sender, EventArgs e)
        {
            CajaResultado.Text = "0";
            labHistorial.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (CajaResultado.Text.Length > 1)
            {
                string txtresul = CajaResultado.Text;
                txtresul = txtresul.Substring(0, txtresul.Length - 1);

                if (txtresul.Length == 1 && txtresul.Contains("-"))
                {
                    CajaResultado.Text = "0";
                }
                else
                {
                    CajaResultado.Text=txtresul;
                }
            }
            else
            {
                CajaResultado.Text = "0"; 
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            //Si contiene un punto no dejara agregar mas...
            if (CajaResultado.Text.Contains("."))
            {
                return;
            }
            else
            {
                CajaResultado.Text += ".";
            }
           
        }
    }
}
