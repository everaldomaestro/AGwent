using AGwent.Models.Others;

namespace AGwent.Models.Factories.Abilities
{
    public sealed class Agile : Ability
    {
        public Agile()
        {
            Type = TypeCard.UNIT;
            Name = "Agile";
            Description = "Can be placed in either the Close Combat or the Ranged Combat row. Cannot be moved once placed.";
        }
    }
}
