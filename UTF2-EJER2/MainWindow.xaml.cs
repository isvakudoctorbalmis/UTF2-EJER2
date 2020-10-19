using System;

using System.Windows;
using System.Windows.Controls;


namespace UTF2_EJER2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
             
        }
        
        public int operar(int valor1, string operador, int valor2)
        {

                int resultado;
                resultado = 0;
                if (operador == "+")
                    resultado = valor1 + valor2;
                else if (operador == "-")
                    resultado = valor1 - valor2;
                else if (operador == "*")
                    resultado = valor1 * valor2;
                else if (operador == "/")
                    resultado = valor1 / valor2;
                return resultado;
          
        }
        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            int temp = 0;
            if (int.TryParse(operando1TexBox.Text, out temp) && int.TryParse(operando2TexBox.Text, out temp))
            {
                int opera1 = int.Parse(operando1TexBox.Text);
                int opera2 = int.Parse(operando2TexBox.Text);
                String opera3 = operando3TexBox.Text;               
                    ResultadoTexBox.Text =  operar(opera1, opera3, opera2).ToString();

               
            }
            else
                MessageBox.Show("!!Error System57 escriba numeros en los operando!!");
        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            operando1TexBox.Text = "";
            operando2TexBox.Text = "";
            operando3TexBox.Text = "";
            ResultadoTexBox.Text = "";
                
        }

        private void operando3TexBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (operando3TexBox.Text == "+"|| operando3TexBox.Text == "-"|| operando3TexBox.Text == "*"|| operando3TexBox.Text == "/")
                CalcularButton.IsEnabled = true;
            else
                CalcularButton.IsEnabled = false;
        }
    }
}
