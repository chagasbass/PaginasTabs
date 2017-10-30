using System;
using Xamarin.Forms.Internals;

namespace PaginasTabs.Models
{
    /// <summary>
    /// Classe que representa o item do menu
    /// </summary>
    /// 
    [Preserve(AllMembers = true)]
    public class ItemMenu
    {
        public string Texto { get; set; }
        public string Icone { get; set; }
        public Type Pagina { get; set; }

        public ItemMenu()
        {

        }
    }
}