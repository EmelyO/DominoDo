using DominoDO.Model;
using DominoDO.ViewModel;

namespace DominoDO.Pages;

public partial class ScorePage : ContentPage
{
	public ScorePage(Action<ScoreTemp> onScore)
	{
		InitializeComponent();

        var vm = new ScoreViewModel(result =>
        {
            onScore(result);
            Navigation.PopModalAsync();
        });

        BindingContext = new ScoreViewModel(onScore);
    }
}