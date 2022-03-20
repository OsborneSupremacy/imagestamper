using System.Drawing;

namespace ImageStamper.Service
{
    public class BatchValidator
    {
        public (bool isValid, List<string> errors) Validate(
            IEnumerable<FileInfo> imageFiles,
            DirectoryInfo outputDirectory
            )
        {
            var errors = new List<string>();

            if (!outputDirectory.Exists)
                 errors.Add($"Output directory {outputDirectory.FullName} does not exist.");

            foreach (var imageFile in imageFiles)
            {
                var (isValid, error) = ValidateBitmap(imageFile, outputDirectory);
                if (!isValid)
                    errors.Add(error);
            }

            return (errors.Any(), errors);
        }

        public (bool isValid, string error) ValidateBitmap(FileInfo imageFile, DirectoryInfo outputDirectory)
        {
            if (!imageFile.Exists)
                return (false, $"{imageFile.FullName} not found");

            if (imageFile.Directory == outputDirectory)
                return (false, $"{imageFile.FullName} is in the output directory. The output directory must not be the same as the input directory for any images.");

            if(outputDirectory
                .GetFiles()
                .Select(x => x.Name)
                .Contains(imageFile.Name, StringComparer.OrdinalIgnoreCase))
                    return (false, $"{imageFile.Name} already exists in the output directory.");

            try
            {
                var bitmap = new Bitmap(imageFile.FullName);
                if (bitmap == null)
                    return (false, $"{imageFile.FullName} is not a compatible image type.");
                return (true, string.Empty);
            }
            catch (PlatformNotSupportedException)
            {
                return (false, $"{imageFile.FullName} is not a compatible image type.");
            };
        }
    }
}
