using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin04_Sam.iOS;

//using MonoTouch.Foundation;
//using MonoTouch.UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(WhoAreYou))]
namespace Xamarin04_Sam.iOS
{
	class WhoAreYou : IWhoAreYou
	{
		public string Hello()
		{
			return " iOSiOSiOS";
		}
	}
}