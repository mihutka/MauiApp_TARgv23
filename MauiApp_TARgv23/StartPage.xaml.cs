namespace MauiApp_TARgv23;

public partial class StartPage : ContentPage
{
    List<ContentPage> lehed = new List<ContentPage>() { new TextPage(0), new FigurePage(1) };
    List<string> tekstid = new List<string>() { "Tee lahti TextPage", "Tee lahti FigurePage" };
    ScrollView sv;
    VerticalStackLayout vst;
    int number = 0;
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
        number ++;
    }
}