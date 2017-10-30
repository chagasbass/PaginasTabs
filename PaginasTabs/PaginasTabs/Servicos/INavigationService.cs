using System;
using System.Threading.Tasks;
using Xamarin.Forms.Internals;

namespace PaginasTabs.Servicos
{
    //Interface do servico de navegaçao
    [Preserve(AllMembers = true)]
    public interface INavigationService
    {
        Task NavegarParaMenu();
        void NavegarParaProximaPaginaAsync(Type pagina);
        void NavegarDeModoNormal(Type pagina);
    }
}
