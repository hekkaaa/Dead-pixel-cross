using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadPixelCross.ViewModel
{
    //[INotifyPropertyChanged]
    public partial class GeneralViewModel : INotifyPropertyChanged
    {
        //[ObservableProperty]
        public string numberTest = "АУФ!";

        public GeneralViewModel() { }


        public string NameTest
        {
            get { return numberTest; }
            set { numberTest = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NameTest")); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
