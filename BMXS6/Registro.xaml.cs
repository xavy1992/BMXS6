using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BMXS6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnInsertar_Clicked(object sender, EventArgs e)
        {
            
                try
                {
                    WebClient cliente= new WebClient();
                    var parametros = new System.Collections.Specialized.NameValueCollection();
                    parametros.Add("codigo", txtId.Text);
                    parametros.Add("nombre", txtNombre.Text);
                    parametros.Add("apellido", txtApellido.Text);
                    parametros.Add("edad", txtEdad.Text);
                    cliente.UploadValues("http://192.168.1.10/moviles/Post.php", "POST", parametros);

                }
                catch (Exception ex)
                {
                    DisplayAlert("ALERTA", ex.Message, "Cerrar");

                }

               

           
        }

        private void btnRegresar_Clicked(object sender, EventArgs e)
        {
             Navigation.PushAsync(new MainPage());
        }
    }
}