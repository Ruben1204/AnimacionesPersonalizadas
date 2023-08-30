namespace RecursosNETMAUI.Views;

public partial class AnimacionBasica : ContentPage
{
	public AnimacionBasica()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await imagen.RotateTo(360, 2000, Easing.BounceIn);
        imagen.Rotation =0;
    }
    private async void Button_Clicked1(object sender, EventArgs e)
    {
        await imagen.RotateTo(-360, 2000, Easing.BounceOut);
        imagen.Rotation =0;
    }
    private async void Button_Clicked2(object sender, EventArgs e)
    {
        await imagen.RotateXTo(120, 2000, Easing.CubicIn);
        imagen.RotationX = 0;
    }
    private async void Button_Clicked3(object sender, EventArgs e)
    {
        await imagen.RotateYTo(-120, 2000, Easing.CubicInOut);
        imagen.RotationY = 0;
    }
    private async void Button_Clicked4(object sender, EventArgs e)
    {
        await imagen.RelRotateTo(-360, 2000, Easing.Linear);
    }

    private async void Button_Clicked5(object sender, EventArgs e)
    {
        await imagen1.ScaleTo(2, 2000, Easing.SinIn);
        imagen1.Scale = 1;

    }
    private async void Button_Clicked6(object sender, EventArgs e)
    {
        await imagen1.ScaleXTo(2, 2000, Easing.SinInOut);
        imagen1.ScaleX = 1;

    }
    private async void Button_Clicked7(object sender, EventArgs e)
    {
        await imagen1.ScaleYTo(2);
        imagen1.ScaleY = 1;
    }
    private async void Button_Clicked8(object sender, EventArgs e)
    {
        await imagen1.RelScaleTo(2, 2000, Easing.SinOut);
        imagen1.ScaleY = 1;

    }
    private async void Button_Clicked9(object sender, EventArgs e)
    {
        imagen1.Opacity = 0;
        await imagen1.FadeTo(1, 4000, Easing.SpringIn);
    }

    private async void Button_Clicked10(object sender, EventArgs e)
    {
        double radius = Math.Min(verticalStackLayout.Width, verticalStackLayout.Height)/5;
        imagen2.AnchorY = radius / imagen2.Height;
        await imagen2.RotateTo(360, 2000, Easing.SpringOut);
        imagen2.Rotation = 0;

    }
    private async void Button_Clicked11(object sender, EventArgs e)
    {
        await imagen2.TranslateTo(-100, -100, 1000);
        imagen2.TranslationX = 0;
        imagen2.TranslationY = 0;

    }
    private async void Button_Clicked12(object sender, EventArgs e)
    {
        await imagen2.TranslateTo(-100, 0, 1000);    // Se mueve la imagen a la izquierda
        await imagen2.TranslateTo(-100, -100, 1000); // Se mueve la imagen diagonalmente arriba a la izquierda
        await imagen2.TranslateTo(100, 100, 2000);   // Se mueve la imagen diagonalmente abajo a derecha
        await imagen2.TranslateTo(0, 100, 1000);     // Se mueve la imagen a la izquierda
        await imagen2.TranslateTo(0, 0, 1000);       // Se mueve la imagen arriba
        await imagen2.RotateTo(360, 4000);
        await imagen2.ScaleTo(2, 2000);
        await imagen2.ScaleTo(1, 2000);

        imagen2.TranslationX = 0;
        imagen2.TranslationY = 0;

    }

    private async void Button_Clicked13(object sender, EventArgs e)
    {
        await Task.WhenAny<bool>
         (
           imagen3.RotateTo(360, 4000),
           imagen3.ScaleTo(2, 2000)

         );
        await imagen3.ScaleTo(1, 2000);
        imagen3.Rotation=0;
    }

    private async void Button_Clicked14(object sender, EventArgs e)
    {
        uint duracion = 1 * 60 * 1000;

        await Task.WhenAll
         (
           imagen4.RotateTo(31 * 360, duracion),
           imagen4.RotateXTo(23 * 360, duracion),
           imagen4.RotateYTo(19 * 360, duracion)

         );

        imagen4.Rotation=0;
        imagen4.RotationX=0;
        imagen4.RotationY=0;
    }
    private void Button_Clicked15(object sender, EventArgs e)
    {
        imagen4.CancelAnimations();
    }
    private async void Button_Clicked16(object sender, EventArgs e)
    {
        double AceleracionPersonalizada(double parametro)
        {
            return parametro == 0 || parametro == 1 ? parametro : (int)(5* parametro)/ 5.0;
        }
        await imagen5.TranslateTo(0, -200, 2000, (Easing)AceleracionPersonalizada);
        imagen5.TranslationY = 0;
    }
    private async void Button_Clicked17(object sender, EventArgs e)
    {
        Func<double, double> FuncionAceleracion = t => 9 * t* t* t - 13.5 * t *t + 5.5 * t;
        await imagen5.TranslateTo(0, -200, 2000, FuncionAceleracion);
        imagen5.TranslationY = 0;
    }
    private async void Button_Clicked18(object sender, EventArgs e)
    {
        await imagen5.TranslateTo(0, -200, 2000, new Easing(t => 1- Math.Cos(10 * Math.PI* t)* Math.Exp(-5*t)));
        imagen5.TranslationY = 0;
    }
}