namespace ImageStamper.Utility
{
    public static class StringExtensions
    {
        public static FileInfo GetFileInfo(this string input) =>
            new(input);
    }
}
