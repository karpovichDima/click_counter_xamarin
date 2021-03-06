﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using App1.Models;
using Xamarin.Forms;

namespace App1.ViewModels
{
    class MainPageViewModel : BaseViewModel
    {
        private IClickModel clickModel;

        public ICommand ClickCommand { get; private set; }

        public string ClicksCount
        {
            get { return clickModel.Clicks.ToString(); }
        }

        public MainPageViewModel(IClickModel clickModel)
        {
            ClickCommand = new Command(OnButtonClick);
            this.clickModel = clickModel;
        }

        private void OnButtonClick()
        {
            clickModel.OnClick();
            OnPropertyChanged(nameof(ClicksCount));
        }
    }
}
