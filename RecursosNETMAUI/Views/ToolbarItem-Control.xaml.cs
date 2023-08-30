namespace RecursosNETMAUI.Views;

public partial class ToolbarItem_Control : ContentPage
{
	public ToolbarItem_Control()
	{
		InitializeComponent();
	}

    private void ToolbarItem_Clicked(object sender, EventArgs e)
    {
		ToolbarItem elemento = (ToolbarItem)sender;
		etiquetaMensaje.Text = $"Haz oprimido el elemento {elemento.Text}de la barra de herramientas";
    }

}