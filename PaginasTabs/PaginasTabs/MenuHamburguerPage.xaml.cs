using PaginasTabs.Models;
using PaginasTabs.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PaginasTabs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuHamburguerPage : ContentPage
    {
        private MenuItemViewModel ViewModel
        {
            get { return BindingContext as MenuItemViewModel; }
            set { BindingContext = value; }
        }

        public MenuHamburguerPage()
        {
            InitializeComponent();
            ViewModel = new MenuItemViewModel();
            BindingContext = ViewModel;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (ItemMenu)e.SelectedItem;
            ViewModel.ItemSelecionado = item;

            ViewModel.SelecionarItemCommand.Execute(null);

            ViewModel.ItemSelecionado = null;

            //ViewModel.SelecionarItemCommand.Execute(null);
        }
    }
}