namespace DesignPatterns.Command.Practical
{
    using System;
    using System.Collections.Generic;
    public class CommandHistory 
    {

    private Stack<Command> _history = new Stack<Command>();

    public void Push(Command c) {
        _history.Push(c);
    }

    public Command Pop() {
        return _history.Pop();
    }

    public bool IsEmpty() { return _history.Count == 0; }
    }
} 