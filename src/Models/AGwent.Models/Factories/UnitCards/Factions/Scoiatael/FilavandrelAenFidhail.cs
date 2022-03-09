using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Scoiatael
{
    public sealed class FilavandrelAenFidhail : UnitCard
    {
        public FilavandrelAenFidhail()
        {
            Name = "Filavandrel aén Fidháil";
            Description = "Though we are now few and scattered, our hearts burn brighter than ever.";
            StrengthValueOriginal = 6;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE, Row.RANGED };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Scoiatael();
            Ability = new Abilities.Agile();
        }
    }
}
