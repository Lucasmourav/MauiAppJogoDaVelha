using System.Diagnostics;

namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Button clicado = (Button)sender;
            clicado.Text = vez;

            vez = (vez == "X") ? "O" : "X";

            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                await DisplayAlertAsync("Fim de Jogo", "Jogador X venceu!", "OK");
            }

            //caminho mais longo para acessar os itens do jogo
            var itens = Jogo.Children;

            foreach (var x in Jogo.Children)
            {
                if (x is Button btn)
                {
                    int coluna = Grid.GetColumn(btn);
                    int linha = Grid.GetRow(btn);

                    Debug.WriteLine(btn.Text);
                    Debug.WriteLine(coluna);
                    Debug.WriteLine(linha);
                }
            }

        }
    }
}
