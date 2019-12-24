using Xamarin.Forms;

namespace SmartmanApps {public class ColourSettingsPage :ContentPage {

public ColourSettingsPage(){
    Title="ColourSettingsPage";
    BackgroundColor=Color.Black;
    Label CSPLabel=new Label{
        HorizontalTextAlignment=TextAlignment.Center,
        VerticalTextAlignment=TextAlignment.Center
        };
    CSPLabel.TextColor=Color.FromHex("009933");
    CSPLabel.Text="ColourSettingsPage";
//    var MainStack=new StackLayout{VerticalOptions=LayoutOptions.Center};
//    MainStack.Children.Add(TopLabel);
//    Content=MainStack;
    Content=CSPLabel;
    }

}}