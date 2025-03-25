using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Grande
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtpantalla.Text = "0";
            this.Width = 258; 
            txtpantalla.Width = 205;
            // Guardar la posición inicial del Label
            initialLabelLocation = label1.Location;
        }
        bool radianes = false;
        string mem = "0";
        string op = "";
        double num1 = 0;
        double num2 = 0;
        double res = 0;
        bool isDarkMode = false;
        private void btnC_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = "0";
            op = "";
            num1 = 0;
            num2 = 0;
            res = 0;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "0")
            {
                txtpantalla.Text = "0";
            }
            else
            {
                txtpantalla.Text += "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "0")
            {
                txtpantalla.Text = "1";
            }
            else
            {
                txtpantalla.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "0")
            {
                txtpantalla.Text = "2";
            }
            else
            {
                txtpantalla.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "0")
            {
                txtpantalla.Text = "3";
            }
            else
            {
                txtpantalla.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "0")
            {
                txtpantalla.Text = "4";
            }
            else
            {
                txtpantalla.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "0")
            {
                txtpantalla.Text = "5";
            }
            else
            {
                txtpantalla.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "0")
            {
                txtpantalla.Text = "6";
            }
            else
            {
                txtpantalla.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "0")
            {
                txtpantalla.Text = "7";
            }
            else
            {
                txtpantalla.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "0")
            {
                txtpantalla.Text = "8";
            }
            else
            {
                txtpantalla.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "0")
            {
                txtpantalla.Text = "9";
            }
            else
            {
                txtpantalla.Text += "9";
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text.Any(c => !char.IsDigit(c) && c != ',' && c != '-' && c != '+' && c != '*' && c != '/' && c != '%' && c != '^'))
            {
                MessageBox.Show("No es posible realizar operaciones con carácteres.");
                return;  // Termina la ejecución del método si hay caracteres no válidos
            }
            if (mem == "")
            {
                MessageBox.Show("No hay valor guardado en la memoria.");

            }
            if (!double.TryParse(txtpantalla.Text, out num2))
            {
                MessageBox.Show("Ingrese datos válidos");
                txtpantalla.Clear();
                return;
            }

            switch (op)
            {
                case "+":
                    res = num1 + num2;
                    break;
                case "-":
                    res = num1 - num2;
                    break;
                case "*":
                    res = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("Error: indeterminación.");
                        return;
                    }
                    res = num1 / num2;
                    break;
                case "Mod":
                    if (num2 == 0)
                    {
                        MessageBox.Show("Error: división por cero.");
                        return;
                    }
                    res = num1 % num2;
                    break;
                case "Exp":
                    res = Math.Pow(num1, num2);
                    break;
                case "%":
                    res = (num1 * num2) / 100;
                    break;

                default:
                    MessageBox.Show("Operación no válida.");
                    return;
            }
            
            txtpantalla.Text = res.ToString();
            op = ""; // Reiniciar el operador después de calcular el resultado
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!txtpantalla.Text.Contains(","))
            {
                txtpantalla.Text += ",";
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtpantalla.Text, out num1))
            {
                MessageBox.Show("Ingrese datos válidos");
                txtpantalla.Clear();
                return;
            }
            op = "+";
            txtpantalla.Text = "";
            txtpantalla.ReadOnly = false;
            txtpantalla.Focus();
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "0" || txtpantalla.Text == "")
            {
                txtpantalla.Text = "-";
            }
            else if (!double.TryParse(txtpantalla.Text, out num1))
            {
                MessageBox.Show("Ingrese datos válidos");
                txtpantalla.Clear();
            }
            else
            {
                op = "-";
                txtpantalla.Text = "";
            }
            txtpantalla.ReadOnly = false;
            txtpantalla.Focus();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtpantalla.Text, out num1))
            {
                MessageBox.Show("Ingrese datos válidos");
                txtpantalla.Clear();
                return;
            }
            op = "*";
            txtpantalla.Text = "";
            txtpantalla.ReadOnly = false;
            txtpantalla.Focus();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtpantalla.Text, out num1))
            {
                MessageBox.Show("Ingrese datos válidos");
                txtpantalla.Clear();
                return;
            }
            op = "/";
            txtpantalla.Text = "";
            txtpantalla.ReadOnly = false;
            txtpantalla.Focus();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private Point initialLabelLocation;

        private void standarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            txtpantalla.Text = "0";
            this.Width = 258;
            txtpantalla.Width = 205;
            label1.Location = initialLabelLocation;

        }

        private void btnMasMenos_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text != "0" && txtpantalla.Text != "")
            {
                double valor;
                if (double.TryParse(txtpantalla.Text, out valor))
                {
                    txtpantalla.Text = (-valor).ToString();
                }
            }
        }

        private void txtpantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void científicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = "0";
            this.Width = 546; 
            txtpantalla.Width = 493;
            label1.Location = new Point(label1.Location.X + 143, label1.Location.Y); // Mueve el Label 100 unidades a la derecha

        }

        private void xEXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCal;
            exitCal = MessageBox.Show("¿Desea salir de la aplicación?", "Calculadora", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitCal == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "0")
            {
                txtpantalla.Text = "3,141592";
            }
            else
            {
                txtpantalla.Text += "3,141592";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {

            double logg = Convert.ToDouble(txtpantalla.Text);
            if (logg <= 0)
            {
                MessageBox.Show("Error: Logaritmo para cero o números negativos.");
                return;
            }
            logg = Math.Log10(logg);
            txtpantalla.Text = Convert.ToString(logg);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double raiz = Convert.ToDouble(txtpantalla.Text);
            if (raiz < 0)
            {
                MessageBox.Show("Error: Raíz de un número negativo.");
                return;
            }
            raiz = Math.Sqrt(raiz);
            txtpantalla.Text = Convert.ToString(raiz);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(txtpantalla.Text)* Convert.ToDouble(txtpantalla.Text);
            txtpantalla.Text = Convert.ToString(x);
        }

        private void btnSen_Click(object sender, EventArgs e)
        {
            double sen = Convert.ToDouble(txtpantalla.Text);
            if (!radianes)
            {
                // Convierte grados a radianes si no estamos en modo radianes
                sen = sen * (Math.PI / 180);
            }
            sen = Math.Sin(sen);
            txtpantalla.Text = Convert.ToString(sen);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double cos = Convert.ToDouble(txtpantalla.Text);
            if (!radianes)
            {
                // Convierte grados a radianes si no estamos en modo radianes
                cos = cos * (Math.PI / 180);
            }
            cos = Math.Cos(cos);
            txtpantalla.Text = Convert.ToString(cos);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double tan = Convert.ToDouble(txtpantalla.Text);
            if (!radianes)
            {
                // Convierte grados a radianes si no estamos en modo radianes
                tan = tan * (Math.PI / 180);
            }
            tan = Math.Tan(tan);
            txtpantalla.Text = Convert.ToString(tan);
        }

        private void btnResiduo_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtpantalla.Text, out num1))
            {
                MessageBox.Show("Ingrese datos válidos");
                txtpantalla.Clear();
                return;
            }
            op = "Mod";
            txtpantalla.Text = "";
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtpantalla.Text, out num1))
            {
                MessageBox.Show("Ingrese datos válidos");
                txtpantalla.Clear();
                return;
            }
            op = "Exp";
            txtpantalla.Text = "";
        }

        private void btnFraccion_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0/ Convert.ToDouble(txtpantalla.Text));
            txtpantalla.Text = Convert.ToString(a);
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            double lnx = Convert.ToDouble(txtpantalla.Text);
            if (lnx <= 0)
            {
                MessageBox.Show("Error: Logaritmo natural para cero o números negativos.");
                return;
            }
            lnx = Math.Log(lnx);
            txtpantalla.Text = Convert.ToString(lnx);
        }

        private void btnporcen_Click(object sender, EventArgs e)
        {
            op = "%"; // Establece el operador a porcentaje
            if (double.TryParse(txtpantalla.Text, out num1))
            {
                txtpantalla.Clear(); // Limpia la pantalla para el siguiente número
            }
            else
            {
                MessageBox.Show("Ingrese datos válidos");
                txtpantalla.Clear();
            }
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si el número en la pantalla es un número binario
                if (IsBinary(txtpantalla.Text))
                {
                    int decimalValue = Convert.ToInt32(txtpantalla.Text, 2);
                    txtpantalla.Text = Convert.ToString(decimalValue);
                }
                else
                {
                    double dec = Convert.ToDouble(txtpantalla.Text);
                    int i2 = (int)dec;
                    txtpantalla.Text = Convert.ToString(i2);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese datos válidos");
                txtpantalla.Text = "0";
            }
        }
        private bool IsBinary(string text)
        {
            // Verificar si el texto solo contiene los caracteres '0' o '1'
            foreach (char c in text)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }
        private void btnBin_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtpantalla.Text);
                txtpantalla.Text = Convert.ToString(a, 2);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese datos válidos");
                txtpantalla.Text = "0";
            }

        }

        private void btnHex_Click(object sender, EventArgs e)
        {

            try
            {
                int a = int.Parse(txtpantalla.Text);
                txtpantalla.Text = Convert.ToString(a, 16);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese datos válidos");
                txtpantalla.Text = "0";
            }
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtpantalla.Text);
                txtpantalla.Text = Convert.ToString(a, 8);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese datos válidos");
                txtpantalla.Text = "0";
            }
        }

        private void btnms_Click(object sender, EventArgs e)
        {
            //almacenar datos en memoria
            mem = txtpantalla.Text;
        }

        private void btnmr_Click(object sender, EventArgs e)
        {
            //muestra el valor
            txtpantalla.Text = mem;
        }

        private void btnmc_Click(object sender, EventArgs e)
        {
            //borrará valor
            mem = "0";
            
        }

        private void btnCambiocolor_Click(object sender, EventArgs e)
        {
            if (isDarkMode)
            {
                SetLightMode();
                isDarkMode = false;
            }
            else
            {
                SetDarkMode();
                isDarkMode = true;
            }
        }

        private void SetDarkMode()
        {
            // Cambio a color negro
            this.BackColor = ColorTranslator.FromHtml("#202020");
            txtpantalla.BackColor = ColorTranslator.FromHtml("#202020");
            txtpantalla.ForeColor = ColorTranslator.FromHtml("white");
            CambiaColorBoton("dark");
        }

        private void SetLightMode()
        {
            // Cambio a color blanco
            this.BackColor = ColorTranslator.FromHtml("White");
            txtpantalla.BackColor = ColorTranslator.FromHtml("white");
            txtpantalla.ForeColor = ColorTranslator.FromHtml("black");
            CambiaColorBoton("light");
        }

        private void CambiaColorBoton(string mode)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    if (mode == "dark")
                    {
                        button.BackColor = ColorTranslator.FromHtml("#323232");
                        button.ForeColor = ColorTranslator.FromHtml("#ffffff");
                    }
                    else
                    {
                        button.BackColor = ColorTranslator.FromHtml("WhiteSmoke");
                        button.ForeColor = ColorTranslator.FromHtml("Black");
                    }
                }
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text.Length > 0)
                txtpantalla.Text = txtpantalla.Text.Remove(txtpantalla.Text.Length - 1, 1);
            if (txtpantalla.Text == string.Empty) txtpantalla.Text = "0";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult exitCal;
            exitCal = MessageBox.Show("¿Desea salir de la aplicación?", "Calculadora", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitCal == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnRadian_Click(object sender, EventArgs e)
        {

            radianes = true;  // Establece el modo a radianes
            MessageBox.Show("Modo de ángulo: Radianes");
        }

        private void btnGrado_Click(object sender, EventArgs e)
        {
            radianes = false;  // Establece el modo a grados
            MessageBox.Show("Modo de ángulo: Grados");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int factorial = (int)Convert.ToDouble(txtpantalla.Text);

            if (factorial < 0)
            {
                MessageBox.Show("El factorial no está definido para números negativos.");
                return;
            }
            long resultado = 1;
            for (int i = 1; i <= factorial; i++)
            {
                resultado *= i;
            }
            txtpantalla.Text = resultado.ToString();

        }
        private long facto(int num)
        {
            if (num <= 1) return 1;
            return num * facto(num - 1);
        }

        private void btnTeclado_Click(object sender, EventArgs e)
        {
            txtpantalla.ReadOnly = false;  
            txtpantalla.Focus();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }

}
