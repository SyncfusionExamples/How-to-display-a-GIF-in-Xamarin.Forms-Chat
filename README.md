# This-sample-describes-how-to-display-a-GIF-as-message-in-Xamarin.Forms-Chat
This sample describes how to display a GIF as message in Xamarin.Forms Chat (SfChat)
Image message in SfChat : https://help.syncfusion.com/xamarin/chat/messages#image-message

## Sample

```xaml

    <ContentPage.Resources>
        <ResourceDictionary>
            <Style TargetType="sfchat:ChatImageView">
                <Setter Property="ControlTemplate">
                    <Setter.Value>
                        <ControlTemplate>
                            <local:GifContainer/>
                        </ControlTemplate>
                    </Setter.Value>
                </Setter>
            </Style>
        </ResourceDictionary>
    </ContentPage.Resources>

GifContainer:

    <ContentView xmlns="http://xamarin.com/schemas/2014/forms" 
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:d="http://xamarin.com/schemas/2014/forms/design"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
             xmlns:ffimageloading="clr-namespace:FFImageLoading.Svg.Forms;assembly=FFImageLoading.Svg.Forms"
             mc:Ignorable="d"
             x:Class="GettingStarted.GifContainer">
        <ffimageloading:SvgCachedImage 
           HeightRequest="200"
           WidthRequest="150"
           HorizontalOptions="StartAndExpand" 
           VerticalOptions="Center" 
           Aspect="Fill" 
           x:Name="imageWave" 
           Source="{TemplateBinding BindingContext.Source}"
           Margin="0"/>
    </ContentView>

```

## Requirements to run the demo

To run the demo, refer to [System Requirements for Xamarin](https://help.syncfusion.com/xamarin/system-requirements).

## Troubleshooting

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
