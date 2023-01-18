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
                    WebClient estudiante = new WebClient();
                    var parametros = new System.Collections.Specialized.NameValueCollection();
                    parametros.Add("codigo", txtId.Text);
                    parametros.Add("codigo", txtNombre.Text);
                    parametros.Add("codigo", txtApellido.Text);
                    parametros.Add("codigo", txtEdad.Text);
                    estudiante.UploadValues("http://192.168.22.15/moviles/post.php", "POST", parametros);

                }
                catch (Exception ex)
                {
                    DisplayAlert("ALERTA", ex.Message, "Cerrar");

                }

               

           
        }

        private void btnRegresar_Clicked(object sender, EventArgs e)
        {

        }
    }
}