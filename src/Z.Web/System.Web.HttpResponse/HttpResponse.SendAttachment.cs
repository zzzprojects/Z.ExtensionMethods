using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     A HttpResponse extension method that sends an attachment.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="fullPathToFile">The full path to file.</param>
    /// <param name="outputFileName">Filename of the output file.</param>
    public static void SendAttachment(this HttpResponse @this, string fullPathToFile, string outputFileName)
    {
        @this.Clear();
        @this.AddHeader("content-disposition", "attachment; filename=" + outputFileName);
        @this.WriteFile(fullPathToFile);
        @this.ContentType = "";
        @this.End();
    }
}