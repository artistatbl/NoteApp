using System.ComponentModel;

namespace NotesMauiBlazorWasm.Common.States
{
    public class GlobalAppState : INotifyPropertyChanged
    {
        private bool _isInitializing = true;
        public bool IsInitializing
        {
            get => _isInitializing;
            set
            {
                _isInitializing = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsInitializing)));
            }
        }

        private string? _errorMessage;
        public string? ErrorMessage
        {
            get => _errorMessage;
            set
            {
                _errorMessage = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ErrorMessage)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
