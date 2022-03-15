namespace ImageStamper.Utility
{
    public static class FileInfoExtensions
    {
        private static readonly HashSet<string> _validExtensions = new()
        {
            ".jpg",
            ".gif",
            ".png",
            ".bmp"
        };

        public static bool IsValidImageFile(this FileInfo input) => 
            _validExtensions.Contains(input.Extension, StringComparer.OrdinalIgnoreCase);
    }
}