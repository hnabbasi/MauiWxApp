using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiWxApp.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private string _title;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public BaseViewModel()
        {
        }

        protected virtual void SetProperty<T>(ref T prop, T newValue, [CallerMemberName] string propertyName = null)
        {
            if(EqualityComparer<T>.Default.Equals(prop, newValue))
                return;
            
            prop = newValue;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

