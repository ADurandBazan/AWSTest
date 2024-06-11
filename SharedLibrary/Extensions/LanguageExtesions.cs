using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Extensions
{
    public static class LanguageExtesions
    {
        public static bool IsSupportedLanguage(this string language) 
        {
            return language == "esp"? true: language == "eng";
        }
    }
}
