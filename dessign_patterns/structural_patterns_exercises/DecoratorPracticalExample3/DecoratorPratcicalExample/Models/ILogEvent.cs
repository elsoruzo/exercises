using System;

namespace DecoratorPratcicalExample.Models
{
    public interface ILogEvent: ITodoEvent
    {
       DateTime DateTime { get; set; }
    }
}
