namespace RecursosNETMAUI.Views;

public partial class PaginaModal : ContentPage
{
	public PaginaModal()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopModalAsync();
    }
}