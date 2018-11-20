using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using App1.ViewModels;

namespace App1.IoC
{
    class CrossplatformModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<MainPageViewModel>();
        }
    }
}