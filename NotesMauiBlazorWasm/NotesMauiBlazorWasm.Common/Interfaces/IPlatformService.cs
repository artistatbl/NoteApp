namespace NotesMauiBlazorWasm.Common.Interfaces
{
    public interface IPlatformService
    {
        bool IsBrowser { get; }
        Task<string?> ChooseFromOptions(string title, params string[] options)
        {
            return null;
        }

        Task CopyToClipboardAsync(string text);
        Task ShareAsync(string text);
    }
}
