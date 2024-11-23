namespace Commons.MVC
{
    public abstract class UpdatableModel : IModel
    {
        //method names "Notify" and "Subscribe" are used in the Observer pattern
        public delegate void Notify();

        public event Notify OnUpdate;

        public void Subscribe(Notify notify)
        {
            OnUpdate += notify;
        }

        public void Unsubscribe(Notify notify)
        {
            OnUpdate -= notify;
        }
    }

    public interface IModel
    {
    }
}