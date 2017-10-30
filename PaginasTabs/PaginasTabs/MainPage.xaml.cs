using PaginasTabs.Servicos;
using Xamarin.Forms;

namespace PaginasTabs
{
    public partial class MainPage : MasterDetailPage
    {
        readonly INavigationService _NavegacaoService = DependencyService.Get<INavigationService>();

        public MainPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
            this.Master = new MenuHamburguerPage();
            this.Detail = new NavigationPage(new TabPageCentral());
            this.MasterBehavior = MasterBehavior.Popover;
            App.MasterDetail = this;
        }
    }
}
