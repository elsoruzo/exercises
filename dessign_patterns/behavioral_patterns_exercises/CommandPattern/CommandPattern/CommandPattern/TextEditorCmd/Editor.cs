namespace DesignPatterns.Command.Practical
{
    using System;
    using System.Collections.Generic;
public class Editor {
    public JSList<string> TextField = new JSList<string>();
    public string Clipboard;
    private CommandHistory _history = new CommandHistory();

    public void Init() {
      string userInput = null;
      while(userInput != "stop"){

        Editor editor = this;
        Console.WriteLine("Enter the command");
        userInput = Console.ReadLine();
        if(userInput == "push")
        {
                ExecuteCommand(new PushCommand(editor));
        }

        if(userInput == "pop")
        {
                ExecuteCommand(new PopCommand(editor));
        }

        // if(userInput == "shift")
        // {
        //         ExecuteCommand(new ShiftCommand(editor));
        // }

        // if(userInput == "unshift")
        // {
        //         ExecuteCommand(new UnshiftCommand(editor));
        // }

        if(userInput == "undo")
        {
              Undo();
        }

        if(userInput == "state")
        {
            foreach(var el in TextField)
            {
              Console.WriteLine($"{el}");
            }
        }

      }
    }

    private void ExecuteCommand(Command command) {
        if (command.Execute()) {
            _history.Push(command);
        }
    }

    private void Undo() {
        if (_history.IsEmpty()) return;

        Command command = _history.Pop();
        if (command != null) {
            command.Undo();
        }
    }
}
} 