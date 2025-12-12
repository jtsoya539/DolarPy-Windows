using DolarPy.Core.ViewModels;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DolarPy.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
           .EndingWith("Service")
           .AsInterfaces()
           .RegisterAsLazySingleton();

            RegisterAppStart<ExchangeRatesViewModel>();
        }
    }
}
