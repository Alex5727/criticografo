using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace criticografo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
           private void Btn_Criticar(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Nombre.Text) && (Hombre.IsChecked || Mujer.IsChecked))
            {
                string nombre = Nombre.Text;
                string sexo = "";

                if (Hombre.IsChecked)
                {
                    sexo = "Hombre";
                }
                else if (Mujer.IsChecked)
                {
                    sexo = "Mujer";
                }


                string caracteristicas = "No se seleccionaron caracteristicas";

                string agregarCaracteristica(string a, string b)
                {
                    if (a == "No se seleccionaron caracteristicas")
                    {
                        a = b;
                    }
                    else
                    {
                        a = a + ", " + b;
                    }
                    return a;
                }

                if (Alto.IsChecked)
                {
                   caracteristicas = agregarCaracteristica(caracteristicas, "Alto");
                }
                if (Feo.IsChecked)
                {
                    caracteristicas = agregarCaracteristica(caracteristicas, "Feo");
                }
                if (Listo.IsChecked)
                {
                    caracteristicas = agregarCaracteristica(caracteristicas, "Listo");
                }
                if (Extravagante.IsChecked)
                {
                    caracteristicas = agregarCaracteristica(caracteristicas, "Extravagante");
                }
                if (Raro.IsChecked)
                {
                    caracteristicas = agregarCaracteristica(caracteristicas, "Raro");
                }
                if (Grande.IsChecked)
                {
                    caracteristicas = agregarCaracteristica(caracteristicas, "Grande");
                }

                string resultado = "Nombre: " + nombre + "\nSexo: " + sexo + "\nCaracteristicas: " + caracteristicas;

                DisplayAlert("Resultado", resultado, "Quitar");
            }
            else
            {
                DisplayAlert("Datos erroneos", "Porfavor llena todos los campos", "Quitar");
            }
        }
        
    }
}

