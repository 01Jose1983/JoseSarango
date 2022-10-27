using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JoseSarango
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage

    {


        public Registro( string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "El usuario conectado es: " + usuario;
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            double monto = Convert.ToDouble(txtMonto.Text);

             if (monto <=3000 & monto >=0)
            {
                double pago = 3000 - monto;
                //double pagom = (pago / 5) * 1.05;
                double pagom = ((3000 * 0.05) + pago) / 5;

                txtPago.Text = pagom.ToString();
                DisplayAlert("Resultado", pagom.ToString(), "cerrar");

            }

             else
            {
                DisplayAlert("alerta", "ingrese valor correcto", "Cerrar");
            }
            
            
                               

        }

        private async  void btnRegistrar_Clicked(object sender, EventArgs e)
        {
            
            string usu = "Jose2022";
            string nom = Convert.ToString(txtNombre.Text);
            string mont = Convert.ToString(txtPago.Text);

            await Navigation.PushAsync(new Resumen(usu, nom, mont));
        }
    }
}