using SmartmanApps;
using Amporis.Xamarin.Forms.ColorPicker;
using Xamarin.Forms;
namespace SmartmanApps {public class ColourSettingsPage :ContentPage {
#region variables
IColours Colours;
public ColorPickerEntry AccentColourEntry,BgColourEntry,FgColourEntry,WarnColourEntry;
public FontAttributes FontProperty=FontAttributes.Bold;
public Grid ColourSettingsGrid;
public Label AccentLabel,BgLabel,FgLabel,WarnLabel;
#endregion
#region constructor
public ColourSettingsPage(IColours colours)
{
Padding=new Thickness(30,20,30,0);
Colours=colours;
Title="ColourSettings Page";
this.SetBinding(BackgroundColorProperty,new Binding(nameof(Colours.Background),source:Colours));
#region views
#region ColourEntries
AccentColourEntry=new ColorPickerEntry{EditAlfa=false,BackgroundColor=Color.White,};
BgColourEntry=new ColorPickerEntry{EditAlfa=false,BackgroundColor=Color.White,};
FgColourEntry=new ColorPickerEntry{EditAlfa=false,BackgroundColor=Color.White,};
WarnColourEntry=new ColorPickerEntry{EditAlfa=false,BackgroundColor=Color.White,};
AccentColourEntry.Color=Colours.Accent;
BgColourEntry.Color=Colours.Background;
FgColourEntry.Color=Colours.Foreground;
WarnColourEntry.Color=Colours.Warning;
AccentColourEntry.SetBinding(ColorPickerEntry.ColorProperty,new Binding(nameof(Colours.Accent),source:Colours));
BgColourEntry.SetBinding(ColorPickerEntry.ColorProperty,new Binding(nameof(Colours.Background),source:Colours));
FgColourEntry.SetBinding(ColorPickerEntry.ColorProperty,new Binding(nameof(Colours.Foreground),source:Colours));
WarnColourEntry.SetBinding(ColorPickerEntry.ColorProperty,new Binding(nameof(Colours.Warning),source:Colours));
#endregion
#region labels
#region Accentabel
AccentLabel=new Label{
    Text="Accent colour",
    FontAttributes=FontProperty,
    };
AccentLabel.SetBinding(Label.TextColorProperty,new Binding(nameof(Colours.Foreground),source:Colours));
AccentLabel.SetBinding(Label.BackgroundColorProperty,new Binding(nameof(Colours.Accent),source:Colours));
#endregion
#region BgLabel
BgLabel=new Label{
    Text="Background colour",
    FontAttributes=FontProperty,
    };
BgLabel.SetBinding(Label.TextColorProperty,new Binding(nameof(Colours.Foreground),source:Colours));
BgLabel.SetBinding(Label.BackgroundProperty,new Binding(nameof(Colours.Background),source:Colours));
#endregion
#region FgLabel
FgLabel=new Label{
    Text="Foreground (text) colour",
    FontAttributes=FontProperty,
    };
FgLabel.SetBinding(Label.TextColorProperty,new Binding(nameof(Colours.Foreground),source:Colours));
FgLabel.SetBinding(Label.BackgroundColorProperty,new Binding(nameof(Colours.Background),source:Colours));
#endregion
#region WarnLabel
WarnLabel=new Label{
    Text="Warning colour",
    FontAttributes=FontProperty,
    };
WarnLabel.SetBinding(Label.TextColorProperty,new Binding(nameof(Colours.Warning),source:Colours));
WarnLabel.SetBinding(Label.BackgroundColorProperty,new Binding(nameof(Colours.Background),source:Colours));
#endregion
#endregion
#endregion
#region assemble GUI
ColourSettingsGrid=new Grid();
//ColourSettingsGrid.ColumnDefinitions.Add(new ColumnDefinition{Width=GridLength.Auto});
ColourSettingsGrid.ColumnDefinitions.Add(new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)});
ColourSettingsGrid.ColumnDefinitions.Add(new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)});
ColourSettingsGrid.RowDefinitions.Add(new RowDefinition{Height=GridLength.Auto});
ColourSettingsGrid.RowDefinitions.Add(new RowDefinition{Height=GridLength.Auto});
ColourSettingsGrid.RowDefinitions.Add(new RowDefinition{Height=GridLength.Auto});
ColourSettingsGrid.RowDefinitions.Add(new RowDefinition{Height=GridLength.Auto});
ColourSettingsGrid.Children.Add(BgLabel,0,0);
ColourSettingsGrid.Children.Add(BgColourEntry,1,0);
ColourSettingsGrid.Children.Add(FgLabel,0,1);
ColourSettingsGrid.Children.Add(FgColourEntry,1,1);
ColourSettingsGrid.Children.Add(AccentLabel,0,2);
ColourSettingsGrid.Children.Add(AccentColourEntry,1,2);
ColourSettingsGrid.Children.Add(WarnLabel,0,3);
ColourSettingsGrid.Children.Add(WarnColourEntry,1,3);
#endregion
}
#region methods
public void RemoveWarningColourEntry()
{
ColourSettingsGrid.Children.Remove(WarnLabel);
ColourSettingsGrid.Children.Remove(WarnColourEntry);
ColourSettingsGrid.RowDefinitions.RemoveAt(3);
}
#endregion
#endregion
}}