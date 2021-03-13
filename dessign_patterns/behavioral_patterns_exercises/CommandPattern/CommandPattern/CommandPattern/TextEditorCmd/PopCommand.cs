namespace DesignPatterns.Command.Practical
{
    using System;
    public class PopCommand : Command 
    {

    public PopCommand(Editor editor): base(editor){}

    
      public override bool Execute() {
        if(Editor.TextField.Count == 0)
        {
          Console.WriteLine("Nothing to pop");
          return false;
        }
        Backup();
        Editor.Clipboard = Editor.TextField.Pop();
        Console.WriteLine($"Elemnt was popped: {Editor.Clipboard}");
        return true;
      }
    }
} 