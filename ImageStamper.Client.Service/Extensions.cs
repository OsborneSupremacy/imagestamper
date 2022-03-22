using ImageStamper.Utility;

namespace ImageStamper.Client.Service
{
    public static class Extensions
    {
        public static bool TryGetOkResponse(this CommonDialog input) => input.ShowDialog().Equals(DialogResult.OK);

        public static List<string> GetSelectedFiles(this FileDialog input)
        {
            Func<List<string>> dialogDelegate = () =>
            {
                if (!input.TryGetOkResponse())
                    return Enumerable.Empty<string>().ToList();
                return input.FileNames.ToList();
            };

            return StaExecutor.Execute(dialogDelegate, Enumerable.Empty<string>().ToList());
        }

        public static string? GetDirectory(this FolderBrowserDialog input)
        {
            Func<string?> dialogDelegate = () =>
            {
                if (!input.TryGetOkResponse())
                    return null;
                return input.SelectedPath;
            };

            return StaExecutor.Execute(dialogDelegate, null);
        }

        public static List<string> GetFiles(
            this FolderBrowserDialog input,
            HashSet<string> supportedFileTypes
            )
        {
            Func<string> dialogDelegate = () =>
            {
                if (!input.TryGetOkResponse())
                    return string.Empty;
                return input.SelectedPath;
            };

            var result = StaExecutor.Execute(dialogDelegate, string.Empty);
            if (string.IsNullOrWhiteSpace(result)) return Enumerable.Empty<string>().ToList();

            return new DirectoryInfo(result)
                .GetFiles()
                .Where(x => supportedFileTypes.Contains(x.Extension, StringComparer.OrdinalIgnoreCase))
                .Select(x => x.FullName)
                .ToList();
        }

        public static void AddRangeNewOnly<T>(this ListBox input, IEnumerable<T> items)
        {
            var existing = input.GetItems<T>();
            foreach (T item in items)
                if (!existing.Contains(item))
                    input.Items.Add(item);
        }

        public static List<T> GetItems<T>(this ListBox input)
        {
            List<T> items = new();
            foreach (T item in input.Items)
                items.Add(item);
            return items;
        }

        public static List<T> GetSelectedItems<T>(this ListBox input)
        {
            List<T> items = new();
            foreach (T item in input.SelectedItems)
                items.Add(item);
            return items;
        }

        public static void RemoveSelectedItems(this ListBox input)
        {
            var selectedItems = input
                .GetSelectedItems<string>()
                .ToHashSet(StringComparer.OrdinalIgnoreCase);

            for (int i = input.Items.Count - 1; i >= 0; i--)
                if (selectedItems.Contains(input.Items[i]))
                    input.Items.RemoveAt(i);
        }
    }
}
