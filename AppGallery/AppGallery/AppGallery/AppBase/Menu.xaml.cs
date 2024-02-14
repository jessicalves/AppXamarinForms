using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.AppBase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AbrirContantPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new XamarinForms.Paginas.PaginaDeConteudo.Conteudo01());
            IsPresented = false;
            
        }

        private void AbrirNavigationPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new XamarinForms.Paginas.PaginaDeNavegacao.Conteudo01());
            IsPresented = false;
        }

        private void AbrirCarouselPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new XamarinForms.Paginas.PaginaDeCarousel.Carousel());
            IsPresented = false;
        }

        private void AbrirTabbeddPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new XamarinForms.Paginas.PaginaDeAbas.Abas());
            IsPresented = false;
        }

        private void AbrirMasterDetailPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new XamarinForms.Paginas.PaginaMenuLateral.MenuLateral());
            IsPresented = false;
        }

        private void AbrirModal(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new XamarinForms.Paginas.Modall.Conteudo01());
            IsPresented = false;
        }
    }
}