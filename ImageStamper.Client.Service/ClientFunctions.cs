using ImageStamper.Objects;
using ImageStamper.Utility;
using System.Text;

namespace ImageStamper.Client.Service
{
    public static class ClientFunctions
    {
        private const string _tempFolderDateFormat = "yyyy-MM-dd-HH-mm-ss";

        public static string GetTempFolderName() =>
            Path.Combine(Path.GetTempPath(), nameof(ImageStamper), DateTime.Now.ToString(_tempFolderDateFormat));

        public static DirectoryInfo GetOrCreateDirectory(string path)
        {
            var dir = new DirectoryInfo(path);
            if (!dir.Exists)
                dir.Create();
            return dir;
        }

        public static string CreateAndGetInitialFolder()
        {
            var appDirectory = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(ImageStamper)));
            if (!appDirectory.Exists)
                appDirectory.Create();
            return appDirectory.FullName;
        }

        /// <summary>
        /// Composes a filter string like this:
        /// 
        /// Supported Image Files(*.bmp, *.jpg, *.jpeg, *.gif, *.png) | *.bmp; *.jpg; *.jpeg; *.gif; *.png
        /// </summary>
        /// <returns></returns>
        public static string ComposeFileDialogFilter(IEnumerable<string> supportedImageTypes)
        {
            StringBuilder s = new();
            s.Append("Supported Image Files(");
            s.Append(supportedImageTypes.ToPunctuatedString("*", ", "));
            s.Append(") | ");
            s.Append(supportedImageTypes.ToPunctuatedString("*", "; "));
            return s.ToString();
        }

        public static PositionConstants GetPositionFromName(string buttonName)
        {
            return (PositionConstants)Enum.Parse(typeof(PositionConstants), removeSuffix(buttonName), true);

            // button name contains word "Button". Remove it to get text corresponding
            // to PositionConstants values.
            static string removeSuffix(string input) => input.Replace("button", string.Empty, StringComparison.OrdinalIgnoreCase);
        }
    }
}
