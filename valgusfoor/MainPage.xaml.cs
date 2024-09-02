using Microsoft.Maui.Controls;

namespace valgusfoor
{
    public partial class MainPage : ContentPage
    {
        BoxView esimene, teine, kolmas;

        HorizontalStackLayout hsl;
        Button sisse, välja;
        List<string> buttons = new List<string> { "Sisse", "Välja" };
        List<string> valgusfoor = new List<string> { "Punane", "Kollane", "Roheline" };
        public MainPage()
        {
            hsl = new HorizontalStackLayout { };
            for (int i = 0; i < buttons.Count; i++)
            {
                Button c = new Button
                {
                    Text = buttons[i],
                    ZIndex = i,
                    WidthRequest = DeviceDisplay.Current.MainDisplayInfo.Width / 8.3,
                };
                hsl.Add(c);
            }
            VerticalStackLayout vst = new VerticalStackLayout
            {
                Children = { hsl },
                
            };
            Content = vst;

            esimene = new BoxView
            {
                Color = Color.FromRgb(192, 192, 192),
                CornerRadius = 20,
                WidthRequest = 200,
                HeightRequest = 200,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End,
                
            };
            vst.Add(esimene);

            teine = new BoxView
            {
                Color = Color.FromRgb(192, 192, 192),
                CornerRadius = 20,
                WidthRequest = 200,
                HeightRequest = 200,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,

            };
            vst.Add(teine);

            kolmas = new BoxView
            {
                Color = Color.FromRgb(192, 192, 192),
                CornerRadius = 20,
                WidthRequest = 200,
                HeightRequest = 200,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start,
            };
            vst.Add(kolmas);

            TapGestureRecognizer tap = new TapGestureRecognizer();
            TapGestureRecognizer tap2 = new TapGestureRecognizer();
            TapGestureRecognizer tap3 = new TapGestureRecognizer();
            tap.Tapped += Klik_boksi_esimene;
            esimene.GestureRecognizers.Add(tap);
            tap2.Tapped += Klik_boksi_teine;
            teine.GestureRecognizers.Add(tap2);
            tap3.Tapped += Klik_boksi_kolmas;
            kolmas.GestureRecognizers.Add(tap3);

            
                

        }

        private void Klik_boksi_esimene(object sender, EventArgs e)
        {
            esimene.Color = Color.FromRgb(255, 0, 0);

        }

        private void Klik_boksi_teine(object sender, EventArgs e)
        {

            teine.Color = Color.FromRgb(255, 255, 0);

        }
        private void Klik_boksi_kolmas(object sender, EventArgs e)
        {

            kolmas.Color = Color.FromRgb(0, 255, 0);
        }




    }

}
