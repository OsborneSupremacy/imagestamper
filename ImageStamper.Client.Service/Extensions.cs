using ImageStamper.Utility;

namespace ImageStamper.Client.Service;

public static class Extensions
{
    public static bool IsResponseOk(this CommonDialog input) => input.ShowDialog().Equals(DialogResult.OK);

    private static readonly List<string> _emptyStringList = Enumerable.Empty<string>().ToList();

    public static List<string> GetSelectedFiles(this FileDialog input)
    {
        Func<List<string>> dialogDelegate = () =>
        {
            if (!input.IsResponseOk())
                return _emptyStringList;
            return input.FileNames.ToList();
        };

        return StaExecutor.Execute(dialogDelegate, _emptyStringList);
    }

    public static bool TryGetDirectoryName(this FolderBrowserDialog input, out string directoryName)
    {
        directoryName = string.Empty;

        Func<string?> dialogDelegate = () =>
        {
            if (!input.IsResponseOk())
                return null;
            return input.SelectedPath;
        };

        directoryName = StaExecutor.Execute(dialogDelegate, string.Empty) ?? string.Empty;
        return string.IsNullOrWhiteSpace(directoryName);
    }

    public static List<string> GetFiles(
        this FolderBrowserDialog input,
        HashSet<string> supportedFileTypes
        )
    {
        Func<string> dialogDelegate = () =>
        {
            if (!input.IsResponseOk())
                return string.Empty;
            return input.SelectedPath;
        };

        var result = StaExecutor.Execute(dialogDelegate, string.Empty);
        if (string.IsNullOrWhiteSpace(result)) return _emptyStringList;

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

    public static List<FileInfo> GetFiles(this ListBox input) =>
        input
            .GetItems<string>()
            .Select(x => new FileInfo(x))
            .ToList();

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
