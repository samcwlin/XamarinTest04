using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin04_Sam.UWP;



[assembly: Xamarin.Forms.Dependency(typeof(WhoAreYour))]
namespace Xamarin04_Sam.UWP
{
	class WhoAreYour : IWhoAreYou
	{
		public string Hello()
		{
			return "Windows UWP";
		}
	}
}
