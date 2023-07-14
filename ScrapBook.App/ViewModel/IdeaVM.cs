using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapBook.App.ViewModel
{
    internal class IdeaVM : ViewModelBase
    {
        private string _Name;
        private string _Description;

        internal string Name { get => _Name; set => SetProperty(ref _Name, value); }
        internal string Description { get => _Description; set => SetProperty(ref _Description, value); }

        internal Command SaveIdea => new(() =>
        {

        });
    }
}
