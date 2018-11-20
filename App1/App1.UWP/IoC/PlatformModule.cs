using App1.Models;
using App1.UWP.Models;
using Autofac;


namespace App1.UWP.IoC
{
    class PlatformModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<ClickModel>().As<IClickModel>();
        }
    }
}