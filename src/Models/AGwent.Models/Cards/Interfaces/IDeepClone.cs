namespace AGwent.Models.Cards.Interfaces
{
    public interface IDeepClone<T> where T : class
    {
        T Clone();
    }
}
