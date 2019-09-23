using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Xamarin.Forms.Platform.UWP;

namespace PrettyWeather.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

			var xfApp = new PrettyWeather.App();

			LoadApplication(xfApp);

			if (xfApp.MainPage is PrettyWeather.MainPage xfPage
				&& xfPage.Background.GetOrCreateRenderer().ContainerElement is LayoutRenderer xfRenderer)
			{
				xfRenderer.Background = new LinearGradientBrush
				{
					StartPoint = new Point(0.5, 0),
					EndPoint = new Point(0.5, 1),
					GradientStops =
					{
						new GradientStop {Color = Color.FromArgb(255, 246, 204, 102), Offset = 0.0},
						new GradientStop {Color = Color.FromArgb(255, 252, 161, 132), Offset = 1.0}
					}
				};
			}
		}
    }
}
