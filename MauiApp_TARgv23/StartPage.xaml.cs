namespace MauiApp_TARgv23;

public partial class StartPage : ContentPage
{
    List<ContentPage> lehed = new List<ContentPage>() { new TextPage(), new FigurePage() };
    List<string> tekstid = new List<string>() { "Tee lahti TextPage", "Tee lahti FigurePage" };
    List<ContentPage> figure = new List<ContentPage>() { new LeftButton(), new MiddleButton(), new RightButton };
    List<string> figure = new List<string>() { "<-", "H", "->" };
    ScrollView sv;
    VerticalStackLayout vst;
    public StartPage()
    {
        //InitializeComponent();
        vst = new VerticalStackLayout() { BackgroundColor = Color.FromRgb(180, 100, 20) };
        for (int i = 0; i < tekstid.Count; i++)
        {
            Button nupp = new Button
            {
                Text = tekstid[i],
                BackgroundColor = Color.FromRgb(20, 100, 200),
                TextColor = Color.FromRgb(10, 20, 15),
                FontFamily = "GLORYSE 400",
                BorderWidth = 10,
                ZIndex = i
            };
            vst.Add(nupp);
            nupp.Clicked += Nupp_Clicked;
        }
        sv = new ScrollView { Content = vst };
        Content = sv;
    }

    private async void Nupp_Clicked(object sender, EventArgs e)
    {
        Button btn = (Button)sender; //sender as Button
        await Navigation.PushAsync(lehed[btn.ZIndex]);
    }
}