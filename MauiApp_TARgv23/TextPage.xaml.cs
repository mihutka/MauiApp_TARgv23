using System.Security.Cryptography.X509Certificates;

namespace MauiApp_TARgv23;

public partial class TextPage : ContentPage
{
    Label lbl;
    Editor editor;
    Button btn_tagasi, btn_edasi, btn_algus;
    HorizontalStackLayout hsl;
    List<string> buttons = new List<string> { "Tagasi", "Avaleht", "Edasi" };
    public TextPage()
	{
        lbl = new Label()
        {
            Text = "Pealkiri",
            TextColor = Color.FromRgb(200, 0, 0),
            FontFamily = "Socafe 400",
        };
        editor = new Editor
        {
            Placeholder = "Vihje:Sisesta siia tekst",
            PlaceholderColor = Color.FromRgb(50, 100, 100),
            TextColor = Color.FromRgb(200, 0, 0),
            BackgroundColor = Color.FromRgb(10, 100, 200)
        };
        VerticalStackLayout vst = new VerticalStackLayout
        {
            Children = { lbl, editor, hsl }
        };

		
	}
}