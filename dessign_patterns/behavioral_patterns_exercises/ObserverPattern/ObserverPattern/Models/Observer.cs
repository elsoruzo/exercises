
namespace ObserverPattern.Models
{
    public abstract class Observer
    {
        protected Subject Subject { get; set; }
        public abstract void Update();
    }
}
