namespace Deneme
{
    public class Class1
    {
        public static string EraseExtraBlanks(string text)
        {
            text = text.Trim();

            string newText = string.Empty;

            for (int i = 0; 0 < text.Length; i++)
            {
                if (text[i] == ' ' && text[i + 1] == ' ')
                {
                    continue;
                }
                newText += text[i];
            }
            return newText;
        }
    }
}