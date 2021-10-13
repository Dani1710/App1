using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void RestablecerContrasena(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RestablecerContraseña());
        }

        private async void Ingresar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ingresar());
        }
    }       
}