using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Prism.Navigation;

namespace Xamarin04_Sam.ViewModels
{
	public class New1PageViewModel : BindableBase,INavigationAware
	{

		#region FromLabel
		private string _FromLabel;
		/// <summary>
		/// PropertyDescription
		/// </summary>
		public string FromLabel
		{
			get { return this._FromLabel; }
			set { this.SetProperty(ref this._FromLabel, value); }
		}
		#endregion

		public New1PageViewModel()
		{

		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
			
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			var foo1 = parameters["Where"] as string;
			var foo2 = parameters["From"] as string;

			FromLabel = $"{foo1}/{foo2}";
		}
	}
}
