
using PaginasTabs.Servicos;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PaginasTabs
{
    public partial class App : Application
    {
        public static MasterDetailPage MasterDetail { get; set; }

        public App()
        {
            InitializeComponent();
            DependencyService.Register<INavigationService, NavigationService>();
            MainPage = new PaginasTabs.MainPage();
        }

        public async static Task NavigateMasterDetail(Type pagina)
        {
            App.MasterDetail.Detail = new NavigationPage((Page)Activator.CreateInstance(pagina));
            App.MasterDetail.IsPresented = false;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
