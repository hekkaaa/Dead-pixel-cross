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
            _versionProgramm = "0.0.2";
            //_versionProgramm = DeadPixelCross.Resources.Language.Lang_en.VersionProgramm;
        }


        [ObservableProperty]
        private Color colorWindow = Microsoft.Maui.Graphics.Colors.White;
        [ObservableProperty]
        private bool _isVisibleMonoColorScene = true;
        [ObservableProperty]
        private bool _isVisibleFullColorScene = false;

        [RelayCommand]
        public void ChangeColorInBtn()
        {
            if(countColor == 4 ) 
            {
                _isVisibleMonoColorScene = false;
                _isVisibleFullColorScene = true;
                countColor = -1;
                OnPropertyChanged(nameof(IsVisibleFullColorScene));
                OnPropertyChanged(nameof(IsVisibleMonoColorScene));
            }
            else
            {   
                if(_isVisibleFullColorScene == true)
                {
                    _isVisibleMonoColorScene = true;
                    _isVisibleFullColorScene = false;
                    OnPropertyChanged(nameof(IsVisibleFullColorScene));
                    OnPropertyChanged(nameof(IsVisibleMonoColorScene));
                }
                countColor++;
                colorWindow = _colorsList[countColor];
                OnPropertyChanged(nameof(ColorWindow));
            }
           
        }
    }
}
