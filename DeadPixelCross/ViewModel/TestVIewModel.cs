using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DeadPixelCross.ViewModel
{
    partial class TestVIewModel : ObservableObject
    {
        [ObservableProperty]
        private string _nameProgrammTest = "DeadPixelCross";

        //public string NameProgramm
        //{
        //    get { return _nameProgramm; }
        //    set { _nameProgramm = value; }
        //}

        [RelayCommand]
        public void AddTest()
        {
            _nameProgrammTest = "DropTestICommand!";
            OnPropertyChanged(nameof(NameProgrammTest));
        }
    }
}
