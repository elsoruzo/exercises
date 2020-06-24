namespace IteratorPattern.Models
{
    public interface IinventoryIterator
    {
        bool IsDone();

        void GoNext();

        Item GetCurrent();
    }
}