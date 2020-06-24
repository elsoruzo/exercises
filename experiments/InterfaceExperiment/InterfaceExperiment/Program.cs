using System;

namespace InterfaceExperiment
{
    public interface IUndoable { void Undo(); }
    public interface IRedoable : IUndoable { void Redo(); }

    //public class TextBox : IUndoable { public void Undo() => Console.WriteLine("TextBox.Undo"); }
    //public class RichTextBox : TextBox, IUndoable { public void Undo() => Console.WriteLine("RichTextBox.Undo"); }

    public class TextBox : IUndoable
    {
        void IUndoable.Undo() => Undo();    // Calls method below
        public virtual void Undo() => Console.WriteLine ("TextBox.Undo");
    }

    public class RichTextBox : TextBox
    {
        public override void Undo() => Console.WriteLine("RichTextBox.Undo"); 

    }
        class Program
    {
        static void Main(string[] args)
        {
            RichTextBox r = new RichTextBox(); 
            r.Undo();                 // RichTextBox.Undo      Case 1
            ((IUndoable)r).Undo();    // RichTextBox.Undo      Case 2 
            ((TextBox)r).Undo();      // TextBox.Undo          Case 3
        }
    }
}
