


using Microsoft.Maui.Controls;

namespace MauiApp_TARgv23;

public partial class FigurePage : ContentPage
{
	BoxView bw;
	Random rnd = new Random();
    HorizontalStackLayout hsl;
    Button btn_tagasi, btn_edasi, btn_algus;
    List<string> buttons = new List<string> { "Tagasi", "Avaleht", "Edasi" };
    
    public FigurePage(int k)
	{
		int r = rnd.Next(0, 255);
		int g = rnd.Next(0, 255);
		int b = rnd.Next(0, 255);
		bw = new BoxView
		{
			Color = Color.FromRgb(r, g, b),
			CornerRadius = 20,
			WidthRequest = 200,
			HeightRequest = 200,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
		};
		TapGestureRecognizer tap = new TapGestureRecognizer();
		tap.Tapped += Klik_boksi_peal;
		bw.GestureRecognizers.Add(tap);
		VerticalStackLayout vsl = new VerticalStackLayout { Children = { bw } };
		Content = vsl;

		

        hsl = new HorizontalStackLayout { };
        for (int i = 0; i < 3; i++)
        {
            Button c = new Button
            {
                Text = buttons[i],
                ZIndex = i,
                WidthRequest = DeviceDisplay.Current.MainDisplayInfo.Width / 8.3,
            };
            hsl.Add(c);
            c.Clicked += Liikumine;
        }
        VerticalStackLayout vst = new VerticalStackLayout
        {
            Children = { hsl, bw },
            VerticalOptions = LayoutOptions.End,
        };
        Content = vst;
    }

	private void Klik_boksi_peal(object sender, EventArgs e)
	{
		bw.Color = Color.FromRgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
	}
    private async void Liikumine(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        if (btn.ZIndex == 0)
        {
            await Navigation.PushAsync(new TextPage(btn.ZIndex));
        }
        else if (btn.ZIndex == 1)
        {
            await Navigation.PushAsync(new StartPage());
        }
        else
        {
            await Navigation.PushAsync(new FigurePage(btn.ZIndex));
        }
    }
}