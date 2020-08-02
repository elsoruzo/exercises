using System.Collections.Generic;
using System.Linq;

namespace ObserverPattern.Models
{
    public class MessageStream : Subject
    {
        private Queue<string> _messageHistory = new Queue<string>();

        public override void SetState(string message)
        {
            _messageHistory.Enqueue(message);
            this.NotifyObservers();
        }

        public override string GetState()
        {
            return _messageHistory.LastOrDefault();
        }
	}
}
