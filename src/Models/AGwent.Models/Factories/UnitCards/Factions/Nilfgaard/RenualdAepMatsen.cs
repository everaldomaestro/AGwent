using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class RenualdAepMatsen : UnitCard
    {
        public RenualdAepMatsen()
        {
            Name = "Renuald aep Matsen";
            Description = "They say the Impera fear nothing. Untrue. Renuald scares them shitless";
            StrengthValueOriginal = 5;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.RANGED };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Nilfgaard();
        }
    }
}
