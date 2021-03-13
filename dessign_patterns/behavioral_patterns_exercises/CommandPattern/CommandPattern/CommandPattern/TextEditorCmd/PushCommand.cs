namespace DesignPatterns.Command.Practical
{
    using System;
    public class PushCommand : Command 
    {

    public PushCommand(Editor editor): base(editor){}

    
      public override bool Execute() {
        Backup();
        Console.WriteLine("Enter element to push");
        var element = Console.ReadLine();
        Editor.TextField.Push(element);
        return true;
      }
    }
} 