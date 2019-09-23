using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace PrettyWeather
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
		{
			Console.WriteLine("CREATING PAGE");

			try
			{
				InitializeComponent();
			}
			catch (Exception e)
			{
				Console.WriteLine("CREATING PAGE FAILED");
				Console.WriteLine(e);
			}
		}

		public Grid Background => _background;
    }
}
