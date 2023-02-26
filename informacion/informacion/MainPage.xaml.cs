using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace informacion
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Button1_Clicked(object sender, EventArgs e)
        {
            string nombre = EntryParaNombre.Text;
            string apellido = EntryParaApellido.Text;
            string edad = EntryParaeedad.text;
            string correo = EntryParacorreo.text;

            await Application.Current.MainPage.Navigation.PushAsync(new Pagina2view(nombre, apellido,edad,correo));
        }

    }
}