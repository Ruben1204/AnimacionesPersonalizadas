namespace RecursosMauiNet7.Views;

public partial class AnimacionPersonalizada : ContentPage
{
	public AnimacionPersonalizada()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        var animacion = new Animation(v => imagenPrueba.Scale = v, 1, 2);
        animacion.Commit(this, "AnimacionSimple", 16, 2000, Easing.Linear, (v, c) => imagenPrueba.Scale = 1, () => true);
    }
    private void Button_Clicked1(object sender, EventArgs e)
    {
        var parentAnimation = new Animation();
        var scaleUpAnimation = new Animation(v => imagenPrueba1.Scale = v, 1, 2, Easing.SpringIn);
        var rotateAnimation = new Animation(v => imagenPrueba1.Rotation = v, 0, 360);
        var scaleDownAnimation = new Animation(v => imagenPrueba1.Scale = v, 2, 1, Easing.SpringOut);

        parentAnimation.Add(0, 0.5, scaleUpAnimation);
        parentAnimation.Add(0, 1, rotateAnimation);
        parentAnimation.Add(0.5, 1, scaleDownAnimation);

        parentAnimation.Commit(this, "AnimacionesSecundarias", 16, 4000, null, (v, c) => Btn2.IsEnabled = (false));
    }
    private void Button_Clicked2(object sender, EventArgs e)
    {
        new Animation(callback: v => Btn3.BackgroundColor = Color.FromHsla(v, 1, 0.5),
                      start: 0, end: 1).Commit(this, "Animation", 16, 4000, Easing.Linear, (v, c) => Btn3.BackgroundColor = Colors.Black);
    }
    private async void Button_Clicked3(object sender, EventArgs e)
    {
        await Task.WhenAll(
        label1.ColorTo(Colors.Green, Colors.Red, c => label1.TextColor = c, 5000),
        label1.ScaleTo(1.5, 2500));
        await this.ColorTo(Color.FromRgb(0, 0, 0), Color.FromRgb(255, 255, 255), c => BackgroundColor = c, 5000);
        await boxView.ColorTo(Colors.Pink, Colors.Purple, c => boxView.Color = c, 4000);
    }

    private void btnCancel_Clicked(object sender, EventArgs e)
    {
        this.AbortAnimation("AnimacionesSecundarias");
        this.AbortAnimation("AnimacionSimple");
        this.AbortAnimation("ColorTo");
    }
}