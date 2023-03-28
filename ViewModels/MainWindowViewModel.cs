using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JournalApp2._0.ViewModels.Base;

namespace JournalApp2._0.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string title = "(Без) УП не вырулишь";
        
        public string Title 
        {
            get { return title; }
            set { Set(ref title, value); }
        }


    }
}
