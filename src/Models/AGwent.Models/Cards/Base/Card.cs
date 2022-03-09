using AGwent.Models.Cards.Interfaces;
using AGwent.Models.Game;
using AGwent.Models.Others;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace AGwent.Models.Cards.Base
{
    public abstract class Card
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public Category Category { get; protected set; }
        public abstract TypeCard Type { get; protected set; }
        public StatusCard? StatusCard { get; protected set; }
        public Ability? Ability { get; protected set; }
        public Faction Faction { get; set; }
        public string SpriteName { get; set; }

        public int Count { get; protected set; } = 1;
        public int Copy { get; protected set; } = 0;

        public void UpdateStatus(StatusCard? statusCard)
        {
            StatusCard = statusCard;
        }

        public abstract void PlayCard(Gwent game, Row? row, PlayerNumber player);


        public void SetSpriteName(string spriteName)
        {
            SpriteName = spriteName;
        }

        public string GetSpriteName()
        {
            if (Name != null)
            {
                //var name = Name.ToLower().Replace(' ', '-');

                var name = new string(Name.Normalize(NormalizationForm.FormD)
                                .Where(ch => char.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)
                                .ToArray()).ToLower().Replace(' ','-').Replace("'", "").Replace(":","");

                string pattern = @"(?i)[^0-9a-záéíóúàèìòùâêîôûãõç\\s]";
                Regex rgx = new Regex(pattern);
                string replacement = "";
                var result = rgx.Replace(name, replacement);

                return name;
            }

            return String.Empty;
        }
    }
}