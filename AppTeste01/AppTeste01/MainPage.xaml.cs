using System;
using System.ComponentModel;
using Xamarin.Forms;
using AppTeste01.Negocios;
using AppTeste01.Modelos;

namespace AppTeste01
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }




        private void btEntrar_Clicked(object sender, EventArgs e)
        {
            if (NegociosUsuarios.ValidaUsuario(etUsuario.Text, etSenha.Text) == true)
            {
                Navigation.PushModalAsync(new MenuPrincipal());
            }
        }
    }
}
