using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyViewIssue
{
    public class MainPageViewModel: INotifyPropertyChanged
    {

        public MainPageViewModel() { }

		private List<string> quotes;

        public event PropertyChangedEventHandler? PropertyChanged;

        public List<string> Quotes 
		{
			get { return quotes; }
			set 
			{
				quotes = value; 
				PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(nameof(Quotes)));
			}
		}

	}
}
