using Microsoft.Extensions.Options;

namespace MysticPartyTracker.View;

public partial class DiceView : ContentPage
{

    int valor = 0;
    public DiceView()
	{
		InitializeComponent();
	}

    private async void RollBtn_Clicked(object sender, EventArgs e)
    {
		valor = Convert.ToInt32(Lados.SelectedItem) +1;

        var valorsorteado = 0;

        valorsorteado = new Random().Next(1, valor);

        ResultLabel.Text = valorsorteado.ToString();

    }
}