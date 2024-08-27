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
        lbl = new Label();
        editor = new Editor();
        hsl = new HorizontalStackLayout { };
        for (int i = 0; i < 3; i++)
        {
            Button b = new Button
            {
                Text = buttons[i],
            };
            hsl.Add(b);
        }
        VerticalStackLayout vst = new VerticalStackLayout
        {
            Children = { lbl, editor, hsl }
        };
        Content = vst;

		
	}
}