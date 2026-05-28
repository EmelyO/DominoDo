using DominoDO.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DominoDO.Pages;

public partial class HomePage : ContentPage
{
    public ICommand ChangeNameOrAddScore { get; set; } = new Command(() => { });

    public HomePage()
	{
		InitializeComponent();	

        BindingContext = this;
    }

}