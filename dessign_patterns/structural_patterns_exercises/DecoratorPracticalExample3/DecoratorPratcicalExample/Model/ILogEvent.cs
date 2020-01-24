using System;

namespace DecoratorPratcicalExample.Model
{
    public interface ILogEvent: ITodoEvent
    {
       DateTime DateTime { get; set; }
    }
}
