using NotesMauiBlazorWasm.Common.Interfaces;

namespace NotesMauiBlazorWasm.Services
{
    public class PlatformService : IPlatformService
    {
        private readonly Page _page;
        public PlatformService()
        {
            _page = App.Current.MainPage;
        }
        public bool IsBrowser => false;
        public async Task<string?> ChooseFromOptions(string title, params string[] options) =>
            await _page.DisplayActionSheet(title, "Cancel", null, options);

        public async Task CopyToClipboardAsync(string text)
        {
            await Clipboard.Default.SetTextAsync(text);
        }

        public async Task ShareAsync(string text)
        {
            await Share.Default.RequestAsync(text);
        }
    }
}
