using DominoDO.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace DominoDO.Pages;

public partial class HomePage : ContentPage
{
    public new event PropertyChangedEventHandler? PropertyChanged;
    private ICommand ChangeNameOrAddScore { get; set; } = new Command(() => { });

    private ObservableCollection<ScoreTemp> score = new ObservableCollection<ScoreTemp>();
    public ObservableCollection<ScoreTemp> Score { get => score; set { score = value; RaiseOnPropertyChanged(); } }

    public HomePage()
	{
		InitializeComponent();

		ChangeNameOrAddScore = new Command(async() => { var dialog = new ScorePage(this, OnScore); await Navigation.PushModalAsync(dialog); });
	}

	private void OnScore(ScoreTemp score)
	{
        Score.Add(score);
	}

    public void RaiseOnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}