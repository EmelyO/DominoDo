namespace DominoDO
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

#if ANDROID
    try
    {
        var status = await Permissions.RequestAsync<Permissions.StorageWrite>();
        if (status != PermissionStatus.Granted)
        {
            await DisplayAlert("Error", "Permiso denegado", "OK");
            return;
        }

        var exporter = new DominoDO.Platforms.Android.database();
        exporter.Export();
        await DisplayAlert("OK", "Exportado exitosamente", "OK");
    }
    catch (Exception ex)
    {
        await DisplayAlert("Error", ex.Message, "OK");
    }
#endif
        }
    }
}
