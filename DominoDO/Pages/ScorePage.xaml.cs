using DominoDO.Model;
using DominoDO.ViewModel;

namespace DominoDO.Pages;

public partial class ScorePage : ContentPage
{
	public ScorePage(Page page, Action<ScoreTemp> onScore)
	{
		InitializeComponent();
		BindingContext = new ScoreViewModel(page, onScore);
    }
}