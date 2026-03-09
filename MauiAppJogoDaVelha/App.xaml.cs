using Android.Views;
using Microsoft.Extensions.DependencyInjection;

namespace MauiAppJogoDaVelha
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            Window W = new Window(new AppShell());
            W.Height = 700;
            W.Width = 350;
            return W;
        }
    }
}