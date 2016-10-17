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

		public DelegateCommand 顯示New1PageCommand { get; private set; }

		private readonly INavigationService _navigationService;

		public MainPageViewModel(INavigationService navigationService)
		{
			_navigationService = navigationService;
			顯示New1PageCommand = new DelegateCommand(顯示New1Page);
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
