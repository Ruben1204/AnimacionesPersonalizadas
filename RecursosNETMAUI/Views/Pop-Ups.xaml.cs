namespace RecursosNETMAUI.Views;

public partial class Pop_Ups : ContentPage
{
	public Pop_Ups()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		bool respuesta = await DisplayAlert("Pregunta!", "Te gusta la programación Móvil?", "Si", "No");
		if(respuesta == true)
		{
			lblRespuesta.Text = "Entonces te recomiendo ver este curso para que te vuelvas un\n y hagas parte de esta gran comunidad!";
		}
		else
		{
			lblRespuesta.Text = "Gracias por tu respuesta!";
		}
		//await DisplayAlert("Saludos!", "No Olvides Suscribirte y Valorar este Video si te gusto..", "Cerrar");
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
		string action = await DisplayActionSheet("Cual es el Lenguaje de programación que usa MAUI para su Logica?","Cancelar","Eliminar",FlowDirection.RightToLeft,"XAML","F#","C#");
		if ((action == "XAML") || (action == "F#"))
		{
			lblRespuesta.Text = "Lo siento tu respuesta no es correcta";
		}
		else
		{
			lblRespuesta.Text = "¡Felicidades Acertaste!";
		}
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
		string result = await DisplayPromptAsync("Operación Matematica", "Cuanto es 5 + 5", "Verificar", "Cancelar", "Respuesta", 2, Keyboard.Numeric, null);
		if(Convert.ToInt32(result) == 10)
		{
			lblRespuesta.Text = $"Felicidades la Respuesta {Convert.ToInt32(result)} es correcta";
		}
		else
		{
			lblRespuesta.Text = $" La Respuesta {Convert.ToInt32(result)} no es correcta";
		}
    }

    private async void Button_Clicked_3(object sender, EventArgs e)
    {
		await Navigation.PushModalAsync(new PaginaModal());
    }
}