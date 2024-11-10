using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto ()
            {
                Descricao = "Suíte Super Luxo",
                ValorDiariaAdulto = 120.0,
                ValorDiariaCrianca = 46.00
            },
            new Quarto()
            {
                Descricao = "Suíte luxo",
                ValorDiariaAdulto = 100.0,
                ValorDiariaCrianca = 35.00
            },
            new Quarto ()
            {
                Descricao = "Suíte Simples 1",
                ValorDiariaAdulto = 80.0,
                ValorDiariaCrianca = 30.00
            },
             new Quarto ()
            {
                Descricao = "Suíte Simples 2",
                ValorDiariaAdulto = 70.0,
                ValorDiariaCrianca = 30.00
            },
        };


        public App()
        {

            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());


        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}
