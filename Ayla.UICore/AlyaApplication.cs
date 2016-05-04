using Caliburn.Micro;
using Caliburn.Micro.Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ayla.UICore
{
    public abstract class AlyaApplication : FormsApplication
    {
        readonly SimpleContainer container;
        readonly NavigationPage navigationPage = new NavigationPage();
        readonly IMasterDetailNavigationService navigationService;

        public AlyaApplication(SimpleContainer container)
        {
            this.container = container;
            navigationService = new MasterDetailNavigationService(navigationPage);
        }
    }
}
