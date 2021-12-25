namespace XML_editor.Extensions
{
    public static class StringExtensions
    {
        public static string FileNameWithoutExtensions(this string fileName)
        {
            if (!string.IsNullOrEmpty(fileName))
            {
                var fileExtPos = fileName.LastIndexOf(".");
                if (fileExtPos >= 0)
                    fileName = fileName.Substring(0, fileExtPos);
            }
            return fileName;
        }
    }
}
