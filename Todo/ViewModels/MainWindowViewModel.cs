using System;
using System.Collections.Generic;
using System.Text;

using ReactiveUI;

namespace Todo.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";
        public bool _isChanged;

        public bool isChanged {
            get => _isChanged;
            set => this.RaiseAndSetIfChanged(ref _isChanged, value);
        }

        public void ShowToolBar() {
            if (isChanged == false) isChanged = true;
            else if (isChanged == true) isChanged = false;
        }
    }
}
