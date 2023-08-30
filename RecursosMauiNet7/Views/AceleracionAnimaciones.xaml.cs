namespace RecursosMauiNet7.Views;

public partial class AceleracionAnimaciones : ContentPage
{
	public AceleracionAnimaciones()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await imagenPrueba.TranslateTo(150, 0, 2000,Easing.BounceIn);
        imagenPrueba.TranslationX = 0;
        imagenPrueba.TranslationY = 0;
    }
    private async void Button_Clicked1(object sender, EventArgs e)
    {
        await imagenPrueba.TranslateTo(150, 0, 2000, Easing.BounceOut);
        imagenPrueba.TranslationX = 0;
        imagenPrueba.TranslationY = 0;
    }
    private async void Button_Clicked2(object sender, EventArgs e)
    {
        await imagenPrueba.TranslateTo(150, 0, 2000, Easing.CubicIn);
        imagenPrueba.TranslationX = 0;
        imagenPrueba.TranslationY = 0;
    }
    private async void Button_Clicked3(object sender, EventArgs e)
    {
        await imagenPrueba.TranslateTo(150, 0, 2000, Easing.CubicInOut);
        imagenPrueba.TranslationX = 0;
        imagenPrueba.TranslationY = 0;
    }
    private async void Button_Clicked4(object sender, EventArgs e)
    {
        await imagenPrueba.TranslateTo(150, 0, 2000, Easing.CubicOut);
        imagenPrueba.TranslationX = 0;
        imagenPrueba.TranslationY = 0;
    }
    private async void Button_Clicked5(object sender, EventArgs e)
    {
        await imagenPrueba.TranslateTo(150, 0, 2000, Easing.Linear);
        imagenPrueba.TranslationX = 0;
        imagenPrueba.TranslationY = 0;
    }
    private async void Button_Clicked6(object sender, EventArgs e)
    {
        await imagenPrueba.TranslateTo(150, 0, 2000, Easing.SinIn);
        imagenPrueba.TranslationX = 0;
        imagenPrueba.TranslationY = 0;
    }
    private async void Button_Clicked7(object sender, EventArgs e)
    {
        await imagenPrueba.TranslateTo(150, 0, 2000, Easing.SinInOut);
        imagenPrueba.TranslationX = 0;
        imagenPrueba.TranslationY = 0;
    }
    private async void Button_Clicked8(object sender, EventArgs e)
    {
        await imagenPrueba.TranslateTo(150, 0, 2000, Easing.SinOut); 
        imagenPrueba.TranslationX = 0;
        imagenPrueba.TranslationY = 0;
    }
    private async void Button_Clicked9(object sender, EventArgs e)
    {
        await imagenPrueba.TranslateTo(150, 0, 2000, Easing.SpringIn);
        imagenPrueba.TranslationX = 0;
        imagenPrueba.TranslationY = 0;
    }
    private async void Button_Clicked10(object sender, EventArgs e)
    {
        await imagenPrueba.TranslateTo(150, 0, 2000, Easing.SpringOut);
        imagenPrueba.TranslationX = 0;
        imagenPrueba.TranslationY = 0;
    }
    private async void Button_Clicked11(object sender, EventArgs e)
    {
        double AceleracionPersonalizada(double parametro)
        {
            return parametro == 0 || parametro == 1 ? parametro : (int)(5*parametro)/5.0;
        }
        await imagenPrueba.TranslateTo(150,0,2000, (Easing)AceleracionPersonalizada);
        imagenPrueba.TranslationX = 0;
        imagenPrueba.TranslationY = 0;
    }
    private async void Button_Clicked12(object sender, EventArgs e)
    {
        Func<double, double> FuncionAceleracion = t => 9 * t *t *t - 12.5*t*t + 5.5 *t;
        await imagenPrueba.TranslateTo(150, 0, 2000, FuncionAceleracion);
        imagenPrueba.TranslationX = 0;
        imagenPrueba.TranslationY = 0;
    }
    private async void Button_Clicked13(object sender, EventArgs e)
    {
        await imagenPrueba.TranslateTo(150, 0, 2000, new Easing(t => 1 -Math.Cos(10 *Math.PI * t) * Math.Exp(-5 * t)));
        imagenPrueba.TranslationX = 0;
        imagenPrueba.TranslationY = 0;
    }
}