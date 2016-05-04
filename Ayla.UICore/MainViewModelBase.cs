using Caliburn.Micro;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayla.UICore
{
    [ImplementPropertyChanged]
    public class MainViewModelBase : Conductor<ViewModelBase>
    {
        public Screen ActiveScreen { get; set; }

        private IMasterDetailNavigationService navigationService;

        public MainViewModelBase(IMasterDetailNavigationService navigationService)
        {
            this.navigationService = navigationService;
            navigationService.MainViewModel = this;
        }
    }
}
