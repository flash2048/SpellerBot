using System;
using System.Linq;
using System.Text;
using YandexLinguistics.NET;

namespace SpellForBot
{
    public class SpellerForBot
    {
        public static string Spell(string text)
        {
            if (String.IsNullOrEmpty(text))
            {
                return "String is not correct";
            }
            StringBuilder result = new StringBuilder(text);

            var yandexSpeller = new Speller();
            var yandexResult = yandexSpeller.CheckText(text);
            if (yandexResult.Errors.Any())
            {
                var shift = 0;
                foreach (var error in yandexResult.Errors)
                {
                    result.Insert(error.Position + shift, "**");
                    result.Insert(error.Position+error.Length + shift + 2, "**");
                    result.Append($"\n\r**{error.Word}**: {error.Steer}");
                    shift += 4;
                }
            }
            return result.ToString();
        }
    }
}
