using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Xamarin04_Sam.ViewModels
{
	public class MainPageViewModel : BindableBase, INavigationAware
	{
		private string _title;
		public string Title
		{
			get { return _title; }
			set { SetProperty(ref _title, value); }
		}


		#region 你是誰Label
		private string _你是誰Label;
		/// <summary>
		/// PropertyDescription
		/// </summary>
		public string 你是誰Label
		{
			get { return this._你是誰Label; }
			set { this.SetProperty(ref this._你是誰Label, value); }
		}
		#endregion


		public DelegateCommand 顯示New1PageCommand { get; private set; }

		public DelegateCommand 你是誰Command { get; private set; } 

		private readonly INavigationService _navigationService;

		public IWhoAreYou _IWhoAreYou;

		public MainPageViewModel(INavigationService navigationService, IWhoAreYou iWhoAreYou)
		{
			_IWhoAreYou = iWhoAreYou;
			_navigationService = navigationService;
			顯示New1PageCommand = new DelegateCommand(顯示New1Page);
			你是誰Command = new DelegateCommand(你是誰);
		}

		private void 你是誰()
		{
			你是誰Label = _IWhoAreYou.Hello();
		}

		private async void 顯示New1Page()
		{
			NavigationParameters foo = new NavigationParameters();
			foo.Add("Where",DateTime.Now.ToString());

			await _navigationService.NavigateAsync("New1Page?From=台灣",foo);
//			throw new NotImplementedException();
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
		     
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			if (parameters.ContainsKey("title"))
				Title = (string)parameters["title"] + " and Prism";
		}
	}
}
