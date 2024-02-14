using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //var pagina = new NavigationPage(new XamarinForms.Paginas.PaginaDeNavegacao.Conteudo01());
            //MainPage = pagina;

            //MainPage = new XamarinForms.Paginas.Modall.Conteudo01();

            //var pagina = new CarouselPage();
            //pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarousel.Conteudo01());
            //pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarousel.Conteudo02());
            //pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarousel.Conteudo03());
            //pagina.CurrentPage = pagina.Children[1];
            //MainPage = pagina;

            //MainPage = new XamarinForms.Paginas.PaginaDeCarousel.Carousel();

            //MainPage = new XamarinForms.Paginas.PaginaDeAbas.Abas();

            //var pagina = new MasterDetailPage();
            ////Menu
            //pagina.Master = ;
            ////Conteudo
            //pagina.Detail = ;

            //MainPage = new XamarinForms.Paginas.PaginaMenuLateral.MenuLateral();

            MainPage = new AppBase.Menu();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
