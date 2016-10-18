using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin04_Sam.Droid;


[assembly: Xamarin.Forms.Dependency(typeof(WhoAreYou))]
namespace Xamarin04_Sam.Droid
{
	class WhoAreYou : IWhoAreYou
	{
		public string Hello()
		{
			return "Android";
		}
	}
}