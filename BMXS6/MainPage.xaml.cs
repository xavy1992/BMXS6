using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BMXS6
{
    public partial class MainPage : ContentPage
    {
        private const string Url = "http://192.168.1.10/moviles/Post.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<BMXS6.datos> _post;
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnGet_Clicked (object sender, EventArgs e)
        {
            var content = await client.GetStringAsync(Url);
            List<BMXS6.datos> posts = JsonConvert.DeserializeObject<List<BMXS6.datos>>(content);
            _post = new ObservableCollection<BMXS6.datos>(posts);
            MyListView.ItemsSource = _post;


        }

        private void btningresar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registro());
        }
    }
}
