using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using cliente.Model;
using System.IO;

namespace cliente
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            Cliente client = new Cliente();
            client.Nombre = EntryNombre.Text;
            Conexion Conectado = new Conexion(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Cliente.db3"));
            if (Conectado.CreateCliente(client) > 0)
            {
                DisplayAlert("Notificacion","Cliente agregado","ok");
            }
        }

        protected override void OnAppearing()
        {
            Conexion con = new Conexion(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Cliente.db3"));
           DatosCliente.ItemsSource= con.LeerDatos();
        }
    }
}
