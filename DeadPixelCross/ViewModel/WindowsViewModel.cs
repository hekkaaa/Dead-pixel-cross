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
        public WindowsViewModel()
        {
            _platformName = "Windows";
            _versionProgramm = "Version: 0.0.1 - test";
        }
    }
}
