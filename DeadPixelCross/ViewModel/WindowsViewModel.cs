using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Graphics.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadPixelCross.ViewModel
{
    partial class WindowsViewModel : GeneralViewModel
    {
        private int countColor = 0;
        private List<Color> _colorsList = new() { Colors.White, Colors.Red, Colors.Green, Colors.Blue, Colors.Black };

        public WindowsViewModel()
        {
            _platformName = "Windows";
            _versionProgramm = "Version: 0.0.1 - test";
        }


        [ObservableProperty]
        public Color colorWindow = Microsoft.Maui.Graphics.Colors.White;

        [RelayCommand]
        public void ChangeColorInBtn()
        {
            if(countColor == 4 ) { countColor = -1;}
            countColor++;
            colorWindow = _colorsList[countColor];
            OnPropertyChanged(nameof(ColorWindow));
        }
    }
}
