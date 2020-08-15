using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTeste01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPrincipal : ContentPage
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            lblRelogio.Text = System.DateTimeKind.Utc.ToString();
        }

    }
}