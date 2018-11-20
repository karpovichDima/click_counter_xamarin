﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.ViewModels;
using CommonServiceLocator;
using Xamarin.Forms;

namespace App1.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = ServiceLocator.Current.GetInstance<MainPageViewModel>();
        }
    }
}
