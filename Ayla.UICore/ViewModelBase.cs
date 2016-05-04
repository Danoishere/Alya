﻿using Caliburn.Micro;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayla.UICore
{
    [ImplementPropertyChanged]
    public class ViewModelBase : Screen, IActivate, IDeactivate
    {
    }
}
