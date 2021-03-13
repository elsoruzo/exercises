namespace DesignPatterns.Command.Practical
{
    using System;
    public abstract class Command 
    {

    public Editor Editor;
    private JSList<string> _backup;

    public Command(Editor editor) {
        this.Editor = editor;
    }

    protected void Backup() {
        _backup = new JSList<string>();
        Console.WriteLine("backuping...");
            foreach(var el in Editor.TextField)
            {
              Console.WriteLine($"backuped el: {el}");
              _backup.Push(el);
            }
    }

    public void Undo() {
        Editor.TextField = _backup;
    }

    public abstract bool Execute();

    }
} 