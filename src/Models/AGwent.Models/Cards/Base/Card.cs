using AGwent.Models.Game;
using AGwent.Models.Others;

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

        public void UpdateStatus(StatusCard? statusCard)
        {
            StatusCard = statusCard;
        }

        public abstract void PlayCard(Gwent game, Row? row, PlayerNumber player);
    }
}