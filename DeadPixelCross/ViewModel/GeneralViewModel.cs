using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
        public string _languageStringVersion = Resources.Language.Lang_en.StringVersionProgramm;
        [ObservableProperty]
        public string _versionProgramm = "Version not recognized";
        [ObservableProperty]
        public List<string> _languageList = new List<string>() { "Ru", "En" };
        [ObservableProperty]
        public string _textForPlatform = Resources.Language.Lang_en.Platform_for;

        public string _selectedLanguale = string.Empty;

        public string SelectedLanguale
        {
            get => _selectedLanguale;
            set
            {
                if (!global::System.Collections.Generic.EqualityComparer<string>.Default.Equals(_selectedLanguale, value))
                {
                  
                  if(value == "Ru")
                    {
                        _selectedLanguale = value;
                        _languageStringVersion = Resources.Language.Lang_ru.StringVersionProgramm;
                        _textForPlatform = Resources.Language.Lang_ru.Platform_for;
                      
                    }
                    if (value == "En")
                    {
                        _selectedLanguale = value;
                        _languageStringVersion = Resources.Language.Lang_en.StringVersionProgramm;
                        _textForPlatform = Resources.Language.Lang_en.Platform_for;
                    
                    }
                    else
                    {
                        _selectedLanguale = value;
                        _languageStringVersion = Resources.Language.Lang_en.StringVersionProgramm;
                        _textForPlatform = Resources.Language.Lang_en.Platform_for;
                    }
                }

                OnPropertyChanged(nameof(LanguageStringVersion));
                OnPropertyChanged(nameof(TextForPlatform));
            }
        }

        [RelayCommand]
        private void Test1()
        {
            OnPropertyChanged(nameof(LanguageStringVersion));
            OnPropertyChanged(nameof(TextForPlatform));
            OnPropertyChanged(nameof(SelectedLanguale));
        }
    }
}
