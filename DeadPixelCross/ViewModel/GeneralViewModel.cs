using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadPixelCross.ViewModel
{
    public partial class GeneralViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _nameProgramm = "DeadPixelCross!";
        [ObservableProperty]
        public string _platformName = "Other";
        [ObservableProperty]
        public string _versionProgramm = "Version not recognized";

    }
}
