using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapBook.App.ViewModel
{
    internal class LandingVM : ViewModelBase
    {
        private IEnumerable<object> _Relationships;

        internal IEnumerable<object> Relationships { get =>  _Relationships; set => SetProperty(ref _Relationships, value); }

        internal Command NewRelationship => new(() => { });
    }
}
