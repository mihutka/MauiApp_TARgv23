namespace Lumemm
{
    public partial class MainPage : ContentPage
    {
        AbsoluteLayout absolute;
        Label lbl;
        Frame body, head, bucket;


        public MainPage()
        {
            absolute = new AbsoluteLayout();
            Content = absolute;
            body = new Frame
            {
                BorderColor = Color.FromRgb(192, 192, 192),
                BackgroundColor = Color.FromRgb(192, 192, 192),
                CornerRadius = 30,
                
                
                
            };
            absolute.Children.Add(body);

            head = new Frame
            {
                BorderColor = Color.FromRgb(192, 192, 192),
                BackgroundColor = Color.FromRgb(192, 192, 192),
                
                CornerRadius = 200
            };
            absolute.Children.Add(head);

            bucket = new Frame
            {
                BorderColor = Color.FromRgb(192, 192, 192),
                BackgroundColor = Color.FromRgb(192, 192, 192),
                CornerRadius = 258
            };
            absolute.Children.Add(bucket);
            AbsoluteLayout.SetLayoutBounds(body, new Rect(195, 10, 50, 50));
            AbsoluteLayout.SetLayoutBounds(bucket, new Rect(170, 40, 100, 100));
            AbsoluteLayout.SetLayoutBounds(head, new Rect(150, 80, 150, 150));

        }
            

        
    }

}
