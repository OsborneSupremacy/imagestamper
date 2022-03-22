using System.Windows.Forms;

namespace ImageStamper.Client.Service
{
    public static class Extensions
    {
        public static bool Ok(this DialogResult input) => input.Equals(DialogResult.OK);

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
