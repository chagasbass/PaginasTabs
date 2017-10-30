using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PaginasTabs.Servicos
{
    public class NavigationService : INavigationService
    {
        public async Task NavegarParaMenu() => await App.Current.MainPage.Navigation.PushAsync(new MainPage());

        public async void NavegarParaProximaPaginaAsync(Type pagina)
        {
            await App.NavigateMasterDetail(pagina);
        }

        public void NavegarDeModoNormal(Type pagina) => App.Current.MainPage.Navigation.PushAsync((Page)Activator.CreateInstance(pagina));
    }
}
