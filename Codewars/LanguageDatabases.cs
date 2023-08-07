using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal static class LanguageDatabases
    {
        public static Dictionary<string, string> greetings = new Dictionary<string, string>
            {
                    {"english", "Welcome"},
                    {"czech", "Vitejte"},
                    {"danish", "Velkomst"},
                    {"dutch", "Welkom"},
                    {"estonian", "Tere tulemast"},
                    {"finnish", "Tervetuloa"},
                    {"flemish", "Welgekomen"},
                    {"french", "Bienvenue"},
                    {"german", "Willkommen"},
                    {"irish", "Failte"},
                    {"italian", "Benvenuto"},
                    {"latvian", "Gaidits"},
                    {"lithuanian", "Laukiamas"},
                    {"polish", "Witamy"},
                    {"spanish", "Bienvenido"},
                    {"swedish", "Valkommen"},
                    {"welsh", "Croeso"},
            };
        public static string Greet(string language)
        {
            language = language.ToLower();

            if (greetings.TryGetValue(language, out string greeting))
            {
                return greeting;
            }
            else
            {
                return greetings["en"];
            }

        }
    }
}
