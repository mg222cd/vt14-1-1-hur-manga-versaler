using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Model
{
    public static class TextAnalyzer
    {
        public static int GetNumberOfCapitalse(string text)
        {
            int numberOfCapitals = 0;
            
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsUpper(text[i]))
                {
                    numberOfCapitals++;
                }
            }

            return numberOfCapitals;
        }
    }
}