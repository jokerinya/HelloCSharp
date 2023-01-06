using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class StringHelper
    {
        public static void Main(string[] args)
        {
        }
        public static string EraseExtraBlanks(string text)
        {
            text = text.Trim();

            string newText = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                // Thanks to Trim method the text[i] == ' ' cannot be the last el of the text
                // and this expression never throws an index out of exception error  
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
