using SharedLibrary.Extensions;

namespace SharedLibrary
{
    public class Message
    {
        public static string GetMessage(string language) 
        {
            if (!language.IsSupportedLanguage())
                throw new Exception("Unsopported language");

            if (language == "esp")
                return "Hola desde shared library";
           
            return "Hello from shared library";
        }
    }
}
