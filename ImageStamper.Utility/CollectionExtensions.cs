using System.Text;

namespace ImageStamper.Utility;

public static class CollectionExtensions
{
    public static string ToPunctuatedString(this IEnumerable<string> input, string preText, string postText) =>
        input.Aggregate(new StringBuilder(),
            (cumulative, add) => cumulative.Append($"{preText}{add}{postText}"),
            final => final.ToString().Trim()
        ).ToString();
}
