using DominoDO.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DominoDO.Pages;

public partial class HomePage : ContentPage
{
    public ICommand ChangeNameOrAddScore { get; set; } = new Command(() => { });
    public ObservableCollection<ScoreTemp> Score { get; set; } = new();

    public HomePage()
	{
		InitializeComponent();

		ChangeNameOrAddScore = new Command(async() => { var dialog = new ScorePage(OnScore); await Navigation.PushModalAsync(dialog); });

        BindingContext = this;
    }

	private void OnScore(ScoreTemp score)
	{
        Score.Add(score);
	}
}