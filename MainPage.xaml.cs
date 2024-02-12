using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;

namespace TestMap2;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Move1_Clicked(object sender, EventArgs e)
    {
        MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Location(50, 6), Distance.FromKilometers(1)));
    }

    private void Move2_Clicked(object sender, EventArgs e)
    {
        MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Location(50, 6.01), Distance.FromKilometers(10)));
    }

    private void Move3_Clicked(object sender, EventArgs e)
    {
        var latitudeDegrees = .0014;
        var longitudeDegrees = .0018;
        MyMap.MoveToRegion(new MapSpan(new Location(50, 6), latitudeDegrees, longitudeDegrees));
    }

    private void AddPin_Clicked(object sender, EventArgs e)
    {
        MyMap.Pins.Clear();
        MyMap.Pins.Add(new Microsoft.Maui.Controls.Maps.Pin()
        {
            Location = new Location(50, 6),
            Label = "Here I am!",
            Address = "1234 Main St"
        });
    }

    private void AddCircle_Clicked(object sender, EventArgs e)
    {
        var circle = new Circle
        {
            Radius = new Distance(meters: 250),
            Center = new Location(50, 6),
            StrokeColor = Colors.DarkGray
        };
        MyMap.MapElements.Add(circle);
    }
}
