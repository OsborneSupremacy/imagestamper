namespace ImageStamper.Utility
{
    public static class StringExtensions
    {
        public static FileInfo GetFileInfo(this string input) =>
            new FileInfo(input);

        public static bool IsValidImageFile(this string input) =>
            input.GetFileInfo().IsValidImageFile();






    }
}
