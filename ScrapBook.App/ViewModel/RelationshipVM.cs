using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapBook.App.ViewModel
{
    internal class RelationshipVM : ViewModelBase
    {
        private IEnumerable<PersonVM> _People;

        internal IEnumerable<PersonVM> People { get => _People; set => SetProperty(ref _People, value); }
    }
}
