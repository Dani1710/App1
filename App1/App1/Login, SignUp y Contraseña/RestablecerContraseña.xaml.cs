using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecuperarContraseña : ContentPage
    {
        public RecuperarContraseña()
        {
            InitializeComponent();
        }

        private async void ConfirmacionCambioContra(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Restablecer());
        }
    }
}