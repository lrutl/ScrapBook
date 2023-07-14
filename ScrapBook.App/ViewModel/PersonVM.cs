using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapBook.App.ViewModel
{
    internal class PersonVM : ViewModelBase
    {
        private string _Name;

        internal string Name { get => _Name; set => SetProperty(ref _Name, value); }
    }
}
