using Microsoft.Maui.Controls;

namespace valgusfoor
{
    public partial class MainPage : ContentPage
    {
        
        List<BoxView> boxViews = new List<BoxView>();
        HorizontalStackLayout hsl;
        List<string> buttons = new List<string> { "Sisse", "Välja"};
        public Label label, label2;
        
        public MainPage()
        {

            
            HorizontalStackLayout hsl = new HorizontalStackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                Spacing = 10 
            };

            
            var horizontalOptionList = new List<LayoutOptions> { LayoutOptions.Center, LayoutOptions.Center, LayoutOptions.Center };
            var verticalOptionList = new List<LayoutOptions> { LayoutOptions.Start, LayoutOptions.Center, LayoutOptions.End };

            
            VerticalStackLayout vst = new VerticalStackLayout
            {
                Spacing = 30 
            };

            
            Content = vst;

            
            for (int i = 0; i < 3; i++)
            {
                BoxView boxview = new BoxView
                {
                    Color = Color.FromRgb(192, 192, 192),
                    CornerRadius = 15,
                    WidthRequest = 200,
                    HeightRequest = 200,
                    BindingContext = i, 
                    HorizontalOptions = horizontalOptionList[i], 
                    VerticalOptions = verticalOptionList[i] 
                };

                
                TapGestureRecognizer tap = new TapGestureRecognizer();
                tap.Tapped += boxclick; 
                boxview.GestureRecognizers.Add(tap);

                
                boxViews.Add(boxview);
                vst.Children.Add(boxview); 
            }

            

            for (int i = 0; i < buttons.Count; i++)
            {
                Button c = new Button
                {
                    Text = buttons[i],
                    ZIndex = i, 
                    WidthRequest = DeviceDisplay.Current.MainDisplayInfo.Width / 8, 
                    VerticalOptions = LayoutOptions.End 
                };

                
                TapGestureRecognizer tap_button = new TapGestureRecognizer();
                tap_button.Tapped += buttonclick; 
                c.GestureRecognizers.Add(tap_button);

                
                hsl.Children.Add(c);
            }

            
            vst.Children.Add(hsl);



            label = new Label
            {
                Text = "Valgusfoor on valjatud",
                TextColor = Color.FromRgb(255, 0, 0),
                FontSize = 15,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                TranslationY = -10,
                IsVisible = true

            };
           vst.Children.Add(label);

            label2 = new Label
            {
                Text = "Valgusfoor on sisse",
                TextColor = Color.FromRgb(0, 255, 0),
                FontSize = 15,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                TranslationY = -10,
                IsVisible = false
            };
            vst.Children.Add(label2);






















        }


        private void boxclick (object sender, EventArgs e)
        {
            
            if (sender is BoxView clickedBoxView)
            {
                int boxId = (int)clickedBoxView.BindingContext;

                switch (boxId)
                {
                    case 0:
                        clickedBoxView.Color = Color.FromRgb(255, 0, 0);
                        label.IsVisible = false;
                        label2.IsVisible = true;
                        break;
                    case 1:
                        clickedBoxView.Color = Color.FromRgb(255, 255, 0);
                        label.IsVisible = false;
                        label2.IsVisible = true;
                        break;
                    case 2:
                        clickedBoxView.Color = Color.FromRgb(0, 255, 0);
                        label.IsVisible = false;
                        label2.IsVisible = true;
                        break;
                    
                }

                   
                


            }
            
            
                
        }

        private void buttonclick(object sender, EventArgs e)
        {
            
            if (sender is Button clickedButton)
            {
                string buttontext = clickedButton.Text;

                if (buttontext == "Välja")
                {
                    label.IsVisible = true;
                    label2.IsVisible = false;
                    foreach (var boxView in boxViews)
                    {
                        int boxId = (int)boxView.BindingContext;
                        switch (boxId)
                        {
                            case 0:
                                boxView.Color = Color.FromRgb(192, 192, 192);
                                
                                break;
                            case 1:
                                boxView.Color = Color.FromRgb(192, 192, 192);
                                
                                break;
                            case 2:
                                boxView.Color = Color.FromRgb(192, 192, 192);
                                
                                break;
                        }

                    }
                    




                }
                if (buttontext == "Sisse")
                {
                    label.IsVisible = false;
                    label2.IsVisible = true;
                    foreach (var boxView in boxViews)
                    {
                        int boxId = (int)boxView.BindingContext;
                        switch (boxId)
                        {
                            case 0:
                                
                                boxView.Color = Color.FromRgb(255, 0, 0);
                                break;
                            case 1:
                                
                                boxView.Color = Color.FromRgb(255, 255, 0);
                                break;
                            case 2:
                                
                                boxView.Color = Color.FromRgb(0, 192, 0);
                                break;
                        }
                    }
                }
                
            }

        }


    }

}
