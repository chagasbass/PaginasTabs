using PaginasTabs.Models;
using PaginasTabs.Servicos;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace PaginasTabs.ViewModels
{
    /// <summary>
    /// ViewModel responsável pelo Menu
    /// </summary>
    /// 
    [Preserve(AllMembers = true)]
    public class MenuItemViewModel : BaseViewModel
    {
        public ICommand SelecionarItemCommand { get; private set; }
        public ICommand ListarItemsCommand { get; private set; }

        public ObservableCollection<ItemMenu> ListaMenu { get; private set; } = new ObservableCollection<ItemMenu>();

        #region Propriedades

        ItemMenu _ItemSelecionado;
        string _MensagemUsuario;
        INavigationService _NavigationService;
        Type _PaginaAtual;
        Type _PaginaAnterior;

        public ItemMenu ItemSelecionado
        {
            get { return _ItemSelecionado; }
            set { SetValue(ref _ItemSelecionado, value); }
        }

        public string MensagemUsuario
        {
            get { return _MensagemUsuario; }
            set { SetValue(ref _MensagemUsuario, value); }
        }

        public Type PaginaAtual
        {
            get { return _PaginaAtual; }
            set { SetValue(ref _PaginaAtual, value); }
        }

        public Type PaginaAnterior
        {
            get { return _PaginaAnterior; }
            set { SetValue(ref _PaginaAnterior, value); }
        }

        #endregion

        public MenuItemViewModel()
        {
            Inicializar();
            SelecionarItemCommand = new Command(SelecionarItem);
            CriarListaDeMenu();
        }

        private void Inicializar()
        {
            _NavigationService = DependencyService.Get<INavigationService>();

            MensagemUsuario = "Usuário";
          
        }

        /// <summary>
        /// Efetua a seleção do item de navegação
        /// </summary>
        void SelecionarItem()
        {
            _NavigationService.NavegarParaProximaPaginaAsync(ItemSelecionado.Pagina);
        }

        void VoltarUltimaEscolha()
        {
            _NavigationService.NavegarParaProximaPaginaAsync(PaginaAnterior);
        }

        /// <summary>
        /// Efetua a criação da lista de opções do menu
        /// </summary>
        void CriarListaDeMenu()
        {
            ListaMenu.Add(new ItemMenu() { Texto = "Tabs", Icone = "ic_help_outline_white_24dp", Pagina = typeof(TabPageCentral) });
            ListaMenu.Add(new ItemMenu() { Texto = "Opção 1", Icone = "ic_restaurant_white_24dp", Pagina = typeof(Opcao1Page) });
            ListaMenu.Add(new ItemMenu() { Texto = "Opção 2", Icone = "ic_settings_white_24dp", Pagina = typeof(Opcao2Page) });
        }
    }
}
